float[] input = { 2, 4, 7.5f, 8};
float[] pesos = { 2, 3, 4, 1 };
float notaDigitada = 6.4f;

float media = ((input[0] * pesos[0]) + (input[1] * pesos[1]) + (input[2] * pesos[2]) + (input[3] * pesos[3])) / 10;

Console.WriteLine($"Media: {media}");

if ( media >= 7.0)
{
    Console.WriteLine("Aluno Aprovado");
}

if (media < 5.0)
{
    Console.WriteLine("Aluno reprovado");
}

if ( media >= 5.0 && media <= 6.9)
{
    Console.WriteLine("Aluno em exame.");
    Console.WriteLine($"Nota do exame: {notaDigitada}");
    float resultadoFinal = (media + notaDigitada) / 2;
    if (resultadoFinal >= 5.0) { Console.WriteLine("Aluno Aprovado."); } else { Console.WriteLine("Aluno Reprovado."); }

    Console.WriteLine($"Media Final: {resultadoFinal}");
}

