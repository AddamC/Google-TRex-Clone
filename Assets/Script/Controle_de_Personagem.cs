using UnityEngine;
using System.Collections;


public class Controle_de_Personagem : MonoBehaviour {

    public float alturaPulo;
    private Rigidbody2D corpo;
    public bool chao;
    public GameObject gameOver;
	public Animator anim;
    public AudioSource puloFX;

    
    //public Pontuacao pontuacao;

    // Use this for initialization
    void Start () {
        corpo = GetComponent<Rigidbody2D>();
        chao = true;
        //pontuacao = FindObjectOfType<Pontuacao>();
        
        //objects = FindObjectsOfType(typeof(GameObject));
    }

    //void FixedUpdate()
    //{
    //    isGrounded = Physics2D.OverlapCircle(groundCheck.position, groundCheckRadius, whatIsGround);
    //    if (isGrounded)
    //        playerAnim.SetBool("isJumping", false);
    //}

    // Update is called once per frame
    

	void Update ()
    {
    
		anim.SetBool ("Run", true);

            if (Input.GetKey(KeyCode.Space) && chao)
            {
                pulo();
            }



            if (!chao && Input.GetKey(KeyCode.S))
            {
                corpo.gravityScale = 10;
            }
            // Debug.Log(Time.timeScale);

        
    }

    void OnCollisionEnter2D(Collision2D other)
    {
        if(other.gameObject.tag == "chao")
        {
            chao = true;

        }
        if(other.gameObject.tag == "Cacto")
        {
            
            gameOver.SetActive(true);
			anim.SetBool ("isDead", true);
            //foreach (GameObject jogo in objects)
          //  {
           //     jogo.SendMessage("OnPauseGame", SendMessageOptions.DontRequireReceiver);
          //  }

            Time.timeScale = 0.0f;
            //Debug.Log("Bateu!!!");
            
        }
    }

    //função para pular
    void pulo()
    {
        puloFX.Stop();
        puloFX.Play();
		anim.SetBool ("Run", false);
        corpo.gravityScale = 3;
        corpo.velocity = new Vector2(corpo.velocity.x, alturaPulo);
        chao = false;
    }

}
