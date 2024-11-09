namespace Flyweight;

public class BulletFlyweightFactory {
    private readonly Dictionary<string, BulletFlyweight> _bulletFlyweights = [];

    public BulletFlyweight GetBulletType(string type, string color, string texture) {
        string key = $"{type}-{color}-{texture}";

        if (!_bulletFlyweights.TryGetValue(key, out BulletFlyweight? value)) {
            value = new BulletFlyweight(type, color, texture);
            _bulletFlyweights[key] = value;
        }

        return value;
    }
}

