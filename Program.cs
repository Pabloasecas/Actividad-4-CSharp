Console.WriteLine("Introduzca el primer número"); 
var primerNumero = Console.ReadLine();
int numero1 = int.Parse(primerNumero);
Console.WriteLine("Introduzca el segudno número"); 
var segundoNumero = Console.ReadLine();
int numero2 = int.Parse(primerNumero);
if (numero1 > numero2)
{
    Console.WriteLine("El primer número introducido es mayor al segundo");
}
else if (numero1 < numero2)
{
    Console.WriteLine("El primer número introducido es menor al segundo");
}
else
{
    Console.WriteLine("El primer número introducido es igual al segundo");
}
