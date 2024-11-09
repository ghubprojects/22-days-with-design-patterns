using Flyweight;

var bulletManager = new BulletManager();

bulletManager.SpawnBullet(0, 0, 10, 0, "Basic", "Red", "SimpleTexture");
bulletManager.SpawnBullet(5, 5, 12, Math.PI / 6, "Basic", "Red", "SimpleTexture");
bulletManager.SpawnBullet(10, 10, 16, Math.PI / 4, "Sniper", "Blue", "ComplexTexture");
bulletManager.SpawnBullet(15, 15, 24, Math.PI / 3, "Sniper", "Blue", "ComplexTexture");

Console.WriteLine("\nAfter 1 second:");
bulletManager.UpdateBullets(1);

Console.WriteLine("\nAfter 2 seconds:");
bulletManager.UpdateBullets(1);
