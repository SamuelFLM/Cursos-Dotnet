


//byte[] valores = { 5, 6, 7, 8 };
byte[] valores = { 2, 3, 2, 6 };

if (valores[1] > valores[2] && valores[3] > valores[0])
{
    if ((valores[2] + valores[3]) > (valores[0] + valores[1]))
    {
        if (valores[2] > 0 && valores[3] > 0)
        {
            Console.WriteLine("Valores aceitos");
        }
    }
}
else
{
     Console.WriteLine("Valores nao aceitos");
}
