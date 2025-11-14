using UnityEngine;

public class TrapBehaviour : MonoBehaviour
{
    [SerializeField] private TrapTargetType trapType;

    private Trap trap;

    private void Awake()
    {
        trap = new Trap();
    }
    private void OnTriggerEnter(Collider other)
    {
        IPlayer player = other.GetComponent<IPlayer>();
        trap.HandleCharacterEnter(player, trapType);
    }
}

public enum TrapTargetType { Player, Npc}