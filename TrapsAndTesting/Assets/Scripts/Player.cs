using System;
using UnityEngine;

public class Player : MonoBehaviour, IPlayer
{
    public IEquipment weapon { get; set; }
    public IEquipment armor { get; set; }

    private CharacterController character;

    [SerializeField] bool isPlayer;

    public bool IsPlayer()
    {
        return isPlayer;
    }

    private int health = 10;

    public int Health { get; set; }

    private void Awake()
    {
        character = gameObject.GetComponent<CharacterController>();
        weapon = gameObject.GetComponent<Weapon>();
        armor = gameObject.GetComponent<Armor>();
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
}
