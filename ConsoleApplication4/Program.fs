// Learn more about F# at http://fsharp.org
// See the 'F# Tutorial' project for more help.

module Bla =
    
    [<ReflectedDefinition>]
    let sum (a : int) = a + 1

[<EntryPoint>]
let main argv = 
    printfn "%A" (Bla.sum 1)
    0 // return an integer exit code
