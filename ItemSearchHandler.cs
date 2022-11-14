
using SmartCart.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiApp1.SearchHandlers
{
    public class ItemSearchHandler: SearchHandler
    {
        public IList<ItemModel> Items { get; set; }
        protected override void OnQueryChanged(string oldValue, string newValue)
        {
            base.OnQueryChanged(oldValue, newValue);

            if (string.IsNullOrWhiteSpace(newValue))
            {
                ItemsSource = null;
            }
            else 
            {
                ItemsSource = Items.Where(items => items.Name.ToLower().Contains(newValue.ToLower())).ToList();    
            }
        }
        protected override void OnItemSelected(object item)
        {
            base.OnItemSelected(item);
        }
    }
}
