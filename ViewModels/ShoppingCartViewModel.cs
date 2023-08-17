using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using WaxLoversOnline.Models;

namespace WaxLoversOnline.ViewModels
{
    public class ShoppingCartViewModel
    {
        [Key]
        public int ID { get; set; }
        public List<Cart> CartItems { get; set; }
        public decimal CartTotal { get; set; }
    }
}