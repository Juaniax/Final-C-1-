/*Hacer un programa que permita ingresar una lista de números que 
corta cuando se ingresa un cero. A partir de dichos datos informar:
a. El mayor de los números pares.
b. La cantidad de números impares.
c. El menor de los números primos.
Nota: evaluar el uso de una función que analice si un 
número dado es primo o no y que devuelva true o false según corresponda.
*/
int n, nMayorPar = 0, cantImp = 0, menPri = 1000;
int cont=0;

Console.WriteLine("ingrese un nro:");
n = int.Parse(Console.ReadLine());

while (n != 0)
{
    if (primo(n,cont) && n < menPri)
    menPri = n;


    if (n % 2 == 0 && n > nMayorPar)
    nMayorPar = n;
    else if (n % 2 != 0)
    cantImp++;

    Console.WriteLine("ingrese un nro:");
    n = int.Parse(Console.ReadLine());

}
Console.WriteLine("el mayor de los pares es: "+ nMayorPar );
Console.WriteLine("la cantidad de impares es: "+ cantImp );
Console.WriteLine("el menor de los primos es: "+ menPri );

static bool primo (int nro, int con){
    
    for (int x = 1; x <= nro; x++)
    {
    if (nro % x == 0)
    con++;
    }
       if (con == 2)
            return true;
        else
            return false;         
}