// int[] numeros = { 8, 5, 9, 10, 2, 3, 7, 6 };

// foreach(var item in numeros.Where(x => x > 4).OrderBy(n => n))
// {
//     Console.WriteLine(item);
// }

string[] cores = {"preto", "branco", "vermelho", "azul" };

var resultado = cores.Where(x => x.Contains("e"));

foreach(string cor in resultado)
{
    Console.WriteLine(cor);
}
 