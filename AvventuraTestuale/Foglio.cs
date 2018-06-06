using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AvventuraTestuale {
    public class Foglio : ObtainableItem {
        private string content;

        public Foglio() {
            MaximumStackableQuantity = 1;
            content = "Non ci sta scritto ancora niente.";
        }

        public Foglio(string content) {
            MaximumStackableQuantity = 1;
            this.content = content;
        }



        public string leggi() {
            return content;
        }
    }
}
