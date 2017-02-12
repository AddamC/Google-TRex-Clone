using UnityEngine;
using System.Collections;

public class ground_move : MonoBehaviour {

    public float posMapa;
    public float valor;
    
    
    void Start()
    {
        valor = 10;
    }
    
    // Update is called once per frame
	void Update () {
        transform.position = new Vector3 (posMapa, this.transform.position.y, 0 );
        if (posMapa > -12)
        {
            posMapa -= Time.deltaTime*valor;
        }
        else
            posMapa = 0;
        valor += Time.deltaTime * 0.10f;
    }
}
