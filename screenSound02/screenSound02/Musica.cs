
public class Musica
{    
    public string Nome { get; }
    public Banda Artista { get; }
    public int Duracao { get; set; }
    public bool Disponivel { get; set; }
    public Genero? Genero { get; set; }
    public string DescricaoResumida => 
        $"Música: {Nome}, pertence à Banda: {Artista.Nome}.";

    public Musica(Banda artista, string nome, Genero genero)
    {
        Artista = artista;
        Nome = nome;
        Genero = genero;
    }

    public Musica(Banda artista, string nome)
    {
        Artista = artista;
        Nome = nome;        
    }

    public void ExibirFichaTecnica()
    {
        Console.WriteLine("\n======================================================================================\n");
        Console.WriteLine($"Nome: {Nome}");
        Console.WriteLine($"Artista: {Artista.Nome}");
        Console.WriteLine($"Genero: {Genero?.Nome}");
        Console.WriteLine($"Duração: {Duracao}");      

        if (Disponivel)
        {
            Console.WriteLine("Disponível no plano.\n");
           
        } else
        {
            Console.WriteLine("Adquira o plano premium.\n");
            
        }

        Console.WriteLine($"Descricao Resumida: {DescricaoResumida}\n");        
    }
}