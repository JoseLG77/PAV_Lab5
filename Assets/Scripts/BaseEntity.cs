using UnityEngine;

public enum EntityType
{
    none,
    Personaje,
    Slime
}
public class BaseEntity : MonoBehaviour
{
    private string entityName;
    private int hp;
    private EntityType type = EntityType.none;

    public int Hp => hp;
    public string EntityName => entityName;

    public void SetHp(int _hp)
    {
        hp = _hp;
    }

    public BaseEntity(EntityType _type, string _entityName, int _hp)
    {
        type = _type;
        entityName = _entityName;
        hp = _hp;
    }

    public void ShowBaseEntityInfo()
    {
        Debug.Log($"El {type} de nombre {entityName} tiene {Hp} de vida");
    }
}
