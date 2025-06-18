namespace CommandPatternDemo.Commands;
public class CommandManager
{
    private readonly Stack<ICommand> _history = new();
    private readonly Stack<ICommand> _redo = new();

    public Stack<string> UndoList = new Stack<string>();
    public Stack<string> RedoList = new Stack<string>();

    public void ExecuteCommand(ICommand command, string commandName)
    {
        command.Execute();
        _history.Push(command);
        UndoList.Push(commandName); // Store command type name for undo

        RedoList.Clear(); // Clear redo stack on new command execution
        _redo.Clear();
    }

    public void Undo()
    {
        if (_history.TryPop(out var command))
        {
            command.Undo();
            _redo.Push(command);
            RedoList.Push(UndoList.Pop()); // Store command type name for redo
        }
    }

    public void Redo()
    {
        if (_redo.TryPop(out var command))
        {
            command.Execute();
            _history.Push(command);
            UndoList.Push(RedoList.Pop()); // Store command type name for undo
        }
    }
}