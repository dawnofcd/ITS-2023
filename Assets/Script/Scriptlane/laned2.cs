using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class laned2 : MonoBehaviour
{


    public float wanted;
    public static int count2;
    public GameObject []carspawm;
    private int seconSpawn;
    public Text vehical;
    //private int countVehical;
    void Start()
    {
        StartCoroutine(SpawnCar());                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                               
    }

  IEnumerator SpawnCar()
  {
   while(true)
   {
seconSpawn= Random.Range(8,11);
wanted = -0.5f;
var Pos= new Vector3(wanted, transform.position.y);
GameObject car= Instantiate(carspawm[Random.Range(0,carspawm.Length)], Pos, Quaternion.identity);
car.transform.Rotate(0,0,180); 
  count2++; 
  
  
 if(moVe2_1.Asset==false&&moVe2_2.Asset==false)
{ 
count2=count2-count2;

}
//countVehical++;
//vehical.text= countVehical.ToString();
yield return new WaitForSeconds(seconSpawn);
   }
  }
}
