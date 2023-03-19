using System;

public class Entity {
  protected int xcord;
  protected int ycord;
  protected char symbol;
  protected string type;

  public int[] getCoordinates() {
    int[] array1 = new int[] {this.xcord, this.ycord};
    return array1;
  }
  public char getSymbol() {
    return this.symbol;
  }
  public string getType() {
    return this.type;
  }
}

public class Character : Entity {

  protected int health;
  protected int damage;

  public int getHealth() {
    return this.health;
  }
  public int getDamage() {
    return this.damage;
  }
  public void takeDamage(int damageAmount) {
    this.health -= damageAmount;
  }

  public void dealDamage(Character enemy, int damageAmount) {
    enemy.takeDamage(damageAmount);
  }

  public void moveRight() {
    this.xcord += 1;
  }

  public void moveLeft() {
    this.xcord -= 1;
  }

  public void moveTop() {
    this.ycord += 1;
  }

  public void moveBot() {
    this.ycord -= 1;
  }
}

public class Hero : Character {
  public Hero(int xcord, int ycord) { 
    this.type = "Hero";
    this.symbol = '@';
    this.damage = 10;
    this.health = 100;
    this.xcord = xcord;
    this.ycord = ycord;
  }
}

public class Enemy : Character {

  public Enemy(string type, int xcord, int ycord) {
    if (type == "Goblin") {
      this.health = 10;
      this.damage = 5;
      this.symbol = 'g';
      this.xcord = xcord;
      this.ycord = ycord;
    }
  }
}