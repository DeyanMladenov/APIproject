using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace BasicProject.Pages.DemoQApaga
{
    public partial class DemoQApaga
    {
        public void ConfirmGreenColorIsDisplayed()
        {
           
            Assert.IsTrue(GreenColor.Displayed);
        }
    }
}
