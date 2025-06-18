
namespace CommandPatternDemo.Commands;

public class Box
{
    public Guid Id { get; set; } = Guid.NewGuid();
    public double X { get; set; }
    public double Y { get; set; }
    public double Width { get; set; } = 100;
    public double Height { get; set; } = 100;
    public string Color { get; set; } = "#3498db";
    public double BorderRadius { get; set; } = 0;
}
