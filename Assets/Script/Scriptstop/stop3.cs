using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class stop3 : MonoBehaviour
{
    void OnCollisionEnter2D(Collision2D other)
    {
        
    }

    void OnCollisionStay2D(Collision2D other)
    {
        
    }
     
     void OnCollisionExit2D(Collision2D other)
     {
        
     }
  public GameObject stopBox;
    void FixedUpdate()
    {
        ActiveStop();
        
    }
    public void ActiveStop()
    {
        if (lightcontrol.checklight3==true)
        {
            stopBox.SetActive(true);
        }
        else
        {
            stopBox.SetActive(false);
        }
    }
   
}
