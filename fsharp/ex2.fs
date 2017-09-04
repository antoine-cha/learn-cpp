let addFibo L =
    match L with
    | [] -> []
    | [a] -> [a]
    | p :: q :: l -> [p+q] @ L

let rec fiboList n = 
    match n with
    | 0 -> [1]
    | 1 -> [1;1]
    | n -> addFibo (fiboList (n-1))

let x = fiboList 35
        |> Seq.filter (fun x -> (x < 4000000))
        |> Seq.filter (fun x -> ((x % 2) = 0)) 
        |> Seq.sum