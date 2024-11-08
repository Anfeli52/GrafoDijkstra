using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace GrafoDijkstra
{
    public class GrafoDibujador
    {
        private int[,] matriz;
        private int n;
        private Panel panelDibujo;

        public GrafoDibujador(int[,] matriz, int n, Panel panelDibujo)
        {
            this.matriz = matriz;
            this.n = n;
            this.panelDibujo = panelDibujo;
        }

        public void DibujarGrafo()
        {
            LimpiarPanel();

            if (matriz == null || n == 0)
            {
                MessageBox.Show("La matriz no ha sido generada.");
                return;
            }

            Graphics g = panelDibujo.CreateGraphics();
            int radio = Math.Min(panelDibujo.Width, panelDibujo.Height) / 2 - 40;
            Point centro = new Point(panelDibujo.Width / 2, panelDibujo.Height / 2);
            Point[] posiciones = new Point[n];

            for (int i = 0; i < n; i++)
            {
                double angulo = 2 * Math.PI * i / n;
                int x = centro.X + (int)(radio * Math.Cos(angulo));
                int y = centro.Y + (int)(radio * Math.Sin(angulo));
                posiciones[i] = new Point(x, y);
            }

            Pen penArista = new Pen(Color.Black, 2);
            Font fuentePeso = new Font("Arial", 10);
            Brush brushPeso = Brushes.Black;

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (i != j && matriz[i, j] != int.MaxValue)
                    {
                        Point p1 = posiciones[i];
                        Point p2 = posiciones[j];

                        Point p2Ajustado = AjustarPuntoFinal(p1, p2, 15);

                        g.DrawLine(penArista, p1, p2Ajustado);

                        int pesoX = (p1.X + p2.X) / 2;
                        int pesoY = (p1.Y + p2.Y) / 2;
                        if (matriz[j, i] != int.MaxValue && matriz[i, j] != matriz[j, i])
                        {
                            int desplazamiento = 10;
                            pesoX += (p2.Y - p1.Y) > 0 ? desplazamiento : -desplazamiento;
                            pesoY += (p1.X - p2.X) > 0 ? desplazamiento : -desplazamiento;
                        }
                        g.DrawString(matriz[i, j].ToString(), fuentePeso, brushPeso, pesoX, pesoY);

                        DibujarFlecha(g, penArista, p1, p2Ajustado);
                    }
                }
            }

            Brush brushNodo = Brushes.LightBlue;
            Font fuenteNodo = new Font("Arial", 12, FontStyle.Bold);
            for (int i = 0; i < n; i++)
            {
                Rectangle nodoRect = new Rectangle(posiciones[i].X - 15, posiciones[i].Y - 15, 30, 30);
                g.FillEllipse(brushNodo, nodoRect);
                g.DrawEllipse(Pens.Black, nodoRect);

                string etiquetaNodo = (i + 1).ToString();
                SizeF tamañoTexto = g.MeasureString(etiquetaNodo, fuenteNodo);
                g.DrawString(etiquetaNodo, fuenteNodo, Brushes.Black, posiciones[i].X - tamañoTexto.Width / 2, posiciones[i].Y - tamañoTexto.Height / 2);
            }
        }

        private Point AjustarPuntoFinal(Point inicio, Point fin, int ajuste)
        {
            double angulo = Math.Atan2(fin.Y - inicio.Y, fin.X - inicio.X);

            int xAjustado = (int)(fin.X - ajuste * Math.Cos(angulo));
            int yAjustado = (int)(fin.Y - ajuste * Math.Sin(angulo));
            return new Point(xAjustado, yAjustado);
        }

        private void DibujarFlecha(Graphics g, Pen pen, Point inicio, Point fin)
        {
            double angulo = Math.Atan2(fin.Y - inicio.Y, fin.X - inicio.X);
            int tamañoFlecha = 10;

            PointF flechaIzquierda = new PointF(
                (float)(fin.X - tamañoFlecha * Math.Cos(angulo - Math.PI / 6)),
                (float)(fin.Y - tamañoFlecha * Math.Sin(angulo - Math.PI / 6))
            );
            PointF flechaDerecha = new PointF(
                (float)(fin.X - tamañoFlecha * Math.Cos(angulo + Math.PI / 6)),
                (float)(fin.Y - tamañoFlecha * Math.Sin(angulo + Math.PI / 6))
            );

            g.DrawLine(pen, fin, flechaIzquierda);
            g.DrawLine(pen, fin, flechaDerecha);
        }

        private void LimpiarPanel()
        {
            panelDibujo.Invalidate();
            panelDibujo.Update();
        }
    }
}