using System;

class Program {
    public static void Main(string[] args) {
    Console.Clear();
    Hero hero = new Hero(1, 1);
    List<Entity> entities = new List<Entity>(){hero, new Enemy("Goblin", 3, 3)};
    Room room1 = new Room(20, 10, entities);
    room1.drawRoom();
    ConsoleKeyInfo key;
    while (true) {
        key = Console.ReadKey();
        if (key.Key == ConsoleKey.LeftArrow) {
            if (room1.getMap()[hero.getCoordinates()[0] - 1, hero.getCoordinates()[1]].getType() == "freespace") {
                hero.moveLeft();
            }
        } else if (key.Key == ConsoleKey.RightArrow) {
            if (room1.getMap()[hero.getCoordinates()[0] + 1, hero.getCoordinates()[1]].getType() == "freespace") {
                hero.moveRight();
            }
        } else if (key.Key == ConsoleKey.UpArrow) {
            if (room1.getMap()[hero.getCoordinates()[0], hero.getCoordinates()[1] - 1].getType() == "freespace") {
                hero.moveTop();
            }
        } else if (key.Key == ConsoleKey.DownArrow) {
            if (room1.getMap()[hero.getCoordinates()[0], hero.getCoordinates()[1] + 1].getType() == "freespace") {
                hero.moveBot();
            }
        }
        Console.Clear();
        room1.drawRoom();
    }
    }
}