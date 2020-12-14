using System;

namespace POO_Static
{
    public class Conversor
    {
        private static float cotacaoDolar = 5.07f;

        public static float realParaDolar(float valorRS){
            return valorRS / cotacaoDolar;
        }

        public static float dolarParaReais(float valorUS){
            return cotacaoDolar * valorUS;
        }

        public static float realParaEuro()
        {
            throw new NotImplementedException();
        }

        private static float cotacaoEuro = 6.12f;

        public static float realParaEuro(float valorRS){
            return valorRS / cotacaoEuro;
        }

        public static float euroParaReais(float valorEUR){
            return cotacaoEuro * valorEUR;
        }

    }
}