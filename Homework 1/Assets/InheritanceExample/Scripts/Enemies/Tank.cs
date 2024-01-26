using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tank : EnemyBase
{
    private float _timer = 1f;
    
    protected override void OnHit()
    {
        // stops movement for 1 second. getting hit while not moving will reset timer
        MoveSpeed = 0;
        StartCoroutine(Timer(_timer));
    }

    IEnumerator Timer(float _timer)
    {
        yield return new WaitForSeconds(_timer);
        MoveSpeed = .05f; //resumes normal speed
    }
}
