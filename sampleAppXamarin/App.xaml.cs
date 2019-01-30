using System.Collections.Generic;
using Xamarin.Forms;
using Microsoft.AppCenter;
using Microsoft.AppCenter.Analytics;
using Microsoft.AppCenter.Crashes;

namespace sampleAppXamarin
{
    public partial class App : Application
    {
        public App()
        {
            AppCenter.Start("android=53f8bf66-ac10-4bfc-9f35-f80fd8ed67f7;" +
                   "ios=d9880644-275f-4841-85b2-b01404b23c3e;",
                   typeof(Analytics), typeof(Crashes));
            MainPage = new ButtonPage();
        }
    }
}
