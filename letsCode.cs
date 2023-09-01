using System.Collections;
using System.Collections.Gnerics;

public class EnemyAI : MonoBehaviour
{
    float health;
    int speed;
    string enemyName;

    int [] intArray = new int[] {1,2,3,4,5,6,7,8,9,10};
    List<int> intList = new List<int>() {1,2,3,4,5,6,7,8,9,10};

    void Movement()
    {
        if(speed > 0)
        {
            
        }else
        {

        }
    }

    void Dead()
    {
        if (health <= 0)
        {
            
        }
    }

    void Attack()
    {

    }
}

