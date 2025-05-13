using System.Numerics;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Biblioteca
{
    internal static class Program
    {
        // Propriedades est�ticas para acesso global
        public static List<ExemplarClasse> Exemplares { get; set; } = new();
        public static List<LeitorClasse> Leitores { get; set; } = new();
        public static List<FuncionarioClasse> Funcionarios { get; set; } = new();

        public static void MostrarDados()
        {
            // Implementa��o para mostrar dados
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

            // converte atrav�s do nome do enum para a chave num�rica
            int cargoFuncionarioNumerico = (int)(EnumFuncionarioCargo)Enum.Parse(typeof(EnumFuncionarioCargo), "Gerente"); // 1
            MessageBox.Show("" + cargoFuncionarioNumerico);

            // converte atrav�s da chave num�rica para representa��o textual do �ndice
            var cargoFuncChaveText = (EnumFuncionarioCargo)Enum.Parse(typeof(EnumFuncionarioCargo), 3.ToString()); // Caixa
            MessageBox.Show("" + cargoFuncChaveText);

            // typeof � usado para obter um Type do objeto
            MessageBox.Show($"{typeof(EnumFuncionarioCargo)}"); // ProjetoFinalBiblioteca.EnumFuncionarioCargo
        }
    }
}
//N�colas Bastos