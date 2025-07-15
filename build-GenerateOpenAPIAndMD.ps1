$DockerEnvValues = @{
    Authority      = "http://api"
    IssuerUrl      = "https://localhost:5001"
    DatabaseEngine = "SqlServer"
    PathBase       = "adminapi"
    SigningKey     = "<Generated encryption key>"
    AdminDB        = "Data Source=.; Initial Catalog=EdFi_Admin; User Id=sa; Password=Lp&Oly3Jq!9Z0rG@; Trust Server Certificate=True;"
    SecurityDB     = "Data Source=.; Initial Catalog=EdFi_Security; User Id=sa; Password=Lp&Oly3Jq!9Z0rG@; Trust Server Certificate=True;"
}

.\build.ps1 `
    -Command "GenerateOpenAPIAndMD" `
    -APIVersion "2.2.1" `
    -Configuration "Release" `
    -DockerEnvValues $DockerEnvValues `
