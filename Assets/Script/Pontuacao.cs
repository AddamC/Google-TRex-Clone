using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Pontuacao : MonoBehaviour {

    public float maiorPonto;
    public float pontoAtual;
    public Text texto;
    private float inicioTempo;

	// Use this for initialization
	void Start () {
        texto = GetComponent<Text>();
        inicioTempo = 0;
        maiorPonto = PlayerPrefs.GetInt("maiorPonto");
	}

	
	// Update is called once per frame
	void Update () {
        inicioTempo += Time.deltaTime * 10;
        //arredondar para a string de pontuação
        pontoAtual = Mathf.Round(inicioTempo);
        if (pontoAtual > maiorPonto)
        {
            maiorPonto = pontoAtual;
            PlayerPrefs.SetInt("maiorPonto", (int)maiorPonto);
        }
        texto.text = "" + maiorPonto + "      " + pontoAtual;
        //if (Input.GetKeyDown(KeyCode.Escape)){
        //    PlayerPrefs.SetInt("maiorPonto", 0);
        //    Application.Quit();

        //}
    }

    void OnApplicationQuit()
    {
        PlayerPrefs.SetInt("maiorPonto", 0);
    }
}
