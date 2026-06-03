var builder = DistributedApplication.CreateBuilder(args);

builder.AddProject<Projects.AspireIntro_Blog>("aspireintro-blog");

builder.Build().Run();
