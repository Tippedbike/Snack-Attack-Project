using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectCollision : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }
    void OnTriggerEnter(Collider other)
        {
            if(other.CompareTag("Player"))
            {
                PlayerController pc = other.GetComponet<PlayerController>();
                pc.score += scoreToAdd;
                Destroy(gameObject);
                Destroy(other.gameObject);
            }
        }
    // Update is called once per frame
    void Update()
    {
        
    }
    
}
