namespace CommandPatternDemo.Commands;
public interface ICommand
{
    void Execute();
    void Undo(); // optional
}

