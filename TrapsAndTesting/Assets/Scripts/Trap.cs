public class Trap
{
    public void HandleCharacterEnter(IPlayer player, TrapTargetType trapType)
    {
        if (player.IsPlayer())
        {
            if (trapType == TrapTargetType.Player)
            {
                player.Health--;
            }
            return;
        }
        if(trapType == TrapTargetType.Npc)
        {
            player.Health--;
        }
    }
}
