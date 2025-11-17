using UnityEngine;

public class Weapon : MonoBehaviour, IEquipment
{
    public string getEquipmentName()
    {
        return "Excalibur";
    }
}
