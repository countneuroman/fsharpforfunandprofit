open System

//Define named function
let addTwoNumbers x y = x + y

Console.WriteLine(addTwoNumbers 2 3)


let oneToTen = [1..10]
let evens list =
    let isEven x =x % 2 = 0
    List.filter isEven list
    
evens oneToTen |> Seq.iter (printf "%d ")

let square x = x * x

let sumOfSquareTo3piped =
    [1..3] |> List.map square |> List.sum |> printfn "%d"
    
//Define lambdas with "fun" keyword
let sumOfSquareTo3fun =
    [1..3] |> List.map (fun x -> x * x) |> List.sum |> printfn "%d"
    
//Pattern matching
let simplePatternMatch =
    let x = Console.ReadLine()
    match x with
    | "a" -> printfn "x is a"
    | "b" -> printfn "x is b"
    | _ -> printfn "x is %A" x
    
//Some(..) and None are roughly analogous to Nullable wrappers
let validValue = Some(99)
let invalidValue = None

let optionPatternMatch input =
    match input with
    | Some i -> printfn "input is int = %d" i
    | None -> printfn "Input is missing"
    
optionPatternMatch validValue
optionPatternMatch invalidValue

let threeTuple = 1,"s",true

//Record type
type Person = {FirstName:string; LastName:string}
let person1 = {FirstName="Vadim"; LastName="Nikolaev"}
let person2 = {FirstName="Nikolai"; LastName="Sergeev"}

//Union type
type Temp =
    | DegressF of float
    | DegressC of float
let tempInMoscow = Temp.DegressC 23,4

type Employee =
    | Developer of Person
    | Manager of Employee list

let developer = Developer person1
let developer2 = Developer person2
