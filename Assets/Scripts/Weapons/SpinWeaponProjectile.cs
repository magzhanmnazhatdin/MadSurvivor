using UnityEngine;

public class SpinWeaponProjectile : MonoBehaviour
{
    private SpinWeapon weapon;

    void Start()
    {
        weapon = GameObject.Find("Spin Weapon").GetComponent<SpinWeapon>();
    }

    void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.CompareTag("Enemy"))
        {
            Enemy enemy = collider.GetComponent<Enemy>();
            if (enemy != null)
            {
                enemy.TakeDamage(weapon.stats[weapon.weaponLevel].damage);
            }
        }
    }
}
