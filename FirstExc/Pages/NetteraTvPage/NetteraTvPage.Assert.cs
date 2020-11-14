using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace BasicProject.Pages.NetteraTvPage
{
   public partial class NetteraTvPage
    {
        public void AssertForCorrectHeaderOfTheMovie()
        {
            Assert.AreEqual(movieTitle, "Съни бийч Сезон 1 Епизод 1");
        }
    }
}
