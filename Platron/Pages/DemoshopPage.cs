using System;

namespace Platron.Pages
{
    public class DemoshopPage : BasePage
    {
        public string ThingsOnMainPage = "//li/a/h2";
        public string InBinOnMainPage = "./ancestor::a//following-sibling::a";
    }
}
