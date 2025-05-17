Console.Clear();
string Sexo;
double altura;
Console.Write("Digite sua altura em m..........:");
altura = Convert.ToDouble(Console.ReadLine());
Console.Write("Sexo [M]asculino / [F]eminino...:");
Sexo = Console.ReadLine()!.ToUpper()!;
if (Sexo == "M")
{
    double PesoIdeal;
    PesoIdeal = (altura * 72.7) - 58.0;
    Console.Write($"Seu peso ideal é {PesoIdeal:N1}");

}
else if (Sexo == "F")
{
    double PesoIdeal;
    PesoIdeal = (altura * 62.1) - 44.7;
    Console.Write($"Seu peso ideal é {PesoIdeal:N1}");
}
