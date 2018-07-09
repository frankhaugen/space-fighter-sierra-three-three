using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LimitLife : MonoBehaviour {

    public float LifeExpectancyInSeconds = 30f;
    [SerializeField]
    public float AgeInSeconds = 0.0f;
    
    void FixedUpdate()
    {
        if (AgeInSeconds > LifeExpectancyInSeconds)
        {
            Destroy(gameObject);
        }
        else
        {
            AgeInSeconds += Time.deltaTime % 60;
        }

    }
}
