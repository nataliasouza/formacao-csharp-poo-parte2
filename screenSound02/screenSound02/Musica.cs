
public class Musica
{    
    public string Nome;
    public string Artista;
    public int Duracao;
    public bool Disponivel;

    public void ExibirFichaTecnica()
    {
        Console.WriteLine("\n================================\n");
        Console.WriteLine($"Nome: {Nome}");
        Console.WriteLine($"Artista: {Artista}");
        Console.WriteLine($"Duração: {Duracao}");
        Console.WriteLine($"Disponível: {Disponivel}");
        

        if (Disponivel)
        {
            Console.WriteLine("Disponível no plano.\n");
            Console.WriteLine("================================");
        } else
        {
            Console.WriteLine("Adquira o plano premium.\n");
            Console.WriteLine("================================");
        }
    }
}