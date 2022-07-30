using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class secondday : MonoBehaviour
{
string HeroName = "Goku ";
float superherohight = 1.75f;
int age = 50;
int herosuperpower =100;

string VillainName = "Aizen ";
int vililanHeight = 186;
int VillainAge = 45;
string power = "None";
 






    // Start is called before the first frame update
    void Start()
   {
    print("hero name is " + HeroName + " his age is " + age + " he is so fast hes movement speed is " + herosuperpower);
    print("the villain is " + VillainName + " his age is " +  VillainAge + " and he can " +power + " himself and use it to be criminal ");
    print(power);
    print ("true super hero hight" +(superherohight + 5));
    print("ageDifference is " + (age - VillainAge));
    
    

   }
        
    }

