namespace CadastroDeFuncionario
{
    public class FuncionarioEstagiario : Funcionario
    {
        public double BolsaAuxilio { get; set; }

        public double ValeTransporte { get; set; }

        public override double CalcularSalario()
        {
            return BolsaAuxilio + ValeTransporte;
        }

        public override void ExibirDados()
        {
            Console.WriteLine($"Nome: {Nome}\nDocumento: {Cpf}\nSalario: {CalcularSalario()}\nTipo: {Tipo}");
        }
    }
}
