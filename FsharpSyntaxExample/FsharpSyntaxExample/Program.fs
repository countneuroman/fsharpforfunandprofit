open System

//Define named function
let addTwoNumbers x y = x + y

Console.WriteLine(addTwoNumbers 2 3)


let oneToTen = [1..10]
let evens list =
    let isEven x =x % 2 = 0
    List.filter isEven list
    
evens oneToTen |> Seq.iter (printf "%d ")