using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class PlayerControl : MonoBehaviour {
	public float groundForce=50;
	public float moveSpeed;
	public float moveVelocity;
	public float jumpHeight;
	public bool grounded;
	public bool doublejumped;
	public Transform groundEnd;
    public Transform groundEnd1;
    public Transform groundEnd2;
	public float hInput;
	public float vInput;
	public float verticalInput;
	public float horizontalInput;
    float jumpTime, jumpDelay = 0.5f;
    bool jumped;
    public Image buttonUP;
    public Image buttonLEFT;
    public Image buttonRIGHT;
    public Sprite buttonupUp;
    public Sprite buttonupDown;
    public Sprite buttonleftUp;
    public Sprite buttonrightUp;
    public Sprite buttonleftDown;
    public Sprite buttonrightDown;

    Animator anim;
	void Start()
	{
		anim = GetComponent<Animator>();
        transform.localScale = new Vector2(5, 4);
    }

	// Update is called once per frame
	void Update () 
	{

        //Movement ();
        if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.D))
        {
            anim.SetFloat("speed", 1f);

        }
        else
            anim.SetFloat("speed", -1f);

        moveVelocity = 0f;
        if (Input.GetKey(KeyCode.D))
        {

            GetComponent<Rigidbody2D>().velocity = new Vector2(moveSpeed, GetComponent<Rigidbody2D>().velocity.y);
            transform.localScale = new Vector2(5, 4);
            anim.SetFloat("speed", 1f);
        }


        if (Input.GetKey(KeyCode.A))
        {
            GetComponent<Rigidbody2D>().velocity = new Vector2(-moveSpeed, GetComponent<Rigidbody2D>().velocity.y);
            transform.localScale = new Vector2(-5, 4);
            anim.SetFloat("speed", 1f);
        }
        RayCasting ();
		startJumping (vInput);
		startMoving(hInput);
		jump ();
		Move ();



	}

	void RayCasting ()
	{
		Debug.DrawLine(this.transform.position,groundEnd.position,Color.green);
        Debug.DrawLine(this.transform.position, groundEnd1.position, Color.green);
        Debug.DrawLine(this.transform.position, groundEnd2.position, Color.green);

        grounded = Physics2D.Linecast(this.transform.position,groundEnd.position,1<<LayerMask.NameToLayer("Ground"));
        grounded = Physics2D.Linecast(this.transform.position, groundEnd1.position, 1 << LayerMask.NameToLayer("Ground"));
        grounded = Physics2D.Linecast(this.transform.position, groundEnd2.position, 1 << LayerMask.NameToLayer("Ground"));

    }
    public void Move()
	{
		if (hInput == 1 ) {
			GetComponent<Rigidbody2D>().velocity = new Vector2(moveSpeed,GetComponent<Rigidbody2D>().velocity.y);
            transform.localScale = new Vector2(5, 4);
			anim.SetFloat("speed",1f);
            buttonRIGHT.GetComponent<Image>().sprite = buttonrightDown;
        }
        else
            buttonRIGHT.GetComponent<Image>().sprite = buttonrightUp;
		 if (hInput == -1) {
			GetComponent<Rigidbody2D>().velocity = new Vector2(-moveSpeed,GetComponent<Rigidbody2D>().velocity.y);
            transform.localScale = new Vector2(-5, 4);
            anim.SetFloat("speed",1f);
            buttonLEFT.GetComponent<Image>().sprite = buttonleftDown;
        }
         else
            buttonLEFT.GetComponent<Image>().sprite = buttonleftUp;
        if (hInput == 0) {
			
			anim.SetFloat("speed",-1f);
		}

		
		
		//if (vInput==2 && grounded == true) {
		//	GetComponent<Rigidbody2D>().velocity = new Vector2(GetComponent<Rigidbody2D>().velocity.x,jumpHeight);
		//	doublejumped = false;
	//	}
		
		//if (vInput==2 && grounded==false && doublejumped==false) {
		//	GetComponent<Rigidbody2D>().velocity = new Vector2(GetComponent<Rigidbody2D>().velocity.x,jumpHeight);
		//	doublejumped=true;
		//}
	}
	public void jump()
	{
        
		if (grounded) {
			doublejumped=false;
		}
		if (vInput == 2 && grounded) {
            anim.SetTrigger("jump");
            jumped = true;
            jumpTime = jumpDelay;
            jumpMethod ();
            vInput = 1;
		}
    
        jumpTime -= Time.deltaTime;
        if(jumpTime<=0 && grounded && jumped == true)
        {
            anim.SetTrigger("land");

        }
		if (vInput == 2 && !grounded && doublejumped ==false) {
            jumpMethod();
			vInput =1;
			doublejumped = true;
		}
       



    }


	void Movement()
	{	if (Input.GetKey (KeyCode.A) || Input.GetKey (KeyCode.D)) {
		anim.SetFloat("speed",1f);

		}
		else
		anim.SetFloat("speed",-1f);

		moveVelocity = 0f;
		if (Input.GetKey (KeyCode.D)) {

			GetComponent<Rigidbody2D>().velocity = new Vector2(moveSpeed,GetComponent<Rigidbody2D>().velocity.y);
            transform.localScale = new Vector2(5, 5);
            anim.SetFloat("speed", 1f);
        }

		
		if (Input.GetKey (KeyCode.A)) {
			GetComponent<Rigidbody2D>().velocity = new Vector2(-moveSpeed,GetComponent<Rigidbody2D>().velocity.y);
            transform.localScale = new Vector2(-5,5);
            anim.SetFloat("speed", 1f);
        }
		//if ( grounded == true) {
		//	doublejumped = false;
	//	}
		
		
		//if (Input.GetKeyDown(KeyCode.W) && grounded == true) {
		//	GetComponent<Rigidbody2D>().velocity = new Vector2(GetComponent<Rigidbody2D>().velocity.x,jumpHeight);

		//}
		
		//if ((Input.GetKeyDown(KeyCode.W) && grounded==false) && (doublejumped==false)) {
		//	GetComponent<Rigidbody2D>().velocity = new Vector2(GetComponent<Rigidbody2D>().velocity.x,jumpHeight);
		//	doublejumped=true;
		//}

	}

	public void jumpMethod()
	{
		GetComponent<Rigidbody2D>().velocity = new Vector2(GetComponent<Rigidbody2D>().velocity.x,jumpHeight);
	}

public void startMoving(float horizontalInput)
	{
		hInput = horizontalInput;
	}
public void startJumping(float verticalInput)
	{
		vInput = verticalInput;
        if(vInput==2)
        {
            buttonUP.GetComponent<Image>().sprite = buttonupDown;
        }
        else if(vInput<=1)
            buttonUP.GetComponent<Image>().sprite = buttonupUp;

    }

}
