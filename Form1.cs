namespace Uninove.Calculadora
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSomar_Click(object sender, EventArgs e)
        {
            double numero1 = Convert.ToDouble(txtNumero1.Text);
            double numero2 = Convert.ToDouble(txtNumero2.Text);

            //double resultado = Somar(numero1, numero2);
            double resultado = 0;

            SomarUtilizandoReferencia(numero1, numero2, ref resultado);

            txtResultado.Text = resultado.ToString();


            //criar variáveis double para armazenar os valores   - OK
            //realizar a operação de soma com as variáveis       - OK
            //converter o resultado da soma para inteiro         - OK
            //atribuir o resultado da soma ao input de resultado - OK
        }

        //criar uma função
        //receber os dados
        //retornar o resultado da soma

        public double Somar(double numero1, double numero2)
        {
            double resultado;
            resultado = numero1 + numero2;

            return resultado;
        }


        public void SomarUtilizandoReferencia(double numero1, double numero2, 
                                              ref double resultado)
        {
            resultado = numero1 + numero2;
            numero1 = 10;
        }

        private void btnVerificarMaior_Click(object sender, EventArgs e)
        {
            var numero1 = Convert.ToDouble(txtNumero1.Text);
            var numero2 = Convert.ToDouble(txtNumero2.Text);

            var resultado = VerificarMaiorNumero(numero1, numero2);

            txtResultado.Text = resultado.ToString();
        }

        public double VerificarMaiorNumero(double numero1, double numero2)
        {
            if (numero1 > numero2)
                return numero1;
            else
                return numero2;
        }
    }
}