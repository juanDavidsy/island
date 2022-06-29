using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(player))]
public class playercontroller : MonoBehaviour
{  [Header("Movement main hero")]
    public player playermovement;
   
    private void Start()
    {
        playermovement = GetComponent<player>();
    }

    public void Update()
    {


        playermovement.Mover(Input.GetAxis("Vertical"), Input.GetAxis("Horizontal"));
        
        playermovement.Rotarpersonaje(Input.GetAxis("Mouse X"));
     
        playermovement.Rotarcamara(Input.GetAxis("Mouse Y"));

    }




}
