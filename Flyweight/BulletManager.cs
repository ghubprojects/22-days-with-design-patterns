namespace Flyweight;

public class BulletManager {
    private readonly List<Bullet> _bullets = [];
    private readonly BulletFlyweightFactory _bulletFlyweightFactory = new();

    public void SpawnBullet(double x, double y, double velocity, double angle, string type, string color, string texture) {
        var bulletFlyweight = _bulletFlyweightFactory.GetBulletType(type, color, texture);
        var bullet = new Bullet(x, y, velocity, angle, bulletFlyweight);
        _bullets.Add(bullet);
        bullet.Render();
    }

    public void UpdateBullets(double time) {
        foreach (Bullet bullet in _bullets) {
            bullet.UpdatePosition(time);
            bullet.Render();
        }
    }
}
