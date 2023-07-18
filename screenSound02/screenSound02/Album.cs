public class Album
{
    private List<Musica> listaDeMusicas = new List<Musica>();
    public string Nome { get; set; }
    public int DuracaoTotal => listaDeMusicas.Sum(m => m.Duracao);

    public void AdicionarMusica(Musica musica) 
    {
        listaDeMusicas.Add(musica);
    }

    public void ExibirMusicasDoAlbum()
    {
        Console.WriteLine("\n======================================================================================\n");
        Console.WriteLine($"\tLista da Banda de músicas do álbum {Nome}: ");
        Console.WriteLine("\n======================================================================================\n");

        foreach (var musica in listaDeMusicas)
        {
            Console.WriteLine($"Música: {musica.Nome}");
        }
        Console.WriteLine($"Duração total deste álbum: {DuracaoTotal}");
    }
}