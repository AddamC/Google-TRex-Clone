using UnityEngine;
using System.Collections;

public class ground_move2 : MonoBehaviour
{

    public float posMapa;
    public float valor;

    void Start()
    {
        valor = 10;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(posMapa, this.transform.position.y, 0);
        if (posMapa > 0)
        {
            posMapa -= Time.deltaTime*valor;
        }
        else
            posMapa = 12;
        valor += Time.deltaTime*0.10f;
  
    }
}
