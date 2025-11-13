using UnityEngine;

public class TrapBehaviour : MonoBehaviour
{
    private Trap trap;

    private void Awake()
    {
        trap = new Trap();
    }
    private void OnTriggerEnter(Collider other)
    {
        IPlayer player = other.GetComponent<IPlayer>();
        trap.HandleCharacterEnter(player);
    }
}