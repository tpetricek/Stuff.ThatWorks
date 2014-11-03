namespace System
open System.Reflection

[<assembly: AssemblyTitleAttribute("Stuff.EmailValidator")>]
[<assembly: AssemblyProductAttribute("Stuff.EmailValidator")>]
[<assembly: AssemblyDescriptionAttribute("Stuff that works demo - email validator.")>]
[<assembly: AssemblyVersionAttribute("2.0")>]
[<assembly: AssemblyFileVersionAttribute("2.0")>]
do ()

module internal AssemblyVersionInformation =
    let [<Literal>] Version = "2.0"
