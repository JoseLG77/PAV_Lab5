using UnityEngine;

public class Slime : BaseEntity
{
    public Slime(string _entityName, int _hp) : base(EntityType.Slime, _entityName, _hp)
    {}

    public Slime(string _entityName, Slime slime1, Slime slime2)
        : base(EntityType.Slime, _entityName, slime1 + slime2)
    {}

    public static int operator +(Slime slime1, Slime slime2)
    {
        return slime1.Hp + slime2.Hp; 
    }
}
