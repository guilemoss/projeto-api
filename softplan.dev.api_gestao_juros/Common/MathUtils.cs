using System;

namespace softplan.dev.api_gestao_juros.Common
{
    public static class MathUtils
    {
        public static decimal CalcularPotencia(double pNumero, int pExpoente) => (decimal)Math.Pow(pNumero, pExpoente);
        public static decimal TruncarValor(decimal pValor, int pQtdDecimais = 2) => Math.Round(pValor, pQtdDecimais);
    }
}
