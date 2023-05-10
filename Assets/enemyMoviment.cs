using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyMoviment : MonoBehaviour
{
    private CharacterController character;
    private Vector3 inputs;
    private Vector3 inputs2;
    private float speed = 4f;
    private float speedFrente = 0.5f;

    void Start()
    {
        character = GetComponent<CharacterController>();
    }

    void Update()
    {
        inputs.Set((Input.GetAxis("Horizontal") * -1), 0, 0);
        character.Move(inputs * Time.deltaTime * speed);

        inputs2.Set(0, 0, -1);
        character.Move(inputs2 * Time.deltaTime * speedFrente);
    }
}
