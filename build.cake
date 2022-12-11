#load "nuget:?package=Linedata.Foundation.Build&version=2.0.6"

// Basic build
//BuildDefinition
//    .DotNetCoreSolution("Linedata.My.Service.sln")
//    .Run();

// Build and Publish Docker Image
var name = "Linedata.My.Service";
var dockerfilePath = "./Dockerfile";
var contextPath = System.IO.Directory.GetParent(dockerfilePath).FullName;
var repository = name.ToLowerInvariant();
var dockerfile = new Dockerfile(dockerfilePath, contextPath, repository);
var feed = "modulename"; // e.g. ordergen, trading, etc.

// Path to the Microservice Host Project
var project = "./src/Host/Linedata.My.Service.Host.csproj";

BuildDefinition.CleanFolders("bin", "obj")
    .DotNetCoreSolution($"{name}.sln")
    .PublishTarget(project, "netcoreapp3.1")
    .BuildDockerImages(dockerfile)
    // Foundation Build will determine from context (envar settings) whether to push to AWS ECR or Artifactory
    .PushDockerImages(feed)
    .Run();
