using System;

public class Word
{
	public Word()
	{
        static int[] PalabrasCaracteres(string frase)
        {
            int palabras = 0;
            int caracterestotales = 0;
            for (int i = 0; i < frase.Length; i++)
            {
                if (frase[i] == ' ' || frase[i] == '.')
                {
                    palabras++;
                }
            }
            int[] PalabrasCaracteres = new int[2];
            caracterestotales = frase.Length - palabras;
            PalabrasCaracteres[0] = palabras;
            PalabrasCaracteres[1] = caracterestotales;
            return PalabrasCaracteres;
        }

        Console.Write("Ingrese una frase: ");
        string frase = Console.ReadLine();
        int[] resultado = PalabrasCaracteres(frase);
        Console.WriteLine("La frase tiene {0} palabras", resultado[0]);
        Console.WriteLine("La frase tiene {0} caracteres", resultado[1]);
        Console.ReadKey();

    }
}
