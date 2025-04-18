using UnityEngine;

public enum Emotion
{
    none,
    Feliz,
    Triste,
    Enojado
}

public enum Estado
{
    none,
    Normal,
    Knockback
}

public class Personaje : BaseEntity
{
    private Emotion myEmotion = Emotion.none;
    private Estado myState = Estado.none;
    private bool InKnockback;

    public Emotion MyEmotion => myEmotion;
    public Estado MyState => myState;


    public Personaje(string _entityName) : base(EntityType.Personaje, _entityName, 100)
    {}

    public void SetMyEmotion(Emotion _myEmotion)
    {
        myEmotion = _myEmotion;
    }

    public void SetMyState(Estado _myState)
    {
        myState = _myState;
    }

    public void Talk(string Message)
    {
        Debug.Log($"{Message}");
    }

    public void Talk(string Message, Emotion _myEmotion)
    {
        SetMyEmotion(_myEmotion);
        Debug.Log($"El personaje {EntityName} dijo \"{Message}\" con la emoción de {myEmotion}");
    }

    public void ApllyDamage(int _damage)
    {
        int newHp = Hp - _damage;

        if (newHp < 0)
        {
            newHp = 0;
        }

        if (newHp > 100)
        {
            newHp = 100;
        }

        SetHp(newHp);
    }
    public void CheckNewState()
    {
        if (InKnockback)
        {
            SetMyState(Estado.Knockback);
        }
        else
        {
            SetMyState(Estado.Normal);
        }
    }
    public void ReceiveDamage(int _damage)
    {
        ApllyDamage(_damage);
        Debug.Log($"Jugador \"{EntityName}\" ha recibido {_damage} de daño, su nueva vida es {Hp}");
    }

    public void RecieveDamage(int _damage, int _critRate)
    {
        Debug.Log($"Daño base: {_damage}, probabilidad de crítico: {_critRate}");
        if (Random.Range(0, 101) <= _critRate)
        {
            _damage *= 2;
            Debug.Log($"Ha sido un golpe crítico: Daño x2");
        }
        else 
        {
            Debug.Log($"Ha sido un golpe común: Daño normal");
        }
        switch (Random.Range(0, 2))
        {
            case 0:
                InKnockback = true;
                break;
            case 1:
                InKnockback = false;
                break;
        }
        CheckNewState();
        ApllyDamage(_damage);
        Debug.Log($"Jugador \"{EntityName}\" ha recibido {_damage} de daño, su nueva vida es {Hp} y se le aplica el estado: \"{MyState}\"");
    }
}
