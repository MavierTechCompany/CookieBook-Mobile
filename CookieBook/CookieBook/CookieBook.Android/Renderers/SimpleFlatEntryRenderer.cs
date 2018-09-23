using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.Graphics.Drawables;
using Android.Content.Res;
using Android.Text;
using CookieBook.CustomControl;
using CookieBook.Droid.Renderers;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;

[assembly: ExportRenderer(typeof(SimpleFlatEntry), typeof(SimpleFlatEntryRenderer))]
namespace CookieBook.Droid.Renderers
{
    class SimpleFlatEntryRenderer : EntryRenderer
    {
        public SimpleFlatEntryRenderer(Context context) : base(context) { }

        protected override void OnElementChanged(ElementChangedEventArgs<Entry> e)
        {
            base.OnElementChanged(e);
            GradientDrawable gd = new GradientDrawable();
            gd.SetColor(global::Android.Graphics.Color.Transparent);
            this.Control.SetBackgroundDrawable(gd);
            this.Control.SetRawInputType(InputTypes.TextFlagNoSuggestions);
            //Control.SetHintTextColor(ColorStateList.ValueOf(global::Android.Graphics.Color.White));
        }
    }
}