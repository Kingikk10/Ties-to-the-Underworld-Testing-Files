using UnityEngine;
using System.Collections;

public class WarriorClass : MonoBehaviour
{


    public int exp, level;
    int str, dex, vit, mag;
    int HealthPoints, ManaPoints;
    public int basedamage;
    int damageReduction;

 




	// Use this for initialization
	void Start ()
    {
        level = 1;
        exp = 0;

        str = 12;
        dex = 8;
        vit = 10;
        mag = 4;

        HealthPoints = vit * 5;
        ManaPoints = mag * 5;

        basedamage = str / 2;
    }
	
	// Update is called once per frame
	void Update ()
    {
    
        

    }




}
