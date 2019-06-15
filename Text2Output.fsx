open System.Web.Configuration
open System.Windows.Forms.VisualStyles.VisualStyleElement.TreeView
open System.Windows.Forms.VisualStyles.VisualStyleElement.TreeView
let m = [2;3;4;5]
1 :: m
m @ m

2%1 = 1
List.map (fun a -> a + a) [1..100]

List.sum [1..100]
List.sum (List.map (fun a -> a + a) [1..100])
List.sumBy (fun a -> a + a) [1..100]
List.map (fun a -> a + a) [1..100] 

let a= (fun  m ->  
    match m with
       | "a" -> printfn "a"
       | "b" -> printfn "b"
       | _ -> printfn "whatever"
) 

let a = Some("d")

type CompanyTypes =
    CompanyUnderManagement
    | Trust
    | Branch


let c = Branch

let b s =
    match s with
    | CompanyUnderManagement -> 1
    | Trust -> 2
    | Branch -> 3

b CompanyTypes.Branch




