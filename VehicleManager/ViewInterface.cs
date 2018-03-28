using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleManager
{
	public interface ViewInterface
	{
		void Add(Vehicle vehicle);
		void Remove(Vehicle vehicle);
		void Edit(Vehicle vehicle);
		void Refresh(List<Vehicle> vehicles);
	}
}
