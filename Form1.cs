using System.Windows.Forms;
using Videos_windows_forms.Algoritmos;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
namespace Videos_windows_forms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void button1_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("Ejecutando el método del cuadrado medio");
            // Condicion de vacio
            if (textBox5.Text.Equals(""))
            {
                MessageBox.Show("Los números tienen que ser MAYOR que cero, NO VACÍOS");
                return;
            }

            // Inicialización de parámetros
            int Semilla1 = Convert.ToInt32(textBox5.Text);

            // Condiciones
            if (Semilla1 <= 0)
            {
                MessageBox.Show("Valor semilla 1 tiene que ser mayor que CERO");
                return;
            }

            AlgoritmoSimulacion algoritmo = new AlgoritmoSimulacion();
            (List<int> listaEnteros1, List<int> listaEnteros2) = algoritmo.CuadradoMedio(Semilla1);
            llenarGridCMyPM(listaEnteros1, listaEnteros2);
        }
        private void button2_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("Ejecutando el método del producto medio");
            // Condicion de vacio
            if (textBox6.Text.Equals("") ||
                textBox7.Text.Equals(""))
            {
                MessageBox.Show("Los números tienen que ser MAYOR que cero, NO VACÍOS");
                return;
            }

            // Inicialización de parámetros
            int Semilla1 = Convert.ToInt32(textBox6.Text);
            int Semilla2 = Convert.ToInt32(textBox7.Text);

            // Condiciones
            if (Semilla1 <= 0 || Semilla2 <= 0)
            {
                MessageBox.Show("Valores semilla 1 y semilla 2 tienen que ser mayor que CERO");
                return;
            }

            AlgoritmoSimulacion algoritmo = new AlgoritmoSimulacion();
            (List<int> listaEnteros1, List<int> listaEnteros2) = algoritmo.ProductoMedio(Semilla1, Semilla2);
            llenarGridCMyPM(listaEnteros1, listaEnteros2);
        }
        private void button3_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("Ejecutando el método de generador congruencial lineal");
            // Condicion de vacio
            if (textBox1.Text.Equals("") ||
                textBox2.Text.Equals("") ||
                textBox3.Text.Equals("") ||
                textBox4.Text.Equals(""))
            {
                MessageBox.Show("Los números tienen que ser MAYOR que cero, NO VACÍOS");
                return;
            }

            // Inicialización de parámetros
            int a = Convert.ToInt32(textBox1.Text);
            int c = Convert.ToInt32(textBox2.Text);
            int m = Convert.ToInt32(textBox3.Text);
            int X0 = Convert.ToInt32(textBox4.Text);

            // Condiciones
            if (a <= 0 || c <= 0 || X0 <= 0)
            {
                MessageBox.Show("Valores a, c, X0 tienen que ser mayor que CERO");
                return;
            }
            if (m <= X0 || m <= c || m <= a)
            {
                MessageBox.Show("El valor de m tiene que ser mayor que CERO");
                return;
            }

            List<int> primes = new List<int>()
            {
                2, 3, 5, 7, 11, 13, 17, 19,
                23, 29, 31, 37, 41, 43, 47,
                53, 59, 61, 67, 71, 73, 79,
                83, 89, 97, 101, 103, 107,
                109, 113, 127, 131, 137, 139,
                149, 151, 157, 163, 167, 173,
                179, 181, 191, 193, 197, 199
            };

            if (!primes.Contains(m))
            {
                MessageBox.Show("El valor de m tiene que ser un numero primo");
                return;
            }

            AlgoritmoSimulacion algoritmo = new AlgoritmoSimulacion();
            List<int> listaEnteros = algoritmo.GeneradorCongruencialLineal(a, c, m, X0);
            llenarGridGCLyGCNL(listaEnteros);
        }
        private void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Ejecutando el método de generador congruencial no lineal");
            // Condicion de vacio
            if (textBox8.Text.Equals("") ||
                textBox9.Text.Equals("") ||
                textBox10.Text.Equals("") ||
                textBox11.Text.Equals(""))
            {
                MessageBox.Show("Los números tienen que ser MAYOR que cero, NO VACÍOS");
                return;
            }

            // Inicialización de parámetros
            int a = Convert.ToInt32(textBox8.Text);
            int c = Convert.ToInt32(textBox9.Text);
            int m = Convert.ToInt32(textBox10.Text);
            int X0 = Convert.ToInt32(textBox11.Text);

            // Condiciones
            if (a <= 0 || c <= 0 || X0 <= 0)
            {
                MessageBox.Show("Valores a, c, X0 tienen que ser mayor que CERO");
                return;
            }
            if (m <= X0 || m <= c || m <= a)
            {
                MessageBox.Show("El valor de m tiene que ser mayor que CERO");
                return;
            }

            List<int> primes = new List<int>()
            {
                2, 3, 5, 7, 11, 13, 17, 19,
                23, 29, 31, 37, 41, 43, 47,
                53, 59, 61, 67, 71, 73, 79,
                83, 89, 97, 101, 103, 107,
                109, 113, 127, 131, 137, 139,
                149, 151, 157, 163, 167, 173,
                179, 181, 191, 193, 197, 199
            };

            if (!primes.Contains(m))
            {
                MessageBox.Show("El valor de m tiene que ser un numero primo");
                return;
            }

            AlgoritmoSimulacion algoritmo = new AlgoritmoSimulacion();
            List<int> listaEnteros = algoritmo.GeneradorCongruencialNoLineal(a, c, m, X0);
            llenarGridGCLyGCNL(listaEnteros);
        }
        public void llenarGridGCLyGCNL(List<int> lista)
        {
            // Número de columnas
            string numeroColumna1 = "1";
            string numeroColumna2 = "2";

            // Cantidad de columnas
            dataGridView1.Columns.Clear();
            dataGridView1.Columns.Add(numeroColumna1, "Id");
            dataGridView1.Columns.Add(numeroColumna2, "Valor");

            //Llenas los valores aleatorios
            for (int i = 0; i < lista.Count; i++)
            {
                dataGridView1.Rows.Add();
                dataGridView1.Rows[i].Cells[Int32.Parse(numeroColumna1) - 1].Value = (i + 1).ToString();
                dataGridView1.Rows[i].Cells[Int32.Parse(numeroColumna2) - 1].Value = lista[i].ToString();
            }
        }
        public void llenarGridCMyPM(List<int> lista1, List<int> lista2)
        {
            // Número de columnas
            string numeroColumna1 = "1";
            string numeroColumna2 = "2";
            string numeroColumna3 = "3";

            // Cantidad de columnas
            dataGridView1.Columns.Clear();
            dataGridView1.Columns.Add(numeroColumna1, "Id");
            dataGridView1.Columns.Add(numeroColumna2, "Valor 1");
            dataGridView1.Columns.Add(numeroColumna3, "Valor 2");

            //Llenas los valores aleatorios
            for (int i = 0; i < lista1.Count; i++)
            {
                dataGridView1.Rows.Add();
                dataGridView1.Rows[i].Cells[Int32.Parse(numeroColumna1) - 1].Value = (i + 1).ToString();
                dataGridView1.Rows[i].Cells[Int32.Parse(numeroColumna2) - 1].Value = lista1[i].ToString();
                dataGridView1.Rows[i].Cells[Int32.Parse(numeroColumna3) - 1].Value = lista2[i].ToString();
            }
        }
        public void DescargasExcel(DataGridView data)
        {
            // Instalar excel
            Microsoft.Office.Interop.Excel.Application exportarExcel = new Microsoft.Office.Interop.Excel.Application();
            exportarExcel.Application.Workbooks.Add(true);
            int indiceColumna = 0;

            // Construyes columnas y los nombres de las "cabeceras"
            foreach (DataGridViewColumn columna in data.Columns)
            {
                indiceColumna++;
                exportarExcel.Cells[1, indiceColumna] = columna.HeaderText;
            }

            // Construyes filas y Llenas valores
            int indiceFilas = 0;
            foreach (DataGridViewRow fila in data.Rows)
            {
                indiceFilas++;
                indiceColumna = 0;
                foreach (DataGridViewColumn columna in data.Columns)
                {
                    indiceColumna++;
                    exportarExcel.Cells[indiceFilas + 1, indiceColumna] = fila.Cells[columna.Name].Value;
                }
            }
            exportarExcel.Visible = true;
        }
        private void button0_Click_1(object sender, EventArgs e)
        {
            DescargasExcel(dataGridView1);
        }
    }
}