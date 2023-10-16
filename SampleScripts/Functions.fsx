open System.Linq

let addOne = fun(x: int) -> x + 1

let mutable res = addOne 4

printfn "%A" res


let concactNames = fun(fName:string, lName:string) -> String.concat " " [fName; lName]

let s (n: string) =
    let mutable res = n.ToCharArray();
    for i = 0 to n.Length - 1 do
        if i = 0 then 
            res[0] <- res[0].ToString().ToUpper().ToCharArray()[0]
        if res[i].ToString() = " " then 
            res[i+1] <- res[i+1].ToString().ToUpper().ToCharArray()[0]
    System.String res

let finalFunc = concactNames >> s

let fName = "william"
let lName = "moore"

let result = finalFunc(fName, lName) |> fun (name:string) -> name + "!" 

printfn "%A" result
