using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class laned1 : MonoBehaviour
{

    public float wanted;
    public static int count1;
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
wanted = -0.2f;
var Pos= new Vector3(transform.position.x, wanted);
GameObject car= Instantiate(carspawm[Random.Range(0,carspawm.Length)], Pos, Quaternion.identity);
car.transform.Rotate(0,0,-90); 
  count1++; 
 if(moVe1_1.Asset==false&&moVe1_2.Asset==false)
{ 
count1=count1-count1;
}
//countVehical=countVehical+1;
//vehical.text= countVehical.ToString();
yield return new WaitForSeconds(seconSpawn);
   }
  }
}
