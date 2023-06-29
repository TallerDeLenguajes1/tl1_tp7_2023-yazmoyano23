// See https://aka.ms/new-console-template for more information
using EspacioCalculadora;

Calculadora miCalculadora = new Calculadora();

bool anda = false;
string? numString = "";
int num=0, operacion = 0;
string? operar = "S";

while (!anda) {
    Console.WriteLine("Ingrese un número: ");
    numString = Console.ReadLine();
    anda = int.TryParse(numString, out num);
    if (!anda) {
        Console.WriteLine(numString + " no es numero válido.");   
    }
}

anda = false;

while (!anda) {
    Console.WriteLine("Ingrese la operacion que desea realizar: (1:SUMAR 2:RESTAR 3:MULTIPLICAR 4:DIVIDIR)");
    numString = Console.ReadLine();
    anda = int.TryParse(numString, out operacion);
    //Control de numero
    if (!anda) {
        Console.WriteLine(numString + " no es numero válido.");   
    }
    if (operacion > 4 ){
        anda = false;
        Console.WriteLine(operacion + " no es una opción válida.");
    }
}


anda = false;

while (operar == "S"){

    switch (operacion)
    {
        case 1: 
                miCalculadora.Sumar(num);
                Console.WriteLine( "Resultado de la suma: " + miCalculadora.Resultado );
            break;

        case 2: 
                miCalculadora.Restar(num);
                Console.WriteLine( "Resultado de la resta: " + miCalculadora.Resultado );
            break;

        case 3:
                miCalculadora.Multiplicar(num);
                Console.WriteLine( "Resultado de la multiplicación: " + miCalculadora.Resultado );
            break;

        case 4:
                if (num == 0)
                {
                    while (!anda) {
                        Console.WriteLine("Ingrese un número: ");
                        numString = Console.ReadLine();
                        anda = int.TryParse(numString, out num);
                        if (!anda) {
                            Console.WriteLine(numString + " no es numero válido.");   
                        }
                        if (num == 0)
                        {
                            anda = false;
                        }
                    }
                }
                miCalculadora.Dividir(num);
                Console.WriteLine( miCalculadora.Resultado );
            break;
        case 5:
                miCalculadora.Limpiar();
            break;        

    }

  
    anda = false;
    //Control para continuar operando
    while (!anda)
    {
        Console.WriteLine("Seguir operando: S (SI), N (NO)");
        operar = Console.ReadLine();
        if (operar != "S" && operar != "N") {
            anda = false;
        }else
        {
          anda=true; 
        }
    } 

    anda = false;

    if (operar == "N")
    {
        Console.WriteLine("\nEl resultado final es: " + miCalculadora.Resultado);
        miCalculadora.Limpiar();
    } else {
        while (!anda) {
            Console.WriteLine("Ingrese un número: ");
            numString = Console.ReadLine();
            anda = int.TryParse(numString, out num);
            if (!anda) {
                Console.WriteLine(numString + " no es numero válido.");   
            }
        }
    }

        anda = false;

    //Control para realizar una nueva operacion
    while (!anda) {
        Console.WriteLine("Ingrese la operacion que desea realizar: (1:SUMAR 2:RESTAR 3:MULTIPLICAR 4:DIVIDIR)");
        numString = Console.ReadLine();
        anda = int.TryParse(numString, out operacion);
        //Control de numero
        if (!anda) {
            Console.WriteLine(numString + " no es numero válido.");   
        }
        if (operacion > 4 ){
            anda = false;
            Console.WriteLine(operacion + " no es una opción válida.");
        }
    }

}

        
   
