namespace Atividade_02
{
    public class Aluno
    {
        public Aluno(string matricula, double nota1, double nota2, double nota3, int frequencia)
        {
            this.Matricula = matricula;
            this.Nota1 = nota1;
            this.Nota2 = nota2;
            this.Nota3 = nota3;
            this.Frequencia = frequencia;
        }
        public Aluno()
        {

        }

        public string Matricula { get; private set; }
        public double Nota1 { get; private set; }
        public double Nota2 { get; private set; }
        public double Nota3 { get; private set; }
        private double Media { get; set; }
        public int Frequencia { get; set; }
     
        public double MediaAluno()
        {
            this.Media = (this.Nota1 + this.Nota2 + this.Nota3) / 3;

            return this.Media;
        }

        public bool CondicaoAprovacao()
        {
            if (this.Media > 7)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public override string ToString()
        {
            string retorno;
            if (CondicaoAprovacao())
            {
                retorno = $"Matricula: {this.Matricula}\nNota Final: {this.Media.ToString("0.00")}\nAluno Aprovado";
            }
            else
            {
                retorno = $"Matricula: {this.Matricula}\nNota Final: {this.Media.ToString("0.00")}\nAluno Reprovado";
            }
            return retorno;
        }

    }

}