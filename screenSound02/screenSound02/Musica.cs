
public class Musica
{    
    public string Nome { get; set; }
    public string Artista { get; set; }
    public int Duracao { get; set; }
    public bool Disponivel { get; set; }
    public string DescricaoResumida => 
        $"Música: {Nome}, pertence à banda {Artista}.";

   
    public void ExibirFichaTecnica()
    {
        Console.WriteLine("\n======================================================================================\n");
        Console.WriteLine($"Nome: {Nome}");
        Console.WriteLine($"Artista: {Artista}");
        Console.WriteLine($"Duração: {Duracao}");      

        if (Disponivel)
        {
            Console.WriteLine("Disponível no plano.\n");
           
        } else
        {
            Console.WriteLine("Adquira o plano premium.\n");
            
        }

        Console.WriteLine($"Descricao Resumida: {DescricaoResumida}");
        Console.WriteLine("\n======================================================================================");
    }
}