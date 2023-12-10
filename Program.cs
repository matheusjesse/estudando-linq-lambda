int[] numeros = { 8, 5, 9, 10, 2, 3, 7, 6 };

foreach(var item in numeros.Where(x => x > 4).OrderBy(n => n))
{
    Console.WriteLine(item);
}
