using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;

namespace Mvc5UnhandledExceptionTelemetry.Models
{
    public class ContactModels
    {
        public void doSomething()
        {
            try
            {
                doNothing();
            }
            catch (Exception e)
            {
                throw new InvalidDataException("Invalid Data", e);
            }
        }

        private void doNothing()
        {
            int.Parse("thisisntanumber");
        }
    }
}