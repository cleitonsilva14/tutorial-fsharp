open System

// define uma função
let from whom = 
    sprintf "from %s" whom


let main argv =
    let message = from "F#" // chama a função
    printf "Hello world %s" message
    0 // exit code
