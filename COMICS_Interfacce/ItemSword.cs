using System;
namespace COMICS_Interfacce
{
    public class ItemSword : ICollectible, IWeapon
    {
        bool equipped = false;

        public void Equip()
        {
            equipped = true;
            Console.WriteLine("Hai impugnato la spada");
        }

        public void Unequip() => equipped = false;
        public bool IsEquipped => equipped;


        public void PickUp()
        {
            Console.WriteLine("Hai raccolto la spada");
        }

        void ICollectible.Drop()
        {
            Console.WriteLine("Hai lasciato la spada");
        }

        public int GetDamage() => 5;
    }
}
