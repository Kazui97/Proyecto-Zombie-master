using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZombieOp : MonoBehaviour
{
    

    // public string [] Gustos;
    public CosasZombie datosZombi;
   

     

    void Awake()
    {
        

        datosZombi.colorEs = (CosasZombie.ColorZombie)Random.Range(0, 3);

        int dargusto = Random.Range(0, 5);
        datosZombi.sabroso = (CosasZombie.Gustos)dargusto;

    }

    
    void Update()
    {
        
    }

    

}



public struct CosasZombie
{
    public enum Gustos 
    {
        Brazos,
        Piernas,
        Huesitos,
        Ojito,
        corazoncito
    };
    public Gustos sabroso;

    public enum Estados
    {
        Idle,
        Moving
    };
    public Estados condicion;

    public enum ColorZombie
    {
        magenta,
        green, 
        cyan
    };
    public ColorZombie colorEs;
}