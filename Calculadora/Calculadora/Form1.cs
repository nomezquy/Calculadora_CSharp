namespace Calculadora
{
    public partial class Form1 : Form
    {
        string memoria;
        double valorPrevio;
        double valorPosterior;
        string operaciones;
        double resultadoCalculo;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void BotonNumero9_Click(object sender, EventArgs e)
        {
            Pantalla.Text = Pantalla.Text + "9";
        }

        private void BotonNumero7_Click(object sender, EventArgs e)
        {
            Pantalla.Text = Pantalla.Text + "7";
        }

        private void button16_Click(object sender, EventArgs e)
        {
            operaciones = "-";
            valorPrevio = double.Parse(Pantalla.Text);
            Pantalla.Clear();
        }

        private void button17_Click(object sender, EventArgs e)
        {

        }
        private void button3_Click(object sender, EventArgs e)
        {
            Pantalla.Text = Pantalla.Text + "9";
        }

        private void button18_Click(object sender, EventArgs e)
        {
            operaciones = "+";
            valorPrevio = double.Parse(Pantalla.Text);
            Pantalla.Clear();
        }

        private void button19_Click(object sender, EventArgs e)
        {
            operaciones = "/";
            valorPrevio = double.Parse(Pantalla.Text);
            Pantalla.Clear();
        }

        private void button20_Click(object sender, EventArgs e)
        {
            operaciones = "*";
            valorPrevio = double.Parse(Pantalla.Text);
            Pantalla.Clear();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void BotonNumero1_Click(object sender, EventArgs e)
        {
            Pantalla.Text = Pantalla.Text + "1";
        }

        private void BotonNumero2_Click(object sender, EventArgs e)
        {
            Pantalla.Text = Pantalla.Text + "2";
        }

        private void BotonNumero3_Click(object sender, EventArgs e)
        {
            Pantalla.Text = Pantalla.Text + "3";
        }

        private void BotonNumero4_Click(object sender, EventArgs e)
        {
            Pantalla.Text = Pantalla.Text + "4";
        }

        private void BotonNumero5_Click(object sender, EventArgs e)
        {
            Pantalla.Text = Pantalla.Text + "5";
        }

        private void BotonNumero6_Click(object sender, EventArgs e)
        {
            Pantalla.Text = Pantalla.Text + "6";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Pantalla.Text = Pantalla.Text + "7";
        }

        private void BotonNumero8_Click(object sender, EventArgs e)
        {
            Pantalla.Text = Pantalla.Text + "8";
        }

        private void BotonNumero0_Click(object sender, EventArgs e)
        {
            Pantalla.Text = Pantalla.Text + "0";
        }

        private void BotonAC_Click(object sender, EventArgs e)
        {
            Pantalla.Clear();
        }
         
        private void BotonGuardarMemoria_Click(object sender, EventArgs e)
        {
            memoria = Pantalla.Text;
        }

        private void BotonBorrarMemoria_Click(object sender, EventArgs e)
        {
            memoria = "";
        }

        private void BotonUsarMemoria_Click(object sender, EventArgs e)
        {
            Pantalla.Text = Pantalla.Text + memoria;
        }

        private void BotonPunto_Click(object sender, EventArgs e)
        {
            Pantalla.Text = Pantalla.Text + ".";
        }

        private void BotonResultado_Click(object sender, EventArgs e)
        {
           valorPosterior = double.Parse(Pantalla.Text);
            switch(operaciones)
            {
                case "+":
                    resultadoCalculo = valorPrevio + valorPosterior;
                    Pantalla.Text = resultadoCalculo.ToString();
                    break;

                case "-":
                    resultadoCalculo = valorPrevio - valorPosterior;
                    Pantalla.Text = resultadoCalculo.ToString();
                    break;

                case "*":
                    resultadoCalculo = valorPrevio * valorPosterior;
                    Pantalla.Text = resultadoCalculo.ToString();
                    break;

                case "/":
                    resultadoCalculo = valorPrevio / valorPosterior;
                    Pantalla.Text = resultadoCalculo.ToString();
                    break;
            }
        }
    }
}