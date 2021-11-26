// See https://aka.ms/new-console-template for more information

Console.WriteLine("Peso: ");
int p = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Altura: ");
double h = Convert.ToDouble(Console.ReadLine());

var imc = p/(h*h);

if (imc < 16)
{
    Console.WriteLine("Su IMC es: " + imc + ". Categoria: Delgadez severa");
}
else if (imc < 16.99 && imc > 16)
{
    Console.WriteLine("Su IMC es: " + imc + ". Categoria: Delgadez moderada");
}
else if (imc < 18.49 && imc > 17)
{
    Console.WriteLine("Su IMC es: " + imc + ". Categoria: Delgadez aceptable");
}
else if (imc < 24.99 && imc > 18.5)
{
    Console.WriteLine("Su IMC es: " + imc + ". Categoria: Peso normal");
}
else if (imc < 29.99 && imc > 25)
{
    Console.WriteLine("Su IMC es: " + imc + ". Categoria: Sobrepeso");
}
