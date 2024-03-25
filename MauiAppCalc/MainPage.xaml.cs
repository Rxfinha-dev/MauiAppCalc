namespace MauiAppCalc
{
    public partial class MainPage : ContentPage
    {
        string operacao = null;

        double memoria_calc_pre_operacao = 0;
        double memoria_calc_pos_operacao = 0;

        string para_aparecer_no_visor = "";

        public MainPage()
        {
            InitializeComponent();
        }
        private void remover_sinais_visor()
        {
            if(para_aparecer_no_visor =="+" ||
                para_aparecer_no_visor =="-"||
                 para_aparecer_no_visor =="*"||
                  para_aparecer_no_visor == "/") 
            {
                para_aparecer_no_visor = "";    
            }
        }
        private void zerar_Clicked(System.Object sender, System.EventArgs e)
        {
            visor.Text = "0";
            para_aparecer_no_visor = "";
            memoria_calc_pre_operacao = 0;
            memoria_calc_pos_operacao = 0;
            operacao = null;
        }

        private void maismenos_Clicked(System.Object sender, System.EventArgs e)
        {
            double valor = Convert.ToDouble(visor.Text);
            valor = valor * -1;
            visor.Text = valor.ToString();

        }

        private void porcento_Clicked(System.Object sender, System.EventArgs e)
        {
            double valor= Convert.ToDouble(visor.Text);
            valor = valor /100;
            visor.Text = valor.ToString();
        }

        private void dividir_Clicked(System.Object sender, System.EventArgs e)
        {

        }

        private void num7_Clicked(System.Object sender, System.EventArgs e)
        {

        }

        private void num8_Clicked(System.Object sender, System.EventArgs e)
        {

        }

        private void num9_Clicked(System.Object sender, System.EventArgs e)
        {

        }

        private void multiplicar_Clicked(System.Object sender, System.EventArgs e)
        {

        }

        private void num4_Clicked(System.Object sender, System.EventArgs e)
        {

        }

        private void num5_Clicked(System.Object sender, System.EventArgs e)
        {

        }

        private void num6_Clicked(System.Object sender, System.EventArgs e)
        {

        }

        private void subtrair_Clicked(System.Object sender, System.EventArgs e)
        {

        }

        private void num1_Clicked(System.Object sender, System.EventArgs e)
        {

        }

        private void num2_Clicked(System.Object sender, System.EventArgs e)
        {

        }

        private void num3_Clicked(System.Object sender, System.EventArgs e)
        {

        }

        private void somar_Clicked(System.Object sender, System.EventArgs e)
        {

        }

        private void num0_Clicked(System.Object sender, System.EventArgs e)
        {

        }

        private void ponto_Clicked(System.Object sender, System.EventArgs e)
        {

        }

        private void igual_Clicked(System.Object sender, System.EventArgs e)
        {

        }
    }

}
