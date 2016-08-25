using UnityEngine;
using System.Collections;

public class GemController : MonoBehaviour {

    Rigidbody2D myRigidBody;

    bool rotate;
    public float rotationValue;

    public string gemName;

    // Use this for initialization
    void Start () {
        myRigidBody = GetComponent<Rigidbody2D>();
        rotate = false;
    }
	
	// Update is called once per frame
	void Update () {
	
        if(rotate)
        {
            myRigidBody.rotation = rotationValue;
        }

	}

    public void SetSpinAndFall()
    {
        myRigidBody.gravityScale = 0.25f;
        rotate = true;
    }
}
