using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class playerMoviment : MonoBehaviour
{

    private CharacterController character;
    private Vector3 inputs;
    private float speed = 4f;
    public Bullet bullet;
    private float intervaloTiro;
    private int qtdBullet = 15;
    public TextMeshProUGUI textQtdBullet;

    
    void Start()
    {
        character = GetComponent<CharacterController>();
        this.intervaloTiro = 0;
        GameObject textObject = GameObject.FindWithTag("Text");
        if (textObject != null)
        {
            textQtdBullet = textObject.GetComponent<TextMeshProUGUI>();
            textQtdBullet.text = "Quantidade de Balas: " + qtdBullet.ToString();
        }
    }

    
    void Update()
    {
        inputs.Set(Input.GetAxis("Horizontal"), 0, 0);
        character.Move(inputs * Time.deltaTime * speed);

        this.intervaloTiro += Time.deltaTime;
        if(this.intervaloTiro >= 0.50f){
            this.intervaloTiro = 0;
            if(Input.GetMouseButton(0) && qtdBullet > 0){
                Gun();
                qtdBullet--;
                textQtdBullet.text = "Quantidade de Balas: " + qtdBullet.ToString();
            }
            if(Input.GetMouseButton(0) && qtdBullet <= 0){
                textQtdBullet.text = "GAME OVER! ";
            }
        }
    }

    private void Gun() {
    Vector3 rotacaoDesejada = new Vector3(0, 90, 90);

    Quaternion rotacao = Quaternion.Euler(rotacaoDesejada);

    Instantiate(this.bullet, this.transform.position, rotacao);
}
}
