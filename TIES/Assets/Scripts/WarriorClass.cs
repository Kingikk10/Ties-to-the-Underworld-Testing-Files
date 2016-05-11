using UnityEngine;
using System.Collections;

public class WarriorClass : MonoBehaviour
{


    public int exp, level;
    int str, dex, vit, mag;
    int HealthPoints, ManaPoints;
    public int basedamage;
    public int damageReduction;
    public int WeaponDamage;
 




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
        WeaponDamage = 6; //hard value for testing only, this should come from the weapon tables.
        basedamage = str / 2;
    }
	
	// Update is called once per frame
	void Update ()
    {
    
        

    }




}
