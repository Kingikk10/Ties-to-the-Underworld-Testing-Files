using UnityEngine;
using System.Collections;

public class clicktomove : MonoBehaviour {
    private Transform myTransform;              // this transform
    private Vector3 destinationPosition;        // The destination Point
    private float destinationDistance;          // The distance between myTransform and destinationPosition

    public float moveSpeed;





    // Use this for initialization
    void Start ()
    {
        myTransform = transform;
        destinationPosition = myTransform.position;
	}

    // Update is called once per frame
    void Update()
    {
        destinationDistance = Vector3.Distance(destinationPosition, myTransform.position);
        if (destinationDistance < .5f)
        {       // To prevent shakin behavior when near destination
            moveSpeed = 0;
        }
        else if (destinationDistance > .5f)
        {           // To Reset Speed to default
            moveSpeed = 3;
        }

        if(Input.GetKey(KeyCode.LeftShift) )
        {
            moveSpeed = 6;
        }

        // Moves the Player if the Left Mouse Button was clicked
        if (Input.GetMouseButtonDown(0) && GUIUtility.hotControl == 0)
        {

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

        // Moves the player if the mouse button is hold down
        else if (Input.GetMouseButton(0) && GUIUtility.hotControl == 0)
        {

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
            //	myTransform.position = Vector3.MoveTowards(myTransform.position, destinationPosition, moveSpeed * Time.deltaTime);
        }

        // To prevent code from running if not needed
        if (destinationDistance > .5f)
        {
            myTransform.position = Vector3.MoveTowards(myTransform.position, destinationPosition, moveSpeed * Time.deltaTime);
        }
    }
}

    