using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Portal
{
    class Program
    {
        static void Main(string[] args)
        {
            PortalContext context = new Portal.PortalContext();
            Entities.Province model = new Entities.Province();
            context.Provinces.Add(model);
        }
    }
}
