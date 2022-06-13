using Praktika16_2;

Console.WriteLine("Введите текст");
string[] StringMass = Console.ReadLine().Split(' ', '.', ',');
Console.WriteLine(Exam.Second(StringMass));
Console.WriteLine(Exam.Second2(StringMass));
Console.WriteLine(Exam.Second3(StringMass));
