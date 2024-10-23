namespace FantasyRPG.ItemCreator.Models;

public abstract class Item
{
    private static int nextId = 1;
    
    public int Id { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public RarityEnum Rarity { get; set; }
    
    



    public enum RarityEnum
    {
        Common,
        Magic,
        Rare,
        Legendary
    }

    public enum WeaponTypeEnum
    {
        Melee,
        Ranged
    }
}