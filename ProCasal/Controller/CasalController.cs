using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controller
{
    public class CasalController
    {
        Casal casal = new Casal();

        public CasalController()
        {
            casal.DataInicio = DateTime.Today;
        }
    }
}
