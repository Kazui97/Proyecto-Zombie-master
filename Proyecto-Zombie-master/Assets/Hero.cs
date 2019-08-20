using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hero : MonoBehaviour
{
     CosasZombie datosZombi;

    void Start()
    {
        
    }

    
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.transform.name == "ZombieMesh")
        {
            datosZombi = collision.gameObject.GetComponent<ZombieOp>().datosZombi;
            Debug.Log("waaarrr" + "quiero comer" + datosZombi.sabroso);
        }

    }
}



