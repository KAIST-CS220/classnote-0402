open System

type X = list<int>
type Y = int list
type Z = X option

// let f n =
//   if somecase then n + 1
//   else -1

type MyType<'a, 'b> =
  | MyType of 'a * 'b

let rec sum term a next b =
  if a > b then 0
  else term a + sum term (next a) next b

let next n = n + 1
let sumNum a b = sum id a next b

let sumCubes a b =
  sum (fun x -> x * x * x) a next b

let f = function
  | a -> a

let g x =
  match x with
  | a -> a

let g2 = function
  | a -> a

let g3 =
  let x = 1
  let y = 2
  x + y

let g4 =
  (fun x y -> x + y) 1 2

// val findMovie: string -> Movie

[<EntryPoint>]
let main argv =
    printfn "Hello World from F#!"
    0 // return an integer exit code
