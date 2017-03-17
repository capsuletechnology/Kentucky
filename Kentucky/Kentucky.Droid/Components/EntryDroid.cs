using System;
using System.ComponentModel;
using Android.Graphics;
using Android.Graphics.Drawables;
using Android.Graphics.Drawables.Shapes;
using Android.Text;
using Android.Text.Method;
using Android.Util;
using Android.Views;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;
using Kentucky.Helper;
using Kentucky.Droid.Components;
using Color = Xamarin.Forms.Color;

[assembly: ExportRenderer(typeof(xEntry), typeof(EntryDroid))]
namespace Kentucky.Droid.Components
{
    public class EntryDroid : EntryRenderer
    {
        private const int MinDistance = 10;

        private float downX, downY, upX, upY;

        private Drawable originalBackground;

        /// <summary>
        /// Called when [element changed].
        /// </summary>
        /// <param name="e">The e.</param>

        protected override void OnElementChanged(ElementChangedEventArgs<Entry> e)
        {
            base.OnElementChanged(e);

            var view = (xEntry)Element;

            if (Control != null && e.NewElement != null && e.NewElement.IsPassword)
            {
                Control.SetTypeface(Typeface.Default, TypefaceStyle.Normal);
                Control.TransformationMethod = new PasswordTransformationMethod();
            }

            if (originalBackground == null)
                originalBackground = Control.Background;

            SetFont(view);
            SetTextAlignment(view);
            //SetBorder(view);
            SetPlaceholderTextColor(view);
            SetMaxLength(view);

            if (e.NewElement == null)
            {
                this.Touch -= HandleTouch;
            }

            if (e.OldElement == null)
            {
                this.Touch += HandleTouch;
            }
        }

        /// <summary>
        /// Handles the touch.
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="Android.Views.View.TouchEventArgs"/> instance containing the event data.</param>
        void HandleTouch(object sender, TouchEventArgs e)
        {
            var element = (xEntry)this.Element;
            switch (e.Event.Action)
            {
                case MotionEventActions.Down:
                    this.downX = e.Event.GetX();
                    this.downY = e.Event.GetY();
                    return;
                case MotionEventActions.Up:
                case MotionEventActions.Cancel:
                case MotionEventActions.Move:
                    this.upX = e.Event.GetX();
                    this.upY = e.Event.GetY();

                    float deltaX = this.downX - this.upX;
                    float deltaY = this.downY - this.upY;

                    // swipe horizontal?
                    if (Math.Abs(deltaX) > Math.Abs(deltaY))
                    {
                        if (Math.Abs(deltaX) > MinDistance)
                        {
                            if (deltaX < 0)
                            {
                                element.RightSwipe(this, EventArgs.Empty);
                                return;
                            }

                            if (deltaX > 0)
                            {
                                element.LeftSwipe(this, EventArgs.Empty);
                                return;
                            }
                        }
                        else
                        {
                            Log.Info("ExtendedEntry", "Horizontal Swipe was only " + Math.Abs(deltaX) + " long, need at least " + MinDistance);
                            return; // We don't consume the event
                        }
                    }
                    // swipe vertical?
                    //                    else 
                    //                    {
                    //                        if(Math.abs(deltaY) > MIN_DISTANCE){
                    //                            // top or down
                    //                            if(deltaY < 0) { this.onDownSwipe(); return true; }
                    //                            if(deltaY > 0) { this.onUpSwipe(); return true; }
                    //                        }
                    //                        else {
                    //                            Log.i(logTag, "Vertical Swipe was only " + Math.abs(deltaX) + " long, need at least " + MIN_DISTANCE);
                    //                            return false; // We don't consume the event
                    //                        }
                    //                    }

                    return;
            }
        }

        /// <summary>
        /// Handles the <see cref="E:ElementPropertyChanged" /> event.
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="System.ComponentModel.PropertyChangedEventArgs"/> instance containing the event data.</param>
        /// public static readonly BindableProperty BorderColorProperty =
        protected override void OnElementPropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            if (Control != null)
            {
                var customColor = Xamarin.Forms.Color.FromHex("#FFFFFF");
                Control.Background.SetColorFilter(customColor.ToAndroid(), PorterDuff.Mode.SrcAtop);


            }

            var view = (xEntry)Element;

            if (e.PropertyName == xEntry.FontProperty.PropertyName)
            {
                SetFont(view);
            }
            else if (e.PropertyName == xEntry.XAlignProperty.PropertyName)
            {
                SetTextAlignment(view);
            }
            else if (e.PropertyName == xEntry.HasBorderProperty.PropertyName)
            {
                
            }
            else if (e.PropertyName == xEntry.PlaceholderTextColorProperty.PropertyName)
            {
                SetPlaceholderTextColor(view);
            }
            else
            {
                base.OnElementPropertyChanged(sender, e);
                if (e.PropertyName == VisualElement.BackgroundColorProperty.PropertyName)
                {
                    this.Control.SetBackgroundColor(view.BackgroundColor.ToAndroid());
                }
            }
        }

        ///// <summary>
        ///// Sets the border.
        ///// </summary>
        ///// <param name="view">The view.</param>
        private void SetBorder(xEntry view)
        {
            if (view.HasBorder == false)
            {
                var shape = new ShapeDrawable(new RectShape());
                shape.Paint.Alpha = 0;
                shape.Paint.SetStyle(Paint.Style.Stroke);
                Control.SetBackgroundDrawable(shape);
            }
            else
            {
                Control.SetBackground(originalBackground);
            }
        }

        /// <summary>
        /// Sets the text alignment.
        /// </summary>
        /// <param name="view">The view.</param>
        private void SetTextAlignment(xEntry view)
        {
            switch (view.XAlign)
            {
                case Xamarin.Forms.TextAlignment.Center:
                    Control.Gravity = GravityFlags.CenterHorizontal;
                    break;
                case Xamarin.Forms.TextAlignment.End:
                    Control.Gravity = GravityFlags.End;
                    break;
                case Xamarin.Forms.TextAlignment.Start:
                    Control.Gravity = GravityFlags.Start;
                    break;
            }
        }

        /// <summary>
        /// Sets the font.
        /// </summary>
        /// <param name="view">The view.</param>
        private void SetFont(xEntry view)
        {
            if (view.Font != Font.Default)
            {
                Control.TextSize = view.Font.ToScaledPixel();
            }
        }

        /// <summary>
        /// Sets the color of the placeholder text.
        /// </summary>
        /// <param name="view">The view.</param>
        private void SetPlaceholderTextColor(xEntry view)
        {
            if (view.PlaceholderTextColor != Color.Default)
            {
                Control.SetHintTextColor(view.PlaceholderTextColor.ToAndroid());
            }
        }

        /// <summary>
        /// Sets the MaxLength characteres.
        /// </summary>
        /// <param name="view">The view.</param>
        private void SetMaxLength(xEntry view)
        {
            Control.SetFilters(new IInputFilter[] { new InputFilterLengthFilter(view.MaxLength) });
        }

    }
}