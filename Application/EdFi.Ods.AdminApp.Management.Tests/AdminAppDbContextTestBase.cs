// SPDX-License-Identifier: Apache-2.0
// Licensed to the Ed-Fi Alliance under one or more agreements.
// The Ed-Fi Alliance licenses this file to you under the Apache License, Version 2.0.
// See the LICENSE and NOTICES files in the project root for more information.

using System;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using EdFi.Ods.AdminApp.Management.Database;
using EdFi.Ods.AdminApp.Management.Helpers;
using NUnit.Framework;
using Respawn;

namespace EdFi.Ods.AdminApp.Management.Tests
{
    [TestFixture]
    public abstract class AdminAppDbContextTestBase
    {
        protected AdminAppDbContext TestContext { get; private set; }
        protected AdminAppDbContext SetupContext { get; private set; }

        protected enum CheckpointPolicyOptions
        {
            DoNotCheckpoint,
            BeforeEachTest,
            BeforeAnyTest
        }

        protected CheckpointPolicyOptions CheckpointPolicy { get; set; } = CheckpointPolicyOptions.BeforeEachTest;

        private readonly Checkpoint _checkpoint = new Checkpoint
        {
            TablesToIgnore = new[]
            {
                "__MigrationHistory", "DeployJournal", "AdminAppDeployJournal"
            },
            SchemasToExclude = new[]
            {
                "HangFire", "adminapp_HangFire"
            }
        };

        protected virtual string ConnectionString => TestContext.Database.Connection.ConnectionString;

        protected virtual void AdditionalFixtureSetup()
        {
        }

        protected abstract AdminAppDbContext CreateDbContext();

        [OneTimeSetUp]
        public virtual async Task FixtureSetup()
        {
            TestContext = CreateDbContext();
            SetupContext = CreateDbContext();

            if (CheckpointPolicy == CheckpointPolicyOptions.BeforeAnyTest)
            {
                await _checkpoint.Reset(ConnectionString);
            }

            AdditionalFixtureSetup();
        }

        [OneTimeTearDown]
        public async Task FixtureTearDown()
        {
            await _checkpoint.Reset(ConnectionString);
        }

        [SetUp]
        public async Task SetUp()
        {
            TestContext = CreateDbContext();
            SetupContext = CreateDbContext();

            if (CheckpointPolicy == CheckpointPolicyOptions.BeforeEachTest)
            {
                await _checkpoint.Reset(ConnectionString);
            }
        }

        [TearDown]
        public void TearDown()
        {
            TestContext.Dispose();
            SetupContext.Dispose();
        }
        
        protected void Save(params object[] entities)
        {
            foreach (var entity in entities)
            {
                SetupContext.Set(entity.GetType()).Add(entity);
            }

            SetupContext.SaveChanges();
        }

        protected void Delete(params object[] entities)
        {
            foreach (var entity in entities)
            {
                SetupContext.Set(entity.GetType()).Remove(entity);
            }

            SetupContext.SaveChanges();
        }

        protected void DeleteAll<TEntity>() where TEntity : class
        {
            Transaction(database =>
            {
                foreach (var entity in database.Set<TEntity>())
                    database.Set<TEntity>().Remove(entity);
            });
        }

        protected  int Count<TEntity>() where TEntity : class
        {
            using (var database = CreateDbContext())
                return database.Set<TEntity>().Count();
        }

        protected void Transaction(Action<AdminAppDbContext> action)
        {
            using (var dbContext = CreateDbContext())
                Transaction(dbContext, action);
        }

        protected TResult Transaction<TResult>(Func<AdminAppDbContext, TResult> query)
        {
            var result = default(TResult);

            Transaction(database =>
            {
                result = query(database);
            });

            return result;
        }

        protected static void Transaction<TDbContext>(TDbContext dbContext, Action<TDbContext> action)
            where TDbContext : DbContext
        {
            using (var transaction = dbContext.Database.BeginTransaction())
            {
                action(dbContext);
                dbContext.SaveChanges();
                transaction.Commit();
            }
        }

        protected static void Transaction<TDbContext>(Action<TDbContext> action)
            where TDbContext : DbContext, new()
        {
            using(var dbContext = new TDbContext())
            using (var transaction = dbContext.Database.BeginTransaction())
            {
                action(dbContext);
                dbContext.SaveChanges();
                transaction.Commit();
            }
        }
    }
}
