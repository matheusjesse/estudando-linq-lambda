int[] numeros = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

foreach(var item in numeros.Where(x => x > 4))
{
    Console.WriteLine(item);
}
