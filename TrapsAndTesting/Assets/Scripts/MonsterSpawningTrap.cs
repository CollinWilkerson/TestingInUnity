using UnityEngine;

public class MonsterSpawningTrap : MonoBehaviour
{
    [SerializeField] Monster MonsterObject;
    public void OnTrapEnter()
    {
        Instantiate(MonsterObject.gameObject, transform);
    }

    public void TestSetup(Monster monsterObject)
    {
        MonsterObject = monsterObject;
    }
}
