using System.Globalization;

namespace RegistroFuncionario
{
    public class Funcionario
    {
        public string Nome { get; set; }
        public int Id { get; set; }
        public double Salario { get; set; }

        public void AumentaSalario(double porcentagem)
        {
            Salario += Salario * porcentagem / 100;
        }
        public override string ToString()
        {
            return Id
                + ", "
                + Nome
                + ", "
                + Salario.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
