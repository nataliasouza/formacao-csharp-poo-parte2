
public class Genero
{
    private List<Musica> listaDosGeneros = new List<Musica>();
    public string Nome { get;}

    public Genero(string nome)
    {
        Nome = nome;
    }
    public Genero()
    {
            
    }

    public void AdicionarGeneroDaMusica(Musica genero)
    {
        listaDosGeneros.Add(genero);
    }

    public void ExibirMusicasPorGenero()
    {
        Console.WriteLine("\n======================================================================================\n");
        Console.WriteLine($"\tLista de músicas de gênero: {Nome} ");
        Console.WriteLine("\n======================================================================================\n");

        foreach (var musicaPorGenero in listaDosGeneros)
        {
            Console.WriteLine($"Música: {musicaPorGenero.Nome} - Artista: {musicaPorGenero.Artista.Nome}");
        }        
    }
}