namespace CadastroDeFuncionario
{
    public class FuncionarioClt : Funcionario
    {
        public double SalarioBase { get; set; }

        public override double CalcularSalario()
        {
            return SalarioBase;
        }

        public override void ExibirDados()
        {
            Console.WriteLine($"Nome: {Nome}\nDocumento: {Cpf}\nSalario: {CalcularSalario()}\nTipo: {Tipo}");
        }
    }
}
