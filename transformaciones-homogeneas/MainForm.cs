﻿using System;
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
        List<Point> points;

        public MainForm()
        {
            points = new List<Point>();
            InitializeComponent();
        }

        private void WorkSpace_MouseClick(object sender, MouseEventArgs e)
        {

        }
    }
}
