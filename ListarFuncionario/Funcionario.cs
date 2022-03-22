
namespace Course
{
     class Funcionario
    {

        public int ID { get; set; }
        public string Name { get; set; }

        public double Salario { get; private set; }

        public Funcionario(int id, string name, double salario)
        {
            ID = id;
            Name = name;
            Salario = salario;
        }

        public void AumentoSalario (double porcentagem)
        {
            Salario += Salario * porcentagem / 100.0;
        }

        public override string ToString()
        {
            return
                "\n ID: "
                + ID
                + ", Nome: "
                + Name
                + ", Salario: "
                + Salario;
        }
    }
}
