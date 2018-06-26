using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace MobileCalculatorApp
{
	public partial class MainPage : ContentPage
	{
		public MainPage()
		{
			InitializeComponent();
		}

        private Decimal _mem = 0; //Memória Interna da Calculadora
        private Operacao _operacao = Operacao.Nula; //Operação a Ser Aplicada na Memória
        
        private void AcrescentaDigito(int digito)
        {
            if (LblResult.Text == "0")
                LblResult.Text = digito.ToString();
            else
                LblResult.Text += digito.ToString();
        }

        private void BtnC_Clicked(object sender, EventArgs e)
        {
            _mem = 0;
            _operacao = Operacao.Nula;
            LblResult.Text = "0";
        }

        private void BtnDiv_Clicked(object sender, EventArgs e)
        {
            _mem = Decimal.Parse(LblResult.Text);
            LblResult.Text = "0";
            _operacao = Operacao.Dividir;
        }
        private void BtnMult_Clicked(object sender, EventArgs e)
        {
            _mem = Decimal.Parse(LblResult.Text);
            LblResult.Text = "0";
            _operacao = Operacao.Multiplicar;
        }
        private void BtnSub_Clicked(object sender, EventArgs e)
        {
            _mem = Decimal.Parse(LblResult.Text);
            LblResult.Text = "0";
            _operacao = Operacao.Subtrair;
        }
        private void BtnSum_Clicked(object sender, EventArgs e)
        {
            _mem = Decimal.Parse(LblResult.Text);
            LblResult.Text = "0";
            _operacao = Operacao.Somar;
        }
        private void BtnEqual_Clicked(object sender, EventArgs e)
        {
            switch (_operacao)
            {
                case Operacao.Somar:
                    LblResult.Text = (Convert.ToDecimal(LblResult.Text) + _mem).ToString();
                    break;
                case Operacao.Subtrair:
                    LblResult.Text = (Convert.ToDecimal(LblResult.Text) - _mem).ToString();
                    break;
                case Operacao.Multiplicar:
                    LblResult.Text = (Convert.ToDecimal(LblResult.Text) * _mem).ToString();
                    break;
                case Operacao.Dividir:
                    LblResult.Text = (Convert.ToDecimal(LblResult.Text) / _mem).ToString();
                    break;
            }
            _mem = 0;
            _operacao = Operacao.Nula;
        }
        private void Btn7_Clicked(object sender, EventArgs e)
        {
            AcrescentaDigito(7);
        }

        private void Btn8_Clicked(object sender, EventArgs e)
        {
            AcrescentaDigito(8);
        }
        private void Btn9_Clicked(object sender, EventArgs e)
        {
            AcrescentaDigito(9);
        }
        private void Btn4_Clicked(object sender, EventArgs e)
        {
            AcrescentaDigito(4);
        }
        private void Btn5_Clicked(object sender, EventArgs e)
        {
            AcrescentaDigito(5);
        }

        private void Btn6_Clicked(object sender, EventArgs e)
        {
            AcrescentaDigito(6);
        }

        private void Btn1_Clicked(object sender, EventArgs e)
        {
            AcrescentaDigito(1);
        }

        private void Btn2_Clicked(object sender, EventArgs e)
        {
            AcrescentaDigito(2);
        }
        private void Btn3_Clicked(object sender, EventArgs e)
        {
            AcrescentaDigito(3);
        }

        private void Btn0_Clicked(object sender, EventArgs e)
        {
            AcrescentaDigito(0);
        }

        private void BtnDigits_Clicked(object sender, EventArgs args)
        {
            int digit = int.Parse(((Button)sender).Text);
            DisplayAlert("Foi clicado " + digit, digit.ToString(), "Ok");
        }
    }
}
