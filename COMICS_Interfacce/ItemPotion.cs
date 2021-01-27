using System;
namespace COMICS_Interfacce
{
    public class ItemPotion : ICollectible, IConsumable
    {
        int charges = 1;

        public void PickUp()
        {
            Console.WriteLine("Hai raccolto una pozione");
        }

        public void Drop()
        {
            Console.WriteLine("Hai lasciato la pozione");
        }

        public void Use()
        {
            Console.WriteLine("Hai bevuto la pozione");
            charges--;
        }

        public bool IsConsumed => charges <= 0;

        /*public bool IsConsumed
        {
            get
            {
                return charged <= 0;
            }
        }*/
    }
}
