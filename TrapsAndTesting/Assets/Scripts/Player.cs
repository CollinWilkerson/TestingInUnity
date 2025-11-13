using System;
using UnityEngine;

public class Player : MonoBehaviour, IPlayer
{
    private CharacterController character;
    private int health = 10;
    private void Awake()
    {
        character = gameObject.GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");
        character.Move(new Vector3(horizontal, 0, vertical));
    }
    public void TakeDamage()
    {
        health--;
    }

    public int GetHealth()
    {
        return health;
    }
}
