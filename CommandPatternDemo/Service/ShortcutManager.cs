// Services/ShortcutManager.cs

using CommandPatternDemo.Commands;

namespace CommandPatternDemo.Service;
public class ShortcutManager
{
    private readonly Dictionary<string, Func<ICommand?>> _shortcuts = new();
    private readonly Dictionary<string, string> _commandNames = new();

    public void Register(string key, Func<ICommand?> action,string commandName)
    {
        _shortcuts[key] = action;
        _commandNames[key] = commandName;
    }

    public (ICommand?,string) GetCommand(string key)
    {
        return (_shortcuts.TryGetValue(key, out var action) ? action() : null,
                _commandNames.TryGetValue(key,out var name) ? name :"");

    }
}