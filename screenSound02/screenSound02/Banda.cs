
public class Banda
{
    private List<Album> albuns = new List<Album>();
    public string Nome { get; }

    public Banda(string nome)
    {
        Nome = nome;
    }

    public void AdicionarAlbum(Album album)
    {
        albuns.Add(album);
    }

    public void ExibirDiscografia()
    {
        Console.WriteLine($"\nDiscografia da Banda: {Nome}");
        foreach (Album album in albuns)
        {
            Console.WriteLine($"Álbum: {album.Nome} (Duração: {album.DuracaoTotal})");
        }
    }
}