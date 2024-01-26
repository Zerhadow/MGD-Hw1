using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RapidFire : PowerUpBase
{
    protected override void PowerUp()
    {
        // Reduce the TurrentController's Shot cooldown by half
        turretController.FireCooldown /= 2;
    }

    protected override void OnHit()
    {
        // disable powerup visuals and collider
        GetComponent<Collider>().enabled = false;
        GetComponent<MeshRenderer>().enabled = false;
        
        PowerUp();

        // start timer
        StartCoroutine(Timer(PowerUpDuration));
    }

    private void FixedUpdate() {
        // rotate powerup
        transform.Rotate(0, 0, 1);
    }

    protected override void PowerDown()
    {
        // return shot cooldown to normal
        Debug.Log("PowerDown");
        turretController.FireCooldown *= 2;
    }
}
