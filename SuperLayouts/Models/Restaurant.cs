using System;
namespace SuperLayouts.Models
{
	public class Restaurant
	{
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string Image { get; set; }
        public long DeliveryPrice { get; set; }
        public string DeliveryTime { get; set; }
    }
}

