module Luna

open Process

[<EntryPoint>]
let main argv =
    let text = "Hello, is * there?"

    let sentence = 
        { Contents = text |> cleanText |> parseText 
          IsQuestion = text |> isQuestion }
    printfn "%A" sentence
    
    0 // return an integer exit code
