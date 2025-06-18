namespace CommandPatternDemo.Commands;
// Commands/ResizeBoxCommand.cs
public class ResizeBoxCommand : ICommand
{
    private readonly Box _box;
    private readonly double _newWidth;
    private readonly double _newHeight;
    private double _prevWidth, _prevHeight;

    public ResizeBoxCommand(Box box, double newWidth, double newHeight)
    {
        _box = box;
        _newWidth = newWidth;
        _newHeight = newHeight;
        _prevWidth = box.Width;
        _prevHeight = box.Height;
    }

    public void Execute()
    {
        _box.Width = _newWidth;
        _box.Height = _newHeight;
    }

    public void Undo()
    {
        _box.Width = _prevWidth;
        _box.Height = _prevHeight;
    }
}