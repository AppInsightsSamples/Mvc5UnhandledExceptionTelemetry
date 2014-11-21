using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Mvc5UnhandledExceptionTelemetry.Models
{
    public class AboutModels
    {
        public void saySomething()
        {
            try
            {
                sayNothing();
            }
            catch (Exception e)
            {
                throw new NotFiniteNumberException("not finite number", e);
            }
        }

        private void sayNothing()
        {
            throw new DivideByZeroException();
        }
    }
}