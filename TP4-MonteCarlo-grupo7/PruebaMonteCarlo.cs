using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TP4_MonteCarlo_grupo7.Generadores_Aleatorios;

namespace TP4_MonteCarlo_grupo7
{
    public partial class PruebaMonteCarlo : Form
    {
        private double[,] Demanda = { { 0, 0.5 } , { 1, 0.65 } , { 2 , 0.9 } , { 3 , 1 } };
        private double[,] Demora = { { 1, 0.3 }, { 2, 0.7 }, { 3, 1 } };
        private double[,] Rotura = { { 0, 0.7 }, { 1 , 1 } };
        private int Q = 6;
        private int R = 2;
        private int Ko = 20;
        private int Km = 3;
        private int Ks = 5;
        private DataTable resultados = new DataTable();
        private DataTable resultados2 = new DataTable();
        Truncador truncador;
        private bool flagPedido = true;
        int llegadaPedido = 0;
        DataRow row1;
        DataRow row2;
        DataRow rowanterior;

        public PruebaMonteCarlo()
        {
            InitializeComponent();
        }

        private void PruebaMonteCarlo_Load(object sender, EventArgs e)
        {
            cargarTablaResultados();
        }

        private void cargarTablaResultados()
        {
            resultados.Columns.Add("Reloj (semanas)");
            resultados.Columns.Add("RND Demanda");
            resultados.Columns.Add("Demanda");
            resultados.Columns.Add("RND Demora");
            resultados.Columns.Add("Demora");
            resultados.Columns.Add("Orden / Pedido");
            resultados.Columns.Add("Llegada Pedido");
            resultados.Columns.Add("RND Rotura");
            resultados.Columns.Add("Rotura");
            resultados.Columns.Add("Disponible");
            resultados.Columns.Add("Stock");
            resultados.Columns.Add("Ko");
            resultados.Columns.Add("Km");
            resultados.Columns.Add("Ks");
            resultados.Columns.Add("Costo Total");
            resultados.Columns.Add("Costo Acumulado");

            resultados2.Columns.Add("Reloj (semanas)");
            resultados2.Columns.Add("RND Demanda");
            resultados2.Columns.Add("Demanda");
            resultados2.Columns.Add("RND Demora");
            resultados2.Columns.Add("Demora");
            resultados2.Columns.Add("Orden / Pedido");
            resultados2.Columns.Add("Llegada Pedido");
            resultados2.Columns.Add("RND Rotura");
            resultados2.Columns.Add("Rotura");
            resultados2.Columns.Add("Disponible");
            resultados2.Columns.Add("Stock");
            resultados2.Columns.Add("Ko");
            resultados2.Columns.Add("Km");
            resultados2.Columns.Add("Ks");
            resultados2.Columns.Add("Costo Total");
            resultados2.Columns.Add("Costo Acumulado");
        }

        private void hacerSimulacion(int cantSimulaciones, int desde, int hasta, GeneradorUniformeLenguaje generador)
        {
            row1 = resultados.NewRow();
            row1[0] = 0;
            row1[9] = 0;
            int stockAnterior = 7;
            row1[10] = stockAnterior;
            row1[14] = 0;
            int costoAcumulado = 0;
            row1[15] = costoAcumulado;
            resultados.Rows.Add(row1);

            if(desde == 0)
            {
                resultados2.ImportRow(row1);
            }

            for (int i = 1; i < cantSimulaciones+1; i++)
            {
                row2 = resultados.NewRow();
                int calculoKo = 0;
                int calculoKm;
                int calculoKs;
                row2[0] = i;
                double random = generador.siguienteAleatorio();
                row2[1] = random;
                int demanda = calcularProbabilidad(random, Demanda);
                row2[2] = demanda;
                int faltantes = stockAnterior - demanda;

                if (faltantes <= R && flagPedido)
                {
                    flagPedido = false;
                    random = generador.siguienteAleatorio();
                    row2[3] = random;
                    int diasDemora = calcularProbabilidad(random, Demora);
                    row2[4] = diasDemora;
                    row2[5] = "SI";
                    llegadaPedido = i + diasDemora;
                    row2[6] = llegadaPedido;
                    calculoKo = Ko;
                    row2[11] = calculoKo;
                    if (faltantes > 0)
                    {
                        row2[10] = faltantes;
                        stockAnterior = faltantes;
                        calculoKm = Km * faltantes;
                        row2[12] = calculoKo;
                        calculoKs = 0;
                        row2[13] = calculoKs;
                    }
                    else
                    {
                        row2[10] = 0;
                        stockAnterior = 0;
                        calculoKm = 0;
                        row2[12] = calculoKm;
                        calculoKs = Ks * (faltantes * -1);
                        row2[13] = calculoKs;
                    }
                }
                else if (i == llegadaPedido)
                {
                    flagPedido = true;
                    random = generador.siguienteAleatorio();
                    row2[7] = random;
                    int cantRotura = calcularProbabilidad(random, Rotura);
                    row2[8] = cantRotura;
                    row2[9] = Q;
                    int stockActual = stockAnterior + Q - cantRotura - demanda;
                    row2[10] = stockActual;
                    stockAnterior = stockActual;
                    calculoKo = 0;
                    row2[11] = 0;
                    calculoKm = Km * stockActual;
                    row2[12] = calculoKm;
                    calculoKs = 0;
                    row2[13] = calculoKs;
                }
                else
                {
                    row2[9] = 0;
                    calculoKo = 0;
                    row2[11] = calculoKo;
                    if (faltantes > 0)
                    {
                        row2[10] = faltantes;
                        stockAnterior = faltantes;
                        calculoKm = Km * faltantes;
                        row2[12] = calculoKo;
                        calculoKs = 0;
                        row2[13] = calculoKs;
                    }
                    else
                    {
                        row2[10] = 0;
                        stockAnterior = 0;
                        calculoKm = 0;
                        row2[12] = calculoKm;
                        calculoKs = Ks * (faltantes * -1);
                        row2[13] = calculoKs;
                    }
                }
                int costoUnitario = calculoKo + calculoKm + calculoKs;
                row2[14] = costoUnitario;
                row2[15] = costoAcumulado + costoUnitario;
                costoAcumulado = costoAcumulado + costoUnitario;
                rowanterior = row2;
                
                if (i == 0)
                {
                    resultados.Rows.Add(row2);
                }
                else if(i % 2 == 0)
                {
                    resultados.Rows.RemoveAt(0);
                    resultados.Rows.InsertAt(row2, 0);
                }
                else
                {
                    resultados.Rows.RemoveAt(0);
                    resultados.Rows.InsertAt(rowanterior, 0);
                }
                if (i >= desde && i <= hasta)
                {
                    resultados2.ImportRow(row2);
                }
            }
            grdResultados.DataSource = resultados;
            grdResultados2.DataSource = resultados2;
        }

        private int calcularProbabilidad(double random, double[,] matriz)
        {
            for (int i = 0; i < matriz.Length; i++)
            {
                for (int j = 0; j < matriz.Length; j++)
                {
                    if(j == 1 && random < matriz[i,1])
                    {
                        return int.Parse(matriz[i,0].ToString());
                    }
                }
            }
            return 0;
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            truncador = new Truncador(4);
            GeneradorUniformeLenguaje generador = new GeneradorUniformeLenguaje(truncador);
            int cantSimulaciones = int.Parse(txtCantSimulaciones.Text);
            int desde = int.Parse(txtDesde.Text);
            int hasta = int.Parse(txtHasta.Text);
            hacerSimulacion(cantSimulaciones, desde, hasta, generador);
        }
    }
}
