using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace addressbood_white
{
    public class HelperBase
    {
        protected ApplicationManager manager;
        protected string WINTITLE;

        public HelperBase(ApplicationManager manager)
        {
            this.manager = manager;
            //this.aux = manager.Aux;
            WINTITLE = ApplicationManager.WINTITLE;
        }
    }
}