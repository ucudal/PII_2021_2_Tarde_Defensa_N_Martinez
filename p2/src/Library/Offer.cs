using System;
using System.Text;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace Ucu.Poo.Defense
{
    public class Offer
    {
        public DateTime EndDate { get; set; }

        public IReadOnlyCollection<OfferItem> Items
        {
            get
            {
                return new ReadOnlyCollection<OfferItem>(this.items);
            }
        }

        private IList<OfferItem> items = new List<OfferItem>();

        public Offer(DateTime endDate)
        {
            this.EndDate = endDate;
        }

        public void AddItem(OfferItem item)
        {
            this.items.Add(item);
        }

        public void RemoveItem(OfferItem item)
        {
            this.items.Remove(item);
        }

        public string AsText()
        {
            StringBuilder str = new StringBuilder();
            str.Append($"{this.EndDate}\n");
            foreach (OfferItem item in this.Items)
            {
                str.Append($"{item.Quantity} de {item.Residue.Name} a ${item.Price}\n");
            }
            return str.ToString();
        }
    }
}