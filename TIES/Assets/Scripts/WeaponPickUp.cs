using UnityEngine;
using System.Collections;

public class WeaponPickUp : MonoBehaviour {
    private Transform t;
    private Transform player;
    Inventory inv;
    CreateNewWeapon weap;
    BaseWeapon newWeapon;
    // Use this for initialization
    void Start () {
        t = this.transform;
        player = GameObject.FindGameObjectWithTag("Player").transform;
        inv = player.GetComponent<Inventory>();
    }
	
	// Update is called once per frame
	void Update () {
	
	}
    public float Distance()
    {
        return Vector3.Distance(t.position, player.position);
    }
    void OnMouseDown()
    {
        
            inv.AddItem(newWeapon.ItemID);

        
       
            Destroy(this.gameObject);
        


    }
}
