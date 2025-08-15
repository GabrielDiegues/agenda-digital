// Fazer a opção de criar compromisso

using System;
using ConversorFusoHorario;

// See https://aka.ms/new-console-template for more information


// Main program
class Program
{
    static void Main()
    {
        ProgramaAgenda agendaUsuario = new ProgramaAgenda();
        while (true)
        {
            Console.WriteLine("Bem-vindo a agenda");
            int opcaoUsuario = agendaUsuario.criarMenu("1- Exibir compromissos\n2- Criar um compromisso", 2);

            switch (opcaoUsuario)
            {
                case 1:
                    opcaoUsuario = agendaUsuario.criarMenu("1- Exibir compromissos do dia de hoje\n2- Exibir compromissos de um dia em específico", 2);
                    int opcaoTimezone = agendaUsuario. menuTimezone();
                    if (opcaoUsuario == 1)
                    {
                        agendaUsuario.exibirCompromissosHoje(opcaoTimezone);
                    }

                    else
                    {
                        DateTime dataConvertida = agendaUsuario.dataUsuario(true);
                        agendaUsuario.exibirCompromissosEspecifico(dataConvertida, opcaoTimezone);
                    }
                    break;

                case 2:
                    DateTime data = agendaUsuario.dataUsuario();
                    Console.WriteLine("Digite o título do compromisso");
                    string? titulo = Console.ReadLine();
                    agendaUsuario.agenda.Add(new Agenda(data, titulo ?? "Sem título"));
                    Console.WriteLine("Compromisso adicionado com sucesso!");
                    break;
            }
            string terminarPrograma = "";
            while(true) 
            {
                Console.WriteLine("Deseja terminar o programa? (S/N)");
                terminarPrograma = Console.ReadLine();
                if("SsNn".Contains(terminarPrograma[0])) {
                    break;
                }
                Console.WriteLine("Por favor, digite apenas um dos caracteres: S ou N");
            }

            if ("Ss".Contains(terminarPrograma[0]))
            {
                break;
            }
        }
    }
}