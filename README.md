# 🧩 Command Pattern Canvas App

This is a demo Blazor app showcasing the **Command Pattern** with visual feedback using a canvas-style interface. You can add, move, resize, and style boxes with undo/redo functionality and keyboard shortcuts—similar to how design or game editors work.

---

## ✨ Features

- Command Pattern applied for every operation (Add, Move, Resize, Style).
- History support: `Undo` and `Redo` operations.
- Keyboard shortcuts for power users.
- Automatically selects a box after adding.
- Smooth, mobile-friendly iOS-style UI with material icons.
- Key normalization for consistent cross-platform behavior.

---

## 🧱 Architecture

- **Commands**: Each action (like `AddBoxCommand`, `MoveBoxCommand`) implements `ICommand` with `Execute()` and `Undo()` methods.
- **CommandManager**: Manages undo/redo stacks and executes commands.
- **ShortcutManager**: Maps keys to command factory functions.
- **CanvasPage.razor**: Main UI for drawing boxes and attaching behaviors.

---

## ⌨️ Keyboard Shortcuts

| Shortcut        | Action                     |
|----------------|----------------------------|
| `A`            | Add Box (selects it)       |
| `Arrow Keys`   | Move selected box          |
| `S`            | Increase box size          |
| `Shift+S`      | Decrease box size          |
| `C`            | Change color to red        |
| `Shift+C`      | Change color to blue       |
| `R`            | Increase border radius     |
| `Shift+R`      | Decrease border radius     |
| `Ctrl+Z`       | Undo last command          |
| `Ctrl+Y`       | Redo previously undone cmd |

> Note: You must first click anywhere on the canvas to activate key capturing (focus).

---

## 🧠 Selected Box Behavior

- When a box is added (via button or shortcut), it is automatically selected.
- Clicking on any box in the canvas will select it.
- All commands (except Add) act on the selected box.

---

## 🛠️ Extending the App

### Add a new Command

1. Create a new class that implements `ICommand`.
2. Implement `Execute()` and `Undo()` methods.
3. Optionally, update the UI or `SelectedBox` inside the command.
4. Register it in a button or via a shortcut in `CanvasPage.razor`.

### Example
```csharp
public class FlipBoxCommand : ICommand
{
    private readonly Box _box;
    private bool _flipped;

    public FlipBoxCommand(Box box)
    {
        _box = box;
        _flipped = false;
    }

    public void Execute()
    {
        _flipped = !_flipped;
        _box.Color = _flipped ? "#ffffff" : "#000000";
    }

    public void Undo()
    {
        Execute(); // Toggle back
    }
}
```

---

## 📂 Project Structure

```
📁 Commands/
  ├── AddBoxCommand.cs
  ├── MoveBoxCommand.cs
  ├── ResizeBoxCommand.cs
  ├── ChangeColorCommand.cs
  ├── ChangeBorderRadiusCommand.cs
  └── ICommand.cs

📁 Services/
  ├── CommandManager.cs
  └── ShortcutManager.cs

📁 Models/
  └── Box.cs

📁 Pages/
  └── CanvasPage.razor

README.md ← this file
```

---

## 📦 Dependencies

- .NET 9 / Blazor
- Material Icons (via CDN)
- HTML/CSS (iOS-style layout, Flexbox, shadow effects)

---

## 🧪 TODO

- [ ] CompositeCommand support (e.g., grouped actions like add + move).
- [ ] Save/Load canvas state to JSON.
- [ ] Multi-select support.
- [ ] Command preview before execute.

---

## 🧠 Motivation

This project is designed to help developers understand:

- How to structure a **Command Pattern** architecture in a Blazor app.
- How to integrate keyboard shortcuts, command history, and dynamic UI in a modular way.
- How to build reactive and undoable UI interactions.

---

## 🧑‍💻 Author

**TENET**

---