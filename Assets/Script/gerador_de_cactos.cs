using UnityEngine;
using System.Collections;

public class gerador_de_cactos : MonoBehaviour {

    public GameObject cacto1;
    public GameObject cacto2;
    public GameObject cacto3;


    public GameObject player;
    public float tempo;
    public bool teste;

    public GameObject geral;
    public float x;
    public float y;

    public string testando;

    // Use this for initialization
    void Start () {
        teste = true;
        //this.gameObject.GetComponent<SpriteRenderer>().sprite = cacto1;
        x = 0;
        y = 0;
	}
	
	// Update is called once per frame
	void Update () {
        //transform.position = new Vector2 { 0, 0 };
        tempo += Time.deltaTime * 1.5f;
        x += (Time.deltaTime*1.5f)%3;
        y = Mathf.Round( x % 3);

        if (tempo > 20)
        {

            if (teste && y <= 0)
            {
                Instantiate(cacto1, new Vector2(50, -0.6372449f), this.transform.rotation);
				teste = false;
            }else
            {
                if(teste && y <= 1)
                {
                    Instantiate(cacto2, new Vector2(50, -0.6372449f), this.transform.rotation);
					teste = false;
                }else
                {
                    if(teste && y <= 2)
                    {
                        Instantiate(cacto3, new Vector2(50, -0.6372449f), this.transform.rotation);
						teste = false;
                    }
                }
            }

			testando = FindObjectOfType<Cacto>().name;
			//tempo = 0;
			//preFab.transform.position = transform.position;
			geral = GameObject.Find(testando);

            if (!teste)
            {
                if (geral.transform.position.x < player.transform.position.x-5) //LIMITADOR 
                {
                    Destroy(geral);
                    teste = true;
                }
            }
        }
    }
}
