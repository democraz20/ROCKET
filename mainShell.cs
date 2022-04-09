using System;
using System.Reflection;
using System.Text;

namespace ROCKET;

public class Shell
{
    private readonly Dictionary<string, Type> _commands = new Dictionary<string, Type>();
    public Shell(){
        foreach (Type type in Assembly.GetExecutingAssembly().GetTypes())
        {
            // A valid command file will have the InCom interface
            if (!type.GetInterfaces().Contains(typeof(InCom))) continue;

            // Get and store the command info
            var commandtype = type.GetCustomAttribute<CommandAttribute>()!;
            _commands.Add(commandtype.Commandname, type);
            if (commandtype.Aliases != null)
            {
                foreach (string alias in commandtype.Aliases)
                {
                    _commands.Add(alias, type);
                }
            }
            Directory.SetCurrentDirectory(@$"C:\Users\{Environment.UserName}");
        }
    }
        public void Run()
    {
        while (true)
        {
            Console.Write($"R[{Directory.GetCurrentDirectory()}]> ");
            string? input = Console.ReadLine().ToLower();
            if (input is null || input == "") continue;
            if (input is "exit") break;
            
            Execute(input);
        }
    }
    private void Execute(string input)
    {
        string[] args = input.Split(null, 2);
        string commandname = args[0].Trim();
        args = args.Length == 1 ? Array.Empty<string>() : GetArgs(args[1]);

        if (_commands.ContainsKey(commandname))
        {
            var command = (InCom)Activator.CreateInstance(_commands[commandname])!;
            command.Run(args);
            return;
        }
        Console.Error.WriteLine($"Error: {commandname} is not a valid command");
    }

    private static string[] GetArgs(string args)
    {
        var parsedargs = new List<string>();
        var arg = new StringBuilder();
        var quoted = false;
        foreach (char character in args)
        {
            switch (character)
            {
                case ' ' when quoted:
                    arg.Append(' ');
                    break;
                case ' ':
                    parsedargs.Add(arg.ToString());
                    arg.Clear();
                    break;
                case '"':
                    quoted = !quoted;
                    break;
                default:
                    arg.Append(character);
                    break;
            }
        }

        if (arg.Length > 0)
        {
            parsedargs.Add(arg.ToString());
        }

        return parsedargs.ToArray();
    }
}