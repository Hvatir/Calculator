open System
let sum num1 num2 = (num1 + num2)
let substraction num1 num2 = (num1 - num2)
let multiplication num1 num2 = (num1 * num2)
let division num1 num2 = (num1 / num2)

[<EntryPoint>]
let main args =
    
    printfn "Sumar[1] | Restar [2] | Multiplicar [3] | Dividir [4]"
    
    let op = (int (Console.ReadLine()));

    let operation =
        if op <> 1 && op <> 2 && op <> 3 && op <> 4 then
            printfn "\nError: Opción invalida"
        else
            printfn "\nEscribe el primer numero"
            let num1 = Console.ReadLine()

            printfn "\nEscribe el segundo numero"
            let num2 = Console.ReadLine()
            let result = 
                if (op = 1) then
                    printfn "La suma de %s y %s es %i" num1 num2 (sum (int num1) (int num2))
                elif (op = 2) then
                    printfn "\nLa resta de %s y %s es %i" num1 num2 (substraction (int num1) (int num2))
                elif (op = 3) then
                    printfn "\nLa multiplicación de %s y %s es %i" num1 num2 (multiplication (int num1) (int num2))
                elif (op = 4) then
                    printfn "\nLa división de %s y %s es %i" num1 num2 (division (int num1) (int num2))
                else
                    printfn "\nError: Opción invalida"
      
            result
    0