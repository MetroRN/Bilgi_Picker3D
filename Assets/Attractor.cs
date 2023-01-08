using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attractor : MonoBehaviour
{
    public float AttractorSpeed;
    private void OnTriggerStay(Collider other)
        {
            if(other.CompareTag("Physics"))
            {
                transform.position = Vector3.MoveTowards(transform.position, other.transform.position, AttractorSpeed * Time.deltaTime);
            }
        }

        private void OnTriggerEnter(Collider other)
        {
            if(other.CompareTag("Picker"))
            {
                Destroy(gameObject);
            }
        }

        
}
