namespace ex.Models;
class Aluno
{
    public string Nome { get; set; }
    public List<double> Notas { get; set;}

    public static void DeletarAluno(List<Aluno> aluno, string nome)
    {
        aluno.RemoveAll(a => a.Nome == nome);
    }
    
}
