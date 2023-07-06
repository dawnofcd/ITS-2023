using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class laned3 : MonoBehaviour
{


    public float wanted;
    public static int count3;
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
wanted = 1.3f;
var Pos= new Vector3(transform.position.x, wanted);
GameObject car= Instantiate(carspawm[Random.Range(0,carspawm.Length)], Pos, Quaternion.identity);
car.transform.Rotate(0,0,90); 
  count3++; 
  
 if(moVe3_1.Asset==false&&moVe3_2.Asset==false)
{ 
count3=count3-count3;

}
//countVehical++;
//vehical.text= countVehical.ToString();
yield return new WaitForSeconds(seconSpawn);
   }
  }
}
