
int segundos = 556;
int[] tempo = { 3600, 60};

Console.WriteLine($"{segundos / tempo[0]}:{(segundos / tempo[1]) % 60}:{segundos % tempo[1]}");
