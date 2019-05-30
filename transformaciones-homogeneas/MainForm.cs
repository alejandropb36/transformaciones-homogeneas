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
            if(contador < numeroPuntos)
            {
                puntos.Add(new Point(e.X, e.Y));
                contador++;
                WorkSpace.CreateGraphics().DrawEllipse(GetPen(Color.Black), e.X, e.Y, 2, 2);
            }
            if(contador == numeroPuntos)
            {
                DibujarFigura(puntos, Color.Blue);
                contador = 0;
                puntos.Clear();
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
    }
}
