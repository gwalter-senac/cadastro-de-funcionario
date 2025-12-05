namespace CadastroDeFuncionario
{
    public class FuncionarioTerceirizado : Funcionario
    {
        public double HorasTrabalhadas { get; set; }

        public double ValorHora { get; set; }

        public override double CalcularSalario()
        {
            return HorasTrabalhadas * ValorHora;
        }

        public override void ExibirDados()
        {
            Console.WriteLine($"Nome: {Nome}\nDocumento: {Cpf}\nSalario: {CalcularSalario()}\nTipo: {Tipo}");
        }
    }
}
