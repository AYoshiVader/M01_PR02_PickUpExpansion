using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnergyPickUpBehaviour : MonoBehaviour
{
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "Player")
        {
            Destroy(this.transform.parent.gameObject);

            UnityEngine.Debug.Log("Energize!");
        }
    }
}
