using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConversorFusoHorario
{
    internal class ProgramaAgenda
    {
        public List<Agenda> agenda { get; set; }

        Dictionary<int, string> timezones;
        public int criarMenu(string opcoes, int totalOpcoes)
        {
            int inputUsuario = 0;
            do
            {
                Console.WriteLine(opcoes);
                try
                {
                    inputUsuario = int.Parse(Console.ReadLine());
                }
                catch
                {
                    Console.WriteLine("Por favor, insira um número válido");
                }
            }
            while (!(inputUsuario >= 1 && inputUsuario <= totalOpcoes));
            return inputUsuario;
        }


        public void exibirCompromissosHoje(int timeZone)
        {
            string? fuso = timezones.ContainsKey(timeZone) ? timezones[timeZone] : null;
            foreach (Agenda compromisso in agenda)
            {
                compromisso.Imprimir(fuso);
            }
        }


        public void exibirCompromissosEspecifico(DateTime data, int timeZone)
        {
            string? fuso = timezones.ContainsKey(timeZone) ? timezones[timeZone] : null;
            foreach (Agenda compromisso in agenda)
            {

                if (compromisso.DataHora.Date == data.Date)
                {
                    compromisso.Imprimir(fuso);
                }
            }
        }


        public int menuTimezone()
        {
            int inputUsuario = criarMenu("Escolha um timezone:\n1- Brasil\n2- Canadá", 2);
            return inputUsuario;
        }


        public DateTime dataUsuario(bool notHorario = false)
        {
            DateTime dataConvertida;
            string dataUsuario = "";
            do
            {
                Console.WriteLine("Digite uma data e horário no formato: dd/MM/yyyy" + (notHorario ? "" : " HH:mm"));
                dataUsuario = Console.ReadLine();
            } while (!DateTime.TryParseExact(dataUsuario, "dd/MM/yyyy" + (notHorario ? "" : " HH:mm"),
            System.Globalization.CultureInfo.InvariantCulture,
            System.Globalization.DateTimeStyles.None, out dataConvertida));

            return dataConvertida;
        }


        // Construtor
        public ProgramaAgenda()
        {
            this.agenda = new List<Agenda>();
            this.timezones = new Dictionary<int, string>{
                { 1, "E. South America Standard Time" },
                {2, "Eastern Standard Time" }
            };
        }
    }
}
