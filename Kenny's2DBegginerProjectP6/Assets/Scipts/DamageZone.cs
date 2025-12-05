using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageZone : MonoBehaviour
{
    // Start is called before the first frame update
    void OnTriggerStay2D(Collider2D other)
    {
       PlayerController controller = other.GetComponent<PlayerController>();


        if (controller != null) 
        {
            controller.ChangeHealth(-1);
        }

    }

}
