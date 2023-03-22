using System;



public class FightLogics{
    public void Fight(Character attacker, Character defender) 
    {
      int defHealth = defender.getHealth();
      int atkHealth = attacker.getHealth();
      
      if(defHealth > 0){
      attacker.dealDamage(defender);
      
        if (atkHealth > 0 && defHealth > 0){
            defender.dealDamage(attacker);
        }
      }

    }




}