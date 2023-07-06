using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moVe1_2 : MonoBehaviour
{
    
  public Transform []Waypoint;
  private Vector3 Target;
    [SerializeField]  float Speed =1f;
    public int currentTarget;

    private int TurnCar;
     private  bool colLider;
      public static bool Asset=true;
    void OnCollisionEnter2D(Collision2D other)
    {   Asset=true;
        colLider=true;
    }
void OnCollisionStay2D(Collision2D other)
{
     Asset=true;
}
    
    void OnCollisionExit2D(Collision2D other)
    {   Asset=false;
       colLider=false;
        if(colLider==false)
       { Rigidbody2D r2b=GetComponent<Rigidbody2D>();
       Destroy(r2b,0.1f);
       }
    }

    void Update()
    {
        Movement(Target);
    }
   
     void Movement(Vector3 target)
    {
        if (colLider==true)
        {
            target=this.transform.position;
        }
        else
       { transform.position = Vector3.MoveTowards(transform.position, Waypoint[currentTarget].position, Speed * Time.deltaTime);
        ChangeTarget();
       }
    }

        void ChangeTarget()
    {
        if (currentTarget==9)
        {
            Destroy(this.gameObject,1f);
        }
        if(currentTarget==6)
        {
            Destroy(this.gameObject,1f);
        }

        if (transform.position == Waypoint[currentTarget].position)
        {
            currentTarget++;
           if (currentTarget==4)
           {
        TurnCar= Random.Range(1,10);
if (TurnCar==2|| TurnCar==5)
{
    currentTarget=5;
    this.transform.Rotate(0,0,90);
    return;
}
else{
    currentTarget=7;
    return;
}
           }

        }
    }
}


