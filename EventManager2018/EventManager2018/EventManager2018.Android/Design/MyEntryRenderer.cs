using Android.Content;
using Android.Graphics;
using Android.Graphics.Drawables;
using Android.Support.V4.Content;
using Android.Views.InputMethods;
using Android.Widget;
using EventManager2018.Desing;
using EventManager2018.Droid.Design;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;

[assembly: ExportRenderer(typeof(MyEntry), typeof(MyEntryRenderer))]
namespace EventManager2018.Droid.Design
{
    public class MyEntryRenderer : EntryRenderer
    {
        MyEntry element;
        public MyEntryRenderer(Context context)
            : base(context)
        {

        }

        protected override void OnElementChanged(ElementChangedEventArgs<Entry> e)
        {
            base.OnElementChanged(e);

            if (e.OldElement != null || e.NewElement == null)
                return;

            element = (MyEntry)this.Element;

            var editText = this.Control;
            if (!string.IsNullOrEmpty(element.Image))
            {
                switch (element.ImageAlignment)
                {
                    case ImageAlignment.Left:
                        editText.SetCompoundDrawablesWithIntrinsicBounds(GetDrawable(element.Image), null, null, null);
                        break;
                    case ImageAlignment.Right:
                        editText.SetCompoundDrawablesWithIntrinsicBounds(null, null, GetDrawable(element.Image), null);
                        break;
                }
            }
            editText.CompoundDrawablePadding = 25;
            Control.Background.SetColorFilter(element.LineColor.ToAndroid(), PorterDuff.Mode.SrcAtop);

            if (this.Control != null)
            {
                if (element != null)
                {
                    SetReturnType(element);

                    // Editor Action is called when the return button is pressed
                    Control.EditorAction += (object sender, TextView.EditorActionEventArgs args) =>
                    {
                        if (element.ReturnType != EventManager2018.Desing.ReturnType.Next)
                            element.Unfocus();

                        // Call all the methods attached to base_entry event handler Completed
                        element.InvokeCompleted();
                    };
                }
            }
        }

        private BitmapDrawable GetDrawable(string imageEntryImage)
        {
            int resID = Resources.GetIdentifier(imageEntryImage, "drawable", this.Context.PackageName);
            var drawable = ContextCompat.GetDrawable(this.Context, resID);
            var bitmap = ((BitmapDrawable)drawable).Bitmap;

            return new BitmapDrawable(Resources, Bitmap.CreateScaledBitmap(bitmap, element.ImageWidth * 2, element.ImageHeight * 2, true));
        }

        private void SetReturnType(MyEntry entry)
        {
            EventManager2018.Desing.ReturnType type = entry.ReturnType;

            switch (type)
            {
                case EventManager2018.Desing.ReturnType.Go:
                    Control.ImeOptions = ImeAction.Go;
                    Control.SetImeActionLabel("Go", ImeAction.Go);
                    break;
                case EventManager2018.Desing.ReturnType.Next:
                    Control.ImeOptions = ImeAction.Next;
                    Control.SetImeActionLabel("Next", ImeAction.Next);
                    break;
                case EventManager2018.Desing.ReturnType.Send:
                    Control.ImeOptions = ImeAction.Send;
                    Control.SetImeActionLabel("Send", ImeAction.Send);
                    break;
                case EventManager2018.Desing.ReturnType.Search:
                    Control.ImeOptions = ImeAction.Search;
                    Control.SetImeActionLabel("Search", ImeAction.Search);
                    break;
                default:
                    Control.ImeOptions = ImeAction.Done;
                    Control.SetImeActionLabel("Done", ImeAction.Done);
                    break;
            }
        }
    }
}