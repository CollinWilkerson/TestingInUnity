using System.Collections;
using NUnit.Framework;
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
    public void TrapDealsOneDamageOnEnter()
    {
        IPlayer player = new Player();
        int startHealth = player.GetHealth();
        trap.HandleCharacterEnter(player);

        Assert.AreEqual(startHealth, player.GetHealth() - 1);
    }
}
