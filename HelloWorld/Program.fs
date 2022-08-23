open System

[<EntryPoint>]
let main argv =

    printfn "%A" argv[2]

    let mutable a = "Abacaxi"
    printfn "%s" a

    let b = "Banana"
    printfn "%s" b

    a <- "Ameixa"
    printfn "%s" a


    let idade = 18
    let PI = 3.14
    let name = "Jhon"

    let raio:float = 7.5
    let on:bool = true

    printfn $"{name}, {idade}"
    printfn $"={PI**2}"
    printfn "Hi, %s" name
    printfn "Is on: %b" on
    0


