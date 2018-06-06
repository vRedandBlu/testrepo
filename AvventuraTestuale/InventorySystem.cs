using System;
using System.Collections.Generic;
using System.Linq;

namespace AvventuraTestuale {
    public class InventorySystem {
        private const int MAXIMUM_SPACES_IN_INVENTORY = 10;

        public InventorySystem() { }
        private readonly List<InventoryRecord> InventoryRecords = new List<InventoryRecord>();
        public void AddItem(ObtainableItem item,int quantityToAdd) {
            if(InventoryRecords.Count < MAXIMUM_SPACES_IN_INVENTORY) {
                InventoryRecords.Add(new InventoryRecord(item,quantityToAdd));
            }
            /*int oggetti_aggiunti = 0;
            while(oggetti_aggiunti < quantityToAdd) {
                if(InventoryRecords.Count < MAXIMUM_SPACES_IN_INVENTORY) {
                    InventoryRecords.Add(new InventoryRecord(item,0));
                    oggetti_aggiunti++;
                } else {
                    throw new Exception("L`inventario è pieno, lascia qualcosa.");
                }
            }*/
        }

        public List<InventoryRecord> getItemList() {
            return InventoryRecords;
        }

        public InventoryRecord getItemRecord(int index) {
            return InventoryRecords.ElementAt(index);
        }

        public class InventoryRecord {
            private ObtainableItem InventoryItem;
            private int Quantity;

            public InventoryRecord(ObtainableItem item,int quantity) {
                InventoryItem = item;
                Quantity = quantity;
            }

            public void AddToQuantity(int amountToAdd) {
                Quantity += amountToAdd;
            }

            public ObtainableItem GetObtainableItem() { return InventoryItem; }
            public int GetQuantity() { return Quantity; }
        }


    }
}