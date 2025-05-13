using System.Numerics;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Biblioteca
{
    internal static class Program
    {
        // Propriedades estáticas para acesso global
        public static List<ExemplarClasse> Exemplares { get; set; } = new();
        public static List<LeitorClasse> Leitores { get; set; } = new();
        public static List<FuncionarioClasse> Funcionarios { get; set; } = new();

        public static void MostrarDados()
        {
            // Implementação para mostrar dados
        }

        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            Application.Run(new Form1());

            // leitura direta dos valores pela chave
            MessageBox.Show("" + EnumFuncionarioCargo.Gerente); // Gerente
            MessageBox.Show("" + (int)EnumFuncionarioCargo.Gerente); // 1

            // converte através do nome do enum para a chave numérica
            int cargoFuncionarioNumerico = (int)(EnumFuncionarioCargo)Enum.Parse(typeof(EnumFuncionarioCargo), "Gerente"); // 1
            MessageBox.Show("" + cargoFuncionarioNumerico);

            // converte através da chave numérica para representação textual do índice
            var cargoFuncChaveText = (EnumFuncionarioCargo)Enum.Parse(typeof(EnumFuncionarioCargo), 3.ToString()); // Caixa
            MessageBox.Show("" + cargoFuncChaveText);

            // typeof é usado para obter um Type do objeto
            MessageBox.Show($"{typeof(EnumFuncionarioCargo)}"); // ProjetoFinalBiblioteca.EnumFuncionarioCargo
        }
    }
}
//Nícolas Bastos