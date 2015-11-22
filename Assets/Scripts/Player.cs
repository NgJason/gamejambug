using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour
{
	public Transform playerSprite;
    CharacterController c;
    public float moveSpeed = 1;
    private Vector3 pos;

    public HealthSystem healthBar;
    // Use this for initialization

    void Start()
    {
        c = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        Move();
		Face();

    }

	void Face(){





		if (Input.GetAxis ("Horizontal") > 0 && Input.GetAxis ("Vertical") > 0) {
			//faceing right
			//playerSprite.eulerAngles = new Vector3(0,90,0);
			//playerSprite.rotation = transform.right;
			playerSprite.rotation = Quaternion.Euler(90, -135, 0);
			//playerSprite.eulerAngles= transform.right;
		}else if (Input.GetAxis ("Horizontal") > 0 && Input.GetAxis ("Vertical") < 0) {
			//faceing right
			//playerSprite.eulerAngles = new Vector3(0,90,0);
			//playerSprite.rotation = transform.right;
			playerSprite.rotation = Quaternion.Euler(90, 135, 0);
			//playerSprite.eulerAngles= transform.right;
		}else if (Input.GetAxis ("Horizontal") < 0 && Input.GetAxis ("Vertical") < 0) {
			//faceing right
			//playerSprite.eulerAngles = new Vector3(0,90,0);
			//playerSprite.rotation = transform.right;
			playerSprite.rotation = Quaternion.Euler(90, 45, 0);
			//playerSprite.eulerAngles= transform.right;
		}else if (Input.GetAxis ("Horizontal") < 0 && Input.GetAxis ("Vertical") > 0) {
			//faceing right
			//playerSprite.eulerAngles = new Vector3(0,90,0);
			//playerSprite.rotation = transform.right;
			playerSprite.rotation = Quaternion.Euler(90, -45, 0);
			//playerSprite.eulerAngles= transform.right;
		}else if (Input.GetAxis ("Horizontal") < 0) {
			//faceing right
			//playerSprite.eulerAngles = new Vector3(0,90,0);
			//playerSprite.rotation = transform.right;
			playerSprite.rotation = Quaternion.Euler(90, 90, 0);
			//playerSprite.eulerAngles= transform.right;
		}else if (Input.GetAxis ("Horizontal") > 0) {
			//faceing right
			//playerSprite.eulerAngles = new Vector3(0,90,0);
			//playerSprite.rotation = transform.right;
			playerSprite.rotation = Quaternion.Euler(90, 270, 0);
			//playerSprite.eulerAngles= transform.right;
		}else if (Input.GetAxis ("Vertical") > 0) {
			//faceing right
			//playerSprite.eulerAngles = new Vector3(0,90,0);
			//playerSprite.rotation = transform.right;
			playerSprite.rotation = Quaternion.Euler(90, 180, 0);
			//playerSprite.eulerAngles= transform.right;
		}else if (Input.GetAxis ("Vertical") < 0) {
			//faceing right
			//playerSprite.eulerAngles = new Vector3(0,90,0);
			//playerSprite.rotation = transform.right;
			playerSprite.rotation = Quaternion.Euler(90, 0, 0);
			//playerSprite.eulerAngles= transform.right;
		}
	}

    void Move()
    {
        pos = Vector3.zero;
		pos = new Vector3(-Input.GetAxis("Horizontal"), 0, -Input.GetAxis("Vertical"));
        pos = transform.TransformDirection(pos);
        pos *= moveSpeed;

        c.Move(pos * Time.deltaTime);
    }

    //public void OnCollisionEnter(Collision col)
    //{
    //    if (col.gameObject.tag == "Enemy")
    //    {
    //        healthBar.DecreaseHealth(10);
    //    }
    //}
}
