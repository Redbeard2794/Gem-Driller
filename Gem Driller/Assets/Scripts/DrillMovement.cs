using UnityEngine;
using System.Collections;

public class DrillMovement : MonoBehaviour {

    public float speed;

    float moveVelocity;

    Rigidbody2D myRigidBody;

    enum Bullets
    {
        AMBER,
        AMETHYST,
        EMERALD,
        OBSIDIAN,
        RUBY,
        SAPPHIRE
    }
    int currentBulletType;

    public GameObject amberBullet;
    public GameObject amethystBullet;
    public GameObject emeraldBullet;
    public GameObject obsidianBullet;
    public GameObject rubyBullet;
    public GameObject sapphireBullet;

	// Use this for initialization
	void Start () {
        currentBulletType = (int)Bullets.AMBER;
        myRigidBody = GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void Update () {

        moveVelocity = 0;

        //move right
        if(Input.GetKey(KeyCode.D))
        {
            moveVelocity = speed;
        }
        //move left
        else if(Input.GetKey(KeyCode.A))
        {
            moveVelocity = -speed;
        }

        myRigidBody.velocity = new Vector2(moveVelocity, myRigidBody.velocity.y);

        //change current bullet
        if(Input.GetKeyDown(KeyCode.RightBracket))
        {
            Debug.Log("Bullet before: " + currentBulletType);
            if (currentBulletType < 5)
                currentBulletType += 1;
            else currentBulletType = 0;
            Debug.Log("Bullet after: " + currentBulletType);
        }
        else if (Input.GetKeyDown(KeyCode.LeftBracket))
        {
            Debug.Log("Bullet before: " + currentBulletType);
            if (currentBulletType > 0)
                currentBulletType -= 1;
            else currentBulletType = 5;
            Debug.Log("Bullet after: " + currentBulletType);
        }

        //FIRE!
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Fire();
        }

	}

    void Fire()
    {
        if (currentBulletType == (int)Bullets.AMBER)
        {
            Instantiate(amberBullet, new Vector3(transform.position.x, transform.position.y + 0.5f, transform.position.z), transform.rotation);
        }
        else if (currentBulletType == (int)Bullets.AMETHYST)
        {
            Instantiate(amethystBullet, new Vector3(transform.position.x, transform.position.y + 0.5f, transform.position.z), transform.rotation);
        }
        else if (currentBulletType == (int)Bullets.EMERALD)
        {
            Instantiate(emeraldBullet, new Vector3(transform.position.x, transform.position.y + 0.5f, transform.position.z), transform.rotation);
        }
        else if (currentBulletType == (int)Bullets.OBSIDIAN)
        {
            Instantiate(obsidianBullet, new Vector3(transform.position.x, transform.position.y + 0.5f, transform.position.z), transform.rotation);
        }
        else if (currentBulletType == (int)Bullets.RUBY)
        {
            Instantiate(rubyBullet, new Vector3(transform.position.x, transform.position.y + 0.5f, transform.position.z), transform.rotation);
        }
        else if (currentBulletType == (int)Bullets.SAPPHIRE)
        {
            Instantiate(sapphireBullet, new Vector3(transform.position.x, transform.position.y + 0.5f, transform.position.z), transform.rotation);
        }
    }
}
