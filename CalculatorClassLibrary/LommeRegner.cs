using System.Diagnostics.CodeAnalysis;

namespace CalculatorClassLibrary
{
    public class LommeRegner
    {

        /// <summary>
        /// construktøren
        /// </summary>
        public LommeRegner()
        {
            
        }

        /// <summary>
        /// Plus funktion som tager 2 paremetere
        /// </summary>
        /// <param name="x">første parameter i parameterlisten</param>
        /// <param name="y">anden parameter i parameterlisten</param>
        /// <returns>retunere svaret</returns>
        public double PlusFunktion(double x, double y)
        {
            
            return x + y;
        }

        /// <summary>
        /// En funktion til brug af minus stykker, så hvis man som individ gerne vil minus to tal så kan man bruge den her funtkion
        /// </summary>
        /// <param name="x">første input gemmes som double</param>
        /// <param name="y">anden input gemmes som double</param>
        /// <returns>retunere en double med svaret</returns>
        public double MinusFunktion(double x, double y)
        {
            return x - y;
        }

        /// <summary>
        /// En funktion til brug af gange stykker, så hvis man har brug for at gange to tal sammen så kan man bruge den her funtkion
        /// </summary>
        /// <param name="x">første parameter i parameterlisten</param>
        /// <param name="y">anden parameter i parameterlisten</param>
        /// <returns>retunere svaret af regne stykket</returns>
        public double GangeFunktion(double x, double y)
        {
            return x * y;
        }

        /// <summary>
        /// En funktion brug af dividere, så det kank man bruge hvis man har lyst
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <returns>retunere de 2 tal divideret med hinanden</returns>
        public double dividereFunktion(double x, double y)
        {
            return x / y;
        }


        








    }
}
