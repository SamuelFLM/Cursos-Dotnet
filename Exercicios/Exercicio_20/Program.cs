

short[] idade = { 400, 800, 30 };

for (int i = 0; i < idade.Length; i++)
{
    Console.WriteLine($@"
    {(idade[i] / 365)} ano (s) 
    {(idade[i] % 365) / 30} mes (s)
    {(idade[i] % 365) % 30} dia (s)
    ");
}
