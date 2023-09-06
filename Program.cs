// See https://aka.ms/new-console-template for more information
using System.Runtime.Versioning;

Console.WriteLine("Ingresar nombre del cliente !!!");
string nombre = Console.ReadLine();
Console.WriteLine("*******************************");

Console.WriteLine("Cuantos vehiculos desea enviar?..");
float vehiculo =float.Parse(Console.ReadLine());

Console.WriteLine("*-*-*-*-**-*--*--*-*-*-**-*--**-*-");

double precioenvio = Math.Pow(vehiculo, 2) - 2 * vehiculo + 1;

if ( vehiculo >=1 &&  vehiculo<=10)
{


    if (precioenvio >= 0 && precioenvio <= 10)
    {

        Console.WriteLine("La calificacion del correspondiente seria : Bajo");
   
    }
    else if (precioenvio > 10 && precioenvio <= 30)
    {

        Console.WriteLine("La calificacion del correspondiente seria : Medio");
    }
    else if (precioenvio > 30 && precioenvio <= 60)
    {

        Console.WriteLine("La calificacion del correspondiente seria : Buena");
    }
    else if (precioenvio > 60)
    {

        Console.WriteLine("La calificacion del correspondiente seria : Excelente");
    }
    Console.WriteLine("El precio de envio del cliente\t" + nombre + "\tpara\t" + vehiculo + "\tvehiculos es:\t" + precioenvio + "$");
    Console.WriteLine("**********\t********************************************");
    Console.WriteLine("Muchas gracias por comprar!!!!");
}
else
{
   
    Console.WriteLine("ERROR");
    Console.WriteLine("RECUERDE QUE EL MAXIMO ENVIOS DE VEHICULOS ES 10!!:D");
}

