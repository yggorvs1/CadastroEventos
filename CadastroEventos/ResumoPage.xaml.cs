using Microsoft.Maui.Controls;

namespace CadastroEventos
{
    public partial class ResumoPage : ContentPage
    {
        public ResumoPage(Evento evento)
        {
            InitializeComponent();

            NomeEventoLabel.Text = $"Nome do Evento: {evento.Nome}";
            DataInicioLabel.Text = $"Data de In�cio: {evento.DataInicio:dd/MM/yyyy}";
            DataTerminoLabel.Text = $"Data de T�rmino: {evento.DataTermino:dd/MM/yyyy}";
            NumeroParticipantesLabel.Text = $"N�mero de Participantes: {evento.NumeroParticipantes}";
            LocalEventoLabel.Text = $"Local do Evento: {evento.Local}";
            CustoPorParticipanteLabel.Text = $"Custo por Participante: {evento.CustoPorParticipante:C}";
            DuracaoLabel.Text = $"Dura��o do Evento: {evento.Duracao} dias";
            CustoTotalLabel.Text = $"Custo Total do Evento: {evento.CustoTotal:C}";
        }

        private async void OnVoltarClicked(object sender, EventArgs e)
        {
            await Navigation.PopAsync();
        }
    }
}
