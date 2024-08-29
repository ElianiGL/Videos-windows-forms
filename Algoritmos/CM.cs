using Microsoft.Office.Interop.Excel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Videos_windows_forms.Algoritmos
{
    public class CM
    {
        public CM() { }
        public List<int> GenerarValores(int n)
        {
            List<int> listaSalida = new List<int>();
            for (int i = 0; i < n; i++)
            {
                listaSalida.Add(5 * (i + 1));
            }
            return listaSalida;
        }
        public List<int> GeneradorCM(int a, int m, int digitos)
        {
            List<int> listaSalida = new List<int>();
            int xi = a;
            int digitosMedios = digitos / 2;
            bool entra = true;

            while (entra)
            {
                long cuadrado = (long)xi * xi;
                string cuadradoStr = cuadrado.ToString().PadLeft(digitos * 2, '0');

                string medioStr = cuadradoStr.Substring(digitosMedios, digitos);
                xi = int.Parse(medioStr) % m;

                if (!listaSalida.Contains(xi))
                {
                    listaSalida.Add(xi);
                }
                else
                {
                    entra = false;
                }
            }
            return listaSalida;
        }
    }
}