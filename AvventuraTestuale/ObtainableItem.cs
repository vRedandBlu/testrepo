using System;

namespace AvventuraTestuale
{
    public abstract class ObtainableItem
    {
        public Guid ID { get; set; }
        public string Name { get; set; }
        public int MaximumStackableQuantity { get; set; }

        protected ObtainableItem()
        {
            MaximumStackableQuantity = 1;
        }
    }
}