using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class interacciondearmas : MonoBehaviour
{
    public Transform playercamera;
    public float distancia;
    public Transform manos;
    public LayerMask l;
    //private void Update()
    //{
        
    //Debug.DrawRay(playercamera.position, playercamera.forward* 3F, Color.red);
    //    RaycastHit hit;
    //    if (Physics.Raycast(playercamera.position, playercamera.forward, out hit, distancia, l) && l == LayerMask.GetMask("interaccion"))
    //    {

    //        if (hit.transform.tag == "Arma")
    //        {
    //            // Indicarle al jugador el objeto
    //            if (Input.GetButtonDown("Fire1"))
    //            {
    //                hit.transform.parent = manos;
    //                hit.transform.GetComponent<Rigidbody>().isKinematic = true;
    //                hit.transform.position = manos.position;
    //                l = LayerMask.GetMask("Default");
    //            }

    //        }

    //    }
    //    else if (manos.childCount != 0 && Input.GetButtonDown("Fire1"))
    //    {
    //        manos.GetComponentInChildren<Rigidbody>().isKinematic = false;
    //        manos.transform.DetachChildren();
    //        l = LayerMask.GetMask("interaccion");
    //    }

        
    //}

    private void OnTriggerStay(Collider other)
    {
        if (other.tag=="Arma")
        {
            // if (Input.GetButtonDown("Fire1"))
          //  other.transform.parent.parent = manos;
          //  other.transform.parent.parent.position = manos.position;
            other.transform.parent = manos;
            other.transform.position = manos.position;
            other.transform.rotation = manos.rotation;
            //other.transform.GetComponent<Rigidbody>().isKinematic = true;
                    
            
        }
    }

}
