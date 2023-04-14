Console.WriteLine("Introduzca el primer número"); 
var primerNumero = Console.ReadLine();
int numero1 = int.Parse(primerNumero);
Console.WriteLine("Introduzca el segudno número"); 
var segundoNumero = Console.ReadLine();
int numero2 = int.Parse(segundoNumero);
if (numero1 > numero2)
{
    Console.WriteLine("El " + numero1 + " es mayor al " + numero2);
}
else if (numero1 < numero2)
{
    Console.WriteLine("El " + numero1 + " es menor al " + numero2);
}
else
{
    Console.WriteLine("El " + numero1 + " es igual " + numero2);
}
if (numero2 % 2 == 1)
{
    Console.WriteLine("El " + numero2 + " es impar");
}
else
{
    Console.WriteLine("El " + numero2 + " es par");
}