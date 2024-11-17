using System;
using Microsoft.Maui.Controls;

namespace CadastroEventos
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            dtpck_inicio.MinimumDate = DateTime.Now;
            dtpck_inicio.MaximumDate = new DateTime(DateTime.Now.Year, DateTime.Now.Month + 1, DateTime.Now.Day);

            dtpck_fim.MinimumDate = dtpck_inicio.Date.AddDays(1);
            dtpck_fim.MaximumDate = dtpck_inicio.Date.AddMonths(6);

        }

        private async void OnSalvarClicked(object sender, EventArgs e)
        {
            var evento = (Evento)BindingContext;

            if (string.IsNullOrWhiteSpace(evento.Nome) ||
                evento.DataInicio == default ||
                evento.DataTermino == default ||
                evento.NumeroParticipantes <= 0 ||
                evento.CustoPorParticipante <= 0)
            {
                await DisplayAlert("Erro", "Por favor, preencha todos os campos corretamente.", "OK");
                return;
            }

            await Navigation.PushAsync(new ResumoPage(evento));
        }
    }
}
