using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPatternDemo.Commands;
// Commands/ChangeBorderRadiusCommand.cs
public class ChangeBorderRadiusCommand : ICommand
{
    private readonly Box _box;
    private readonly double _newRadius;
    private double _prevRadius;

    public ChangeBorderRadiusCommand(Box box, double newRadius)
    {
        _box = box;
        _newRadius = newRadius;
        _prevRadius = box.BorderRadius;
    }

    public void Execute()
    {
        _box.BorderRadius = _newRadius;
    }

    public void Undo()
    {
        _box.BorderRadius = _prevRadius;
    }
}