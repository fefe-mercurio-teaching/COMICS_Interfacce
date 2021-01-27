using System;
namespace COMICS_Interfacce
{
    public interface IConsumable
    {
        bool IsConsumed { get; }

        void Use();
    }
}
