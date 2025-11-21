using NUnit.Framework;
using NSubstitute;

public class EquipmentStealingTrapTests
{
    EquipmentStealingTrap trap;

    [SetUp]
    public void SetUp()
    {
        trap = new EquipmentStealingTrap();
    }

    [Test]
    public void PlayerEntersWithArmorAndNoWeaponTakesArmor()
    {
        IPlayer player = Substitute.For<IPlayer>();
        player.armor = new Armor();
        trap.OnTrapEnter(player);
        Assert.IsNull(player.armor);
    }

    [Test]
    public void PlayerEntersWithArmorAndWeaponTakesArmor()
    {
        IPlayer player = Substitute.For<IPlayer>();
        player.armor = new Armor();
        player.weapon = new Weapon();
        trap.OnTrapEnter(player);
        Assert.IsNull(player.armor);
    }

    [Test]
    public void PlayerEntersWithWeaponAndNoArmorTakesWeapon()
    {
        IPlayer player = Substitute.For<IPlayer>();
        player.armor = null;
        player.weapon = new Weapon();
        trap.OnTrapEnter(player);
        Assert.IsNull(player.weapon);
    }

    [Test]
    public void PlayerEntersWithNoWeaponAndNoArmorTakesOneDamage()
    {
        IPlayer player = Substitute.For<IPlayer>();
        player.armor = null;
        player.weapon = null;
        int startHealth = player.Health;
        trap.OnTrapEnter(player);
        Assert.That(player.Health, Is.EqualTo(startHealth - 1));
    }
}
