using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExamenBeymarAyalaG
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Stack<Triangulo> pilaTriangulo=new Stack<Triangulo>();
        Stack<Rectangulo> pilaRectangulo=new Stack<Rectangulo>();   
        Stack<Paralelogramo> pilaParalelogramo=new Stack<Paralelogramo>();
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void BtnT_Click(object sender, EventArgs e)
        {
            double baseT = Convert.ToDouble(TxtBaseT.Text);
            double alturaT= Convert.ToDouble(TxtAlturaT.Text);
            string nombreT="Triangulo";
            Triangulo triangulo=new Triangulo(baseT, alturaT, nombreT);
            pilaTriangulo.Push(triangulo);
            TxtBaseT.Clear();
            TxtAlturaT.Clear();
        }

        private void BtnMpT_Click(object sender, EventArgs e)
        {
            LabelMostrarT.Text = "";
            foreach (Triangulo objetos in pilaTriangulo)
            {
                LabelMostrarT.Text += objetos + "\n";
            }
        }

        private void BtnR_Click(object sender, EventArgs e)
        {
            double largoR = Convert.ToDouble(TxtLargoR.Text);
            double anchoR= Convert.ToDouble(TxtAnchoR.Text);
            string nombreR = "Rectangulo";
            Rectangulo rectangulo = new Rectangulo(largoR, anchoR, nombreR);
            pilaRectangulo.Push(rectangulo);
            TxtLargoR.Clear();
            TxtAnchoR.Clear(); 
        }

        private void BtnMpR_Click(object sender, EventArgs e)
        {
            LabelMostrarR.Text = "";
            foreach (Rectangulo objetos in pilaRectangulo)
            {
                LabelMostrarR.Text += objetos + "\n";
            }
        }

        private void BtnP_Click(object sender, EventArgs e)
        {
            double baseP= Convert.ToDouble(TxtBaseP.Text);
            double alturaP= Convert.ToDouble(TxtAlturaP.Text);
            string nombreP = "Paralelogramo";
            Paralelogramo paralelogramo= new Paralelogramo(baseP, alturaP, nombreP);
            pilaParalelogramo.Push(paralelogramo);
            TxtBaseP.Clear();
            TxtAlturaP.Clear();
        }

        private void BtnMpP_Click(object sender, EventArgs e)
        {
            LabelMostrarP.Text = "";
            foreach (Paralelogramo objetos in pilaParalelogramo)
            {
                LabelMostrarP.Text += objetos + "\n";
            }
        }
    }
}
