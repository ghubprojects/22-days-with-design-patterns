using System.IO.Compression;
using System.Text;

namespace Decorator;

public static class FileHelper {
    public static string Encrypt(string data) {
        Console.WriteLine($"Encrypting {data}");
        var dataBytes = Encoding.UTF8.GetBytes(data);
        for (int i = 0; i < dataBytes.Length; i++) {
            dataBytes[i] = (byte)(dataBytes[i] + 1); // a simple way to "encrypt" the data
        }
        return Convert.ToBase64String(dataBytes);
    }

    public static string Decrypt(string data) {
        Console.WriteLine($"Decrypting {data}");
        var dataBytes = Convert.FromBase64String(data);
        for (int i = 0; i < dataBytes.Length; i++) {
            dataBytes[i] = (byte)(dataBytes[i] - 1); // reverse the simple encryption process
        }
        return Encoding.UTF8.GetString(dataBytes);
    }

    public static string Compress(string data) {
        Console.WriteLine($"Compressing {data}");
        var dataBytes = Encoding.UTF8.GetBytes(data);
        using var output = new MemoryStream();
        using (var gzip = new GZipStream(output, CompressionLevel.Optimal)) {
            gzip.Write(dataBytes, 0, dataBytes.Length);
        }
        return Convert.ToBase64String(output.ToArray());
    }

    public static string Decompress(string data) {
        Console.WriteLine($"Decompressing {data}");
        var dataBytes = Convert.FromBase64String(data);
        using var input = new MemoryStream(dataBytes);
        using var output = new MemoryStream();
        using (var gzip = new GZipStream(input, CompressionMode.Decompress)) {
            gzip.CopyTo(output);
        }
        return Encoding.UTF8.GetString(output.ToArray());
    }
}
