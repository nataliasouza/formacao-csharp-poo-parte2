public class Podcast
{
    private List<Episodio> episodios = new();   

    public string Nome { get; }
    public string Host { get; }

    public Podcast(string nome, string host)
    {
        Nome = nome;
        Host = host;
    }
    public int TotalEpisodios => episodios.Count;

    public void AdicionarEpisodio(Episodio episodio)
    {
        episodios.Add(episodio);
    }

    public void ExibirDetalhes()
    {
        Console.WriteLine("\n======================================================================================\n");
        Console.WriteLine($"\tPODCAST: {Nome} |  Apresentado por [ {Host} ]\n");
        Console.WriteLine("======================================================================================\n");

        foreach (Episodio episodio in episodios.OrderBy(e => e.Ordem))
        {
            Console.WriteLine(episodio.Resumo);
        }
        Console.WriteLine($"\n\nTotal de episódios: {TotalEpisodios}.\n\n");
    }
}
