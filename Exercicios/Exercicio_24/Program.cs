
byte[] intervalo = { 25, 50, 75, 100 };

double[] input = { 25.01, 25, 100, -25.02};

for (int i = 0; i < intervalo.Length; i++)
{
    if (input[i] >= 0 &&input[i] <= intervalo[0]) { Console.WriteLine($"Intervalo [0, 25]"); }
    else if (input[i] > intervalo[0] && input[i] <= intervalo[1]) { Console.WriteLine($"Intervalo [25, 50]"); }
    else if (input[i] > intervalo[1] && input[i] <= intervalo[2]) { Console.WriteLine($"Intervalo [50, 75]"); }
    else if (input[i] > intervalo[2] && input[i] <= intervalo[3]) { Console.WriteLine($"Intervalo [75, 100]"); }
    if (input[i] < 0) { Console.WriteLine("Fora de intervalo"); } 
}
