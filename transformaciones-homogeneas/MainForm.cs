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
            contador = 0;
            puntos.Clear();
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

        public List<Point> Rotacion(List<Point> points, int grados)
        {
            List<Point> rotacion = new List<Point>();
            Point point;
            double teta = 0;

            teta = (Math.PI * grados) / 180;

            for (int i = 0; i < points.Count; i++)
            {
                point = new Point();
                
                point.X = (int)((Math.Cos(teta) * points[i].X) - (Math.Sin(teta) * points[i].Y));
                point.Y = (int)((Math.Sin(teta) * points[i].X) + (Math.Cos(teta) * points[i].Y));
                rotacion.Add(point);
            }

            return rotacion;
        }


        public List<Point> Escalado(List<Point> points, int escala)
        {
            List<Point> escalado = new List<Point>();

            for(int i = 0; i < points.Count; i++)
            {
                escalado.Add(new Point(((points[i].X * escala)), ((points[i].Y * escala))));
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

        public void TraslacionAnimada(ref List<Point> points, int tx, int ty, Color color)
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

        public void RotacionAnimada(ref List<Point> points, int grados, Color color)
        {
            List<Point> rotacion = points;
            Point centro = GetPCentro(points);

            for(int i = 0; i <= grados; i++)
            {
                DibujarFigura(rotacion, Color.White);
                rotacion = Traslacion(rotacion, -centro.X, -centro.Y);
                rotacion = Rotacion(rotacion, i);
                rotacion = Traslacion(rotacion, centro.X, centro.Y);
                DibujarFigura(rotacion, color);
                System.Threading.Thread.Sleep(100);
            }

            points = rotacion;
        }

        public void EscaladoAnimado(ref List<Point> points, int escala, Color color)
        {
            List<Point> escalado = points;
            Point centro = GetPCentro(points);

            for (int i = 1; i <= escala; i++)
            {
                WorkSpace.Refresh();
                //escalado = points;
                escalado = Traslacion(escalado, -centro.X, -centro.Y);
                escalado = Escalado(escalado, i);
                escalado = Traslacion(escalado, centro.X, centro.Y);
                DibujarFigura(escalado, color);
                System.Threading.Thread.Sleep(100);
            }

            points = escalado;
        }


        private void buttonAplicar_Click(object sender, EventArgs e)
        {
            List<Point> reflectar;
            Point centro;
            int grados;
            int escalar;
            int tx;
            int ty;

            /*Rotacion*/
            if(comboBoxTrasformacion.SelectedIndex == 0)
            {
                if(comboBoxRotacion.Text != "")
                {
                    grados = Convert.ToInt32(comboBoxRotacion.SelectedItem.ToString());
                    //centro = GetPCentro(puntos);

                    //TraslacionAnimada(ref puntos, -centro.X, -centro.Y, Color.Blue);
                    RotacionAnimada(ref puntos, grados, Color.Black);
                    //TraslacionAnimada(ref puntos, centro.X, centro.Y, Color.Blue);
                }
            }

            /*Escalado*/
            if (comboBoxTrasformacion.SelectedIndex == 1)
            {
                if(comboBoxEscalado.Text != "")
                {
                    //centro = GetPCentro(puntos);
                    escalar = Convert.ToInt32(comboBoxEscalado.SelectedItem.ToString());

                    //TraslacionAnimada(ref puntos, -centro.X, -centro.Y, Color.Blue);
                    EscaladoAnimado(ref puntos, 2, Color.Blue);
                    //TraslacionAnimada(ref puntos, centro.X, centro.Y, Color.Blue);
                }
            }

            /*Reflectar*/
            if (comboBoxTrasformacion.SelectedIndex == 2)
            {
                if (comboBoxReflectar.Text != "")
                {
                    // En X
                    if(comboBoxReflectar.SelectedIndex == 0)
                    {
                        reflectar = ReflexionX(puntos);
                        DibujarFigura(reflectar, Color.Red);
                    }
                    // En Y
                    if (comboBoxReflectar.SelectedIndex == 1)
                    {
                        reflectar = ReflexionY(puntos);
                        DibujarFigura(reflectar, Color.Red);
                    }

                }
            }

            /*Trasladar*/
            if (comboBoxTrasformacion.SelectedIndex == 3)
            {
                if(textBoxTrasladarX.Text == "")
                {
                    tx = 0;
                }
                else{
                    tx = Convert.ToInt32(textBoxTrasladarX.Text.ToString());
                }
                if (textBoxTrasladarY.Text == "")
                {
                    ty = 0;
                }
                else
                {
                    ty = Convert.ToInt32(textBoxTrasladarY.Text.ToString());
                }

                TraslacionAnimada(ref puntos, tx, ty, Color.Blue);
            }
        }
    }
}
