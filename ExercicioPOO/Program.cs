using System;

namespace POOExercicio;

class Pessoa
{
    public float peso = 90.00f;
    public float altura = 1.72f;

    public static void Main(string[] x)
    {

        Pessoa t = new Pessoa();

        Console.WriteLine( Math.Round(t.IMC(), 2) + "\n");

        Console.WriteLine("/-------------/\n");

        Console.WriteLine("/------ Legenda -------/\n");

        var a = t.Legenda();

        Console.WriteLine(a);

        Console.WriteLine("/-------------/");

    }

    public double IMC()
    {
        Console.WriteLine("Calculando!!!\n");

        Pessoa imc = new Pessoa();

        return imc.peso / (imc.altura * 2);
    }

    public string Legenda()
    {
         string text = ("< 18.5 - Abaixo do peso \n" +
                          "< 25 - Peso normal \n" +
                          "< 30 - Acima do peso \n" +
                          "< 35 - Obesidade I \n" +
                          "< 40 - Obesidade II \n" +
                          ">= 40 - Obesidade III \n" +
                          "");
        return text;
    }
}