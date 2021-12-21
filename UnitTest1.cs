using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CountWord
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public static int[] TestMethod(string frase)
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
    }
}
