let imod (n:int64) (p:int64) = n % p
let divide n p = (imod n p) = 0L
let isMult (n:int64) l = 
    l
    |> Seq.map (imod n)
    |> Seq.min = 0L

let addPrime l (n:int64) =
    match isMult n l with
    | false -> n :: l
    | true -> l

let factors l n = 
    l
    |> Seq.filter (divide n)

let rec primeUpTo (n:int64) = 
    match n with
    | 0L -> []
    | 1L -> []
    | 2L -> [2L]
    | n -> addPrime (primeUpTo (n-1L)) n

let N:float = 600851475143.0
let maxFactor:int64 = int64 (sqrt N)
printfn "%d" maxFactor
let primes = primeUpTo 77000L
// let facts = primeUpTo maxFactor
printfn "%A" primes