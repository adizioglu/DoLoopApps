open System

let mutable isValidAge = false
let mutable age = 0

//let mutable testNumber = 0

//do
//    printfn "%d" testNumber
//    testNumber <- testNumber + 3
//while testNumber < 10

while not isValidAge do
    printf "What is your age: "
    let ageText = Console.ReadLine()
    match Int32.TryParse(ageText) with
    | (true, parsedAge) ->
        age <- parsedAge
        isValidAge <- true
    | (false, _) ->
        printfn "That was an invalid age."

printfn "Your age is %d" age

//do
//    // Run the code at least once
//while true

//while true do
//    // Runs the code 0 or more times
