using System;



public class Fight{
    public Fight(Character hero, Character enemy){
      this.hero = hero;
      this.enemy = enemy;
    }
    private Character hero;
    private Character enemy;
    
    
    
    
    
    
    public void start(){
      while (hero.isAlive() && enemy.isAlive()){
        //тут должен быть жесткий код сражения...
      }
    }
    
    
    public void heroMeleeAttack(){
      hero.dealDamage(enemy); //dealDamage стоит вообще наверное удалить, чтобы  метод heroMeleeAttack получал только значение урона из Character
    
}
    
    public void enemyAttack(){
      enemy.dealDamage(hero); //dealDamage стоит вообще наверное удалить, чтобы  метод heroMeleeAttack получал только значение урона из Character
    }
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    // status WIP
    
    /*public void Battle(Character attacker, Character defender) 
    {
      int defHealth = defender.getHealth();
      int atkHealth = attacker.getHealth();
      
      if(defHealth > 0){
      attacker.dealDamage(defender);
      
        if (atkHealth > 0 && defHealth > 0){
            defender.dealDamage(attacker);
        }
      }

    
    
    
    
    
    } */




}