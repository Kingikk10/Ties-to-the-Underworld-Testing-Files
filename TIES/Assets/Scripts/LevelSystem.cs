using UnityEngine;
using System.Collections;

public class LevelSystem : MonoBehaviour {

    //We need 100 exp to level

    public int level;
    public int exp;
    
	void Start ()
    {
	
	}
	
	// Update is called once per frame
	void Update ()
    {
        LevelUp();
	}

    void LevelUp()
    {
        if(exp >= 100)
        {
            level = level + 1;
            exp = 0;
        }
    }
}
