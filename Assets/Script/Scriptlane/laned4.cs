using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class laned4 : MonoBehaviour
{


    public float wanted;
    public static int count4;
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
wanted = 0.9f;
var Pos= new Vector3(wanted, transform.position.y);
GameObject car= Instantiate(carspawm[Random.Range(0,carspawm.Length)], Pos, Quaternion.identity);
  count4++; 
  
 if(moVe4_1.Asset==false&&moVe4_2.Asset==false)
{ 
count4=count4-count4;
}
//countVehical++;
//vehical.text= countVehical.ToString();

yield return new WaitForSeconds(seconSpawn);
   }
  }
}
