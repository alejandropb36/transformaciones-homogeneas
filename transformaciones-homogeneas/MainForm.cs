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
        Pen pen;

        public MainForm()
        {
            contador = 0;
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
            if(contador < Convert.ToInt32(comboBoxPuntos.Text))
            {
                puntos.Add(new Point(e.X, e.Y));
                contador++;
                WorkSpace.CreateGraphics().DrawEllipse(GetPen(Color.Black), e.X, e.Y, 3, 3);
            }
            else
            {
                DibujarLineas(puntos);
                contador = 0;
            }
        }

        void DibujarLineas(List<Point> puntos)
        {
            for(int i = 0; i < puntos.Count; i++)
            {
                if(i == (puntos.Count - 1))
                {
                    WorkSpace.CreateGraphics().DrawLine(GetPen(Color.DarkBlue), puntos[i], puntos[0]);
                }
                else
                {
                    WorkSpace.CreateGraphics().DrawLine(GetPen(Color.DarkBlue), puntos[i], puntos[i + 1]);
                }
                
            }
        }
    }
}
