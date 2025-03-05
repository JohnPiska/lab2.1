open System

let getLastDigit number =
    let absNumber = abs number  
    absNumber % 10              

let rec getNumbersFromUser () =
    printf "Введите числа через пробел: "
    let input = Console.ReadLine()
    
    try
        let numberStrings = input.Split(' ')      
        let numbers = List.map int (Array.toList numberStrings) 
        numbers 
    with
        | :? FormatException -> 
            printfn "Ошибка: Только числа!"
            getNumbersFromUser () 


let numbers = getNumbersFromUser ()
let lastDigits = List.map getLastDigit numbers

printfn "Исходный список чисел: %A" numbers
printfn "Список последних цифр: %A" lastDigits


