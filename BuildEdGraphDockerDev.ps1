$solutionRoot = "$PSScriptRoot/Application"
$dockerRoot = "$PSScriptRoot/Docker"

function DockerBuild {
    Push-Location $dockerRoot
    
    try {
        &docker build `
            -t eg-adminapi-mssql `
            --build-context assets=$(Resolve-Path "..") `
            --no-cache `
            -f edgraph.mssql.Dockerfile `
            .
    }
    finally {
        Pop-Location
    }
}

function DockerRun {
    &docker run `
        --detach `
        --env-file "$solutionRoot/EdFi.Ods.AdminApi/.env" `
        --name eg-adminapi-mssql `
        --network edgraph-network `
        -p 5214:80 `
        --volume "$dockerRoot/Settings/ssl:/ssl/" `
        eg-adminapi-mssql
}
    
DockerBuild

DockerRun
