
string valor = "576.73";
byte[] notas = { 100, 50, 20, 10, 5, 2 };
float[] moedas = { 1, 0.50f, 0.25f, 0.10f, 0.05f, 0.01f };


string[] valorSeparado = valor.Split('.');

short valorNota = short.Parse(valorSeparado[0]);
float valorMoeda = 73/ 100f;

Console.WriteLine("NOTAS: ");
for (int i = 0; i < notas.Length; i++)
{
    Console.WriteLine($"{valorNota / notas[i]} nota (s) de R$ {(notas[i]).ToString("F2")}");
    valorNota %= notas[i];
}

Console.WriteLine("MOEDAS: ");
for (int i = 0; i < moedas.Length; i++) 
{
    Console.WriteLine($"{(int)(valorMoeda / moedas[i])} moeda (s) de R$ {(moedas[i]).ToString("F2")}");
    valorMoeda %= moedas[i];
}