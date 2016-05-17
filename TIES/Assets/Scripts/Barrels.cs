using UnityEngine;
using System.Collections;

public class Barrels : MonoBehaviour
{

    public LevelSystem playerLevel;


    private Transform t;
    private Transform player;
    float BarHit;
    int hp;
    int gold;
    int dongers;
    int ArmorValue;
   public WarriorClass warrior;
    
  


    clicktomove click;
    

    private void Awake()
    {
        ArmorValue = 5;
        hp = 100;
        BarHit = 3;
        t = this.transform;
        player = GameObject.FindGameObjectWithTag("Player").transform;
   

    }

    private void Update()
    {
        //if (player)
        //    print(player.name + " is " + Distance().ToString() + " units from " + t.name);

        //else
        //    print("Player not found!");

        // print(BarHit);
        print(hp);


    }
    private float Distance()
    {
        return Vector3.Distance(t.position, player.position);
    }
    void golddrop()
    {
       dongers = Random.Range(1, 5);
        //for(int dongers = Random.Range(1, 5); dongers < 5; dongers++)
        {
            GameObject sphere = GameObject.CreatePrimitive(PrimitiveType.Sphere);

          sphere.transform.position = new Vector3(t.position.x, t.position.y);

        }
       
    }
   
    void OnMouseDown()
    {
        if (Distance() < 3)
        {
            //  click.moveSpeed = 0;
            hp = hp - Mathf.Abs(ArmorValue - (warrior.basedamage + warrior.WeaponDamage));
        }

        if (hp <= 0)
        {
            playerLevel.exp = playerLevel.exp + 200;
            golddrop();
            Destroy(this.gameObject);


        }


    }
}

