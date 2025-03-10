open System

let getLastDigit number =
    let absNumber = abs number  
    absNumber % 10              

let rec getNumbersFromUser () =
    printf "Введите числа через пробел: "
    let input = Console.ReadLine()  
    
    try
        
        input.Split(' ') 
        |> Seq.map int 
        |> Seq.toList   
    with
    | :? FormatException ->  
        printfn "Ошибка: Введите только числа, разделенные пробелами!"
        getNumbersFromUser ()  

let numbers = getNumbersFromUser () 
let lastDigits = List.map getLastDigit numbers  

printfn "Исходный список чисел: %A" numbers
printfn "Список последних цифр: %A" lastDigits
