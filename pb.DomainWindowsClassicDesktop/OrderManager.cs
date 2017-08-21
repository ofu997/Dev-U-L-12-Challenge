using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pb.DomainWindowsClassicDesktop
{
	public class OrderManager
	{
		public static void CreateOrder()
		{
			Persistence.OrderRepository.CreateOrder();
		}
	}
}
