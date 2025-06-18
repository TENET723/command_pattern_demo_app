namespace CommandPatternDemo.Commands;

public class MoveBoxCommand : ICommand
{
    private readonly Box _box;
    private readonly double _dx;
    private readonly double _dy;
    private double _prevX, _prevY;

    public MoveBoxCommand(Box box, double dx, double dy)
    {
        _box = box;
        _dx = dx;
        _dy = dy;
        _prevX = box.X;
        _prevY = box.Y;
    }

    public void Execute()
    {
        _box.X += _dx;
        _box.Y += _dy;
    }

    public void Undo()
    {
        _box.X = _prevX;
        _box.Y = _prevY;
    }
}
