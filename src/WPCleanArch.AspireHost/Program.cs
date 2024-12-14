var builder = DistributedApplication.CreateBuilder(args);

builder.AddProject<Projects.WPCleanArch_Web>("Web");

builder.Build().Run();
