using UnityEngine;
using System.Collections;

public class Barrels : MonoBehaviour  {


    private Transform t;
    private Transform player;
    float BarHit;
    float hp;
    

    WarriorClass warrior;
    GameObject go = GameObject.FindGameObjectWithTag("Player");

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
            hp -= 10; //warrior.basedamage;
        }
       
        if (hp <= 0)
        {
            
            go.GetComponent<clicktomove>().warData.exp += 40;
            Destroy(this.gameObject);
        }
   
    
    }





}