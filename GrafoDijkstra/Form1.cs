using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GrafoDijkstra
{
    public partial class Form1 : Form
    {
        private int[,] matriz;
        private int n;

        public Form1()
        {
            InitializeComponent();
            panelMatriz.Visible = false;
        }

        private void GenerarMatriz()
        {
            try
            {
                n = int.Parse(txtTamano.Text);

                if (n<2 || n>20)
                {
                    MessageBox.Show("Número de Nodos Inválido, Ingrese un número mayor o igual a 2 y menor o igual a 20.");
                }

                matriz = new int[n, n];

                TableLayoutPanel matrixPanel = new TableLayoutPanel
                {
                    ColumnCount = n,
                    RowCount = n,
                    AutoSize = true,
                    AutoSizeMode = AutoSizeMode.GrowAndShrink,
                    Dock = DockStyle.Fill
                };

                for (int i = 0; i < n; i++)
                {
                    matrixPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100f / n));
                }

                for (int i = 0; i < n; i++)
                {
                    matrixPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 100f / n));
                }

                for (int i = 0; i < n; i++)
                {
                    for (int j = 0; j < n; j++)
                    {
                        TextBox txtBox = new TextBox
                        {
                            Text = (i == j) ? "0" : "Infinito".ToLower().Trim(),
                            Dock = DockStyle.Fill,
                            TextAlign = HorizontalAlignment.Center,
                            Multiline = true,
                            Font = new Font("Arial", 12)
                        };
                        matrixPanel.Controls.Add(txtBox, j, i);
                    }
                }

                panelMatriz.Controls.Clear();
                panelMatriz.Controls.Add(matrixPanel);
            }
            catch (FormatException)
            {
                MessageBox.Show("Por favor ingrese un número válido para el tamaño de la matriz.");
            }
        }

        private void ObtenerMatriz()
        {
            var matrixPanel = (TableLayoutPanel)panelMatriz.Controls[0];
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    TextBox txtBox = (TextBox)matrixPanel.GetControlFromPosition(j, i);

                    if (txtBox.Text == "Infinito".ToLower().Trim())
                    {
                        matriz[i, j] = int.MaxValue;
                    }
                    else
                    {
                        int valor = int.Parse(txtBox.Text);

                        if (valor < 0)
                        {
                            MessageBox.Show("No se permiten pesos negativos. Reemplace los valores con números no negativos.",
                                            "Peso inválido", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                            txtBox.Text = "Infinito".ToLower().Trim();
                            matriz[i, j] = int.MaxValue;
                        }
                        else
                        {
                            matriz[i, j] = valor;
                        }
                    }
                }
            }
        }

        private void CalcularCamino()
        {
            try
            {
                int inicio = int.Parse(txtInicio.Text) - 1;
                int destino = int.Parse(txtDestino.Text) - 1;

                if (inicio < 0 || inicio >= n || destino < 0 || destino >= n)
                {
                    MessageBox.Show("Por favor, ingrese nodos válidos dentro del rango.");
                    return;
                }

                if (inicio == destino)
                {
                    MessageBox.Show("El nodo de inicio no puede ser el mismo que el nodo de destino.");
                    return;
                }

                ObtenerMatriz();

                var (camino, distancia) = Dijkstra(matriz, inicio, destino);

                if (distancia == int.MaxValue)
                {
                    rtbResultado.Text = $"No hay camino entre el nodo {inicio + 1} y el nodo {destino + 1}.";
                }
                else
                {
                    string resultado = $"Camino más corto: ";
                    foreach (var nodo in camino)
                    {
                        resultado += $"{nodo + 1} ";
                    }
                    resultado += $"\nDistancia total: {distancia}";
                    rtbResultado.Text = resultado;
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Por favor ingrese números válidos para los nodos.");
            }
        }

        private (List<int> camino, int distancia) Dijkstra(int[,] grafo, int inicio, int destino)
        {
            int n = grafo.GetLength(0);
            int[] distancias = new int[n];
            int[] predecesores = new int[n];
            bool[] visitados = new bool[n];
            var camino = new List<int>();

            for (int i = 0; i < n; i++)
            {
                distancias[i] = int.MaxValue;
                predecesores[i] = -1;
                visitados[i] = false;
            }

            distancias[inicio] = 0;
            var pq = new SortedSet<(int, int)>();
            pq.Add((0, inicio));

            while (pq.Count > 0)
            {
                var (dist, nodo) = pq.Min;
                pq.Remove(pq.Min);

                if (nodo == destino)
                    break;

                if (visitados[nodo])
                    continue;

                visitados[nodo] = true;

                for (int vecino = 0; vecino < n; vecino++)
                {
                    if (grafo[nodo, vecino] != int.MaxValue && !visitados[vecino])
                    {
                        int nuevaDistancia = dist + grafo[nodo, vecino];

                        if (nuevaDistancia < distancias[vecino])
                        {
                            distancias[vecino] = nuevaDistancia;
                            predecesores[vecino] = nodo;
                            pq.Add((nuevaDistancia, vecino));
                        }
                    }
                }
            }

            int currentNode = destino;
            while (currentNode != -1)
            {
                camino.Insert(0, currentNode);
                currentNode = predecesores[currentNode];
            }

            return (camino, distancias[destino]);
        }


        private void btnGenerarMatriz_Click_1(object sender, EventArgs e)
        {
            GenerarMatriz();
            panelMatriz.Visible = true;
        }

        private void btnCalcularCamino_Click_1(object sender, EventArgs e)
        {
            CalcularCamino();
        }

        private void btnDibujadorGrafo_Click_Click(object sender, EventArgs e)
        {
            if (matriz != null && n > 0)
            {
                GrafoDibujador grafoDibujador = new GrafoDibujador(matriz, n, panelDibujo);
                grafoDibujador.DibujarGrafo();
            }
            else
            {
                MessageBox.Show("Primero genera la matriz.");
            }
        }
    }
}
