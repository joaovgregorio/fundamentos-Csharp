using System;
using System.Text;

namespace Concepts
{
    internal class Program
    {
        private static void Main()
        {
            Console.Clear();
            
            var texto = new StringBuilder();

            texto.Append("Fazendo um teste simples para validação");
            texto.Append(" de um texto com StringBuilder");
            texto.Append(" e não com string normal");

            texto.ToString();
            Console.WriteLine(texto);
        }
    }
}