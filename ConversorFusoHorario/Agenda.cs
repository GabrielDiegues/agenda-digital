using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConversorFusoHorario
{
    public class Agenda : IAgendaEntrada
    {
        public DateTime DataHora { get; set; }
        public string Titulo { get; set; }

        public void Imprimir(string? idFusoDestino = null)
        {
            if(idFusoDestino != null)
            {
                TimeZoneInfo fuso = TimeZoneInfo.FindSystemTimeZoneById(idFusoDestino);
                DateTime dataFuso = TimeZoneInfo.ConvertTimeFromUtc(DateTime.UtcNow, fuso);
                Console.WriteLine(Titulo);
                Console.WriteLine(dataFuso);
            }
        }

        public void ImprimirHora(string? idFusoDestino = null)
        {
            throw new NotImplementedException();
        }

        public void ImprimirDia(string? idFusoDestino = null)
        {
            throw new NotImplementedException();
        }

        public void ImprimirDiaSemana(string? idFusoDestino = null)
        {
            throw new NotImplementedException();
        }


        // Construtor
        public Agenda(DateTime data, string titulo)
        {
            DataHora = data;
            Titulo = titulo;
        }
    }
}
