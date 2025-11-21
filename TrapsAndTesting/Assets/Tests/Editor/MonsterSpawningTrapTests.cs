using UnityEngine;
using NUnit.Framework;

public class MonsterSpawningTrapTests
{
    private MonsterSpawningTrap trap;

    [SetUp]
    public void SetUp()
    {
        GameObject go = new GameObject();
        trap = go.AddComponent < MonsterSpawningTrap > ();
        trap.TestSetup(new GameObject().AddComponent<Monster>());
    }

    [Test]
    public void OnTrapSpawnsGameObjectWithMonsterScript()
    {
        trap.OnTrapEnter();
        Assert.IsNotNull(GameObject.FindAnyObjectByType<Monster>());
    }
}
