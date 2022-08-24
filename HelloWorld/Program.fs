open System

let somar a b =
    let soma = a + b
    soma

[<EntryPoint>]
let main argv =
    let argumentos = argv
    
    let x = 15
    let y = 15
    let s = somar x y
    printfn "%d" s

    0
