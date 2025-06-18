namespace CommandPatternDemo.Commands;

// Commands/AddBoxCommand.cs    
public class AddBoxCommand : ICommand
{
    private readonly List<Box> _boxes;
    private readonly Box _box;

    public AddBoxCommand(List<Box> boxes, Box box)
    {
        _boxes = boxes;
        _box = box;
    }

    public void Execute() => _boxes.Add(_box);

    public void Undo() => _boxes.Remove(_box);
}
