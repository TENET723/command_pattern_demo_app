
namespace CommandPatternDemo.Commands;
public class ChangeColorCommand : ICommand
{
    private readonly Box _box;
    private readonly string _newColor;
    private string _prevColor;

    public ChangeColorCommand(Box box, string newColor)
    {
        _box = box;
        _newColor = newColor;
        _prevColor = box.Color;
    }

    public void Execute()
    {
        _prevColor = _box.Color;
        _box.Color = _newColor;
    }

    public void Undo()
    {
        _box.Color = _prevColor;
    }
}
