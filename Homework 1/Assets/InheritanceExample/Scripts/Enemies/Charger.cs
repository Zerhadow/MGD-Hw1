using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class Charger : EnemyBase
{
    public GameObject powerupPrefab;
    
    protected override void OnHit()
    {
        // increase spd when hit
        MoveSpeed *= 2;
    }

    public override void Kill() {
        // spawn RapidFire powerup at location
        base.Kill();
        Instantiate(powerupPrefab, transform.position, Quaternion.identity);
    }
}
