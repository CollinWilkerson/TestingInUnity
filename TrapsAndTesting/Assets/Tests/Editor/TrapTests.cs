using System.Collections;
using NUnit.Framework;
using NSubstitute;
using UnityEngine;

public class TrapTests
{
    Trap trap;

    [SetUp]
    public void SetUp()
    {
        trap = new Trap();
    }

    // A Test behaves as an ordinary method
    [Test]
    public void Player_TrapDealsOneDamageOnPlayerEnter()
    {
        IPlayer player = Substitute.For<IPlayer>();
        int startHealth = player.Health;
        player.IsPlayer().Returns(true);
        trap.HandleCharacterEnter(player, TrapTargetType.Player);

        Assert.AreEqual(startHealth, player.Health + 1);
    }

    [Test]
    public void NPCTrapDealsOneDamageOnNPCEnter()
    {
        IPlayer player = Substitute.For<IPlayer>();
        int startHealth = player.Health;
        trap.HandleCharacterEnter(player, TrapTargetType.Npc);

        Assert.AreEqual(startHealth, player.Health + 1);
    }
}
