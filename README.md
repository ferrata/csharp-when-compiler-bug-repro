# csharp-when-compiler-bug-repro
Reproduces [the bug](https://github.com/dotnet/roslyn/issues/48493) with `switch` / `when` statements


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

The bug seems to be fixed in Roslyn `main` as of 09/28/2021:

* [https://sharplab.io](https://sharplab.io/#v2:EYLgtghglgdgNAExAagD4AEAMACdBGAFgG4BYAKC1zwDoAZWAR1LPJgjAFMBnABwgGMO2AO4ALDjAD6/APZgeUADYcATpOABXAObkA3uWyHssAC6q2i4zDMqAZgKEBJAEIQuHR9dX3BBo/rIjbABfcj9DU3MIS3QAJmwABQgVCRMAYUU3LmwQbBc3Dy87B3DsAKCg9ABmbGAZGUtnesUElRkeVRMAT2wAXgA+bHtFd2ZSypq6huwAEQ0wMC60mRgEKBMoFYAKAEo+weHR0tCWQKNIlQtceIysgEEcxOTU264uUvKKw2rsei4TAA8MmAACsOPwTIM/iZWu1Oj0BtgYBxhL8oP8gaDwZDdswgidShcrnFsAAlDg8NoIDS+M6GT5fH7oAhkjQwLb5dyeGw+ITAArc7wOHbjfyir5cYTrfiibBbflcoq8kV0r5i1Vqir8ApPFLWV7ZXTYJoNWEdFTdXKHITBbD8cWaipiCR26hzBZLFZrDbbHYgB2OowAeiD2Go4YDgdqKQgAGs8VGgtr3NgDQ86gAPETiGC1GQZujomFtc3dah3GBdLaSfZDaLuP2RwMhsMRjWJozAGPxptanVJPXpTJvMrG5pm+FW+s2/3tjvYFvh6i9zVdjhxhOBk6a7dGAmqpnxfAAdg+DqZeAAbLgWQBZaDs/CYADaAF1sMktFwVZqGY7kai5KUjI1KCLs1CkmyWwAamw5cHcuw7JuFS7oYJzBEAA==)
