using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class PowerUpBase : MonoBehaviour
{
    [SerializeField] protected float PowerUpDuration = .05f;
    protected TurretController turretController;

    protected abstract void PowerUp();
    protected abstract void OnHit();

    protected abstract void PowerDown();

    private void Awake() {
        turretController = FindObjectOfType<TurretController>();
    }

    private void OnTriggerEnter(Collider other) {
        // if projectile hits powerup
        Projectile projectile = other.GetComponent<Projectile>();
        if (projectile != null)
        {
            OnHit();
        }
    }

    protected IEnumerator Timer(float PowerUpDuration)
    {
        yield return new WaitForSeconds(PowerUpDuration);
        PowerDown();
        // destroy powerup gameobject
        Destroy(gameObject);
    }
}
