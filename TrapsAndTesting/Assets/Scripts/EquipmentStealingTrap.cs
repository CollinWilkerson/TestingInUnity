using UnityEngine;

public class EquipmentStealingTrap
{
    public void OnTrapEnter(IPlayer player)
    {
        if(player.armor != null)
        {
            player.armor = null;
            return;
        }
        if(player.weapon != null)
        {
            player.weapon = null;
            return;
        }
        player.Health --;
    }
}
