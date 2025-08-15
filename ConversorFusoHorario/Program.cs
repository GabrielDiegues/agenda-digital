// Fazer a opção de criar compromisso

using System;
using ConversorFusoHorario;

// See https://aka.ms/new-console-template for more information


// Main program
class Program
{
    static void Main()
    {
        Agenda agenda = new Agenda();
        while (true)
        {
            Console.WriteLine("Bem-vindo a agenda");
            int opcaoUsuario = agenda.criarMenu("1- Exibir compromissos\n2- Criar um compromisso", 2);

            switch (opcaoUsuario)
            {
                case 1:
                    opcaoUsuario = agenda.criarMenu("1- Exibir compromissos do dia de hoje\n2- Exibir compromissos de um dia em específico", 2);
                    int opcaoTimezone = agenda. menuTimezone();
                    if (opcaoUsuario == 1)
                    {
                        agenda.exibirCompromissosHoje(opcaoTimezone);
                    }

                    else
                    {
                        DateTime dataConvertida = agenda.dataUsuario();
                        agenda.exibirCompromissosEspecifico(dataConvertida, opcaoTimezone);
                    }
                    break;

                case 2:
                    DateTime data = agenda.dataUsuario();


                    break;
            }
        }
    }
}