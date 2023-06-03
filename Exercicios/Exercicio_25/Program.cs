
Dictionary<short, float> lanche = new Dictionary<short, float>
{
    { 1, 4.00f },
    { 2, 4.50f },
    { 3, 5.00f },
    { 4, 2.00f },
    { 5, 1.50f }
};

short[] entrada = { 2, 3 };

float calculo = lanche[entrada[0]] * entrada[1];

Console.WriteLine($"Total: R$ {calculo.ToString("F2")}");
