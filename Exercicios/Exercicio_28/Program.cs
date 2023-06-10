List<short> input1 = new List<short>(){ 7, 21, -14 };
List<short> input2 = new List<short>() { -14, 21, 7 };


List<short> valoresOrdenados = input2.OrderBy(x => x).ToList();
foreach (short i in valoresOrdenados) { Console.WriteLine(i); }
Console.WriteLine("");
foreach (short i in input2) { Console.WriteLine(i); }

