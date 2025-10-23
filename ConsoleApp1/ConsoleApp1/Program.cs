// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

int n = 100;
int raiz_quadrada_n = (int)Math.Sqrt(n);

List<int> lista = new List<int>();
List<int> numeros_primos = new List<int>();
int i;
for (i = 2; i <= n; i++)
{
    lista.Add(i);
}

try
{
    while ((i = lista.Take(1).First()) <= raiz_quadrada_n)
    {
        numeros_primos.Add(i);
        lista.Remove(i);
        foreach (var item in lista.ToList())
        {
            if (item % i == 0)
            {
                lista.Remove(item);
            }
        }
    }
}
catch (Exception)
{
}

foreach (var item in numeros_primos)
{
    Console.WriteLine($"{item} | ");
}