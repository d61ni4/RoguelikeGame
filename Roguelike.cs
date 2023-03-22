using System;
class Program {
    public static void Main(string[] args) {
        Console.Clear();
        Tree dungeon = new Tree(new Container(1, 1, 10, 5));
        dungeon = dungeon.Split(5, new Container(1, 1, 100, 50));
        dungeon.Paint();
    }
}