using UnityEngine;
using System.Collections;

public class WeaponPickUp : MonoBehaviour {
    private Transform t;
    private Transform player;
    Inventory inv;
    CreateNewEquipment equip;
    BaseEquipment equipment;
    // Use this for initialization
    void Start () {
        t = this.transform;
        player = GameObject.FindGameObjectWithTag("Player").transform;
        inv = player.GetComponent<Inventory>();
        equipment = player.GetComponent<BaseEquipment>();
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
        inv.AddItem(equipment.itemID);
        Destroy(this.gameObject);

    }
}
