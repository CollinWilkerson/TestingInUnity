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
    }

    [Test]
    public void PlayerEntersWithArmorAndWeaponTakesArmor()
    {

    }

    [Test]
    public void PlayerEntersWithWeaponAndNoArmorTakesWeapon()
    {

    }

    [Test]
    public void PlayerEntersWithNoWeaponAndNoArmorTakesOneDamage()
    {

    }
}
