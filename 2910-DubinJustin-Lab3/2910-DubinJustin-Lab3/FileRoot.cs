using System;
namespace _2910_DubinJustin_Lab3
{
    public class FileRoot
    {
        public static string? root = Directory.GetParent(       // Debug
        Directory.GetCurrentDirectory())                    // net6.0
        .Parent                                             // bin
        .Parent                                             // project folder
        .ToString();
    }
}