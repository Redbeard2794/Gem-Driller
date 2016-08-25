using UnityEngine;
using System.Collections;

public class BulletControl : MonoBehaviour
{
    //determines which gems the bullet can collide with
    public string bulletType;
    //determines how fast the bullet will travel
    public float speed;

	// Use this for initialization
	void Start ()
    {
	
	}
	
	// Update is called once per frame
	void Update ()
    {
        transform.position = new Vector2(transform.position.x, transform.position.y + (speed * Time.deltaTime));
	}

    void OnCollisionEnter2D(Collision2D collidee)
    {
        Debug.Log(collidee.gameObject.tag);

        //check that the bullet hit a gem
        if (collidee.gameObject.tag == "Gem")
        {
            //check that gem type matches bullet type
            //sapphire
            if(bulletType == "sapphire" && collidee.gameObject.GetComponent<GemController>().gemName == "sapphire")
            {
                Debug.Log("Sapphire bullet collided with a Sapphire gem");
                collidee.gameObject.GetComponent<GemController>().SetSpinAndFall();
            }
            //ruby
            else if (bulletType == "ruby" && collidee.gameObject.GetComponent<GemController>().gemName == "ruby")
            {
                Debug.Log("Ruby bullet collided with a Ruby gem");
                collidee.gameObject.GetComponent<GemController>().SetSpinAndFall();
            }
            //obsidian
            else if (bulletType == "obsidian" && collidee.gameObject.GetComponent<GemController>().gemName == "obsidian")
            {
                Debug.Log("Obsidian bullet collided with a Obsidian gem");
                collidee.gameObject.GetComponent<GemController>().SetSpinAndFall();
            }
            //emerald
            else if (bulletType == "emerald" && collidee.gameObject.GetComponent<GemController>().gemName == "emerald")
            {
                Debug.Log("Emerald bullet collided with a Emerald gem");
                collidee.gameObject.GetComponent<GemController>().SetSpinAndFall();
            }
            //amethyst
            else if (bulletType == "amethyst" && collidee.gameObject.GetComponent<GemController>().gemName == "amethyst")
            {
                Debug.Log("Amethyst bullet collided with a Amethyst gem");
                collidee.gameObject.GetComponent<GemController>().SetSpinAndFall();
            }
            //amber
            else if (bulletType == "amber" && collidee.gameObject.GetComponent<GemController>().gemName == "amber")
            {
                Debug.Log("Amber bullet collided with a Amber gem");
                collidee.gameObject.GetComponent<GemController>().SetSpinAndFall();
            }
            //didn't hit correct gem
            else
            {
                Debug.Log(bulletType + " bullet didn't hit a " + bulletType + " gem");
            }
        }

        Destroy(gameObject);//maybe mark for destruction instead and do something cool before destroying it?
    }

}
