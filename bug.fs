let mutable x = 10
let mutable y = 20

let add x y = 
    x <- x + y
    y

let result = add x y
printfn "%A %A" x result