namespace CommandPatternDemo.Commands;

// Commands/AddBoxCommand.cs    
public class AddBoxCommand : ICommand
{
    private readonly List<Box> _boxes;
    private readonly Box _box;
    private Action<Box>? _onExecute;

    public AddBoxCommand(List<Box> boxes, Box box, Action<Box>? onExecute = null)
    {
        _boxes = boxes;
        _box = box;
        _onExecute = onExecute;
    }

    public void Execute()
    {
        _boxes.Add(_box);
        _onExecute?.Invoke(_box);
    }

    public void Undo() => _boxes.Remove(_box);
}
