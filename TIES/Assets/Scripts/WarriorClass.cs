using UnityEngine;
using System.Collections;

public class WarriorClass : MonoBehaviour
{


    public int exp, level;
  public int str, dex, vit, mag;
    int HealthPoints, ManaPoints;
    public int basedamage;
    public int damageReduction;
    public int WeaponDamage;

    public bool StatsMenu = false;

    public int statpoints;

    float sw;
    float sh;

    // Use this for initialization
    void Start ()
    {
        level = 1;
        exp = 0;

        str = 12;
        dex = 8;
        vit = 10;
        mag = 4;
        StatsMenu = false;

      
        WeaponDamage = 6; //hard value for testing only, this should come from the weapon tables.
    
    }
	
	// Update is called once per frame
	void Update ()
    {

        if (Input.GetKeyUp(KeyCode.K))
        {
            if (!StatsMenu)
            {
                StatsMenu = true;
            }
            else
            {
                StatsMenu = false;
                Time.timeScale = 1;
            }
        }

        HealthPoints = vit * 5;
        ManaPoints = mag * 5;
        basedamage = str / 2;


    }
    void OnGUI()
    {
        GUI.Button(new Rect(0, 575, 150, 50), "Health:" + HealthPoints);
        GUI.Button(new Rect(1000, 575, 100, 50), "Mana:" + ManaPoints);
        //on top right side have a button to show main menu toggle 
        if (GUI.Button(new Rect(1060, 0, 40, 40), "S:" + statpoints))
        {
            if (!StatsMenu)
            {
                StatsMenu = true;
                Time.timeScale = 0;
            }
            else
            {
                StatsMenu = false;
                Time.timeScale = 1;
            }
        }

        if (StatsMenu)
        {
            //resume button
            if (GUI.Button(new Rect(450, 200, 200, 50), "Stregth:" + str))
            {
                if (statpoints > 0)
                {
                    statpoints = statpoints - 1;
                    str = str + 1;
                }

            }
            //Exit to Menu button
            if (GUI.Button(new Rect(450, 260, 200, 50), "Dex:" + dex))
            {
                if (statpoints > 0)
                {
                    statpoints = statpoints - 1;
                    dex = dex + 1;
                }
            }
            //Quit button
            if (GUI.Button(new Rect(450, 320, 200, 50), "Vit:" + vit))
            {
                if (statpoints > 0)
                {
                    statpoints = statpoints - 1;
                    vit = vit + 1;
                }
            }
            if (GUI.Button(new Rect(450, 380, 200, 50), "Mag:" + mag))
            {
                if (statpoints > 0)
                {
                    statpoints = statpoints - 1;
                    mag = mag + 1;
                }
            }
        }
    }



}
