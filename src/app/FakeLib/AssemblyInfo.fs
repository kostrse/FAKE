﻿namespace System
open System.Reflection
open System.Runtime.CompilerServices
open System.Runtime.InteropServices

[<assembly: AssemblyTitleAttribute("FAKE - F# Make Lib")>]
[<assembly: InternalsVisibleToAttribute("Test.FAKECore")>]
[<assembly: GuidAttribute("d6dd5aec-636d-4354-88d6-d66e094dadb5")>]
[<assembly: AssemblyProductAttribute("FAKE - F# Make")>]
[<assembly: AssemblyVersionAttribute("4.9.3")>]
[<assembly: AssemblyInformationalVersionAttribute("4.9.3")>]
[<assembly: AssemblyFileVersionAttribute("4.9.3")>]
do ()

module internal AssemblyVersionInformation =
    let [<Literal>] Version = "4.9.3"
