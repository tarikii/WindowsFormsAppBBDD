using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsAppBBDD
{
    public class ComboBoxItem
    {
        private int? value;
        private string text;

        public int? Value { get => value; set => this.value = value; }
        public string Text { get => text; set => text = value; }

        public ComboBoxItem(int? value, string text)
        {
            this.value = value;
            this.text = text;
        }
    }
}
