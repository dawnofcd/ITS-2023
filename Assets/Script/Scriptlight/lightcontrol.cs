using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class lightcontrol : MonoBehaviour
{

    public  Material []lightColor;
    public Text Countdown1, Countdown2, Countdown3, Countdown4;
   
    private int GreenTime1 ,GreenTime2, GreenTime3, GreenTime4;
    
    private  int Yellowtime;
    public static bool checklight1, checklight2, checklight3, checklight4;
 void Start()
    {
    StartCoroutine(Control());
    
    }

IEnumerator Control()
  {
    while(true)
    {   // cột 1
        GreenTime1= laned1.count1+8;
        Yellowtime=3;
       ChangelightGreen1();
       checklight1=false;
       checklight2=true;
       checklight3=true;
       checklight4=true;
             while(GreenTime1>=0)
       {
         yield return new WaitForSeconds(1f);
        Countdown1.text= GreenTime1.ToString(); 
        GreenTime1--;
       }
       ChangelightYellow1();
       Countdown1.text= "Slow";
       
       while(Yellowtime>0)
       {
         yield return new WaitForSeconds(1f);
        Countdown1.text= Yellowtime.ToString(); 
        Yellowtime--;
       }
       checklight1=true;
      Countdown1.text="Stop";
      Countdown2.text="go";
      yield return new WaitForSeconds(1f);
      
       // Cột 2
         checklight2=false;
       GreenTime2= laned2.count2+8;
       Yellowtime=3;
       ChangelightGreen2();
       while(GreenTime2>=0)
       {
         yield return new WaitForSeconds(1f);
        Countdown2.text= GreenTime2.ToString(); 
        GreenTime2--;
       }
        ChangelightYellow2();
       Countdown2.text= "Slow";
       while(Yellowtime>0)
       {
         yield return new WaitForSeconds(1f);
        Countdown2.text= Yellowtime.ToString(); 
        Yellowtime--;
       }
       checklight2=true;
        Countdown2.text="Stop";
      Countdown3.text="go";
      yield return new WaitForSeconds(1f);

       //Côt 3
       checklight3=false;
        GreenTime3= laned3.count3+8;
       Yellowtime=3;
       ChangelightGreen3();
       while(GreenTime3>=0)
       {
         yield return new WaitForSeconds(1f);
        Countdown3.text= GreenTime3.ToString(); 
        GreenTime3--;
       }
        ChangelightYellow3();
       Countdown3.text= "Slow";
       
       while(Yellowtime>0)
       {
         yield return new WaitForSeconds(1f);
        Countdown3.text= Yellowtime.ToString(); 
        Yellowtime--;
       }
       checklight3=true;
        Countdown3.text="Stop";
      Countdown4.text="go";
      yield return new WaitForSeconds(1f);

        //Côt 4
        checklight4=false;
       GreenTime4= laned4.count4+8;
       Yellowtime=3;
       ChangelightGreen4();
       while(GreenTime4>=0)
       {
         yield return new WaitForSeconds(1f);
        Countdown4.text= GreenTime4.ToString(); 
        GreenTime4--;
       }
        ChangelightYellow4();
       Countdown4.text= "Slow";
       
       while(Yellowtime>0)
       {
         yield return new WaitForSeconds(1f);
        Countdown4.text= Yellowtime.ToString(); 
        Yellowtime--;
       }
       checklight4=true;
        Countdown4.text="Stop";
      Countdown1.text="go";
      yield return new WaitForSeconds(1f);
      
    }
  }
   public  void  ChangelightGreen1()
   {
           lightColor[0].color= Color.green;
           lightColor[5].color=Color.red;
           lightColor[8].color=Color.red;
           lightColor[11].color=Color.red;
        
           for(int i=0; i<=11;i++)
           {
                if (i!=0&&i!=5&&i!=8&&i!=11)
                {
                        lightColor[i].color=Color.black;
                }
           }
   }
    public void ChangelightGreen2()
   {
           lightColor[2].color= Color.red;
           lightColor[3].color=Color.green;
           lightColor[8].color=Color.red;
           lightColor[11].color=Color.red;
        
           for(int i=0; i<=11;i++)
           {
                if (i!=2&&i!=3&&i!=8&&i!=11)
                {
                        lightColor[i].color=Color.black;
                }
           }
   }
    public void ChangelightGreen3()
   {
           lightColor[2].color= Color.red;
           lightColor[5].color=Color.red;
           lightColor[6].color=Color.green;
           lightColor[11].color=Color.red;
        
           for(int i=0; i<=11;i++)
           {
                if (i!=2&&i!=5&&i!=6&&i!=11)
                {
                        lightColor[i].color=Color.black;
                }
           }
   }
    public  void ChangelightGreen4()
   {
           lightColor[2].color= Color.red;
           lightColor[5].color=Color.red;
           lightColor[8].color=Color.red;
           lightColor[9].color=Color.green;
        
           for(int i=0; i<=11;i++)
           {
                if (i!=2&&i!=5&&i!=8&&i!=9)
                {
                        lightColor[i].color=Color.black;
                }
           }
   }

   public  void ChangelightYellow1()
   {
           lightColor[1].color= Color.yellow;
           lightColor[5].color=Color.red;
           lightColor[8].color=Color.red;
           lightColor[11].color=Color.red;
        
           for(int i=0; i<=11;i++)
           {
                if (i!=1&&i!=5&&i!=8&&i!=11)
                {
                        lightColor[i].color=Color.black;
                }
           }
   }

    public  void ChangelightYellow2()
   {
           lightColor[2].color= Color.red;
           lightColor[4].color=Color.yellow;
           lightColor[8].color=Color.red;
           lightColor[11].color=Color.red;
        
           for(int i=0; i<=11;i++)
           {
                if (i!=2&&i!=4&&i!=8&&i!=11)
                {
                        lightColor[i].color=Color.black;
                }
           }
   }
     public void ChangelightYellow3()
   {
           lightColor[2].color= Color.red;
           lightColor[5].color=Color.red;
           lightColor[7].color=Color.yellow;
           lightColor[11].color=Color.red;
        
           for(int i=0; i<=11;i++)
           {
                if (i!=2&&i!=5&&i!=7&&i!=11)
                {
                        lightColor[i].color=Color.black;
                }
           }
   }
      public  void ChangelightYellow4()
   {
           lightColor[2].color= Color.red;
           lightColor[5].color=Color.red;
           lightColor[8].color=Color.red;
           lightColor[10].color=Color.yellow;
        
           for(int i=0; i<=11;i++)
           {
                if (i!=2&&i!=5&&i!=8&&i!=10)
                {
                        lightColor[i].color=Color.black;
                }
           }
   }
   

     }


