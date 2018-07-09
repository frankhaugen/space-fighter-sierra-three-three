using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeadZone : MonoBehaviour {

	public float CheckIfInDeadZone(float input)
    {
        float output;

        if (input < 0.1f && input > -0.1f)
        {
            output = 0f;
        }
        else
        {
            output = input;
        }

        return output;
    }
}
