using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;


public class Bullet : MonoBehaviour
{
    public float velocidade = 12f;
    public float tempoVida = 4f;
    public Vector3 direcao = Vector3.forward;
    public int hits = 0;
    //public TextMeshProUGUI textTela;
    //public string win = "YOU WIN!";
    

    private void Start()
    {
        GetComponent<Rigidbody>().velocity = direcao.normalized * velocidade;
        Destroy(gameObject, tempoVida);
        //textTela.text = "";
    }

    void OnCollisionEnter(Collision other) {
        if (other.gameObject.CompareTag("Enemy")) {
            Destroy(other.gameObject);
            Destroy(gameObject); 

            //hits++;
            //Debug.Log("hits: " + hits);
        }


        /*if (hits == 9)
        {
            textTela.text = win;
            Debug.Log("hits: " + hits);

        }*/

    }
}
