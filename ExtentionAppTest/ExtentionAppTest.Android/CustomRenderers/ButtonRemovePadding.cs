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
using Color1 = Android.Graphics;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;

using ExtentionAppTest.Renderers;
using ExtentionAppTest.Android.CustomRenderers;

[assembly: ExportRenderer(typeof(ButtonRemovePaddingCR), typeof(ButtonRemovePadding))]
namespace ExtentionAppTest.Android.CustomRenderers
{
    class ButtonRemovePadding : ButtonRenderer
    {
        public ButtonRemovePadding(Context context) : base(context)
        { }

        public Xamarin.Forms.Thickness _padding { get; set; }
        protected override void OnElementChanged(ElementChangedEventArgs<Xamarin.Forms.Button> e)
        {
            base.OnElementChanged(e);
         
            if (Control != null)
            {
                var button = Control;

                //_padding = new Thickness() { Left = 0, Top = 0, Right = 0, Bottom = 0 };
                //button.SetPadding((int)_padding.Left, (int)_padding.Top, (int)_padding.Right, (int)_padding.Bottom);
                button.SetBackgroundColor(Color1.Color.ParseColor("#EFAA42"));
                
                button.SetPadding(40, Control.PaddingTop, 0, Control.PaddingBottom);



            }
        }
    }
}