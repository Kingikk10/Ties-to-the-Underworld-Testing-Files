using UnityEngine;
using System.Collections;

public class Barrels : MonoBehaviour  {


    private Transform t;
    private Transform player;
    float BarHit;
    float hp;

  

   // GameObject go = GameObject.FindGameObjectWithTag("Player");


    clicktomove click;
    

    private void Awake()
    {
       
        hp = 100;
        BarHit = 3;
        t = this.transform;
        player = GameObject.FindGameObjectWithTag("Player").transform;
    
    }

    private void Update()
    {
        if (player)
            print(player.name + " is " + Distance().ToString() + " units from " + t.name);

        else
            print("Player not found!");

        print(BarHit);
        print(hp);
      //  print(go.GetComponent<PlayerClass>().warriorData.exp);
    }

    private float Distance()
    {
        return Vector3.Distance(t.position, player.position);
    }



    //void OnMouseDown()
    //{
    //    if (Distance() < 3)
    //    {
    //        Destroy(this.gameObject);

    //    }
    //}
   
    void OnMouseDown()
    {
        if (Distance() < 3)
        {
          //  click.moveSpeed = 0;
            hp -= 10; //warrior.basedamage;
        }
       
        if (hp <= 0)
        {
          // go.warriorclass.exp += 40; 
         // go.GetComponent<PlayerClass>().warriorData.exp += 40;
            Destroy(this.gameObject);
        }
   
    
    }





}