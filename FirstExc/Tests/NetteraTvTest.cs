using BasicProject.Pages.NetteraTvPage;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace BasicProject.Tests
{
    public class NetteraTvTest : BaseTest
    {
        private NetteraTvPage _netera;


        [SetUp]
        public void SetUp()
        {
            Initialize();
            _netera = new NetteraTvPage(Driver);
            Driver.GoToUrl("https://neterra.tv/");
        }
        [Test]
        public void LoadFavouriteMovie()
        {
            _netera.NavigateToNetteraAndPlayMovie();
            _netera.AssertForCorrectHeaderOfTheMovie();
        }
        
    }
}
