using System;
using System.Collections.Generic;

namespace COMICS_Interfacce
{
    class Program
    {
        static List<ICollectible> inventory = new List<ICollectible>();

        static void Main(string[] args)
        {
            ItemSword sword = new ItemSword();
            ItemPotion potion = new ItemPotion();

            PickUpItem(sword);
            PickUpItem(potion);

            Equip(sword);

            Attack(sword);
            Use(potion);

            Console.WriteLine($"Hai {inventory.Count} oggetti nell'inventario");
        }

        static void PickUpItem(ICollectible item)
        {
            inventory.Add(item);
            item.PickUp();
        }

        static void DropItem(ICollectible item)
        {
            inventory.Remove(item);
            item.Drop();
        }

        static void Equip(IEquipable equipable)
        {
            equipable.Equip();
        }

        static void Attack(IWeapon weapon)
        {
            if (weapon.IsEquipped)
            {
                Console.WriteLine($"Infliggi {weapon.GetDamage()} danni");
            }
            else
            {
                Console.WriteLine("Devi equipaggiare l'arma per poterla usare");
            }
        }

        static void Use(IConsumable item)
        {
            item.Use();
            if (item.IsConsumed && item is ICollectible)
            {
                inventory.Remove((ICollectible) item);
            }
        }
    }
}
