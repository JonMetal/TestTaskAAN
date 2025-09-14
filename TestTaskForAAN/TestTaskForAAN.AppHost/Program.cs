var builder = DistributedApplication.CreateBuilder(args);

builder.AddProject<Projects.TestTaskForAAN>("testtaskforaan");

builder.Build().Run();