using Android.Content;
using ExtentionAppTest.Android.CustomRenderers;
using ExtentionAppTest.Rendereres;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;


[assembly: ExportRenderer(typeof(MyEntry), typeof(MyEntryCR))]
namespace ExtentionAppTest.Android.CustomRenderers
{
    public class MyEntryCR : EntryRenderer
    {
        public MyEntryCR(Context context) : base(context)
        {
        }
        protected override void OnElementChanged(ElementChangedEventArgs<Entry> e)
        {
            base.OnElementChanged(e);
            e.NewElement.BackgroundColor = Color.Beige;
        }
    }
}