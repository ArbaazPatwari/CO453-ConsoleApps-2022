using UnityEngine;

public class Fighter : MonoBehaviour
{
    // Public fields
    public int hitpoint = 5;
    public int maxHitpoint = 10;
    public float pushRecoverySpeed = 0.2f;

    // Invincibility frames
    protected float immuneTime = 1.0f;
    protected float lastImmune;

    // Knockback 
    protected Vector3 pushDirection;

    // All Fighters can ReceiveDamage / Die
    protected virtual void ReceiveDamage(Damage dmg)
    {
        if (Time.time - lastImmune > immuneTime)
        {
            lastImmune = Time.time;
            hitpoint -= dmg.damageAmount;
            pushDirection = (transform.position - dmg.origin).normalized * dmg.pushForce;

            GameManager.instance.ShowText(dmg.damageAmount.ToString(), 25, Color.red, transform.position, Vector3.zero, 0.6f);

            if (hitpoint <= 0)
            {
                hitpoint = 0;
                Death();
            }
        }
    }

    protected virtual void Death()
    {

    }
}
