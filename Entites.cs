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
  public void takeDamage(int damage) {
    this.health -= damage;
  }

  public void dealDamage(Character enemy) {
    enemy.takeDamage(this.damage);
  }

  public void moveRight() {
    this.xcord += 1;
  }

  public void moveLeft() {
    this.xcord -= 1;
  }

  public void moveTop() {
    this.ycord -= 1;
  }

  public void moveBot() {
    this.ycord += 1;
  }

  public bool isAlive(){
      
      if(this.health > 0){ return true; }
      else { return false; }

    }
  public void death(){}
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
    this.type = "enemy";
    if (type == "Goblin") {
      this.health = 10;
      this.damage = 5;
      this.symbol = 'g';
      this.xcord = xcord;
      this.ycord = ycord;
    }
  }
}

public class FreeSpace : Entity {
  public FreeSpace() {
    this.type = "freespace";
    this.symbol = '.';
  }
}

public class Wall : Entity {
  public Wall() {
    this.type = "wall";
    this.symbol = '#';
  }
}

public class Door : Entity {
  public Door(int x, int y) {
    this.type = "door";
    this.symbol = '0';
    this.xcord = x;
    this.ycord = y;
  }
}