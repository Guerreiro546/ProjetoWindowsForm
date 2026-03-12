namespace ProjetoAula
{
    public partial class FormIMC : Form
    {

        float imc;



        public FormIMC()
        {
            InitializeComponent();
        }



        private float CalculoIMC(float peso, float altura)
        {
            imc = peso / (altura * altura);
            return imc;
        }

        private void btnIMC_Click(object sender, EventArgs e)
        {
            CalculoIMC(float.Parse(txtPeso.Text), float.Parse(txtAltura.Text));
           
            string tipoImc;

            switch (imc)
            {
                case >= 40:
                    tipoImc = "Obesidade III";
                    break;

                case >= 35:
                    tipoImc = "Obesidade II";
                    break;

                case >= 30:
                    tipoImc = "Obesidade I";
                    break;

                case >= 25:
                    tipoImc = "Levemente acima do peso";
                    break;

                case >= 18:
                    tipoImc = "Peso ideal";
                    break;

                default:
                    tipoImc = "Abaixo do peso";
                    break;


            }

            MessageBox.Show($"CalculoIMC{imc:F2} Grau {tipoImc}");

        }

        private void txtAltura_TextChanged(object sender, EventArgs e)
        {
           
        }
    }
}
