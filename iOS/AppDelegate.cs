using System;
using System.Collections.Generic;
using System.Linq;

using Foundation;
using Microsoft.AppCenter;
using Microsoft.AppCenter.Analytics;
using Microsoft.AppCenter.Crashes;
using UIKit;

namespace sampleAppXamarin.iOS
{
    [Register("AppDelegate")]
    public partial class AppDelegate : global::Xamarin.Forms.Platform.iOS.FormsApplicationDelegate
    {
        public override bool FinishedLaunching(UIApplication app, NSDictionary options)
        {
            global::Xamarin.Forms.Forms.Init();

            AppCenter.Start("d9880644-275f-4841-85b2-b01404b23c3e",
                   typeof(Analytics), typeof(Crashes));

            LoadApplication(new App());

            #if ENABLE_TEST_CLOUD
            Xamarin.Calabash.Start();
            #endif

			return base.FinishedLaunching(app, options);
        }
    }
}
