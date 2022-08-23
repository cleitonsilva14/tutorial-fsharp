open System

[<EntryPoint>]
let main argv =
    
    let mutable a = "Abacaxi"
    printfn "%s" a

    let b = "Banana"
    printfn "%s" b

    a <- "Ameixa"
    printfn "%s" a
    0