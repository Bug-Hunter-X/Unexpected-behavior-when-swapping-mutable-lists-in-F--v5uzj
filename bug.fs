let mutable x = 10
let mutable y = 20

let swap x y = 
    let temp = x
    x <- y
    y <- temp

swap x y
printfn "%d %d" x y //This will print 20 10 as expected

let mutable a = [1;2;3]
let mutable b = [4;5;6]

let swapList a b = 
    let temp = a
    a <- b
    b <- temp

swapList a b
printfn "%A %A" a b //This will print [4;5;6] [4;5;6] instead of [4;5;6] [1;2;3]