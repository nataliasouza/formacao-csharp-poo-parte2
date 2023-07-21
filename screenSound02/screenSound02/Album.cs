public class Album
{
    private List<Musica> listaDeMusicas = new List<Musica>();
    public string Nome { get; }
    public int DuracaoTotal => listaDeMusicas.Sum(m => m.Duracao);

    public Album(string nome)
    {
        Nome = nome;
    }

    public void AdicionarMusica(Musica musica) 
    {
        listaDeMusicas.Add(musica);
    }

    public void ExibirMusicasDoAlbum()
    {
        Console.WriteLine("\n======================================================================================\n");
        Console.WriteLine($"\tLista de músicas do Álbum: {Nome}");
        Console.WriteLine("\n======================================================================================\n");

        foreach (var musica in listaDeMusicas)
        {
            Console.WriteLine($"Música: {musica.Nome}");
        }
        Console.WriteLine($"Duração total deste álbum: {DuracaoTotal}");
    }
}