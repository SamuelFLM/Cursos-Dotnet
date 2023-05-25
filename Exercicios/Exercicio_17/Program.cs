

internal class Program
{
    private static void Main(string[] args)
    {
        byte[] tempoGastoEVelocidadeMedia = new byte[2];

        for (int i = 0; i < tempoGastoEVelocidadeMedia.Length; i++) { tempoGastoEVelocidadeMedia[i] = byte.Parse(Console.ReadLine()); } 

        float calculoGastoDeCombustivel = tempoGastoEVelocidadeMedia[1] * tempoGastoEVelocidadeMedia[0];

        Console.WriteLine((calculoGastoDeCombustivel / 12).ToString("F3"));
    }
}