using Model;
using System;

namespace Controller
{
    public class CasalController
    {
        Casal casal = new Casal();

        public CasalController()
        {
            casal.DataInicio = Convert.ToString(DateTime.Today);
        }
    }
}
