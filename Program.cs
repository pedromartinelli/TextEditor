using Console = System.Console;

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
        string text = "";

        while (Console.ReadKey().Key != ConsoleKey.Escape)
        {
            text += Console.ReadLine();
            text += Environment.NewLine;

        }
        Console.Write(text);
    }

}
