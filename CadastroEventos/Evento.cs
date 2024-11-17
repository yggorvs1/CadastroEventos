using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadastroEventos
{
    public class Evento : INotifyPropertyChanged
    {
        private string nome;
        private DateTime dataInicio;
        private DateTime dataTermino;
        private int numeroParticipantes;
        private string local;
        private decimal custoPorParticipante;

        public string Nome
        {
            get => nome;
            set { nome = value; OnPropertyChanged(nameof(Nome)); }
        }

        public DateTime DataInicio
        {
            get => dataInicio;
            set { dataInicio = value; OnPropertyChanged(nameof(DataInicio)); }
        }

        public DateTime DataTermino
        {
            get => dataTermino;
            set { dataTermino = value; OnPropertyChanged(nameof(DataTermino)); }
        }

        public int NumeroParticipantes
        {
            get => numeroParticipantes;
            set { numeroParticipantes = value; OnPropertyChanged(nameof(NumeroParticipantes)); }
        }

        public string Local
        {
            get => local;
            set { local = value; OnPropertyChanged(nameof(Local)); }
        }

        public decimal CustoPorParticipante
        {
            get => custoPorParticipante;
            set { custoPorParticipante = value; OnPropertyChanged(nameof(CustoPorParticipante)); }
        }

        public int Duracao => (DataTermino - DataInicio).Days;
        public decimal CustoTotal => NumeroParticipantes * CustoPorParticipante;

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }

}
