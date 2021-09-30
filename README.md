# csharp-when-compiler-bug-repro
Reproduces a bug with `switch` / `when` statements


Compiler version:

```txt
Microsoft (R) Visual C# Compiler version 3.11.0-4.21403.6 (ae1fff34)
Copyright (C) Microsoft Corporation. All rights reserved.
```


Compiler error:

```txt
Build FAILED.

       "C:\work\my\when-compiler-bug\when-compiler-bug\when-compiler-bug.csproj" (build target) (1) ->
       (CoreCompile target) -> 
         C:\Program Files (x86)\Microsoft Visual Studio\2019\Professional\MSBuild\Current\Bin\Roslyn\Microsoft.CSharp.Core.targets(71,5):
         error MSB6006: "csc.exe" exited with code -2146232797.
```
