using System;
using System.Collections.Generic;

Color color1 = new Color(255, 0, 0);
Color color2 = new Color(255, 0, 0);
Color color3 = new Color(250, 5, 3);
Color color4 = new Color(200, 50, 50);
Console.WriteLine($"=== 동등성 비교 ===");
Console.WriteLine($"{color1} == {color2}: {color1.Equals(color2)}");

Console.WriteLine();
Console.WriteLine($"=== 유사 색상 판정 ===");
Console.WriteLine($"{color1}과 {color3}은 유사한가? (임계값 10): {color1.IsSimilar(color3, 10)}");
Console.WriteLine($"{color1}과 {color4}은 유사한가? (임계값 10): {color1.IsSimilar(color4, 10)}");

Console.WriteLine();
Console.WriteLine("=== HashSet 중복 제거 ===");
HashSet<Color> Colors = new HashSet<Color>();
Colors.Add(color1);
Colors.Add(new Color(0, 0, 255));
Colors.Add(new Color(255, 0, 0));
Colors.Add(new Color(0, 255, 0));
Colors.Add(new Color(0, 255, 0));
foreach(Color color in Colors)
{
    Console.WriteLine($"{color}");
}
Console.WriteLine();
Console.WriteLine($"RGB(255, 0, 0) 포함 여부: {Colors.Contains(color1)}");