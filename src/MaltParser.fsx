// include Fake lib
#load @".\Core.fsx"
open Fake 
open Fake.AssemblyInfoFile
open Fake.IKVM.Helpers

// Assembly / NuGet package properties
let projectName = "MaltParser"
let projectDescription = "MaltParser is a system for data-driven dependency parsing, which can be used to induce a parsing model from treebank data and to parse new data using an induced model."

// Targets

// Run IKVM compiler
Target "RunIKVMCompiler" (fun _ ->
    restoreFolderFromUrl 
        @".\temp\maltparser-1.8" 
        "http://maltparser.org/dist/maltparser-1.8.zip"
    [IKVMcTask(@"temp\maltparser-1.8\maltparser-1.8.jar", Version=version,
        Dependencies = 
            [IKVMcTask(@"temp\maltparser-1.8\lib\liblinear-1.8.jar", Version=version)
             IKVMcTask(@"temp\maltparser-1.8\lib\libsvm.jar", Version=version)
             IKVMcTask(@"temp\maltparser-1.8\lib\log4j.jar", Version="1.2.14.0")])]
    |> IKVMCompile ikvmDir @".\MaltParser.NET.snk"
)

// Create NuGet package
Target "CreateNuGet" (fun _ ->     
    copyFilesToNugetFolder()
        
    "MaltParser.nuspec"
      |> NuGet (fun p -> 
            {p with
                Project = projectName
                Authors = authors
                Version = version
                Description = projectDescription
                NoPackageAnalysis = true
                ToolPath = ".\..\.nuget\NuGet.exe"
                WorkingDir = nugetDir
                OutputPath = nugetDir })
)

// Dependencies
"CleanIKVM"
  ==> "RunIKVMCompiler"
  ==> "CleanNuGet"
  ==> "CreateNuGet"
  ==> "Default"

// start build
Run "Default"