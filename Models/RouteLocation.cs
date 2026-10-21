using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AiubBusManagementSystem.Models
{
    internal class RouteLocation
    {
        public int Id { get; set; }

        public int RouteId { get; set; }

        public string LocationName { get; set; }
    }
}
