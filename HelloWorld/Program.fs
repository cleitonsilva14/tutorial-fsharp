open System

let somar a b =
    let 
    soma = a + b
    soma

let dobrarValoresLista values =
    values |> List.map (fun x -> x * x + 1)


[<EntryPoint>]
let main argv =
    
    let x = 15
    let y = 15
    let s = somar x y
    printfn "%d" s

    let numbers = [1;2;3;4;5]
    let result = dobrarValoresLista numbers

    printfn "%d" result
    0
