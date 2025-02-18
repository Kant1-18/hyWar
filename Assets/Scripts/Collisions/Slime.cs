using UnityEngine;

public class Slime : MonoBehaviour
{
    public int life1 = GlobalVariables.EnemyLife1;
    public int Attack1 = GlobalVariables.EnemyAttack1;
    public int Attack2 = GlobalVariables.EnemyAttack2;
    public int Attack3 = GlobalVariables.EnemyAttack3;

    void Start()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Projectile1"))
        {
            life1 -= GlobalVariables.ShipAttack1;
        }
        else if (other.CompareTag("Projectile2"))
        {
            life1 -= GlobalVariables.ShipAttack2;
        }
        else if (other.CompareTag("Projectile3"))
        {
            life1 -= GlobalVariables.ShipAttack3;
        }
    }

    public void CheckHealth()
    {
        if (life1 <= 0)
        {
            Destroy(gameObject);
        }
    }

}
