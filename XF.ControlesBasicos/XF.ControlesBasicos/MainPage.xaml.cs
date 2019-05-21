using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using XF.ControlesBasicos.Pages;

namespace XF.ControlesBasicos
{
    public partial class MainPage : ContentPage
    {
        public Configuracao _configuracao { get; set; }

        public MainPage()
        {
            InitializeComponent();
        }

        private void BtnEnviar_Clicked(object sender, EventArgs e)
        {
            if (_configuracao != null && _configuracao.EnableEmail)
            {
                DisplayAlert("Atenção", $"E-mail enviado para {_configuracao.Email}", "OK");
            }
            else
            {
                DisplayAlert("Atenção", "E-mail não autorizado", "OK");
            }
        }

        private void BtnConfiguracao_Clicked(object sender, EventArgs e)
        {
            if (_configuracao == null)
            {
                _configuracao = new Configuracao();
            }

            Navigation.PushAsync(new ConfigPage() { BindingContext = _configuracao });
        }
    }
}
