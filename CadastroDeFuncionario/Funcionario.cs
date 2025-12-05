namespace CadastroDeFuncionario
{
    public abstract class Funcionario
    {
        public string Nome { get; set; }

        public string Cpf { get; set; }

        public string Tipo { get; set; }

        public abstract double CalcularSalario();

        public abstract void ExibirDados();
    }
}
