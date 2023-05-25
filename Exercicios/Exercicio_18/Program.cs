
byte[] cedulas = { 100, 50, 20, 10, 5, 2, 1 };


short nota = short.Parse(Console.ReadLine());

for (int i = 0; i < cedulas.Length; i++)
{
    Console.WriteLine($" {nota / cedulas[i]} NOTA(S) de R$ {cedulas[i]}");

    nota %= cedulas[i];
}