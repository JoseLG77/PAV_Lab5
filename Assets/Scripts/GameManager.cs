using System.Xml.Linq;
using UnityEngine;
using static UnityEditor.Progress;

public class GameManager : MonoBehaviour
{
    public Inventory inventory = new Inventory();

    private Personaje personaje1 = new Personaje("Oscar");
    private Personaje personaje2 = new Personaje("Palomino");
    private Personaje personaje3 = new Personaje("Chiche");

    private static Slime slime1 = new Slime("Slime1", 10);
    private static Slime slime2 = new Slime("Slime2", 20);
    private Slime slime3 = new Slime("Slime3", slime1, slime2);

    void Start()
    {
        Item item1 = new ("Globes"); 
        Item item2 = new (TypeOfItem.Armor, "Armor"); 
        Item item3 = new(TypeOfItem.Consumable, "Potion");
        Item item4 = new (TypeOfItem.Consumable, "Bread"); 
        Item item5 = new (TypeOfItem.Weapon, "Sword"); 

        inventory.Add(item1); 
        inventory.Add(item1,10); 
        inventory.Add(item2); 
        inventory.Add(item3, 5); 
        inventory.Add(item4, 15); 
        inventory.Add(item5, 2); 
        inventory.Add(item4, 15); 
        inventory.Add(item5, 2);

        inventory.ShowAllItems();


        personaje1.Talk("GAAAAAAAAAAA!!!!");
        personaje1.Talk("Estoy feliz", Emotion.Feliz);
        personaje2.Talk("Estoy triste", Emotion.Triste);
        personaje3.Talk("Estoy enojado", Emotion.Enojado);


        personaje1.ReceiveDamage(30);
        personaje1.RecieveDamage((Random.Range(0, 101)), (Random.Range(0, 101)));
        personaje2.RecieveDamage((Random.Range(0, 101)), (Random.Range(0, 101)));
        personaje3.RecieveDamage((Random.Range(0, 101)), (Random.Range(0, 101)));


        slime1.ShowBaseEntityInfo();
        slime2.ShowBaseEntityInfo();
        slime3.ShowBaseEntityInfo();

    }
}
