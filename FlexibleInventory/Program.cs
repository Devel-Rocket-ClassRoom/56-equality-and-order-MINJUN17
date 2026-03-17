using System;
using System.Collections.Generic;

List<Item> items = new List<Item>()
{
    new Item("불꽃 검", "무기", "전설"),
    new Item("얼음 단검", "무기", "희귀"),
    new Item("철 갑옷", "방어구", "일반"),
    new Item("미스릴 방패", "방어구", "희귀"),
    new Item("체력 물약", "소비", "일반"),
};

Dictionary<Item, List<Item>> typeDict = new Dictionary<Item, List<Item>>(new ItemTypeComparer());
foreach (var item in items)
{
    if (!typeDict.ContainsKey(item))
    {
        typeDict[item] = new List<Item>();
    }
    typeDict[item].Add(item);
}
Console.WriteLine("=== 타입별 그룹핑 ===");
foreach (var group in typeDict)
{
    Console.WriteLine(group.Key.Type);
    foreach (var item in group.Value)
    {
        Console.WriteLine(item);
    }
}
Console.WriteLine();
Dictionary<Item, List<Item>> GradeDict = new Dictionary<Item, List<Item>>(new ItemGradeComparer());
foreach (var item in items)
{
    if (!GradeDict.ContainsKey(item))
    {
        GradeDict[item] = new List<Item>();
    }
    GradeDict[item].Add(item);
}
Console.WriteLine("=== 등급별 그룹핑 ===");
foreach (var group in GradeDict)
{
    Console.WriteLine(group.Key.Type);
    foreach (var item in group.Value)
    {
        Console.WriteLine(item);
    }
}