using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(player))]
public class Enemigos1 : MonoBehaviour
{
    public LayerMask zombie;
    public Animator zombiecontroller;
    public player move;
    public Transform jugador;
    public float rango;
    public float distancia;
    // Start is called before the first frame update
    private void Start()
    {
        move.GetComponent<player>();
 
    }
    private void Update()
    {

        if (Vector3.Distance(transform.position, jugador.position) <= rango)
        {
            move.Mover(1, 0);
            zombiecontroller.SetFloat("speedm", 1f);
            Look();
        }
        else
        {
            zombiecontroller.SetFloat("speedm", 0f);
        }


        if (Physics.Raycast(jugador.position + new Vector3(0, 1, 0), jugador.forward * distancia, out RaycastHit hitt) && zombie == LayerMask.GetMask("heroe") )
        {   
            if (hitt.transform.name == "heroe" )
            {
                print("hola");
                
                zombiecontroller.SetFloat("spedm", 0f);
                zombiecontroller.SetFloat("atack", 2f);
                
            }
            
            
           

        }
        
    }
              
    void Look()
    {
        

            if (Vector3.Dot((jugador.position-transform.position).normalized,transform.TransformDirection(Vector3.forward).normalized) < 0.98f)
            {
                if(Vector3.Dot((jugador.position -transform.position).normalized, transform.TransformDirection(Vector3.right).normalized) > 0f)
                {
                    move.Rotarpersonaje(5f);
                   
                }
                else
                {
                    move.Rotarpersonaje(-5f);
                }

            }

        
        
        
            
        

    }

    
    


}