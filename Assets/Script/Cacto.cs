using UnityEngine;
using System.Collections;


public class Cacto : MonoBehaviour {



    public float posCacto;
    public GameObject player;
    public float valor;

	// Use this for initialization
	void Start () {
        // teste = true;
        posCacto = Random.Range(10, 25);
        valor = FindObjectOfType<ground_move2>().valor;
    }
	
	// Update is called once per frame
	void Update () {

            posCacto -= Time.deltaTime*valor;
        
        //if(valor < 20) //Limite de velocidade
		valor += Time.deltaTime * 0.10f;
        transform.position = new Vector3(posCacto, transform.position.y, 0);
    }
}
