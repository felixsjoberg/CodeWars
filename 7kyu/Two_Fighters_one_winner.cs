
/*
Create a function that returns the name of the winner in a fight between two fighters.

Each fighter takes turns attacking the other and whoever kills the other first is victorious. Death is defined as having health <= 0.

Each fighter will be a Fighter object/instance. See the Fighter class below in your chosen language.

Both health and damagePerAttack (damage_per_attack for python) will be integers larger than 0. You can mutate the Fighter objects.

Your function also receives a third argument, a string, with the name of the fighter that attacks first.
*/

public class Kata {
  public static string declareWinner(Fighter fighter1, Fighter fighter2, string firstAttacker)
        {
            nt health1 = fighter1.Health;
            int health2 = fighter2.Health;
            if (firstAttacker == fighter1.Name)
            {
                while (health2 > 0 || health1 > 0)
                {
                    health2 = health2 - fighter1.DamagePerAttack;
                    if (health1 < 0 || health2 < 0)
                    {
                        break;
                    }
                    health1 = health1 - fighter2.DamagePerAttack;
                    if (health1 <= 0 || health2 <= 0)
                    {
                        break;
                    }

                }
            }
            else
            {
                while (health2 > 0 || health1 > 0)
                {
                    health1 = health1 - fighter2.DamagePerAttack;
                    if (health1 < 0 || health2 < 0)
                    {
                        break;
                    }
                    health2 = health2 - fighter1.DamagePerAttack;
                }
            }
            return health2 <= 0 ? fighter1.Name : fighter2.Name;
        }
}