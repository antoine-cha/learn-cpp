let mod3 x = ((x % 3) = 0)
let mod5 x = ((x % 5) = 0)
let ok x = (mod3 x) || (mod5 x)
let s = [1..999] |> Seq.filter ok |> Seq.sum
printfn "%d" s
