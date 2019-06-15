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

