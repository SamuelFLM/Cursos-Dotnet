float[] cordenadas = { -0.1f, -0.1f };

if (cordenadas[0] == 0 && cordenadas[1] == 0) { Console.WriteLine("Origem"); }

if (cordenadas[0] >= 0.1 && cordenadas[1] >= 0.1) { Console.WriteLine("Q1"); }
if (cordenadas[0] <= 0.1 && cordenadas[1] >= 0.1) { Console.WriteLine("Q2"); }
if (cordenadas[0] <= 0.1 && cordenadas[1] <= 0.1) { Console.WriteLine("Q3"); }
if (cordenadas[0] >= 0.1 && cordenadas[1] <= 0.1) { Console.WriteLine("Q4"); }

