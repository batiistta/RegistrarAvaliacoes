using RegistrarAvaliações;
namespace RegistrarAvaliações
{
    public class Avaliacao
    {
        Professor? professor;        
        private ICollection<Aluno> alunos;
        public float Nota { get; set; }
        public int Serie { get; set; }
        public String? Nome { get; set; }        
        
    }
}