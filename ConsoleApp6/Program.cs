using System;
using System.Linq;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Console.Write("Въведете първото множество: ");
        HashSet<int> set1 = Console.ReadLine().Split(' ').Select(int.Parse).ToHashSet();

        Console.Write("Въведете второто множество: ");
        HashSet<int> set2 = Console.ReadLine().Split(' ').Select(int.Parse).ToHashSet();

        HashSet<int> intersection = new HashSet<int>(set1);
        intersection.IntersectWith(set2);

        HashSet<int> union = new HashSet<int>(set1);
        union.UnionWith(set2);

        HashSet<int> difference = new HashSet<int>(set1);
        difference.ExceptWith(set2);

        HashSet<int> symmetricDifference = new HashSet<int>(set1);
        symmetricDifference.SymmetricExceptWith(set2);

        Console.WriteLine("Сечение: " + string.Join(", ", intersection));
        Console.WriteLine("Обединение: " + string.Join(", ", union));
        Console.WriteLine("Разлика: " + string.Join(", ", difference));
        Console.WriteLine("Симетрична разлика: " + string.Join(", ", symmetricDifference));
    }
}
