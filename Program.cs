//Hacer un programa donde se ingrese la fecha actual y compruebe si corresponde al día de tu cumpleaños. Mostrar un mensaje de felicitaciones en tal caso.

int diaCumple = 23; 
        int mesCumple = 7;  

        Console.WriteLine("Ingrese la fecha actual:");
        Console.Write("Día: ");
        int diaActual = Convert.ToInt32(Console.ReadLine());

        Console.Write("Mes: ");
        int mesActual = Convert.ToInt32(Console.ReadLine());

        if (diaActual == diaCumple && mesActual == mesCumple)
        {
            Console.WriteLine("Feliz cumpleaños!");
        }
        else
        {
            Console.WriteLine("Hoy no es tu cumpleaños.");
        }