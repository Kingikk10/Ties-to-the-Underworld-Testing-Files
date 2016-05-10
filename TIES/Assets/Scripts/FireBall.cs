using UnityEngine;
using System.Collections;

public class FireBall : MonoBehaviour {

    private Transform myTransform;              // this transform
    private Vector3 destinationPosition;        // The destination Point
    private float destinationDistance;


   
    float spawnDistance = 10;









    // Use this for initialization
    void Start ()
    {
        myTransform = transform;
        destinationPosition = myTransform.position;

    }
	
	// Update is called once per frame
	void Update ()
    {
        destinationDistance = Vector3.Distance(destinationPosition, myTransform.position);






        if (Input.GetMouseButtonDown(1) && GUIUtility.hotControl == 0)
        {
            GameObject sphere = GameObject.CreatePrimitive(PrimitiveType.Sphere);

            sphere.transform.position = new Vector3(myTransform.position.x, myTransform.position.y);
            Plane playerPlane = new Plane(Vector3.up, myTransform.position);
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            float hitdist = 0.0f;

            if (playerPlane.Raycast(ray, out hitdist))
            {
                Vector3 targetPoint = ray.GetPoint(hitdist);
                destinationPosition = ray.GetPoint(hitdist);
                Quaternion targetRotation = Quaternion.LookRotation(targetPoint - transform.position);
                myTransform.rotation = targetRotation;
            }
        }
    }
}
