using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace transformaciones_homogeneas
{
    public partial class MainForm : Form
    {
        List<Point> puntos;
        int contador;
        int numeroPuntos;
        Pen pen;

        public MainForm()
        {
            contador = 0;
            numeroPuntos = 3;
            puntos = new List<Point>();
            pen = new Pen(Color.Black);
            InitializeComponent();
        }

        Pen GetPen(Color color)
        {
            pen.Color = color;
            return pen;
        }

        private void WorkSpace_MouseClick(object sender, MouseEventArgs e)
        {
            Point centro;
            if (contador < numeroPuntos)
            {
                puntos.Add(new Point(e.X, e.Y));
                contador++;
                WorkSpace.CreateGraphics().DrawEllipse(GetPen(Color.Black), e.X, e.Y, 2, 2);
            }
            if(contador == numeroPuntos)
            {
                centro = GetPCentro(puntos);
                DibujarFigura(puntos, Color.Blue);
                WorkSpace.CreateGraphics().DrawEllipse(GetPen(Color.Blue), centro.X, centro.Y, 2, 2);
                contador = 0;
            }
        }

        void DibujarFigura(List<Point> puntos, Color color)
        {
            for (int i = 0; i < puntos.Count; i++)
            {
                if (i == (puntos.Count - 1))
                {
                    WorkSpace.CreateGraphics().DrawLine(GetPen(color), puntos[i], puntos[0]);
                }
                else
                {
                    WorkSpace.CreateGraphics().DrawLine(GetPen(color), puntos[i], puntos[i + 1]);
                }
            }
        }

        private void comboBoxPuntos_SelectedIndexChanged(object sender, EventArgs e)
        {
            numeroPuntos = Convert.ToInt32(comboBoxPuntos.Text);
            contador = 0;
            puntos.Clear();
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            WorkSpace.Refresh();
        }

        public Point GetPMayor(List<Point> points)
        {
            Point mayor = points[0];

            for(int i = 1; i < points.Count; i++)
            {
                if(mayor.X < points[i].X)
                {
                    mayor.X = points[i].X;
                }
                if(mayor.Y < points[i].Y)
                {
                    mayor.Y = points[i].Y;
                }
            }

            return mayor;
        }

        public Point GetPMenor(List<Point> points)
        {
            Point menor = points[0];

            for (int i = 1; i < points.Count; i++)
            {
                if (menor.X > points[i].X)
                {
                    menor.X = points[i].X;
                }
                if (menor.Y > points[i].Y)
                {
                    menor.Y = points[i].Y;
                }
            }

            return menor;
        }

        public Point GetPCentro(List<Point> points)
        {
            Point centro = new Point();

            Point menor = GetPMenor(points);
            Point mayor = GetPMayor(points);

            centro.X = (menor.X + mayor.X) / 2;
            centro.Y = (menor.Y + mayor.Y) / 2;

            return centro;
        }

        public List<Point> Traslacion(List<Point> points, int tx, int ty)
        {
            List<Point> traslacion = new List<Point>();
            Point newPoint;

            for(int i = 0; i < points.Count; i++)
            {
                newPoint = new Point();

                newPoint.X = points[i].X + tx;
                newPoint.Y = points[i].Y + ty;

                traslacion.Add(newPoint);
            }

            return traslacion;
        }

        public List<Point> Rotacion(List<Point> points, double grados)
        {
            List<Point> rotacion = new List<Point>();
            Point point;
            double teta = 0;

            for(int i = 0; i < points.Count; i++)
            {
                point = new Point();
                teta = (Math.PI * grados) / 180;
                point.X = (int)((Math.Cos(teta) * points[i].X) - (Math.Sin(teta) * points[i].Y));
                point.Y = (int)((Math.Sin(teta) * points[i].X) + (Math.Cos(teta) * points[i].Y));
                rotacion.Add(point);
            }

            return rotacion;
        }


        public List<Point> Escalado(List<Point> points, double escala)
        {
            List<Point> escalado = new List<Point>();
            for(int i = 0; i < points.Count; i++)
            {
                escalado.Add(new Point(((int)(points[i].X * escala)), ((int)(points[i].Y * escala))));
            }

            return escalado;
        }

        public List<Point> ReflexionX(List<Point> points)
        {
            List<Point> reflexion = new List<Point>();
            Point centro = GetPCentro(points);
            Point point;

            for(int i = 0; i < points.Count; i++)
            {
                point = new Point();
                point.X = points[i].X;
                point.Y = ((centro.Y - points[i].Y) * 2) + points[i].Y;
                reflexion.Add(point);
            }

            return reflexion;
        }

        public List<Point> ReflexionY(List<Point> points)
        {
            List<Point> reflexion = new List<Point>();
            Point centro = GetPCentro(points);
            Point point;

            for (int i = 0; i < points.Count; i++)
            {
                point = new Point();
                point.Y = points[i].Y;
                point.X = ((centro.X - points[i].X) * 2) + points[i].X;
                reflexion.Add(point);
            }

            return reflexion;
        }

        public void TraslacionAnimada(List<Point> points, int tx, int ty, Color color)
        {
            Point centro = GetPCentro(points);
            DibujarFigura(points, color);
            int incrementoX = 1;
            int incrementoY = 1;

            if(tx < 0)
            {
                incrementoX = -1;
            }

            if (ty < 0)
            {
                incrementoY = -1;
            }

            DibujarFigura(points, color);
            for (int i = 0; i != tx; i += incrementoX)
            {
                DibujarFigura(points, Color.White);
                points = Traslacion(points, incrementoX, 0);
                DibujarFigura(points, color);
            }

            DibujarFigura(points, color);
            for (int i = 0; i != ty; i += incrementoY)
            {
                DibujarFigura(points, Color.White);
                points = Traslacion(points, 0, incrementoY);
                DibujarFigura(points, color);
            }
        }


        private void buttonAplicar_Click(object sender, EventArgs e)
        {
            Point centro, centroT, centroR, centroE;
            List<Point> traslacion, rotacion, escalado;

            /*Pruebas de Traslacion
            centro = GetPCentro(puntos);
            traslacion = Traslacion(puntos, -(centro.X), -(centro.Y));
            centroT = GetPCentro(traslacion);
            DibujarFigura(traslacion, Color.Red);
            WorkSpace.CreateGraphics().DrawEllipse(GetPen(Color.Red), centroT.X, centroT.Y, 2, 2);
            */

            /*Pruebas de Rotacion
            rotacion = Rotacion(traslacion, 45);
            DibujarFigura(rotacion, Color.Green);
            centroR = GetPCentro(rotacion);
            WorkSpace.CreateGraphics().DrawEllipse(GetPen(Color.Green), centroT.X, centroT.Y, 2, 2);

            rotacion = Traslacion(rotacion, centro.X, centro.Y);
            DibujarFigura(rotacion, Color.Orange);
            WorkSpace.CreateGraphics().DrawEllipse(GetPen(Color.Orange), centroT.X, centroT.Y, 2, 2);
            */


            /*Eslado
            centro = GetPCentro(puntos);
            traslacion = Traslacion(puntos, -(centro.X), -(centro.Y));
            escalado = Escalado(traslacion, 2);
            centroT = GetPCentro(traslacion);

            DibujarFigura(traslacion, Color.Red);
            centroE = GetPCentro(rotacion);
            WorkSpace.CreateGraphics().DrawEllipse(GetPen(Color.Green), centroT.X, centroT.Y, 2, 2);

            escalado = Traslacion(escalado, centro.X, centro.Y);
            DibujarFigura(escalado, Color.Red);
            centroE = GetPCentro(escalado);
            WorkSpace.CreateGraphics().DrawEllipse(GetPen(Color.Green), centroT.X, centroT.Y, 2, 2);
            */

            /*Reflexion*/

            TraslacionAnimada(puntos, 0, 0, Color.Black);

            puntos.Clear();
        }
    }
}
