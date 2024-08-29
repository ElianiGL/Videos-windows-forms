using Microsoft.Office.Interop.Excel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Videos_windows_forms.Algoritmos
{
    public class AlgoritmoSimulacion
    {
        public AlgoritmoSimulacion() { }
        public List<int> GenerarValores(int n)
        {
            List<int> listaSalida = new List<int>();
            for (int i = 0; i < n; i++)
            {
                listaSalida.Add(5*(i+1));
            }
            return listaSalida;
        }
        public List<int> GenerarValores1(int n)
        {
            List<int> listaSalida1 = new List<int>();
            for (int i = 0; i < n; i++)
            {
                listaSalida1.Add(5 * (i + 1));
            }
            return listaSalida1;
        }
        public List<int> GenerarValores2(int n)
        {
            List<int> listaSalida2 = new List<int>();
            for (int i = 0; i < n; i++)
            {
                listaSalida2.Add(5 * (i + 1));
            }
            return listaSalida2;
        }
        public (List<int> listaSalida1, List<int> listaSalida2) CuadradoMedio(int Semilla1)
        {
            List<int> listaSalida1 = new List<int>();
            List<int> listaSalida2 = new List<int>();
            int xn = Semilla1; // R(n)
            int mr_2;
            int val1;
            int val2;
            bool corre = true;

            while (corre)
            {
                // Verifica que R(n) != 0
                if (xn == 0)
                {
                    corre = false;
                }
                // R(n)^2
                int xn_2 = xn * xn;
                // Convertir R(n)^2 a string
                string xn_2_Str = xn_2.ToString();
                // Verificar que R(n)^2 tenga más de 2 dígitos
                if (xn_2_Str.Length > 2)
                {
                    // Eliminar el primer y último carácter
                    string xn_2_Str_resul = xn_2_Str.Substring(1, xn_2_Str.Length - 2);
                    // M.R(n)^2
                    mr_2 = int.Parse(xn_2_Str_resul);
                }
                else
                {
                    mr_2 = 0; // M.R(n)^2
                }
                // Convertir M.R(n)^2 a string
                string mr_2_Str = mr_2.ToString();
                // Verificar que R(n)^2 tenga más de 3 dígitos
                if (mr_2_Str.Length > 3)
                {
                    // Eliminar el último carácter
                    string mr_2_Str_resul1 = mr_2_Str.Substring(0, mr_2_Str.Length - 1);
                    // Eliminar el primer carácter
                    string mr_2_Str_resul2 = mr_2_Str.Substring(1);
                    // Val 1 y Val 2
                    val1 = int.Parse(mr_2_Str_resul1);
                    val2 = int.Parse(mr_2_Str_resul2);
                }
                else
                {
                    val1 = mr_2; // Val 1
                    val2 = 0; // Val 2
                }
                listaSalida1.Add(val1);
                listaSalida2.Add(val2);
                // R(n) = R(n+1) 
                xn = val1;
            }
            return (listaSalida1, listaSalida2);
        }
        public (List<int> listaSalida1, List<int> listaSalida2) ProductoMedio(int Semilla1, int Semilla2)
        {
            List<int> listaSalida1 = new List<int>();
            List<int> listaSalida2 = new List<int>();
            int xn = Semilla1; // R(n)
            int yn = Semilla2; // R(n+1)
            int mr_2;
            int val1;
            int val2;
            bool corre = true;

            while (corre)
            {
                // Verifica que R(n) != 0
                if (xn == 0)
                {
                    corre = false;
                }
                // R(n)^2
                int xn_2 = xn * yn;
                // Convertir R(n)^2 a string
                string xn_2_Str = xn_2.ToString();
                // Verificar que R(n)^2 tenga más de 2 dígitos
                if (xn_2_Str.Length > 2)
                {
                    // Eliminar el primer y último carácter
                    string xn_2_Str_resul = xn_2_Str.Substring(1, xn_2_Str.Length - 2);
                    // M.R(n)^2
                    mr_2 = int.Parse(xn_2_Str_resul);
                }
                else
                {
                    mr_2 = 0; // M.R(n)^2
                }
                // Convertir M.R(n)^2 a string
                string mr_2_Str = mr_2.ToString();
                // Verificar que R(n)^2 tenga más de 3 dígitos
                if (mr_2_Str.Length > 3)
                {
                    // Eliminar el último carácter
                    string mr_2_Str_resul1 = mr_2_Str.Substring(0, mr_2_Str.Length - 1);
                    // Eliminar el primer carácter
                    string mr_2_Str_resul2 = mr_2_Str.Substring(1);
                    // Val 1 y Val 2
                    val1 = int.Parse(mr_2_Str_resul1);
                    val2 = int.Parse(mr_2_Str_resul2);
                }
                else
                {
                    val1 = mr_2; // Val 1
                    val2 = 0; // Val 2
                }
                listaSalida1.Add(val1);
                listaSalida2.Add(val2);
                // R(n) = R(n+1) 
                xn = yn;
                // R(n+1) = Val 1
                yn = val1;
            }
            return (listaSalida1, listaSalida2);
        }
        public List<int> GeneradorCongruencialLineal(int a, int c, int m, int X0)
        {
            List<int> listaSalida = new List<int>();
            bool entra = true;
            int xi = X0;

            while (entra)
            {
                xi = (a * xi + c) % m;
                if (!listaSalida.Contains((xi + 1) % m))
                {
                    listaSalida.Add((xi + 1) % m);
                }
                else
                {
                    entra = false;
                }
            }
            return listaSalida;
        }
        public List<int> GeneradorCongruencialNoLineal(int a, int c, int m, int X0)
        {
            List<int> listaSalida = new List<int>();
            bool entrada = true;
            int t_count = 0;
            int xi = X0;
            
            while (entrada && t_count <= 25)
            {
                xi = (11 * a * (xi * xi) + 3 * a * xi + c) % m;
                if (!listaSalida.Contains((xi + 1) % m))
                {
                    listaSalida.Add(xi % m + 1);
                }
                else
                {
                    entrada = false;
                }
                t_count++;
            }
            return listaSalida;
        }
    }
}