namespace Flyweight;

public class BulletFlyweight(string type, string color, string texture) {
    private readonly string type = type;
    private readonly string color = color;
    private readonly string texture = texture;

    public void Render(double x, double y, double velocity, double angle) {
        Console.WriteLine($"Rendering a {type} bullet at ({x:G4}; {y:G4}) with color {color}, texture {texture}, velocity {velocity}, and angle {(double.IsInfinity(Math.PI / angle) ? "0" : $"PI/{Math.PI / angle}")} rad.");
    }
}

public class Bullet(double x, double y, double velocity, double angle, BulletFlyweight flyweight) {
    private double x = x;
    private double y = y;
    private readonly double velocity = velocity;
    private readonly double angle = angle;
    private readonly BulletFlyweight flyweight = flyweight;

    public void Render() => flyweight.Render(x, y, velocity, angle);

    public void UpdatePosition(double time) {
        x += velocity * Math.Cos(angle) * time;
        y += velocity * Math.Sin(angle) * time;
    }
}

