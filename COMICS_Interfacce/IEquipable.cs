using System;
namespace COMICS_Interfacce
{
    public interface IEquipable
    {
        bool IsEquipped { get; }

        void Equip();
        void Unequip();
    }
}
