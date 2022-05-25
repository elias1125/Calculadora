namespace Calculadoras_2
{
    public enum Operacion
    {
        noDefinida = 0,
        Suma = 1,
        Resta = 2,
        Division = 3,
        Multiplicacion  = 4,
        Modulo = 5,
    }
    public partial class Form1 : Form
    {
        double valor1 = 0;
        double valor2 = 0;
        Operacion operador = Operacion.noDefinida;
        bool unNumeroLeido = false;
        public Form1()
        {
            InitializeComponent();
        }
        private void LeerNumero (string numero)
        {
            unNumeroLeido = true;
            if (CajaResultado.Text == "0" && CajaResultado.Text != null)
            {
                CajaResultado.Text = numero;
            }
            else
            {
                CajaResultado.Text += numero;
            }
        }
        private double EjecutarOperacion()
        {
            double resultado = 0;
            switch (operador)
            {
                
                case Operacion.Suma:
                    resultado = valor1 + valor2;
                    break;
                case Operacion.Resta:
                    resultado = valor1 - valor2;
                    break;
                case Operacion.Division:
                    if (valor2 == 0)
                    {
                        MessageBox.Show("No se puede dividir entre cero");
                        lblHistorial.Text = "no se puede dividir entre cero";
                        resultado = 0;
                    }
                    else
                    {
                        resultado = valor1 / valor2;
                    }
                    break;
                case Operacion.Multiplicacion:
                    resultado = valor1 * valor2;
                    break;
                case Operacion.Modulo:
                    resultado = valor1 % valor2;
                    break;
            }
            return resultado;
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCero_Click(object sender, EventArgs e)
        {
            unNumeroLeido = false;
            if (CajaResultado.Text == "0")
            {
            return;
            }
            else
            {
            CajaResultado.Text += "0";
            }
           
        }

        private void btnUno_Click(object sender, EventArgs e)
        {
            LeerNumero("1");
            
        }

        private void btnDos_Click(object sender, EventArgs e)
        {
            LeerNumero("2");

        }

        private void btnTres_Click(object sender, EventArgs e)
        {
            LeerNumero("3");
        }

        private void btnCuatro_Click(object sender, EventArgs e)
        {
            LeerNumero("4");
        }

        private void btnCinco_Click(object sender, EventArgs e)
        {
            LeerNumero("5");
        }

        private void btnSeis_Click(object sender, EventArgs e)
        {
            LeerNumero("6");
        }

        private void btnSiete_Click(object sender, EventArgs e)
        {
            LeerNumero("7");
        }

        private void btnOcho_Click(object sender, EventArgs e)
        {
            LeerNumero("8");
        }

        private void btnNueve_Click(object sender, EventArgs e)
        {
            LeerNumero("9");
        }
        private void obtenerValor (string operador)
        {
            valor1 = Convert.ToDouble(CajaResultado.Text);
            lblHistorial.Text = CajaResultado.Text + operador;
            CajaResultado.Text = "0";
        }
        private void btnSuma_Click(object sender, EventArgs e)
        {
            operador = Operacion.Suma;
            obtenerValor("+");
        }

        private void btnResultado_Click(object sender, EventArgs e)
        {
            if (valor2 == 0 && unNumeroLeido)
            {
                valor2 = Convert.ToDouble(CajaResultado.Text);
                lblHistorial.Text += valor2 + "=";
                double resultado = EjecutarOperacion();
                valor1 = 0;
                valor2 = 0;
                unNumeroLeido = false;
                CajaResultado.Text = Convert.ToString(resultado);
            }
        }

        private void btnResta_Click(object sender, EventArgs e)
        {
            operador = Operacion.Resta;
            obtenerValor("-");
        }

        private void btnMultiplicar_Click(object sender, EventArgs e)
        {
            operador = Operacion.Multiplicacion;
            obtenerValor("X");
        }

        private void btnDivision_Click(object sender, EventArgs e)
        {
            operador = Operacion.Division;
            obtenerValor("/");
        }

        private void btnModulo_Click(object sender, EventArgs e)
        {
            operador = Operacion.Modulo;
            obtenerValor("%");
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            CajaResultado.Text = "0";
            lblHistorial.Text = "";
        }
        
     

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            if (CajaResultado.Text.Length > 1)
            {
                string txtResultado = CajaResultado.Text;
                txtResultado = txtResultado.Substring(0, txtResultado.Length - 1);

                if (txtResultado.Length == 1 && txtResultado.Contains("-"))
                {
                    CajaResultado.Text = "0";
                }
                CajaResultado.Text = txtResultado;
            }
            else
            {
                CajaResultado.Text = "0";
            }
        }

        private void btnPunto_Click(object sender, EventArgs e)
        {
            if (CajaResultado.Text.Contains("."))
            {
                return;
            }
            CajaResultado.Text += ".";
        }
    }
}