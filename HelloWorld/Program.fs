
[<EntryPoint>]
let main argv =
    let argumentos = argv
    for arg in argumentos do
        printfn "%s" arg
    printfn "%d" argumentos.Length
    0
