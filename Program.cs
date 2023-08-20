namespace TextEditor;

class Program
{
    static void Main(string[] args)
    {
        Menu();
    }

    static void Menu()
    {
        Console.Clear();
        Console.WriteLine("O que deseja realizar?");
        Console.WriteLine("1 - Abrir arquivo");
        Console.WriteLine("2 - Criar novo arquivo");
        Console.WriteLine("0 - Sair");

        short option = short.Parse(Console.ReadLine()!);

        switch (option)
        {
            case 1: Open(); break;
            case 2: Edit(); break;
            case 0: System.Environment.Exit(0); break;
            default: Menu(); break;
        }
    }

    static void Open() { }

    static void Edit()
    {
        Console.Clear();
        Console.WriteLine("Digite seu texto abaixo (ESC para sair)");
        Console.WriteLine("------------------------");
        var text = "";

        while (Console.ReadKey().Key != ConsoleKey.Escape)
        {
            text += Console.ReadLine();
            text += Environment.NewLine;

        }

        Save(text);
    }

    static void Save(string text)
    {
        Console.Clear();
        Console.WriteLine("Em qual caminho deseja salvar o arquivo?");
        var path = Console.ReadLine();

        using (var file = new StreamWriter(path))
        {
            file.Write(text);
        }

        Console.WriteLine($"Arquivo {path} salvo com sucesso!");
        Console.ReadLine();
        Menu();
    }

}
