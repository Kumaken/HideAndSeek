#region Assembly PresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// C:\Program Files (x86)\Reference Assemblies\Microsoft\Framework\.NETFramework\v4.0\PresentationCore.dll
#endregion

using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime;
using System.Windows.Automation.Peers;
using System.Windows.Input;
using System.Windows.Input.StylusPlugIns;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Effects;
using MS.Internal;
using MS.Internal.PresentationCore;

namespace System.Windows
{
    //
    // Summary:
    //     System.Windows.UIElement is a base class for WPF core level implementations building
    //     on Windows Presentation Foundation (WPF) elements and basic presentation characteristics.
    [UidProperty("Uid")]
    public class UIElement : Visual, IAnimatable, IInputElement
    {
        //
        // Summary:
        //     Identifies the System.Windows.UIElement.PreviewMouseDown routed event.
        //
        // Returns:
        //     The identifier for the System.Windows.UIElement.PreviewMouseDown routed event.
        public static readonly RoutedEvent PreviewMouseDownEvent;
        //
        // Summary:
        //     Identifies the System.Windows.UIElement.AreAnyTouchesOver dependency property.
        //
        // Returns:
        //     The identifier for the System.Windows.UIElement.AreAnyTouchesOver dependency
        //     property.
        public static readonly DependencyProperty AreAnyTouchesOverProperty;
        //
        // Summary:
        //     Identifies the System.Windows.UIElement.AreAnyTouchesDirectlyOver dependency
        //     property.
        //
        // Returns:
        //     The identifier for the System.Windows.UIElement.AreAnyTouchesDirectlyOver dependency
        //     property.
        public static readonly DependencyProperty AreAnyTouchesDirectlyOverProperty;
        //
        // Summary:
        //     Identifies the System.Windows.UIElement.IsKeyboardFocused dependency property.
        //
        // Returns:
        //     The identifier for the System.Windows.UIElement.IsKeyboardFocused dependency
        //     property.
        public static readonly DependencyProperty IsKeyboardFocusedProperty;
        //
        // Summary:
        //     Identifies the System.Windows.UIElement.IsStylusCaptureWithin dependency property.
        //
        // Returns:
        //     The identifier for the System.Windows.UIElement.IsStylusCaptureWithin dependency
        //     property.
        public static readonly DependencyProperty IsStylusCaptureWithinProperty;
        //
        // Summary:
        //     Identifies the System.Windows.UIElement.IsStylusCaptured dependency property.
        //
        // Returns:
        //     The identifier for the System.Windows.UIElement.IsStylusCaptured dependency property.
        public static readonly DependencyProperty IsStylusCapturedProperty;
        //
        // Summary:
        //     Identifies the System.Windows.UIElement.IsMouseCaptureWithin dependency property.
        //
        // Returns:
        //     The identifier for the System.Windows.UIElement.IsMouseCaptureWithin dependency
        //     property.
        public static readonly DependencyProperty IsMouseCaptureWithinProperty;
        //
        // Summary:
        //     Identifies the System.Windows.UIElement.IsMouseCaptured dependency property.
        //
        // Returns:
        //     The identifier for the System.Windows.UIElement.IsMouseCaptured dependency property.
        public static readonly DependencyProperty IsMouseCapturedProperty;
        //
        // Summary:
        //     Identifies the System.Windows.UIElement.IsKeyboardFocusWithin dependency property.
        //
        // Returns:
        //     The System.Windows.UIElement.IsKeyboardFocusWithin dependency property identifier.
        public static readonly DependencyProperty IsKeyboardFocusWithinProperty;
        //
        // Summary:
        //     Identifies the System.Windows.UIElement.IsStylusOver dependency property.
        //
        // Returns:
        //     The System.Windows.UIElement.IsStylusOver dependency property identifier.
        public static readonly DependencyProperty IsStylusOverProperty;
        //
        // Summary:
        //     Identifies the System.Windows.UIElement.IsMouseOver dependency property.
        //
        // Returns:
        //     The System.Windows.UIElement.IsMouseOver dependency property identifier.
        public static readonly DependencyProperty IsMouseOverProperty;
        //
        // Summary:
        //     Identifies the System.Windows.UIElement.IsMouseDirectlyOver dependency property.
        //
        // Returns:
        //     The identifier for the System.Windows.UIElement.IsMouseDirectlyOver dependency
        //     property.
        public static readonly DependencyProperty IsMouseDirectlyOverProperty;
        //
        // Summary:
        //     Identifies the System.Windows.UIElement.TouchLeave routed event.
        //
        // Returns:
        //     The identifier for the System.Windows.UIElement.TouchLeave routed event.
        public static readonly RoutedEvent TouchLeaveEvent;
        //
        // Summary:
        //     Identifies the System.Windows.UIElement.TouchEnter routed event.
        //
        // Returns:
        //     The identifier for the System.Windows.UIElement.TouchEnter routed event.
        public static readonly RoutedEvent TouchEnterEvent;
        //
        // Summary:
        //     Identifies the System.Windows.UIElement.LostTouchCapture routed event.
        //
        // Returns:
        //     The identifier for the System.Windows.UIElement.LostTouchCapture routed event.
        public static readonly RoutedEvent LostTouchCaptureEvent;
        //
        // Summary:
        //     Identifies the System.Windows.UIElement.GotTouchCapture routed event.
        //
        // Returns:
        //     The identifier for the System.Windows.UIElement.GotTouchCapture routed event.
        public static readonly RoutedEvent GotTouchCaptureEvent;
        //
        // Summary:
        //     Identifies the System.Windows.UIElement.TouchUp routed event.
        //
        // Returns:
        //     The identifier for the System.Windows.UIElement.TouchUp routed event.
        public static readonly RoutedEvent TouchUpEvent;
        //
        // Summary:
        //     Identifies the System.Windows.UIElement.PreviewTouchUp routed event.
        //
        // Returns:
        //     The identifier for the System.Windows.UIElement.PreviewTouchUp routed event.
        public static readonly RoutedEvent PreviewTouchUpEvent;
        //
        // Summary:
        //     Identifies the System.Windows.UIElement.TouchMove routed event.
        //
        // Returns:
        //     The identifier for the System.Windows.UIElement.TouchMove routed event.
        public static readonly RoutedEvent TouchMoveEvent;
        //
        // Summary:
        //     Identifies the System.Windows.UIElement.PreviewTouchMove routed event.
        //
        // Returns:
        //     The identifier for the System.Windows.UIElement.PreviewTouchMove routed event.
        public static readonly RoutedEvent PreviewTouchMoveEvent;
        //
        // Summary:
        //     Identifies the System.Windows.UIElement.TouchDown routed event.
        //
        // Returns:
        //     The identifier for the System.Windows.UIElement.TouchDown routed event.
        public static readonly RoutedEvent TouchDownEvent;
        //
        // Summary:
        //     Identifies the System.Windows.UIElement.PreviewTouchDown routed event.
        //
        // Returns:
        //     The identifier for the System.Windows.UIElement.PreviewTouchDown routed event.
        public static readonly RoutedEvent PreviewTouchDownEvent;
        //
        // Summary:
        //     Identifies the System.Windows.UIElement.Drop routed event.
        //
        // Returns:
        //     The identifier for the System.Windows.UIElement.Drop routed event.
        public static readonly RoutedEvent DropEvent;
        //
        // Summary:
        //     Identifies the System.Windows.UIElement.PreviewDrop routed event.
        //
        // Returns:
        //     The identifier for the System.Windows.UIElement.PreviewDrop routed event.
        public static readonly RoutedEvent PreviewDropEvent;
        //
        // Summary:
        //     Identifies the System.Windows.UIElement.DragLeave routed event.
        //
        // Returns:
        //     The identifier for the System.Windows.UIElement.DragLeave routed event.
        public static readonly RoutedEvent DragLeaveEvent;
        //
        // Summary:
        //     Identifies the System.Windows.UIElement.PreviewDragLeave routed event.
        //
        // Returns:
        //     The identifier for the System.Windows.UIElement.PreviewDragLeave routed event.
        public static readonly RoutedEvent PreviewDragLeaveEvent;
        //
        // Summary:
        //     Identifies the System.Windows.UIElement.AreAnyTouchesCaptured dependency property.
        //
        // Returns:
        //     The identifier for the System.Windows.UIElement.AreAnyTouchesCaptured dependency
        //     property.
        public static readonly DependencyProperty AreAnyTouchesCapturedProperty;
        //
        // Summary:
        //     Identifies the System.Windows.UIElement.AreAnyTouchesCapturedWithin dependency
        //     property.
        //
        // Returns:
        //     The identifier for the System.Windows.UIElement.AreAnyTouchesCapturedWithin dependency
        //     property.
        public static readonly DependencyProperty AreAnyTouchesCapturedWithinProperty;
        //
        // Summary:
        //     Identifies the System.Windows.UIElement.AllowDrop dependency property.
        //
        // Returns:
        //     The identifier for the System.Windows.UIElement.AllowDrop dependency property.
        public static readonly DependencyProperty AllowDropProperty;
        //
        // Summary:
        //     Identifies the System.Windows.UIElement.RenderTransform dependency property.
        //
        // Returns:
        //     The identifier for the System.Windows.UIElement.RenderTransform dependency property.
        [CommonDependencyPropertyAttribute]
        public static readonly DependencyProperty RenderTransformProperty;
        //
        // Summary:
        //     Identifies the System.Windows.UIElement.ManipulationCompleted routed event.
        //
        // Returns:
        //     The identifier for the System.Windows.UIElement.ManipulationCompleted routed
        //     event.
        public static readonly RoutedEvent ManipulationCompletedEvent;
        //
        // Summary:
        //     Identifies the System.Windows.UIElement.ManipulationBoundaryFeedback event.
        public static readonly RoutedEvent ManipulationBoundaryFeedbackEvent;
        //
        // Summary:
        //     Identifies the System.Windows.UIElement.ManipulationInertiaStarting routed event.
        //
        // Returns:
        //     The identifier for the System.Windows.UIElement.ManipulationInertiaStarting routed
        //     event.
        public static readonly RoutedEvent ManipulationInertiaStartingEvent;
        //
        // Summary:
        //     Identifies the System.Windows.UIElement.ManipulationDelta routed event.
        //
        // Returns:
        //     The identifier for the System.Windows.UIElement.ManipulationDelta routed event.
        public static readonly RoutedEvent ManipulationDeltaEvent;
        //
        // Summary:
        //     Identifies the System.Windows.UIElement.ManipulationStarted routed event.
        //
        // Returns:
        //     The identifier for the System.Windows.UIElement.ManipulationStarted routed event.
        public static readonly RoutedEvent ManipulationStartedEvent;
        //
        // Summary:
        //     Identifies the System.Windows.UIElement.ManipulationStarting routed event.
        //
        // Returns:
        //     The identifier for the System.Windows.UIElement.ManipulationStarting routed event.
        public static readonly RoutedEvent ManipulationStartingEvent;
        //
        // Summary:
        //     Identifies the System.Windows.UIElement.IsManipulationEnabled dependency property.
        //
        // Returns:
        //     The identifier for the System.Windows.UIElement.IsManipulationEnabled dependency
        //     property.
        public static readonly DependencyProperty IsManipulationEnabledProperty;
        //
        // Summary:
        //     Identifies the System.Windows.UIElement.Focusable dependency property.
        //
        // Returns:
        //     The identifier for the System.Windows.UIElement.Focusable dependency property.
        [CommonDependencyPropertyAttribute]
        public static readonly DependencyProperty FocusableProperty;
        //
        // Summary:
        //     Identifies the System.Windows.UIElement.IsVisible dependency property.
        //
        // Returns:
        //     The System.Windows.UIElement.IsVisible dependency property identifier.
        public static readonly DependencyProperty IsVisibleProperty;
        //
        // Summary:
        //     Identifies the System.Windows.UIElement.IsHitTestVisible dependency property.
        //
        // Returns:
        //     The System.Windows.UIElement.IsHitTestVisible dependency property identifier.
        public static readonly DependencyProperty IsHitTestVisibleProperty;
        //
        // Summary:
        //     Identifies the System.Windows.UIElement.IsEnabled dependency property.
        //
        // Returns:
        //     The identifier for the System.Windows.UIElement.IsEnabled dependency property.
        [CommonDependencyPropertyAttribute]
        public static readonly DependencyProperty IsEnabledProperty;
        //
        // Summary:
        //     Identifies the System.Windows.UIElement.IsFocused dependency property.
        //
        // Returns:
        //     The System.Windows.UIElement.IsFocused dependency property identifier.
        public static readonly DependencyProperty IsFocusedProperty;
        //
        // Summary:
        //     Identifies the System.Windows.UIElement.DragOver routed event.
        //
        // Returns:
        //     The identifier for the System.Windows.UIElement.DragOver routed event.
        public static readonly RoutedEvent DragOverEvent;
        //
        // Summary:
        //     Identifies the System.Windows.UIElement.LostFocus routed event.
        //
        // Returns:
        //     The identifier for the System.Windows.UIElement.LostFocus routed event.
        public static readonly RoutedEvent LostFocusEvent;
        //
        // Summary:
        //     Identifies the System.Windows.UIElement.SnapsToDevicePixels dependency property.
        //
        // Returns:
        //     The System.Windows.UIElement.SnapsToDevicePixels dependency property identifier.
        public static readonly DependencyProperty SnapsToDevicePixelsProperty;
        //
        // Summary:
        //     Identifies the System.Windows.UIElement.Clip dependency property.
        //
        // Returns:
        //     The identifier for the System.Windows.UIElement.Clip dependency property.
        public static readonly DependencyProperty ClipProperty;
        //
        // Summary:
        //     Identifies the System.Windows.UIElement.ClipToBounds dependency property.
        //
        // Returns:
        //     The identifier for the System.Windows.UIElement.ClipToBounds dependency property.
        [CommonDependencyPropertyAttribute]
        public static readonly DependencyProperty ClipToBoundsProperty;
        //
        // Summary:
        //     Identifies the System.Windows.UIElement.Visibility dependency property.
        //
        // Returns:
        //     The identifier for the System.Windows.UIElement.Visibility dependency property.
        [CommonDependencyPropertyAttribute]
        public static readonly DependencyProperty VisibilityProperty;
        //
        // Summary:
        //     Identifies the System.Windows.UIElement.Uid dependency property.
        //
        // Returns:
        //     The identifier for the System.Windows.UIElement.Uid dependency property.
        public static readonly DependencyProperty UidProperty;
        //
        // Summary:
        //     Identifies the System.Windows.UIElement.CacheMode dependency property.
        //
        // Returns:
        //     The identifier for the System.Windows.UIElement.CacheMode dependency property.
        public static readonly DependencyProperty CacheModeProperty;
        //
        // Summary:
        //     Identifies the System.Windows.UIElement.BitmapEffectInput dependency property.
        //
        // Returns:
        //     The System.Windows.UIElement.BitmapEffectInput dependency property identifier.
        public static readonly DependencyProperty BitmapEffectInputProperty;
        //
        // Summary:
        //     Identifies the System.Windows.UIElement.Effect dependency property.
        //
        // Returns:
        //     The identifier for the System.Windows.UIElement.Effect dependency property.
        public static readonly DependencyProperty EffectProperty;
        //
        // Summary:
        //     Identifies the System.Windows.UIElement.BitmapEffect dependency property.
        //
        // Returns:
        //     The System.Windows.UIElement.BitmapEffect dependency property identifier.
        public static readonly DependencyProperty BitmapEffectProperty;
        //
        // Summary:
        //     Identifies the System.Windows.UIElement.OpacityMask dependency property.
        //
        // Returns:
        //     The identifier for the System.Windows.UIElement.OpacityMask dependency property.
        public static readonly DependencyProperty OpacityMaskProperty;
        //
        // Summary:
        //     Identifies the System.Windows.UIElement.Opacity dependency property.
        //
        // Returns:
        //     The identifier for the System.Windows.UIElement.Opacity dependency property.
        public static readonly DependencyProperty OpacityProperty;
        //
        // Summary:
        //     Identifies the System.Windows.UIElement.RenderTransformOrigin dependency property.
        //
        // Returns:
        //     The System.Windows.UIElement.RenderTransformOrigin dependency property identifier.
        public static readonly DependencyProperty RenderTransformOriginProperty;
        //
        // Summary:
        //     Identifies the System.Windows.UIElement.GotFocus routed event.
        //
        // Returns:
        //     The identifier for the System.Windows.UIElement.GotFocus routed event.
        public static readonly RoutedEvent GotFocusEvent;
        //
        // Summary:
        //     Identifies the System.Windows.UIElement.PreviewDragOver routed event.
        //
        // Returns:
        //     The identifier for the System.Windows.UIElement.PreviewDragOver routed event.
        public static readonly RoutedEvent PreviewDragOverEvent;
        //
        // Summary:
        //     Identifies the System.Windows.UIElement.IsStylusDirectlyOver dependency property.
        //
        // Returns:
        //     The identifier for the System.Windows.UIElement.IsStylusDirectlyOver dependency
        //     property.
        public static readonly DependencyProperty IsStylusDirectlyOverProperty;
        //
        // Summary:
        //     Identifies the System.Windows.UIElement.PreviewDragEnter routed event.
        //
        // Returns:
        //     The identifier for the System.Windows.UIElement.PreviewDragEnter routed event.
        public static readonly RoutedEvent PreviewDragEnterEvent;
        //
        // Summary:
        //     Identifies the System.Windows.UIElement.StylusMove routed event.
        //
        // Returns:
        //     The identifier for the System.Windows.UIElement.StylusMove routed event.
        public static readonly RoutedEvent StylusMoveEvent;
        //
        // Summary:
        //     Identifies the System.Windows.UIElement.PreviewStylusMove routed event.
        //
        // Returns:
        //     The identifier for the System.Windows.UIElement.PreviewStylusMove routed event.
        public static readonly RoutedEvent PreviewStylusMoveEvent;
        //
        // Summary:
        //     Identifies the System.Windows.UIElement.StylusUp routed event.
        //
        // Returns:
        //     The identifier for the System.Windows.UIElement.StylusUp routed event.
        public static readonly RoutedEvent StylusUpEvent;
        //
        // Summary:
        //     Identifies the System.Windows.UIElement.PreviewStylusUp routed event.
        //
        // Returns:
        //     The identifier for the System.Windows.UIElement.PreviewStylusUp routed event.
        public static readonly RoutedEvent PreviewStylusUpEvent;
        //
        // Summary:
        //     Identifies the System.Windows.UIElement.StylusDown routed event.
        //
        // Returns:
        //     The identifier for the System.Windows.UIElement.StylusDown routed event.
        public static readonly RoutedEvent StylusDownEvent;
        //
        // Summary:
        //     Identifies the System.Windows.UIElement.PreviewStylusDown routed event.
        //
        // Returns:
        //     The identifier for the System.Windows.UIElement.PreviewStylusDown routed event.
        public static readonly RoutedEvent PreviewStylusDownEvent;
        //
        // Summary:
        //     Identifies the System.Windows.UIElement.QueryCursor routed event.
        //
        // Returns:
        //     The identifier for the System.Windows.UIElement.QueryCursor routed event.
        public static readonly RoutedEvent QueryCursorEvent;
        //
        // Summary:
        //     Identifies the System.Windows.UIElement.LostMouseCapture routed event.
        //
        // Returns:
        //     The identifier for the System.Windows.UIElement.LostMouseCapture routed event.
        public static readonly RoutedEvent LostMouseCaptureEvent;
        //
        // Summary:
        //     Identifies the System.Windows.UIElement.GotMouseCapture routed event.
        //
        // Returns:
        //     The identifier for the System.Windows.UIElement.GotMouseCapture routed event.
        public static readonly RoutedEvent GotMouseCaptureEvent;
        //
        // Summary:
        //     Identifies the System.Windows.UIElement.MouseLeave routed event.
        //
        // Returns:
        //     The identifier for the System.Windows.UIElement.MouseLeave routed event.
        public static readonly RoutedEvent MouseLeaveEvent;
        //
        // Summary:
        //     Identifies the System.Windows.UIElement.MouseEnter routed event.
        //
        // Returns:
        //     The identifier for the System.Windows.UIElement.MouseEnter routed event.
        public static readonly RoutedEvent MouseEnterEvent;
        //
        // Summary:
        //     Identifies the System.Windows.UIElement.MouseWheel routed event.
        //
        // Returns:
        //     The identifier for the System.Windows.UIElement.MouseWheel routed event.
        public static readonly RoutedEvent MouseWheelEvent;
        //
        // Summary:
        //     Identifies the System.Windows.UIElement.PreviewStylusInAirMove routed event.
        //
        // Returns:
        //     The identifier for the System.Windows.UIElement.PreviewStylusInAirMove routed
        //     event.
        public static readonly RoutedEvent PreviewStylusInAirMoveEvent;
        //
        // Summary:
        //     Identifies the System.Windows.UIElement.PreviewMouseWheel routed event.
        //
        // Returns:
        //     The identifier for the System.Windows.UIElement.PreviewMouseWheel routed event.
        public static readonly RoutedEvent PreviewMouseWheelEvent;
        //
        // Summary:
        //     Identifies the System.Windows.UIElement.PreviewMouseMove routed event.
        //
        // Returns:
        //     The identifier for the System.Windows.UIElement.PreviewMouseMove routed event.
        public static readonly RoutedEvent PreviewMouseMoveEvent;
        //
        // Summary:
        //     Identifies the System.Windows.UIElement.MouseRightButtonUp routed event.
        //
        // Returns:
        //     The identifier for the System.Windows.UIElement.MouseRightButtonUp routed event.
        public static readonly RoutedEvent MouseRightButtonUpEvent;
        //
        // Summary:
        //     Identifies the System.Windows.UIElement.PreviewMouseRightButtonUp routed event.
        //
        // Returns:
        //     The identifier for the System.Windows.UIElement.PreviewMouseRightButtonUp routed
        //     event.
        public static readonly RoutedEvent PreviewMouseRightButtonUpEvent;
        //
        // Summary:
        //     Identifies the System.Windows.UIElement.MouseRightButtonDown routed event.
        //
        // Returns:
        //     The identifier for the System.Windows.UIElement.MouseRightButtonDown routed event.
        public static readonly RoutedEvent MouseRightButtonDownEvent;
        //
        // Summary:
        //     Identifies the System.Windows.UIElement.PreviewMouseRightButtonDown routed event.
        //
        // Returns:
        //     The identifier for the System.Windows.UIElement.PreviewMouseRightButtonDown routed
        //     event.
        public static readonly RoutedEvent PreviewMouseRightButtonDownEvent;
        //
        // Summary:
        //     Identifies the System.Windows.UIElement.DragEnter routed event.
        //
        // Returns:
        //     The identifier for the System.Windows.UIElement.DragEnter routed event.
        public static readonly RoutedEvent DragEnterEvent;
        //
        // Summary:
        //     Identifies the System.Windows.UIElement.PreviewMouseLeftButtonUp routed event.
        //
        // Returns:
        //     The identifier for the System.Windows.UIElement.PreviewMouseLeftButtonUp routed
        //     event.
        public static readonly RoutedEvent PreviewMouseLeftButtonUpEvent;
        //
        // Summary:
        //     Identifies the System.Windows.UIElement.MouseLeftButtonDown routed event.
        //
        // Returns:
        //     The identifier for the System.Windows.UIElement.MouseLeftButtonDown routed event.
        public static readonly RoutedEvent MouseLeftButtonDownEvent;
        //
        // Summary:
        //     Identifies the System.Windows.UIElement.PreviewMouseLeftButtonDown routed event.
        //
        // Returns:
        //     The identifier for the System.Windows.UIElement.PreviewMouseLeftButtonDown routed
        //     event.
        public static readonly RoutedEvent PreviewMouseLeftButtonDownEvent;
        //
        // Summary:
        //     Identifies the System.Windows.UIElement.MouseUp routed event.
        //
        // Returns:
        //     The identifier for the System.Windows.UIElement.MouseUp routed event.
        public static readonly RoutedEvent MouseUpEvent;
        //
        // Summary:
        //     Identifies the System.Windows.UIElement.PreviewMouseUp routed event.
        //
        // Returns:
        //     The identifier for the System.Windows.UIElement.PreviewMouseUp routed event.
        public static readonly RoutedEvent PreviewMouseUpEvent;
        //
        // Summary:
        //     Identifies the System.Windows.UIElement.MouseDown routed event.
        //
        // Returns:
        //     The identifier for the System.Windows.UIElement.MouseDown routed event.
        public static readonly RoutedEvent MouseDownEvent;
        //
        // Summary:
        //     Identifies the System.Windows.UIElement.MouseMove routed event.
        //
        // Returns:
        //     The identifier for the System.Windows.UIElement.MouseMove routed event.
        public static readonly RoutedEvent MouseMoveEvent;
        //
        // Summary:
        //     Identifies the System.Windows.UIElement.StylusInAirMove routed event.
        //
        // Returns:
        //     The identifier for the System.Windows.UIElement.StylusInAirMove routed event.
        public static readonly RoutedEvent StylusInAirMoveEvent;
        //
        // Summary:
        //     Identifies the System.Windows.UIElement.MouseLeftButtonUp routed event.
        //
        // Returns:
        //     The identifier for the System.Windows.UIElement.MouseLeftButtonUp routed event.
        public static readonly RoutedEvent MouseLeftButtonUpEvent;
        //
        // Summary:
        //     Identifies the System.Windows.UIElement.StylusLeave routed event.
        //
        // Returns:
        //     The identifier for the System.Windows.UIElement.StylusLeave routed event.
        public static readonly RoutedEvent StylusLeaveEvent;
        //
        // Summary:
        //     Identifies the System.Windows.UIElement.StylusEnter routed event.
        //
        // Returns:
        //     The identifier for the System.Windows.UIElement.StylusEnter routed event.
        public static readonly RoutedEvent StylusEnterEvent;
        //
        // Summary:
        //     Identifies the System.Windows.UIElement.GiveFeedback routed event.
        //
        // Returns:
        //     The identifier for the System.Windows.UIElement.GiveFeedback routed event.
        public static readonly RoutedEvent GiveFeedbackEvent;
        //
        // Summary:
        //     Identifies the System.Windows.UIElement.PreviewGiveFeedback routed event.
        //
        // Returns:
        //     The identifier for the System.Windows.UIElement.PreviewGiveFeedback routed event.
        public static readonly RoutedEvent PreviewGiveFeedbackEvent;
        //
        // Summary:
        //     Identifies the System.Windows.UIElement.QueryContinueDrag routed event.
        //
        // Returns:
        //     The identifier for the System.Windows.UIElement.QueryContinueDrag routed event.
        public static readonly RoutedEvent QueryContinueDragEvent;
        //
        // Summary:
        //     Identifies the System.Windows.UIElement.TextInput routed event.
        //
        // Returns:
        //     The identifier for the System.Windows.UIElement.TextInput routed event.
        public static readonly RoutedEvent TextInputEvent;
        //
        // Summary:
        //     Identifies the System.Windows.UIElement.PreviewTextInput routed event.
        //
        // Returns:
        //     The identifier for the System.Windows.UIElement.PreviewTextInput routed event.
        public static readonly RoutedEvent PreviewTextInputEvent;
        //
        // Summary:
        //     Identifies the System.Windows.UIElement.LostKeyboardFocus routed event.
        //
        // Returns:
        //     The identifier for the System.Windows.UIElement.LostKeyboardFocus routed event.
        public static readonly RoutedEvent LostKeyboardFocusEvent;
        //
        // Summary:
        //     Identifies the System.Windows.UIElement.PreviewLostKeyboardFocus routed event.
        //
        // Returns:
        //     The identifier for the System.Windows.UIElement.PreviewLostKeyboardFocus routed
        //     event.
        public static readonly RoutedEvent PreviewLostKeyboardFocusEvent;
        //
        // Summary:
        //     Identifies the System.Windows.UIElement.GotKeyboardFocus routed event.
        //
        // Returns:
        //     The identifier for the System.Windows.UIElement.GotKeyboardFocus routed event.
        public static readonly RoutedEvent GotKeyboardFocusEvent;
        //
        // Summary:
        //     Identifies the System.Windows.UIElement.PreviewGotKeyboardFocus routed event.
        //
        // Returns:
        //     The identifier for the System.Windows.UIElement.PreviewGotKeyboardFocus routed
        //     event.
        public static readonly RoutedEvent PreviewGotKeyboardFocusEvent;
        //
        // Summary:
        //     Identifies the System.Windows.UIElement.KeyUp routed event.
        //
        // Returns:
        //     The identifier for the System.Windows.UIElement.KeyUp routed event.
        public static readonly RoutedEvent KeyUpEvent;
        //
        // Summary:
        //     Identifies the System.Windows.UIElement.PreviewKeyUp routed event.
        //
        // Returns:
        //     The identifier for the System.Windows.UIElement.PreviewKeyUp routed event.
        public static readonly RoutedEvent PreviewKeyUpEvent;
        //
        // Summary:
        //     Identifies the System.Windows.UIElement.KeyDown routed event.
        //
        // Returns:
        //     The identifier for the System.Windows.UIElement.KeyDown routed event.
        public static readonly RoutedEvent KeyDownEvent;
        //
        // Summary:
        //     Identifies the System.Windows.UIElement.PreviewQueryContinueDrag routed event.
        //
        // Returns:
        //     The identifier for the System.Windows.UIElement.PreviewQueryContinueDrag routed
        //     event.
        public static readonly RoutedEvent PreviewQueryContinueDragEvent;
        //
        // Summary:
        //     Identifies the System.Windows.UIElement.PreviewStylusButtonUp routed event.
        //
        // Returns:
        //     The identifier for the System.Windows.UIElement.PreviewStylusButtonUp routed
        //     event.
        public static readonly RoutedEvent PreviewStylusButtonUpEvent;
        //
        // Summary:
        //     Identifies the System.Windows.UIElement.PreviewKeyDown routed event.
        //
        // Returns:
        //     The identifier for the System.Windows.UIElement.PreviewKeyDown routed event.
        public static readonly RoutedEvent PreviewKeyDownEvent;
        //
        // Summary:
        //     Identifies the System.Windows.UIElement.StylusInRange routed event.
        //
        // Returns:
        //     The identifier for the System.Windows.UIElement.StylusInRange routed event.
        public static readonly RoutedEvent StylusInRangeEvent;
        //
        // Summary:
        //     Identifies the System.Windows.UIElement.PreviewStylusInRange routed event.
        //
        // Returns:
        //     The identifier for the System.Windows.UIElement.PreviewStylusInRange routed event.
        public static readonly RoutedEvent PreviewStylusInRangeEvent;
        //
        // Summary:
        //     Identifies the System.Windows.UIElement.StylusOutOfRange routed event.
        //
        // Returns:
        //     The identifier for the System.Windows.UIElement.StylusOutOfRange routed event.
        public static readonly RoutedEvent StylusOutOfRangeEvent;
        //
        // Summary:
        //     Identifies the System.Windows.UIElement.PreviewStylusSystemGesture routed event.
        //
        // Returns:
        //     The identifier for the System.Windows.UIElement.PreviewStylusSystemGesture routed
        //     event.
        public static readonly RoutedEvent PreviewStylusSystemGestureEvent;
        //
        // Summary:
        //     Identifies the System.Windows.UIElement.PreviewStylusOutOfRange routed event.
        //
        // Returns:
        //     The identifier for the System.Windows.UIElement.PreviewStylusOutOfRange routed
        //     event.
        public static readonly RoutedEvent PreviewStylusOutOfRangeEvent;
        //
        // Summary:
        //     Identifies the System.Windows.UIElement.GotStylusCapture routed event.
        //
        // Returns:
        //     The identifier for the System.Windows.UIElement.GotStylusCapture routed event.
        public static readonly RoutedEvent GotStylusCaptureEvent;
        //
        // Summary:
        //     Identifies the System.Windows.UIElement.LostStylusCapture routed event.
        //
        // Returns:
        //     The identifier for the System.Windows.UIElement.LostStylusCapture routed event.
        public static readonly RoutedEvent LostStylusCaptureEvent;
        //
        // Summary:
        //     Identifies the System.Windows.UIElement.StylusButtonDown routed event.
        //
        // Returns:
        //     The identifier for the System.Windows.UIElement.StylusButtonDown routed event.
        public static readonly RoutedEvent StylusButtonDownEvent;
        //
        // Summary:
        //     Identifies the System.Windows.UIElement.StylusButtonUp routed event.
        //
        // Returns:
        //     The identifier for the System.Windows.UIElement.StylusButtonUp routed event.
        public static readonly RoutedEvent StylusButtonUpEvent;
        //
        // Summary:
        //     Identifies the System.Windows.UIElement.PreviewStylusButtonDown routed event.
        //
        // Returns:
        //     The identifier for the System.Windows.UIElement.PreviewStylusButtonDown routed
        //     event.
        public static readonly RoutedEvent PreviewStylusButtonDownEvent;
        //
        // Summary:
        //     Identifies the System.Windows.UIElement.StylusSystemGesture routed event.
        //
        // Returns:
        //     The identifier for the System.Windows.UIElement.StylusSystemGesture routed event.
        public static readonly RoutedEvent StylusSystemGestureEvent;

        //
        // Summary:
        //     Initializes a new instance of the System.Windows.UIElement class.
        public UIElement();

        //
        // Summary:
        //     Gets or sets the unique identifier (for localization) for this element. This
        //     is a dependency property.
        //
        // Returns:
        //     A string that is the unique identifier for this element.
        public string Uid { get; set; }
        //
        // Summary:
        //     Gets or sets the user interface (UI) visibility of this element. This is a dependency
        //     property.
        //
        // Returns:
        //     A value of the enumeration. The default value is System.Windows.Visibility.Visible.
        [Localizability(LocalizationCategory.None, Readability = Readability.Unreadable)]
        public Visibility Visibility { get; set; }
        //
        // Summary:
        //     Gets or sets a value indicating whether to clip the content of this element (or
        //     content coming from the child elements of this element) to fit into the size
        //     of the containing element. This is a dependency property.
        //
        // Returns:
        //     true if the content should be clipped; otherwise, false. The default value is
        //     false.
        public bool ClipToBounds { get; set; }
        //
        // Summary:
        //     Gets or sets the geometry used to define the outline of the contents of an element.
        //     This is a dependency property.
        //
        // Returns:
        //     The geometry to be used for clipping area sizing. The default is a null System.Windows.Media.Geometry.
        public Geometry Clip { get; set; }
        //
        // Summary:
        //     Gets or sets a value that determines whether rendering for this element should
        //     use device-specific pixel settings during rendering. This is a dependency property.
        //
        // Returns:
        //     true if the element should render in accordance to device pixels; otherwise,
        //     false. The default as declared on System.Windows.UIElement is false.
        public bool SnapsToDevicePixels { get; set; }
        //
        // Summary:
        //     Gets a value that determines whether this element has logical focus. This is
        //     a dependency property.
        //
        // Returns:
        //     true if this element has logical focus; otherwise, false.
        public bool IsFocused { get; }
        //
        // Summary:
        //     Gets or sets a value indicating whether this element is enabled in the user interface
        //     (UI). This is a dependency property.
        //
        // Returns:
        //     true if the element is enabled; otherwise, false. The default value is true.
        public bool IsEnabled { get; set; }
        //
        // Summary:
        //     Gets or sets a value that declares whether this element can possibly be returned
        //     as a hit test result from some portion of its rendered content. This is a dependency
        //     property.
        //
        // Returns:
        //     true if this element could be returned as a hit test result from at least one
        //     point; otherwise, false. The default value is true.
        public bool IsHitTestVisible { get; set; }
        //
        // Summary:
        //     Gets a value indicating whether this element is visible in the user interface
        //     (UI). This is a dependency property.
        //
        // Returns:
        //     true if the element is visible; otherwise, false.
        public bool IsVisible { get; }
        //
        // Summary:
        //     Gets a value that indicates whether at least one touch is captured to this element
        //     or to any child elements in its visual tree.
        //
        // Returns:
        //     true if at least one touch is captured to this element or any child elements
        //     in its visual tree; otherwise, false.
        public bool AreAnyTouchesCapturedWithin { get; }
        //
        // Summary:
        //     Gets a value that uniquely identifies this element.
        //
        // Returns:
        //     The unique identifier for this element.
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        [Obsolete("PersistId is an obsolete property and may be removed in a future release.  The value of this property is not defined.")]
        public int PersistId { get; }
        //
        // Summary:
        //     Gets or sets a value that indicates whether manipulation events are enabled on
        //     this System.Windows.UIElement.
        //
        // Returns:
        //     true if manipulation events are enabled on this System.Windows.UIElement; otherwise,
        //     false. The default is false.
        [CustomCategoryAttribute("Touch_Category")]
        public bool IsManipulationEnabled { get; set; }
        //
        // Summary:
        //     Gets a value that indicates whether at least one touch is pressed over this element
        //     or any child elements in its visual tree.
        //
        // Returns:
        //     true if at least one touch is pressed over this element or any child elements
        //     in its visual tree; otherwise, false.
        public bool AreAnyTouchesOver { get; }
        //
        // Summary:
        //     Gets a value that indicates whether at least one touch is pressed over this element.
        //
        // Returns:
        //     true if at least one touch is pressed over this element; otherwise, false.
        public bool AreAnyTouchesDirectlyOver { get; }
        //
        // Summary:
        //     Gets a value that indicates whether at least one touch is captured to this element.
        //
        // Returns:
        //     true if at least one touch is captured to this element; otherwise, false.
        public bool AreAnyTouchesCaptured { get; }
        //
        // Summary:
        //     Gets all touch devices that are captured to this element.
        //
        // Returns:
        //     An enumeration of System.Windows.Input.TouchDevice objects that are captured
        //     to this element.
        public IEnumerable<TouchDevice> TouchesCaptured { get; }
        //
        // Summary:
        //     Gets all touch devices that are captured to this element or any child elements
        //     in its visual tree.
        //
        // Returns:
        //     An enumeration of System.Windows.Input.TouchDevice objects that are captured
        //     to this element or any child elements in its visual tree.
        public IEnumerable<TouchDevice> TouchesCapturedWithin { get; }
        //
        // Summary:
        //     Gets all touch devices that are over this element or any child elements in its
        //     visual tree.
        //
        // Returns:
        //     An enumeration of System.Windows.Input.TouchDevice objects that are over this
        //     element or any child elements in its visual tree.
        public IEnumerable<TouchDevice> TouchesOver { get; }
        //
        // Summary:
        //     Gets or sets a cached representation of the System.Windows.UIElement.
        //
        // Returns:
        //     A System.Windows.Media.CacheMode that holds a cached representation of the System.Windows.UIElement.
        public CacheMode CacheMode { get; set; }
        //
        // Summary:
        //     Gets or sets a value that indicates whether the element can receive focus. This
        //     is a dependency property.
        //
        // Returns:
        //     true if the element is focusable; otherwise false. The default is false, but
        //     see Remarks.
        public bool Focusable { get; set; }
        //
        // Summary:
        //     Gets or sets an input source for the bitmap effect that applies directly to the
        //     rendered content for this element. This is a dependency property.
        //
        // Returns:
        //     The source for bitmap effects.
        [Obsolete("BitmapEffects are deprecated and no longer function.  Consider using Effects where appropriate instead.")]
        public BitmapEffectInput BitmapEffectInput { get; set; }
        //
        // Summary:
        //     Gets a value that indicates whether the position of the mouse pointer corresponds
        //     to hit test results, which take element compositing into account. This is a dependency
        //     property.
        //
        // Returns:
        //     true if the mouse pointer is over the same element result as a hit test; otherwise,
        //     false. The default is false.
        public bool IsMouseDirectlyOver { get; }
        //
        // Summary:
        //     Gets or sets a bitmap effect that applies directly to the rendered content for
        //     this element. This is a dependency property.
        //
        // Returns:
        //     The bitmap effect to apply.
        [Obsolete("BitmapEffects are deprecated and no longer function.  Consider using Effects where appropriate instead.")]
        public BitmapEffect BitmapEffect { get; set; }
        //
        // Summary:
        //     Gets a value indicating whether the computed size and position of child elements
        //     in this element's layout are valid.
        //
        // Returns:
        //     true if the size and position of layout are valid; otherwise, false.
        public bool IsArrangeValid { get; }
        //
        // Summary:
        //     Gets a value indicating whether the current size returned by layout measure is
        //     valid.
        //
        // Returns:
        //     true if the measure pass of layout returned a valid and current value; otherwise,
        //     false.
        public bool IsMeasureValid { get; }
        //
        // Summary:
        //     Gets the size that this element computed during the measure pass of the layout
        //     process.
        //
        // Returns:
        //     The computed size, which becomes the desired size for the arrange pass.
        public Size DesiredSize { get; }
        //
        // Summary:
        //     Gets or sets a value indicating whether this element can be used as the target
        //     of a drag-and-drop operation. This is a dependency property.
        //
        // Returns:
        //     true if this element can be used as the target of a drag-and-drop operation;
        //     otherwise, false. The default value is false.
        public bool AllowDrop { get; set; }
        //
        // Summary:
        //     Gets a collection of System.Windows.Input.CommandBinding objects associated with
        //     this element. A System.Windows.Input.CommandBinding enables command handling
        //     for this element, and declares the linkage between a command, its events, and
        //     the handlers attached by this element.
        //
        // Returns:
        //     The collection of all System.Windows.Input.CommandBinding objects.
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        public CommandBindingCollection CommandBindings { get; }
        //
        // Summary:
        //     Gets the collection of input bindings associated with this element.
        //
        // Returns:
        //     The collection of input bindings.
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        public InputBindingCollection InputBindings { get; }
        //
        // Summary:
        //     Gets a value indicating whether this element has any animated properties.
        //
        // Returns:
        //     true if this element has animations attached to any of its properties; otherwise,
        //     false.
        public bool HasAnimatedProperties { get; }
        //
        // Summary:
        //     Gets or sets the center point of any possible render transform declared by System.Windows.UIElement.RenderTransform,
        //     relative to the bounds of the element. This is a dependency property.
        //
        // Returns:
        //     The value that declares the render transform. The default value is a System.Windows.Point
        //     with coordinates (0,0).
        public Point RenderTransformOrigin { get; set; }
        //
        // Summary:
        //     Gets a value indicating whether the mouse pointer is located over this element
        //     (including child elements in the visual tree). This is a dependency property.
        //
        // Returns:
        //     true if mouse pointer is over the element or its child elements; otherwise, false.
        //     The default is false.
        public bool IsMouseOver { get; }
        //
        // Summary:
        //     Gets or sets the bitmap effect to apply to the System.Windows.UIElement. This
        //     is a dependency property.
        //
        // Returns:
        //     An System.Windows.Media.Effects.Effect that represents the bitmap effect.
        public Effect Effect { get; set; }
        //
        // Summary:
        //     Gets a value indicating whether the stylus cursor is located over this element
        //     (including visual child elements). This is a dependency property.
        //
        // Returns:
        //     true if stylus cursor is over the element or its child elements; otherwise, false.
        //     The default is false.
        public bool IsStylusOver { get; }
        //
        // Summary:
        //     Gets a value indicating whether the mouse is captured to this element. This is
        //     a dependency property.
        //
        // Returns:
        //     true if the element has mouse capture; otherwise, false. The default is false.
        public bool IsMouseCaptured { get; }
        //
        // Summary:
        //     Gets a value that determines whether mouse capture is held by this element or
        //     by child elements in its visual tree. This is a dependency property.
        //
        // Returns:
        //     true if this element or a contained element has mouse capture; otherwise, false.
        public bool IsMouseCaptureWithin { get; }
        //
        // Summary:
        //     Gets a value that indicates whether the stylus position corresponds to hit test
        //     results, which take element compositing into account. This is a dependency property.
        //
        // Returns:
        //     true if the stylus pointer is over the same element result as a hit test; otherwise,
        //     false. The default is false.
        public bool IsStylusDirectlyOver { get; }
        //
        // Summary:
        //     Gets a value indicating whether the stylus is captured by this element. This
        //     is a dependency property.
        //
        // Returns:
        //     true if the element has stylus capture; otherwise, false. The default is false.
        public bool IsStylusCaptured { get; }
        //
        // Summary:
        //     Gets a value that determines whether stylus capture is held by this element,
        //     or an element within the element bounds and its visual tree. This is a dependency
        //     property.
        //
        // Returns:
        //     true if this element or a contained element has stylus capture; otherwise, false.
        //     The default is false.
        public bool IsStylusCaptureWithin { get; }
        //
        // Summary:
        //     Gets a value indicating whether this element has keyboard focus. This is a dependency
        //     property.
        //
        // Returns:
        //     true if this element has keyboard focus; otherwise, false. The default is false.
        public bool IsKeyboardFocused { get; }
        //
        // Summary:
        //     Gets a value indicating whether an input method system, such as an Input Method
        //     Editor (IME), is enabled for processing the input to this element.
        //
        // Returns:
        //     true if an input method is active; otherwise, false. The default value of the
        //     underlying attached property is true; however, this will be influenced by the
        //     actual state of input methods at runtime.
        public bool IsInputMethodEnabled { get; }
        //
        // Summary:
        //     Gets or sets the opacity factor applied to the entire System.Windows.UIElement
        //     when it is rendered in the user interface (UI). This is a dependency property.
        //
        // Returns:
        //     The opacity factor. Default opacity is 1.0. Expected values are between 0.0 and
        //     1.0.
        [Localizability(LocalizationCategory.None, Readability = Readability.Unreadable)]
        public double Opacity { get; set; }
        //
        // Summary:
        //     Gets or sets an opacity mask, as a System.Windows.Media.Brush implementation
        //     that is applied to any alpha-channel masking for the rendered content of this
        //     element. This is a dependency property.
        //
        // Returns:
        //     The brush to use for opacity masking.
        public Brush OpacityMask { get; set; }
        //
        // Summary:
        //     Gets a value indicating whether keyboard focus is anywhere within the element
        //     or its visual tree child elements. This is a dependency property.
        //
        // Returns:
        //     true if keyboard focus is on the element or its child elements; otherwise, false.
        public bool IsKeyboardFocusWithin { get; }
        //
        // Summary:
        //     Gets all touch devices that are over this element.
        //
        // Returns:
        //     An enumeration of System.Windows.Input.TouchDevice objects that are over this
        //     element.
        public IEnumerable<TouchDevice> TouchesDirectlyOver { get; }
        //
        // Summary:
        //     Gets or sets transform information that affects the rendering position of this
        //     element. This is a dependency property.
        //
        // Returns:
        //     Describes the specifics of the desired render transform. The default is System.Windows.Media.Transform.Identity.
        public Transform RenderTransform { get; set; }
        //
        // Summary:
        //     Gets (or sets, but see Remarks) the final render size of this element.
        //
        // Returns:
        //     The rendered size for this element.
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public Size RenderSize { get; set; }
        //
        // Summary:
        //     Gets a collection of all stylus plug-in (customization) objects associated with
        //     this element.
        //
        // Returns:
        //     The collection of stylus plug-ins, as a specialized collection.
        protected StylusPlugInCollection StylusPlugIns { get; }
        //
        // Summary:
        //     Gets a value that becomes the return value of System.Windows.UIElement.IsEnabled
        //     in derived classes.
        //
        // Returns:
        //     true if the element is enabled; otherwise, false.
        protected virtual bool IsEnabledCore { get; }

        //
        // Summary:
        //     Occurs when a key is released while focus is on this element.
        public event KeyEventHandler KeyUp;
        //
        // Summary:
        //     Occurs when a finger moves on the screen while the finger is over this element.
        [CustomCategoryAttribute("Touch_Category")]
        public event EventHandler<TouchEventArgs> TouchMove;
        //
        // Summary:
        //     Occurs when a finger moves on the screen while the finger is over this element.
        [CustomCategoryAttribute("Touch_Category")]
        public event EventHandler<TouchEventArgs> PreviewTouchMove;
        //
        // Summary:
        //     Occurs when a finger touches the screen while the finger is over this element.
        [CustomCategoryAttribute("Touch_Category")]
        public event EventHandler<TouchEventArgs> TouchDown;
        //
        // Summary:
        //     Occurs when a finger touches the screen while the finger is over this element.
        [CustomCategoryAttribute("Touch_Category")]
        public event EventHandler<TouchEventArgs> PreviewTouchDown;
        //
        // Summary:
        //     Occurs when the input system reports an underlying drop event with this element
        //     as the drop target.
        public event DragEventHandler Drop;
        //
        // Summary:
        //     Occurs when the input system reports an underlying drop event with this element
        //     as the drop target.
        public event DragEventHandler PreviewDrop;
        //
        // Summary:
        //     Occurs when the input system reports an underlying drag event with this element
        //     as the drag origin.
        public event DragEventHandler DragLeave;
        //
        // Summary:
        //     Occurs when the input system reports an underlying drag event with this element
        //     as the drag origin.
        public event DragEventHandler PreviewDragLeave;
        //
        // Summary:
        //     Occurs when the input system reports an underlying drag event with this element
        //     as the potential drop target.
        public event DragEventHandler DragOver;
        //
        // Summary:
        //     Occurs when the input system reports an underlying drag event with this element
        //     as the potential drop target.
        public event DragEventHandler PreviewDragOver;
        //
        // Summary:
        //     Occurs when the input system reports an underlying drag event with this element
        //     as the drag target.
        public event DragEventHandler DragEnter;
        //
        // Summary:
        //     Occurs when the input system reports an underlying drag event with this element
        //     as the drag target.
        public event DragEventHandler PreviewDragEnter;
        //
        // Summary:
        //     Occurs when the input system reports an underlying drag-and-drop event that involves
        //     this element.
        public event GiveFeedbackEventHandler GiveFeedback;
        //
        // Summary:
        //     Occurs when a drag-and-drop operation is started.
        public event GiveFeedbackEventHandler PreviewGiveFeedback;
        //
        // Summary:
        //     Occurs when there is a change in the keyboard or mouse button state during a
        //     drag-and-drop operation.
        public event QueryContinueDragEventHandler QueryContinueDrag;
        //
        // Summary:
        //     Occurs when there is a change in the keyboard or mouse button state during a
        //     drag-and-drop operation.
        public event QueryContinueDragEventHandler PreviewQueryContinueDrag;
        //
        // Summary:
        //     Occurs when this element gets text in a device-independent manner.
        public event TextCompositionEventHandler TextInput;
        //
        // Summary:
        //     Occurs when this element gets text in a device-independent manner.
        public event TextCompositionEventHandler PreviewTextInput;
        //
        // Summary:
        //     Occurs when a finger is raised off of the screen while the finger is over this
        //     element.
        [CustomCategoryAttribute("Touch_Category")]
        public event EventHandler<TouchEventArgs> PreviewTouchUp;
        //
        // Summary:
        //     Occurs when a finger is raised off of the screen while the finger is over this
        //     element.
        [CustomCategoryAttribute("Touch_Category")]
        public event EventHandler<TouchEventArgs> TouchUp;
        //
        // Summary:
        //     Occurs when this element loses a touch capture.
        [CustomCategoryAttribute("Touch_Category")]
        public event EventHandler<TouchEventArgs> LostTouchCapture;
        //
        // Summary:
        //     Occurs when the keyboard is no longer focused on this element,.
        public event KeyboardFocusChangedEventHandler LostKeyboardFocus;
        //
        // Summary:
        //     Occurs when the input device loses contact with the System.Windows.UIElement
        //     object during a manipulation and inertia begins.
        [CustomCategoryAttribute("Touch_Category")]
        public event EventHandler<ManipulationInertiaStartingEventArgs> ManipulationInertiaStarting;
        //
        // Summary:
        //     Occurs when the input device changes position during a manipulation.
        [CustomCategoryAttribute("Touch_Category")]
        public event EventHandler<ManipulationDeltaEventArgs> ManipulationDelta;
        //
        // Summary:
        //     Occurs when an input device begins a manipulation on the System.Windows.UIElement
        //     object.
        [CustomCategoryAttribute("Touch_Category")]
        public event EventHandler<ManipulationStartedEventArgs> ManipulationStarted;
        //
        // Summary:
        //     Occurs when the manipulation processor is first created.
        [CustomCategoryAttribute("Touch_Category")]
        public event EventHandler<ManipulationStartingEventArgs> ManipulationStarting;
        //
        // Summary:
        //     Occurs when the value of the System.Windows.UIElement.Focusable property changes.
        public event DependencyPropertyChangedEventHandler FocusableChanged;
        //
        // Summary:
        //     Occurs when the value of the System.Windows.UIElement.IsVisible property changes
        //     on this element.
        public event DependencyPropertyChangedEventHandler IsVisibleChanged;
        //
        // Summary:
        //     Occurs when the value of the System.Windows.UIElement.IsHitTestVisible dependency
        //     property changes on this element.
        public event DependencyPropertyChangedEventHandler IsHitTestVisibleChanged;
        //
        // Summary:
        //     Occurs when the value of the System.Windows.UIElement.IsEnabled property on this
        //     element changes.
        public event DependencyPropertyChangedEventHandler IsEnabledChanged;
        //
        // Summary:
        //     Occurs when this element loses logical focus.
        public event RoutedEventHandler LostFocus;
        //
        // Summary:
        //     Occurs when a touch is captured to this element.
        [CustomCategoryAttribute("Touch_Category")]
        public event EventHandler<TouchEventArgs> GotTouchCapture;
        //
        // Summary:
        //     Occurs when this element gets logical focus.
        public event RoutedEventHandler GotFocus;
        //
        // Summary:
        //     Occurs when the value of the System.Windows.UIElement.IsKeyboardFocused property
        //     changes on this element.
        public event DependencyPropertyChangedEventHandler IsKeyboardFocusedChanged;
        //
        // Summary:
        //     Occurs when the value of the System.Windows.UIElement.IsStylusCaptureWithin property
        //     changes on this element.
        public event DependencyPropertyChangedEventHandler IsStylusCaptureWithinChanged;
        //
        // Summary:
        //     Occurs when the value of the System.Windows.UIElement.IsStylusDirectlyOver property
        //     changes on this element.
        public event DependencyPropertyChangedEventHandler IsStylusDirectlyOverChanged;
        //
        // Summary:
        //     Occurs when the value of the System.Windows.UIElement.IsMouseCaptureWithinProperty
        //     changes on this element.
        public event DependencyPropertyChangedEventHandler IsMouseCaptureWithinChanged;
        //
        // Summary:
        //     Occurs when the value of the System.Windows.UIElement.IsMouseCaptured property
        //     changes on this element.
        public event DependencyPropertyChangedEventHandler IsMouseCapturedChanged;
        //
        // Summary:
        //     Occurs when the value of the System.Windows.UIElement.IsKeyboardFocusWithinChanged
        //     property changes on this element.
        public event DependencyPropertyChangedEventHandler IsKeyboardFocusWithinChanged;
        //
        // Summary:
        //     Occurs when the value of the System.Windows.UIElement.IsMouseDirectlyOver property
        //     changes on this element.
        public event DependencyPropertyChangedEventHandler IsMouseDirectlyOverChanged;
        //
        // Summary:
        //     Occurs when a touch moves from inside to outside the bounds of this element.
        [CustomCategoryAttribute("Touch_Category")]
        public event EventHandler<TouchEventArgs> TouchLeave;
        //
        // Summary:
        //     Occurs when a touch moves from outside to inside the bounds of this element.
        [CustomCategoryAttribute("Touch_Category")]
        public event EventHandler<TouchEventArgs> TouchEnter;
        //
        // Summary:
        //     Occurs when the layout of the various visual elements associated with the current
        //     System.Windows.Threading.Dispatcher changes.
        public event EventHandler LayoutUpdated;
        //
        // Summary:
        //     Occurs when the keyboard is focused on this element.
        public event KeyboardFocusChangedEventHandler PreviewGotKeyboardFocus;
        //
        // Summary:
        //     Occurs when the keyboard is no longer focused on this element.
        public event KeyboardFocusChangedEventHandler PreviewLostKeyboardFocus;
        //
        // Summary:
        //     Occurs when any mouse button is pressed while the pointer is over this element.
        public event MouseButtonEventHandler PreviewMouseDown;
        //
        // Summary:
        //     Occurs when the stylus moves over this element. The stylus must move while on
        //     the digitizer to raise this event. Otherwise, System.Windows.UIElement.StylusInAirMove
        //     is raised instead.
        public event StylusEventHandler StylusMove;
        //
        // Summary:
        //     Occurs when the stylus moves over an element without actually touching the digitizer.
        public event StylusEventHandler PreviewStylusInAirMove;
        //
        // Summary:
        //     Occurs when the stylus moves over an element without actually touching the digitizer.
        public event StylusEventHandler StylusInAirMove;
        //
        // Summary:
        //     Occurs when the stylus enters the bounds of this element.
        public event StylusEventHandler StylusEnter;
        //
        // Summary:
        //     Occurs when the stylus leaves the bounds of the element.
        public event StylusEventHandler StylusLeave;
        //
        // Summary:
        //     Occurs when the stylus is close enough to the digitizer to be detected, while
        //     over this element.
        public event StylusEventHandler PreviewStylusInRange;
        //
        // Summary:
        //     Occurs when the stylus is close enough to the digitizer to be detected, while
        //     over this element.
        public event StylusEventHandler StylusInRange;
        //
        // Summary:
        //     Occurs when the stylus is too far from the digitizer to be detected.
        public event StylusEventHandler PreviewStylusOutOfRange;
        //
        // Summary:
        //     Occurs when the stylus is too far from the digitizer to be detected, while over
        //     this element.
        public event StylusEventHandler StylusOutOfRange;
        //
        // Summary:
        //     Occurs when the stylus moves while over the element. The stylus must move while
        //     being detected by the digitizer to raise this event, otherwise, System.Windows.UIElement.PreviewStylusInAirMove
        //     is raised instead.
        public event StylusEventHandler PreviewStylusMove;
        //
        // Summary:
        //     Occurs when a user performs one of several stylus gestures.
        public event StylusSystemGestureEventHandler PreviewStylusSystemGesture;
        //
        // Summary:
        //     Occurs when this element captures the stylus.
        public event StylusEventHandler GotStylusCapture;
        //
        // Summary:
        //     Occurs when this element loses stylus capture.
        public event StylusEventHandler LostStylusCapture;
        //
        // Summary:
        //     Occurs when the stylus button is pressed while the pointer is over this element.
        public event StylusButtonEventHandler StylusButtonDown;
        //
        // Summary:
        //     Occurs when the stylus button is released while the pointer is over this element.
        public event StylusButtonEventHandler StylusButtonUp;
        //
        // Summary:
        //     Occurs when the stylus button is pressed while the pointer is over this element.
        public event StylusButtonEventHandler PreviewStylusButtonDown;
        //
        // Summary:
        //     Occurs when the stylus button is released while the pointer is over this element.
        public event StylusButtonEventHandler PreviewStylusButtonUp;
        //
        // Summary:
        //     Occurs when a key is pressed while focus is on this element.
        public event KeyEventHandler PreviewKeyDown;
        //
        // Summary:
        //     Occurs when a key is pressed while focus is on this element.
        public event KeyEventHandler KeyDown;
        //
        // Summary:
        //     Occurs when a key is released while focus is on this element.
        public event KeyEventHandler PreviewKeyUp;
        //
        // Summary:
        //     Occurs when a user performs one of several stylus gestures.
        public event StylusSystemGestureEventHandler StylusSystemGesture;
        //
        // Summary:
        //     Occurs when the user raises the stylus off the digitizer while it is over this
        //     element.
        public event StylusEventHandler StylusUp;
        //
        // Summary:
        //     Occurs when the user raises the stylus off the digitizer while the stylus is
        //     over this element.
        public event StylusEventHandler PreviewStylusUp;
        //
        // Summary:
        //     Occurs when the stylus touches the digitizer while the stylus is over this element.
        public event StylusDownEventHandler StylusDown;
        //
        // Summary:
        //     Occurs when any mouse button is pressed while the pointer is over this element.
        public event MouseButtonEventHandler MouseDown;
        //
        // Summary:
        //     Occurs when any mouse button is released while the mouse pointer is over this
        //     element.
        public event MouseButtonEventHandler PreviewMouseUp;
        //
        // Summary:
        //     Occurs when any mouse button is released over this element.
        public event MouseButtonEventHandler MouseUp;
        //
        // Summary:
        //     Occurs when the left mouse button is pressed while the mouse pointer is over
        //     this element.
        public event MouseButtonEventHandler PreviewMouseLeftButtonDown;
        //
        // Summary:
        //     Occurs when the left mouse button is pressed while the mouse pointer is over
        //     this element.
        public event MouseButtonEventHandler MouseLeftButtonDown;
        //
        // Summary:
        //     Occurs when the left mouse button is released while the mouse pointer is over
        //     this element.
        public event MouseButtonEventHandler PreviewMouseLeftButtonUp;
        //
        // Summary:
        //     Occurs when the left mouse button is released while the mouse pointer is over
        //     this element.
        public event MouseButtonEventHandler MouseLeftButtonUp;
        //
        // Summary:
        //     Occurs when the right mouse button is pressed while the mouse pointer is over
        //     this element.
        public event MouseButtonEventHandler PreviewMouseRightButtonDown;
        //
        // Summary:
        //     Occurs when the right mouse button is pressed while the mouse pointer is over
        //     this element.
        public event MouseButtonEventHandler MouseRightButtonDown;
        //
        // Summary:
        //     Occurs when the right mouse button is released while the mouse pointer is over
        //     this element.
        public event MouseButtonEventHandler PreviewMouseRightButtonUp;
        //
        // Summary:
        //     Occurs when the right mouse button is released while the mouse pointer is over
        //     this element.
        public event MouseButtonEventHandler MouseRightButtonUp;
        //
        // Summary:
        //     Occurs when the mouse pointer moves while the mouse pointer is over this element.
        public event MouseEventHandler PreviewMouseMove;
        //
        // Summary:
        //     Occurs when the mouse pointer moves while over this element.
        public event MouseEventHandler MouseMove;
        //
        // Summary:
        //     Occurs when the user rotates the mouse wheel while the mouse pointer is over
        //     this element.
        public event MouseWheelEventHandler PreviewMouseWheel;
        //
        // Summary:
        //     Occurs when the user rotates the mouse wheel while the mouse pointer is over
        //     this element.
        public event MouseWheelEventHandler MouseWheel;
        //
        // Summary:
        //     Occurs when the mouse pointer enters the bounds of this element.
        public event MouseEventHandler MouseEnter;
        //
        // Summary:
        //     Occurs when the mouse pointer leaves the bounds of this element.
        public event MouseEventHandler MouseLeave;
        //
        // Summary:
        //     Occurs when this element captures the mouse.
        public event MouseEventHandler GotMouseCapture;
        //
        // Summary:
        //     Occurs when this element loses mouse capture.
        public event MouseEventHandler LostMouseCapture;
        //
        // Summary:
        //     Occurs when the cursor is requested to display. This event is raised on an element
        //     each time that the mouse pointer moves to a new location, which means the cursor
        //     object might need to be changed based on its new position.
        public event QueryCursorEventHandler QueryCursor;
        //
        // Summary:
        //     Occurs when the stylus touches the digitizer while it is over this element.
        public event StylusDownEventHandler PreviewStylusDown;
        //
        // Summary:
        //     Occurs when the keyboard is focused on this element.
        public event KeyboardFocusChangedEventHandler GotKeyboardFocus;
        //
        // Summary:
        //     Occurs when the value of the System.Windows.UIElement.IsStylusCaptured property
        //     changes on this element.
        public event DependencyPropertyChangedEventHandler IsStylusCapturedChanged;
        //
        // Summary:
        //     Occurs when a manipulation and inertia on the System.Windows.UIElement object
        //     is complete.
        [CustomCategoryAttribute("Touch_Category")]
        public event EventHandler<ManipulationCompletedEventArgs> ManipulationCompleted;
        //
        // Summary:
        //     Occurs when the manipulation encounters a boundary.
        [CustomCategoryAttribute("Touch_Category")]
        public event EventHandler<ManipulationBoundaryFeedbackEventArgs> ManipulationBoundaryFeedback;

        //
        // Summary:
        //     Adds a routed event handler for a specified routed event, adding the handler
        //     to the handler collection on the current element.
        //
        // Parameters:
        //   routedEvent:
        //     An identifier for the routed event to be handled.
        //
        //   handler:
        //     A reference to the handler implementation.
        [TargetedPatchingOptOut("Performance critical to inline this type of method across NGen image boundaries")]
        public void AddHandler(RoutedEvent routedEvent, Delegate handler);
        //
        // Summary:
        //     Adds a routed event handler for a specified routed event, adding the handler
        //     to the handler collection on the current element. Specify handledEventsToo as
        //     true to have the provided handler be invoked for routed event that had already
        //     been marked as handled by another element along the event route.
        //
        // Parameters:
        //   routedEvent:
        //     An identifier for the routed event to be handled.
        //
        //   handler:
        //     A reference to the handler implementation.
        //
        //   handledEventsToo:
        //     true to register the handler such that it is invoked even when the routed event
        //     is marked handled in its event data; false to register the handler with the default
        //     condition that it will not be invoked if the routed event is already marked handled.
        //     The default is false.Do not routinely ask to rehandle a routed event. For more
        //     information, see Remarks.
        public void AddHandler(RoutedEvent routedEvent, Delegate handler, bool handledEventsToo);
        //
        // Summary:
        //     Adds handlers to the specified System.Windows.EventRoute for the current System.Windows.UIElement
        //     event handler collection.
        //
        // Parameters:
        //   route:
        //     The event route that handlers are added to.
        //
        //   e:
        //     The event data that is used to add the handlers. This method uses the System.Windows.RoutedEventArgs.RoutedEvent
        //     property of the event data to create the handlers.
        public void AddToEventRoute(EventRoute route, RoutedEventArgs e);
        //
        // Summary:
        //     Applies an animation to a specified dependency property on this element, with
        //     the ability to specify what happens if the property already has a running animation.
        //
        // Parameters:
        //   dp:
        //     The property to animate.
        //
        //   clock:
        //     The animation clock that controls and declares the animation.
        //
        //   handoffBehavior:
        //     A value of the enumeration. The default is System.Windows.Media.Animation.HandoffBehavior.SnapshotAndReplace,
        //     which will stop any existing animation and replace with the new one.
        public void ApplyAnimationClock(DependencyProperty dp, AnimationClock clock, HandoffBehavior handoffBehavior);
        //
        // Summary:
        //     Applies an animation to a specified dependency property on this element. Any
        //     existing animations are stopped and replaced with the new animation.
        //
        // Parameters:
        //   dp:
        //     The identifier for the property to animate.
        //
        //   clock:
        //     The animation clock that controls and declares the animation.
        [TargetedPatchingOptOut("Performance critical to inline this type of method across NGen image boundaries")]
        public void ApplyAnimationClock(DependencyProperty dp, AnimationClock clock);
        //
        // Summary:
        //     Positions child elements and determines a size for a System.Windows.UIElement.
        //     Parent elements call this method from their System.Windows.UIElement.ArrangeCore(System.Windows.Rect)
        //     implementation (or a WPF framework-level equivalent) to form a recursive layout
        //     update. This method constitutes the second pass of a layout update.
        //
        // Parameters:
        //   finalRect:
        //     The final size that the parent computes for the child element, provided as a
        //     System.Windows.Rect instance.
        public void Arrange(Rect finalRect);
        //
        // Summary:
        //     Starts a specific animation for a specified animated property on this element,
        //     with the option of specifying what happens if the property already has a running
        //     animation.
        //
        // Parameters:
        //   dp:
        //     The property to animate, which is specified as the dependency property identifier.
        //
        //   animation:
        //     The timeline of the animation to be applied.
        //
        //   handoffBehavior:
        //     A value of the enumeration that specifies how the new animation interacts with
        //     any current (running) animations that are already affecting the property value.
        public void BeginAnimation(DependencyProperty dp, AnimationTimeline animation, HandoffBehavior handoffBehavior);
        //
        // Summary:
        //     Starts an animation for a specified animated property on this element.
        //
        // Parameters:
        //   dp:
        //     The property to animate, which is specified as a dependency property identifier.
        //
        //   animation:
        //     The timeline of the animation to start.
        [TargetedPatchingOptOut("Performance critical to inline this type of method across NGen image boundaries")]
        public void BeginAnimation(DependencyProperty dp, AnimationTimeline animation);
        //
        // Summary:
        //     Attempts to force capture of the mouse to this element.
        //
        // Returns:
        //     true if the mouse is successfully captured; otherwise, false.
        public bool CaptureMouse();
        //
        // Summary:
        //     Attempts to force capture of the stylus to this element.
        //
        // Returns:
        //     true if the stylus was successfully captured; otherwise, false.
        public bool CaptureStylus();
        //
        // Summary:
        //     Attempts to force capture of a touch to this element.
        //
        // Parameters:
        //   touchDevice:
        //     The device to capture.
        //
        // Returns:
        //     true if the specified touch is captured to this element; otherwise, false.
        //
        // Exceptions:
        //   T:System.ArgumentNullException:
        //     touchDevice is null.
        public bool CaptureTouch(TouchDevice touchDevice);
        //
        // Summary:
        //     Attempts to set focus to this element.
        //
        // Returns:
        //     true if keyboard focus and logical focus were set to this element; false if only
        //     logical focus was set to this element, or if the call to this method did not
        //     force the focus to change.
        public bool Focus();
        //
        // Summary:
        //     Returns the base property value for the specified property on this element, disregarding
        //     any possible animated value from a running or stopped animation.
        //
        // Parameters:
        //   dp:
        //     The dependency property to check.
        //
        // Returns:
        //     The property value as if no animations are attached to the specified dependency
        //     property.
        public object GetAnimationBaseValue(DependencyProperty dp);
        //
        // Summary:
        //     Returns the input element within the current element that is at the specified
        //     coordinates, relative to the current element's origin.
        //
        // Parameters:
        //   point:
        //     The offset coordinates within this element.
        //
        // Returns:
        //     The element child that is located at the given position.
        public IInputElement InputHitTest(Point point);
        //
        // Summary:
        //     Invalidates the arrange state (layout) for the element. After the invalidation,
        //     the element will have its layout updated, which will occur asynchronously unless
        //     subsequently forced by System.Windows.UIElement.UpdateLayout.
        public void InvalidateArrange();
        //
        // Summary:
        //     Invalidates the measurement state (layout) for the element.
        public void InvalidateMeasure();
        //
        // Summary:
        //     Invalidates the rendering of the element, and forces a complete new layout pass.
        //     System.Windows.UIElement.OnRender(System.Windows.Media.DrawingContext) is called
        //     after the layout cycle is completed.
        public void InvalidateVisual();
        //
        // Summary:
        //     Updates the System.Windows.UIElement.DesiredSize of a System.Windows.UIElement.
        //     Parent elements call this method from their own System.Windows.UIElement.MeasureCore(System.Windows.Size)
        //     implementations to form a recursive layout update. Calling this method constitutes
        //     the first pass (the "Measure" pass) of a layout update.
        //
        // Parameters:
        //   availableSize:
        //     The available space that a parent element can allocate a child element. A child
        //     element can request a larger space than what is available; the provided size
        //     might be accommodated if scrolling is possible in the content model for the current
        //     element.
        public void Measure(Size availableSize);
        //
        // Summary:
        //     Attempts to move focus from this element to another element. The direction to
        //     move focus is specified by a guidance direction, which is interpreted within
        //     the organization of the visual parent for this element.
        //
        // Parameters:
        //   request:
        //     A traversal request, which contains a property that indicates either a mode to
        //     traverse in existing tab order, or a direction to move visually.
        //
        // Returns:
        //     true if the requested traversal was performed; otherwise, false.
        public virtual bool MoveFocus(TraversalRequest request);
        //
        // Summary:
        //     When overridden in a derived class, returns the element that would receive focus
        //     for a specified focus traversal direction, without actually moving focus to that
        //     element.
        //
        // Parameters:
        //   direction:
        //     The direction of the requested focus traversal.
        //
        // Returns:
        //     The element that would have received focus if System.Windows.UIElement.MoveFocus(System.Windows.Input.TraversalRequest)
        //     were actually invoked.
        public virtual DependencyObject PredictFocus(FocusNavigationDirection direction);
        //
        // Summary:
        //     Raises a specific routed event. The System.Windows.RoutedEvent to be raised is
        //     identified within the System.Windows.RoutedEventArgs instance that is provided
        //     (as the System.Windows.RoutedEventArgs.RoutedEvent property of that event data).
        //
        // Parameters:
        //   e:
        //     A System.Windows.RoutedEventArgs that contains the event data and also identifies
        //     the event to raise.
        public void RaiseEvent(RoutedEventArgs e);
        //
        // Summary:
        //     Releases all captured touch devices from this element.
        public void ReleaseAllTouchCaptures();
        //
        // Summary:
        //     Releases the mouse capture, if this element held the capture.
        public void ReleaseMouseCapture();
        //
        // Summary:
        //     Releases the stylus device capture, if this element held the capture.
        public void ReleaseStylusCapture();
        //
        // Summary:
        //     Attempts to release the specified touch device from this element.
        //
        // Parameters:
        //   touchDevice:
        //     The device to release.
        //
        // Returns:
        //     true if the touch device is released; otherwise, false.
        //
        // Exceptions:
        //   T:System.ArgumentNullException:
        //     touchDevice is null.
        public bool ReleaseTouchCapture(TouchDevice touchDevice);
        //
        // Summary:
        //     Removes the specified routed event handler from this element.
        //
        // Parameters:
        //   routedEvent:
        //     The identifier of the routed event for which the handler is attached.
        //
        //   handler:
        //     The specific handler implementation to remove from the event handler collection
        //     on this element.
        public void RemoveHandler(RoutedEvent routedEvent, Delegate handler);
        //
        // Summary:
        //     Returns whether serialization processes should serialize the contents of the
        //     System.Windows.UIElement.CommandBindings property on instances of this class.
        //
        // Returns:
        //     true if the System.Windows.UIElement.CommandBindings property value should be
        //     serialized; otherwise, false.
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeCommandBindings();
        //
        // Summary:
        //     Returns whether serialization processes should serialize the contents of the
        //     System.Windows.UIElement.InputBindings property on instances of this class.
        //
        // Returns:
        //     true if the System.Windows.UIElement.InputBindings property value should be serialized;
        //     otherwise, false.
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeInputBindings();
        //
        // Summary:
        //     Translates a point relative to this element to coordinates that are relative
        //     to the specified element.
        //
        // Parameters:
        //   point:
        //     The point value, as relative to this element.
        //
        //   relativeTo:
        //     The element to translate the given point into.
        //
        // Returns:
        //     A point value, now relative to the target element rather than this source element.
        public Point TranslatePoint(Point point, UIElement relativeTo);
        //
        // Summary:
        //     Ensures that all visual child elements of this element are properly updated for
        //     layout.
        public void UpdateLayout();
        //
        // Summary:
        //     Defines the template for WPF core-level arrange layout definition.
        //
        // Parameters:
        //   finalRect:
        //     The final area within the parent that element should use to arrange itself and
        //     its child elements.
        protected virtual void ArrangeCore(Rect finalRect);
        //
        // Summary:
        //     Returns an alternative clipping geometry that represents the region that would
        //     be clipped if System.Windows.UIElement.ClipToBounds were set to true.
        //
        // Parameters:
        //   layoutSlotSize:
        //     The available size provided by the element.
        //
        // Returns:
        //     The potential clipping geometry.
        protected virtual Geometry GetLayoutClip(Size layoutSlotSize);
        //
        // Summary:
        //     Implements System.Windows.Media.Visual.HitTestCore(System.Windows.Media.PointHitTestParameters)
        //     to supply base element hit testing behavior (returning System.Windows.Media.HitTestResult).
        //
        // Parameters:
        //   hitTestParameters:
        //     Describes the hit test to perform, including the initial hit point.
        //
        // Returns:
        //     Results of the test, including the evaluated point.
        protected override HitTestResult HitTestCore(PointHitTestParameters hitTestParameters);
        //
        // Summary:
        //     Implements System.Windows.Media.Visual.HitTestCore(System.Windows.Media.GeometryHitTestParameters)
        //     to supply base element hit testing behavior (returning System.Windows.Media.GeometryHitTestResult).
        //
        // Parameters:
        //   hitTestParameters:
        //     Describes the hit test to perform, including the initial hit point.
        //
        // Returns:
        //     Results of the test, including the evaluated geometry.
        protected override GeometryHitTestResult HitTestCore(GeometryHitTestParameters hitTestParameters);
        //
        // Summary:
        //     When overridden in a derived class, provides measurement logic for sizing this
        //     element properly, with consideration of the size of any child element content.
        //
        // Parameters:
        //   availableSize:
        //     The available size that the parent element can allocate for the child.
        //
        // Returns:
        //     The desired size of this element in layout.
        protected virtual Size MeasureCore(Size availableSize);
        //
        // Summary:
        //     Provides class handling for when an access key that is meaningful for this element
        //     is invoked.
        //
        // Parameters:
        //   e:
        //     The event data to the access key event. The event data reports which key was
        //     invoked, and indicate whether the System.Windows.Input.AccessKeyManager object
        //     that controls the sending of these events also sent this access key invocation
        //     to other elements.
        protected virtual void OnAccessKey(AccessKeyEventArgs e);
        //
        // Summary:
        //     Supports layout behavior when a child element is resized.
        //
        // Parameters:
        //   child:
        //     The child element that is being resized.
        protected virtual void OnChildDesiredSizeChanged(UIElement child);
        //
        // Summary:
        //     Returns class-specific System.Windows.Automation.Peers.AutomationPeer implementations
        //     for the Windows Presentation Foundation (WPF) infrastructure.
        //
        // Returns:
        //     The type-specific System.Windows.Automation.Peers.AutomationPeer implementation.
        protected virtual AutomationPeer OnCreateAutomationPeer();
        //
        // Summary:
        //     Invoked when an unhandled System.Windows.DragDrop.DragEnter attached event reaches
        //     an element in its route that is derived from this class. Implement this method
        //     to add class handling for this event.
        //
        // Parameters:
        //   e:
        //     The System.Windows.DragEventArgs that contains the event data.
        protected virtual void OnDragEnter(DragEventArgs e);
        //
        // Summary:
        //     Invoked when an unhandled System.Windows.DragDrop.DragLeave attached event reaches
        //     an element in its route that is derived from this class. Implement this method
        //     to add class handling for this event.
        //
        // Parameters:
        //   e:
        //     The System.Windows.DragEventArgs that contains the event data.
        protected virtual void OnDragLeave(DragEventArgs e);
        //
        // Summary:
        //     Invoked when an unhandled System.Windows.DragDrop.DragOver attached event reaches
        //     an element in its route that is derived from this class. Implement this method
        //     to add class handling for this event.
        //
        // Parameters:
        //   e:
        //     The System.Windows.DragEventArgs that contains the event data.
        protected virtual void OnDragOver(DragEventArgs e);
        //
        // Summary:
        //     Invoked when an unhandled System.Windows.DragDrop.DragEnter attached event reaches
        //     an element in its route that is derived from this class. Implement this method
        //     to add class handling for this event.
        //
        // Parameters:
        //   e:
        //     The System.Windows.DragEventArgs that contains the event data.
        protected virtual void OnDrop(DragEventArgs e);
        //
        // Summary:
        //     Invoked when an unhandled System.Windows.DragDrop.GiveFeedback attached event
        //     reaches an element in its route that is derived from this class. Implement this
        //     method to add class handling for this event.
        //
        // Parameters:
        //   e:
        //     The System.Windows.GiveFeedbackEventArgs that contains the event data.
        protected virtual void OnGiveFeedback(GiveFeedbackEventArgs e);
        //
        // Summary:
        //     Raises the System.Windows.UIElement.GotFocus routed event by using the event
        //     data provided.
        //
        // Parameters:
        //   e:
        //     A System.Windows.RoutedEventArgs that contains event data. This event data must
        //     contain the identifier for the System.Windows.UIElement.GotFocus event.
        [TargetedPatchingOptOut("Performance critical to inline this type of method across NGen image boundaries")]
        protected virtual void OnGotFocus(RoutedEventArgs e);
        //
        // Summary:
        //     Invoked when an unhandled System.Windows.Input.Keyboard.GotKeyboardFocus attached
        //     event reaches an element in its route that is derived from this class. Implement
        //     this method to add class handling for this event.
        //
        // Parameters:
        //   e:
        //     The System.Windows.Input.KeyboardFocusChangedEventArgs that contains the event
        //     data.
        protected virtual void OnGotKeyboardFocus(KeyboardFocusChangedEventArgs e);
        //
        // Summary:
        //     Invoked when an unhandled System.Windows.Input.Mouse.GotMouseCapture attached
        //     event reaches an element in its route that is derived from this class. Implement
        //     this method to add class handling for this event.
        //
        // Parameters:
        //   e:
        //     The System.Windows.Input.MouseEventArgs that contains the event data.
        protected virtual void OnGotMouseCapture(MouseEventArgs e);
        //
        // Summary:
        //     Invoked when an unhandled System.Windows.Input.Stylus.GotStylusCapture attached
        //     event reaches an element in its route that is derived from this class. Implement
        //     this method to add class handling for this event.
        //
        // Parameters:
        //   e:
        //     The System.Windows.Input.StylusEventArgs that contains the event data.
        protected virtual void OnGotStylusCapture(StylusEventArgs e);
        //
        // Summary:
        //     Provides class handling for the System.Windows.UIElement.GotTouchCapture routed
        //     event that occurs when a touch is captured to this element.
        //
        // Parameters:
        //   e:
        //     A System.Windows.Input.TouchEventArgs that contains the event data.
        protected virtual void OnGotTouchCapture(TouchEventArgs e);
        //
        // Summary:
        //     Invoked when an unhandled System.Windows.UIElement.IsKeyboardFocusedChanged event
        //     is raised on this element. Implement this method to add class handling for this
        //     event.
        //
        // Parameters:
        //   e:
        //     The System.Windows.DependencyPropertyChangedEventArgs that contains the event
        //     data.
        protected virtual void OnIsKeyboardFocusedChanged(DependencyPropertyChangedEventArgs e);
        //
        // Summary:
        //     Invoked just before the System.Windows.UIElement.IsKeyboardFocusWithinChanged
        //     event is raised by this element. Implement this method to add class handling
        //     for this event.
        //
        // Parameters:
        //   e:
        //     A System.Windows.DependencyPropertyChangedEventArgs that contains the event data.
        protected virtual void OnIsKeyboardFocusWithinChanged(DependencyPropertyChangedEventArgs e);
        //
        // Summary:
        //     Invoked when an unhandled System.Windows.UIElement.IsMouseCapturedChanged event
        //     is raised on this element. Implement this method to add class handling for this
        //     event.
        //
        // Parameters:
        //   e:
        //     The System.Windows.DependencyPropertyChangedEventArgs that contains the event
        //     data.
        protected virtual void OnIsMouseCapturedChanged(DependencyPropertyChangedEventArgs e);
        //
        // Summary:
        //     Invoked when an unhandled System.Windows.UIElement.IsMouseCaptureWithinChanged
        //     event is raised on this element. Implement this method to add class handling
        //     for this event.
        //
        // Parameters:
        //   e:
        //     A System.Windows.DependencyPropertyChangedEventArgs that contains the event data.
        protected virtual void OnIsMouseCaptureWithinChanged(DependencyPropertyChangedEventArgs e);
        //
        // Summary:
        //     Invoked when an unhandled System.Windows.UIElement.IsMouseDirectlyOverChanged
        //     event is raised on this element. Implement this method to add class handling
        //     for this event.
        //
        // Parameters:
        //   e:
        //     The System.Windows.DependencyPropertyChangedEventArgs that contains the event
        //     data.
        protected virtual void OnIsMouseDirectlyOverChanged(DependencyPropertyChangedEventArgs e);
        //
        // Summary:
        //     Invoked when an unhandled System.Windows.UIElement.IsStylusCapturedChanged event
        //     is raised on this element. Implement this method to add class handling for this
        //     event.
        //
        // Parameters:
        //   e:
        //     A System.Windows.DependencyPropertyChangedEventArgs that contains the event data.
        protected virtual void OnIsStylusCapturedChanged(DependencyPropertyChangedEventArgs e);
        //
        // Summary:
        //     Invoked when an unhandled System.Windows.UIElement.IsStylusCaptureWithinChanged
        //     event is raised on this element. Implement this method to add class handling
        //     for this event.
        //
        // Parameters:
        //   e:
        //     The System.Windows.DependencyPropertyChangedEventArgs that contains the event
        //     data.
        protected virtual void OnIsStylusCaptureWithinChanged(DependencyPropertyChangedEventArgs e);
        //
        // Summary:
        //     Invoked when an unhandled System.Windows.UIElement.IsStylusDirectlyOverChanged
        //     event is raised on this element. Implement this method to add class handling
        //     for this event.
        //
        // Parameters:
        //   e:
        //     The System.Windows.DependencyPropertyChangedEventArgs that contains the event
        //     data.
        protected virtual void OnIsStylusDirectlyOverChanged(DependencyPropertyChangedEventArgs e);
        //
        // Summary:
        //     Invoked when an unhandled System.Windows.Input.Keyboard.KeyDown attached event
        //     reaches an element in its route that is derived from this class. Implement this
        //     method to add class handling for this event.
        //
        // Parameters:
        //   e:
        //     The System.Windows.Input.KeyEventArgs that contains the event data.
        protected virtual void OnKeyDown(KeyEventArgs e);
        //
        // Summary:
        //     Invoked when an unhandled System.Windows.Input.Keyboard.KeyUp attached event
        //     reaches an element in its route that is derived from this class. Implement this
        //     method to add class handling for this event.
        //
        // Parameters:
        //   e:
        //     The System.Windows.Input.KeyEventArgs that contains the event data.
        protected virtual void OnKeyUp(KeyEventArgs e);
        //
        // Summary:
        //     Raises the System.Windows.UIElement.LostFocus routed event by using the event
        //     data that is provided.
        //
        // Parameters:
        //   e:
        //     A System.Windows.RoutedEventArgs that contains event data. This event data must
        //     contain the identifier for the System.Windows.UIElement.LostFocus event.
        [TargetedPatchingOptOut("Performance critical to inline this type of method across NGen image boundaries")]
        protected virtual void OnLostFocus(RoutedEventArgs e);
        //
        // Summary:
        //     Invoked when an unhandled System.Windows.Input.Keyboard.LostKeyboardFocus attached
        //     event reaches an element in its route that is derived from this class. Implement
        //     this method to add class handling for this event.
        //
        // Parameters:
        //   e:
        //     The System.Windows.Input.KeyboardFocusChangedEventArgs that contains event data.
        protected virtual void OnLostKeyboardFocus(KeyboardFocusChangedEventArgs e);
        //
        // Summary:
        //     Invoked when an unhandled System.Windows.Input.Mouse.LostMouseCapture attached
        //     event reaches an element in its route that is derived from this class. Implement
        //     this method to add class handling for this event.
        //
        // Parameters:
        //   e:
        //     The System.Windows.Input.MouseEventArgs that contains event data.
        protected virtual void OnLostMouseCapture(MouseEventArgs e);
        //
        // Summary:
        //     Invoked when an unhandled System.Windows.Input.Stylus.LostStylusCapture attached
        //     event reaches an element in its route that is derived from this class. Implement
        //     this method to add class handling for this event.
        //
        // Parameters:
        //   e:
        //     The System.Windows.Input.StylusEventArgs that contains event data.
        protected virtual void OnLostStylusCapture(StylusEventArgs e);
        //
        // Summary:
        //     Provides class handling for the System.Windows.UIElement.LostTouchCapture routed
        //     event that occurs when this element loses a touch capture.
        //
        // Parameters:
        //   e:
        //     A System.Windows.Input.TouchEventArgs that contains the event data.
        protected virtual void OnLostTouchCapture(TouchEventArgs e);
        //
        // Summary:
        //     Called when the System.Windows.UIElement.ManipulationBoundaryFeedback event occurs.
        //
        // Parameters:
        //   e:
        //     The data for the event.
        protected virtual void OnManipulationBoundaryFeedback(ManipulationBoundaryFeedbackEventArgs e);
        //
        // Summary:
        //     Called when the System.Windows.UIElement.ManipulationCompleted event occurs.
        //
        // Parameters:
        //   e:
        //     The data for the event.
        protected virtual void OnManipulationCompleted(ManipulationCompletedEventArgs e);
        //
        // Summary:
        //     Called when the System.Windows.UIElement.ManipulationDelta event occurs.
        //
        // Parameters:
        //   e:
        //     The data for the event.
        protected virtual void OnManipulationDelta(ManipulationDeltaEventArgs e);
        //
        // Summary:
        //     Called when the System.Windows.UIElement.ManipulationInertiaStarting event occurs.
        //
        // Parameters:
        //   e:
        //     The data for the event.
        protected virtual void OnManipulationInertiaStarting(ManipulationInertiaStartingEventArgs e);
        //
        // Summary:
        //     Called when the System.Windows.UIElement.ManipulationStarted event occurs.
        //
        // Parameters:
        //   e:
        //     The data for the event.
        protected virtual void OnManipulationStarted(ManipulationStartedEventArgs e);
        //
        // Summary:
        //     Provides class handling for the System.Windows.UIElement.ManipulationStarting
        //     routed event that occurs when the manipulation processor is first created.
        //
        // Parameters:
        //   e:
        //     A System.Windows.Input.ManipulationStartingEventArgs that contains the event
        //     data.
        protected virtual void OnManipulationStarting(ManipulationStartingEventArgs e);
        //
        // Summary:
        //     Invoked when an unhandled System.Windows.Input.Mouse.MouseDown attached event
        //     reaches an element in its route that is derived from this class. Implement this
        //     method to add class handling for this event.
        //
        // Parameters:
        //   e:
        //     The System.Windows.Input.MouseButtonEventArgs that contains the event data. This
        //     event data reports details about the mouse button that was pressed and the handled
        //     state.
        protected virtual void OnMouseDown(MouseButtonEventArgs e);
        //
        // Summary:
        //     Invoked when an unhandled System.Windows.Input.Mouse.MouseEnter attached event
        //     is raised on this element. Implement this method to add class handling for this
        //     event.
        //
        // Parameters:
        //   e:
        //     The System.Windows.Input.MouseEventArgs that contains the event data.
        protected virtual void OnMouseEnter(MouseEventArgs e);
        //
        // Summary:
        //     Invoked when an unhandled System.Windows.Input.Mouse.MouseLeave attached event
        //     is raised on this element. Implement this method to add class handling for this
        //     event.
        //
        // Parameters:
        //   e:
        //     The System.Windows.Input.MouseEventArgs that contains the event data.
        protected virtual void OnMouseLeave(MouseEventArgs e);
        //
        // Summary:
        //     Invoked when an unhandled System.Windows.UIElement.MouseLeftButtonDown routed
        //     event is raised on this element. Implement this method to add class handling
        //     for this event.
        //
        // Parameters:
        //   e:
        //     The System.Windows.Input.MouseButtonEventArgs that contains the event data. The
        //     event data reports that the left mouse button was pressed.
        protected virtual void OnMouseLeftButtonDown(MouseButtonEventArgs e);
        //
        // Summary:
        //     Invoked when an unhandled System.Windows.UIElement.MouseLeftButtonUp routed event
        //     reaches an element in its route that is derived from this class. Implement this
        //     method to add class handling for this event.
        //
        // Parameters:
        //   e:
        //     The System.Windows.Input.MouseButtonEventArgs that contains the event data. The
        //     event data reports that the left mouse button was released.
        protected virtual void OnMouseLeftButtonUp(MouseButtonEventArgs e);
        //
        // Summary:
        //     Invoked when an unhandled System.Windows.Input.Mouse.MouseMove attached event
        //     reaches an element in its route that is derived from this class. Implement this
        //     method to add class handling for this event.
        //
        // Parameters:
        //   e:
        //     The System.Windows.Input.MouseEventArgs that contains the event data.
        protected virtual void OnMouseMove(MouseEventArgs e);
        //
        // Summary:
        //     Invoked when an unhandled System.Windows.UIElement.MouseRightButtonDown routed
        //     event reaches an element in its route that is derived from this class. Implement
        //     this method to add class handling for this event.
        //
        // Parameters:
        //   e:
        //     The System.Windows.Input.MouseButtonEventArgs that contains the event data. The
        //     event data reports that the right mouse button was pressed.
        protected virtual void OnMouseRightButtonDown(MouseButtonEventArgs e);
        //
        // Summary:
        //     Invoked when an unhandled System.Windows.UIElement.MouseRightButtonUp routed
        //     event reaches an element in its route that is derived from this class. Implement
        //     this method to add class handling for this event.
        //
        // Parameters:
        //   e:
        //     The System.Windows.Input.MouseButtonEventArgs that contains the event data. The
        //     event data reports that the right mouse button was released.
        protected virtual void OnMouseRightButtonUp(MouseButtonEventArgs e);
        //
        // Summary:
        //     Invoked when an unhandled System.Windows.Input.Mouse.MouseUp routed event reaches
        //     an element in its route that is derived from this class. Implement this method
        //     to add class handling for this event.
        //
        // Parameters:
        //   e:
        //     The System.Windows.Input.MouseButtonEventArgs that contains the event data. The
        //     event data reports that the mouse button was released.
        protected virtual void OnMouseUp(MouseButtonEventArgs e);
        //
        // Summary:
        //     Invoked when an unhandled System.Windows.Input.Mouse.MouseWheel attached event
        //     reaches an element in its route that is derived from this class. Implement this
        //     method to add class handling for this event.
        //
        // Parameters:
        //   e:
        //     The System.Windows.Input.MouseWheelEventArgs that contains the event data.
        protected virtual void OnMouseWheel(MouseWheelEventArgs e);
        //
        // Summary:
        //     Invoked when an unhandled System.Windows.DragDrop.PreviewDragEnter attached event
        //     reaches an element in its route that is derived from this class. Implement this
        //     method to add class handling for this event.
        //
        // Parameters:
        //   e:
        //     The System.Windows.DragEventArgs that contains the event data.
        protected virtual void OnPreviewDragEnter(DragEventArgs e);
        //
        // Summary:
        //     Invoked when an unhandled System.Windows.DragDrop.PreviewDragLeave attached event
        //     reaches an element in its route that is derived from this class. Implement this
        //     method to add class handling for this event.
        //
        // Parameters:
        //   e:
        //     The System.Windows.DragEventArgs that contains the event data.
        protected virtual void OnPreviewDragLeave(DragEventArgs e);
        //
        // Summary:
        //     Invoked when an unhandled System.Windows.DragDrop.PreviewDragOver attached event
        //     reaches an element in its route that is derived from this class. Implement this
        //     method to add class handling for this event.
        //
        // Parameters:
        //   e:
        //     The System.Windows.DragEventArgs that contains the event data.
        protected virtual void OnPreviewDragOver(DragEventArgs e);
        //
        // Summary:
        //     Invoked when an unhandled System.Windows.DragDrop.PreviewDrop attached event
        //     reaches an element in its route that is derived from this class. Implement this
        //     method to add class handling for this event.
        //
        // Parameters:
        //   e:
        //     The System.Windows.DragEventArgs that contains the event data.
        protected virtual void OnPreviewDrop(DragEventArgs e);
        //
        // Summary:
        //     Invoked when an unhandled System.Windows.DragDrop.PreviewGiveFeedback attached
        //     event reaches an element in its route that is derived from this class. Implement
        //     this method to add class handling for this event.
        //
        // Parameters:
        //   e:
        //     The System.Windows.GiveFeedbackEventArgs that contains the event data.
        protected virtual void OnPreviewGiveFeedback(GiveFeedbackEventArgs e);
        //
        // Summary:
        //     Invoked when an unhandled System.Windows.Input.Keyboard.PreviewGotKeyboardFocus
        //     attached event reaches an element in its route that is derived from this class.
        //     Implement this method to add class handling for this event.
        //
        // Parameters:
        //   e:
        //     The System.Windows.Input.KeyboardFocusChangedEventArgs that contains the event
        //     data.
        protected virtual void OnPreviewGotKeyboardFocus(KeyboardFocusChangedEventArgs e);
        //
        // Summary:
        //     Invoked when an unhandled System.Windows.Input.Keyboard.PreviewKeyDown attached
        //     event reaches an element in its route that is derived from this class. Implement
        //     this method to add class handling for this event.
        //
        // Parameters:
        //   e:
        //     The System.Windows.Input.KeyEventArgs that contains the event data.
        protected virtual void OnPreviewKeyDown(KeyEventArgs e);
        //
        // Summary:
        //     Invoked when an unhandled System.Windows.Input.Keyboard.PreviewKeyUp attached
        //     event reaches an element in its route that is derived from this class. Implement
        //     this method to add class handling for this event.
        //
        // Parameters:
        //   e:
        //     The System.Windows.Input.KeyEventArgs that contains the event data.
        protected virtual void OnPreviewKeyUp(KeyEventArgs e);
        //
        // Summary:
        //     Invoked when an unhandled System.Windows.Input.Keyboard.PreviewKeyDown attached
        //     event reaches an element in its route that is derived from this class. Implement
        //     this method to add class handling for this event.
        //
        // Parameters:
        //   e:
        //     The System.Windows.Input.KeyboardFocusChangedEventArgs that contains the event
        //     data.
        protected virtual void OnPreviewLostKeyboardFocus(KeyboardFocusChangedEventArgs e);
        //
        // Summary:
        //     Invoked when an unhandled System.Windows.Input.Mouse.PreviewMouseDown attached
        //     routed event reaches an element in its route that is derived from this class.
        //     Implement this method to add class handling for this event.
        //
        // Parameters:
        //   e:
        //     The System.Windows.Input.MouseButtonEventArgs that contains the event data. The
        //     event data reports that one or more mouse buttons were pressed.
        protected virtual void OnPreviewMouseDown(MouseButtonEventArgs e);
        //
        // Summary:
        //     Invoked when an unhandled System.Windows.UIElement.PreviewMouseLeftButtonDown
        //     routed event reaches an element in its route that is derived from this class.
        //     Implement this method to add class handling for this event.
        //
        // Parameters:
        //   e:
        //     The System.Windows.Input.MouseButtonEventArgs that contains the event data. The
        //     event data reports that the left mouse button was pressed.
        protected virtual void OnPreviewMouseLeftButtonDown(MouseButtonEventArgs e);
        //
        // Summary:
        //     Invoked when an unhandled System.Windows.UIElement.PreviewMouseLeftButtonUp routed
        //     event reaches an element in its route that is derived from this class. Implement
        //     this method to add class handling for this event.
        //
        // Parameters:
        //   e:
        //     The System.Windows.Input.MouseButtonEventArgs that contains the event data. The
        //     event data reports that the left mouse button was released.
        protected virtual void OnPreviewMouseLeftButtonUp(MouseButtonEventArgs e);
        //
        // Summary:
        //     Invoked when an unhandled System.Windows.Input.Mouse.PreviewMouseMove attached
        //     event reaches an element in its route that is derived from this class. Implement
        //     this method to add class handling for this event.
        //
        // Parameters:
        //   e:
        //     The System.Windows.Input.MouseEventArgs that contains the event data.
        protected virtual void OnPreviewMouseMove(MouseEventArgs e);
        //
        // Summary:
        //     Invoked when an unhandled System.Windows.UIElement.PreviewMouseRightButtonDown
        //     routed event reaches an element in its route that is derived from this class.
        //     Implement this method to add class handling for this event.
        //
        // Parameters:
        //   e:
        //     The System.Windows.Input.MouseButtonEventArgs that contains the event data. The
        //     event data reports that the right mouse button was pressed.
        protected virtual void OnPreviewMouseRightButtonDown(MouseButtonEventArgs e);
        //
        // Summary:
        //     Invoked when an unhandled System.Windows.UIElement.PreviewMouseRightButtonUp
        //     routed event reaches an element in its route that is derived from this class.
        //     Implement this method to add class handling for this event.
        //
        // Parameters:
        //   e:
        //     The System.Windows.Input.MouseButtonEventArgs that contains the event data. The
        //     event data reports that the right mouse button was released.
        protected virtual void OnPreviewMouseRightButtonUp(MouseButtonEventArgs e);
        //
        // Summary:
        //     Invoked when an unhandled System.Windows.Input.Mouse.PreviewMouseUp attached
        //     event reaches an element in its route that is derived from this class. Implement
        //     this method to add class handling for this event.
        //
        // Parameters:
        //   e:
        //     The System.Windows.Input.MouseButtonEventArgs that contains the event data. The
        //     event data reports that one or more mouse buttons were released.
        protected virtual void OnPreviewMouseUp(MouseButtonEventArgs e);
        //
        // Summary:
        //     Invoked when an unhandled System.Windows.Input.Mouse.PreviewMouseWheel attached
        //     event reaches an element in its route that is derived from this class. Implement
        //     this method to add class handling for this event.
        //
        // Parameters:
        //   e:
        //     The System.Windows.Input.MouseWheelEventArgs that contains the event data.
        protected virtual void OnPreviewMouseWheel(MouseWheelEventArgs e);
        //
        // Summary:
        //     Invoked when an unhandled System.Windows.DragDrop.PreviewQueryContinueDrag attached
        //     event reaches an element in its route that is derived from this class. Implement
        //     this method to add class handling for this event.
        //
        // Parameters:
        //   e:
        //     The System.Windows.QueryContinueDragEventArgs that contains the event data.
        protected virtual void OnPreviewQueryContinueDrag(QueryContinueDragEventArgs e);
        //
        // Summary:
        //     Invoked when an unhandled System.Windows.Input.Stylus.PreviewStylusButtonDown
        //     attached event reaches an element in its route that is derived from this class.
        //     Implement this method to add class handling for this event.
        //
        // Parameters:
        //   e:
        //     The System.Windows.Input.StylusButtonEventArgs that contains the event data.
        protected virtual void OnPreviewStylusButtonDown(StylusButtonEventArgs e);
        //
        // Summary:
        //     Invoked when an unhandled System.Windows.Input.Stylus.PreviewStylusButtonUp attached
        //     event reaches an element in its route that is derived from this class. Implement
        //     this method to add class handling for this event.
        //
        // Parameters:
        //   e:
        //     The System.Windows.Input.StylusButtonEventArgs that contains the event data.
        protected virtual void OnPreviewStylusButtonUp(StylusButtonEventArgs e);
        //
        // Summary:
        //     Invoked when an unhandled System.Windows.Input.Stylus.PreviewStylusDown attached
        //     event reaches an element in its route that is derived from this class. Implement
        //     this method to add class handling for this event.
        //
        // Parameters:
        //   e:
        //     The System.Windows.Input.StylusDownEventArgs that contains the event data.
        protected virtual void OnPreviewStylusDown(StylusDownEventArgs e);
        //
        // Summary:
        //     Invoked when an unhandled System.Windows.Input.Stylus.PreviewStylusInAirMove
        //     attached event reaches an element in its route that is derived from this class.
        //     Implement this method to add class handling for this event.
        //
        // Parameters:
        //   e:
        //     The System.Windows.Input.StylusEventArgs that contains the event data.
        protected virtual void OnPreviewStylusInAirMove(StylusEventArgs e);
        //
        // Summary:
        //     Invoked when an unhandled System.Windows.Input.Stylus.PreviewStylusInRange attached
        //     event reaches an element in its route that is derived from this class. Implement
        //     this method to add class handling for this event.
        //
        // Parameters:
        //   e:
        //     The System.Windows.Input.StylusEventArgs that contains the event data.
        protected virtual void OnPreviewStylusInRange(StylusEventArgs e);
        //
        // Summary:
        //     Invoked when an unhandled System.Windows.Input.Stylus.PreviewStylusMove attached
        //     event reaches an element in its route that is derived from this class. Implement
        //     this method to add class handling for this event.
        //
        // Parameters:
        //   e:
        //     The System.Windows.Input.StylusEventArgs that contains the event data.
        protected virtual void OnPreviewStylusMove(StylusEventArgs e);
        //
        // Summary:
        //     Invoked when an unhandled System.Windows.Input.Stylus.PreviewStylusOutOfRange
        //     attached event reaches an element in its route that is derived from this class.
        //     Implement this method to add class handling for this event.
        //
        // Parameters:
        //   e:
        //     The System.Windows.Input.StylusEventArgs that contains the event data.
        protected virtual void OnPreviewStylusOutOfRange(StylusEventArgs e);
        //
        // Summary:
        //     Invoked when an unhandled System.Windows.Input.Stylus.PreviewStylusSystemGesture
        //     attached event reaches an element in its route that is derived from this class.
        //     Implement this method to add class handling for this event.
        //
        // Parameters:
        //   e:
        //     The System.Windows.Input.StylusSystemGestureEventArgs that contains the event
        //     data.
        protected virtual void OnPreviewStylusSystemGesture(StylusSystemGestureEventArgs e);
        //
        // Summary:
        //     Invoked when an unhandled System.Windows.Input.Stylus.PreviewStylusUp attached
        //     event reaches an element in its route that is derived from this class. Implement
        //     this method to add class handling for this event.
        //
        // Parameters:
        //   e:
        //     The System.Windows.Input.StylusEventArgs that contains the event data.
        protected virtual void OnPreviewStylusUp(StylusEventArgs e);
        //
        // Summary:
        //     Invoked when an unhandled System.Windows.Input.TextCompositionManager.PreviewTextInput
        //     attached event reaches an element in its route that is derived from this class.
        //     Implement this method to add class handling for this event.
        //
        // Parameters:
        //   e:
        //     The System.Windows.Input.TextCompositionEventArgs that contains the event data.
        protected virtual void OnPreviewTextInput(TextCompositionEventArgs e);
        //
        // Summary:
        //     Provides class handling for the System.Windows.UIElement.PreviewTouchDown routed
        //     event that occurs when a touch presses this element.
        //
        // Parameters:
        //   e:
        //     A System.Windows.Input.TouchEventArgs that contains the event data.
        protected virtual void OnPreviewTouchDown(TouchEventArgs e);
        //
        // Summary:
        //     Provides class handling for the System.Windows.UIElement.PreviewTouchMove routed
        //     event that occurs when a touch moves while inside this element.
        //
        // Parameters:
        //   e:
        //     A System.Windows.Input.TouchEventArgs that contains the event data.
        protected virtual void OnPreviewTouchMove(TouchEventArgs e);
        //
        // Summary:
        //     Provides class handling for the System.Windows.UIElement.PreviewTouchUp routed
        //     event that occurs when a touch is released inside this element.
        //
        // Parameters:
        //   e:
        //     A System.Windows.Input.TouchEventArgs that contains the event data.
        protected virtual void OnPreviewTouchUp(TouchEventArgs e);
        //
        // Summary:
        //     Invoked when an unhandled System.Windows.DragDrop.QueryContinueDrag attached
        //     event reaches an element in its route that is derived from this class. Implement
        //     this method to add class handling for this event.
        //
        // Parameters:
        //   e:
        //     The System.Windows.QueryContinueDragEventArgs that contains the event data.
        protected virtual void OnQueryContinueDrag(QueryContinueDragEventArgs e);
        //
        // Summary:
        //     Invoked when an unhandled System.Windows.Input.Mouse.QueryCursor attached event
        //     reaches an element in its route that is derived from this class. Implement this
        //     method to add class handling for this event.
        //
        // Parameters:
        //   e:
        //     The System.Windows.Input.QueryCursorEventArgs that contains the event data.
        protected virtual void OnQueryCursor(QueryCursorEventArgs e);
        //
        // Summary:
        //     When overridden in a derived class, participates in rendering operations that
        //     are directed by the layout system. The rendering instructions for this element
        //     are not used directly when this method is invoked, and are instead preserved
        //     for later asynchronous use by layout and drawing.
        //
        // Parameters:
        //   drawingContext:
        //     The drawing instructions for a specific element. This context is provided to
        //     the layout system.
        protected virtual void OnRender(DrawingContext drawingContext);
        //
        // Summary:
        //     Invoked when an unhandled System.Windows.Input.Stylus.StylusButtonDown attached
        //     event reaches an element in its route that is derived from this class. Implement
        //     this method to add class handling for this event.
        //
        // Parameters:
        //   e:
        //     The System.Windows.Input.StylusButtonEventArgs that contains the event data.
        protected virtual void OnStylusButtonDown(StylusButtonEventArgs e);
        //
        // Summary:
        //     Invoked when an unhandled System.Windows.Input.Stylus.StylusButtonUp attached
        //     event reaches an element in its route that is derived from this class. Implement
        //     this method to add class handling for this event.
        //
        // Parameters:
        //   e:
        //     The System.Windows.Input.StylusButtonEventArgs that contains the event data.
        protected virtual void OnStylusButtonUp(StylusButtonEventArgs e);
        //
        // Summary:
        //     Invoked when an unhandled System.Windows.Input.Stylus.StylusDown attached event
        //     reaches an element in its route that is derived from this class. Implement this
        //     method to add class handling for this event.
        //
        // Parameters:
        //   e:
        //     The System.Windows.Input.StylusDownEventArgs that contains the event data.
        protected virtual void OnStylusDown(StylusDownEventArgs e);
        //
        // Summary:
        //     Invoked when an unhandled System.Windows.Input.Stylus.StylusEnter attached event
        //     is raised by this element. Implement this method to add class handling for this
        //     event.
        //
        // Parameters:
        //   e:
        //     The System.Windows.Input.StylusEventArgs that contains the event data.
        protected virtual void OnStylusEnter(StylusEventArgs e);
        //
        // Summary:
        //     Invoked when an unhandled System.Windows.Input.Stylus.StylusInAirMove attached
        //     event reaches an element in its route that is derived from this class. Implement
        //     this method to add class handling for this event.
        //
        // Parameters:
        //   e:
        //     The System.Windows.Input.StylusEventArgs that contains the event data.
        protected virtual void OnStylusInAirMove(StylusEventArgs e);
        //
        // Summary:
        //     Invoked when an unhandled System.Windows.Input.Stylus.StylusInRange attached
        //     event reaches an element in its route that is derived from this class. Implement
        //     this method to add class handling for this event.
        //
        // Parameters:
        //   e:
        //     The System.Windows.Input.StylusEventArgs that contains the event data.
        protected virtual void OnStylusInRange(StylusEventArgs e);
        //
        // Summary:
        //     Invoked when an unhandled System.Windows.Input.Stylus.StylusLeave attached event
        //     is raised by this element. Implement this method to add class handling for this
        //     event.
        //
        // Parameters:
        //   e:
        //     The System.Windows.Input.StylusEventArgs that contains the event data.
        protected virtual void OnStylusLeave(StylusEventArgs e);
        //
        // Summary:
        //     Invoked when an unhandled System.Windows.Input.Stylus.StylusMove attached event
        //     reaches an element in its route that is derived from this class. Implement this
        //     method to add class handling for this event.
        //
        // Parameters:
        //   e:
        //     The System.Windows.Input.StylusEventArgs that contains the event data.
        protected virtual void OnStylusMove(StylusEventArgs e);
        //
        // Summary:
        //     Invoked when an unhandled System.Windows.Input.Stylus.StylusOutOfRange attached
        //     event reaches an element in its route that is derived from this class. Implement
        //     this method to add class handling for this event.
        //
        // Parameters:
        //   e:
        //     The System.Windows.Input.StylusEventArgs that contains the event data.
        protected virtual void OnStylusOutOfRange(StylusEventArgs e);
        //
        // Summary:
        //     Invoked when an unhandled System.Windows.Input.Stylus.StylusSystemGesture attached
        //     event reaches an element in its route that is derived from this class. Implement
        //     this method to add class handling for this event.
        //
        // Parameters:
        //   e:
        //     The System.Windows.Input.StylusSystemGestureEventArgs that contains the event
        //     data.
        protected virtual void OnStylusSystemGesture(StylusSystemGestureEventArgs e);
        //
        // Summary:
        //     Invoked when an unhandled System.Windows.Input.Stylus.StylusUp attached event
        //     reaches an element in its route that is derived from this class. Implement this
        //     method to add class handling for this event.
        //
        // Parameters:
        //   e:
        //     The System.Windows.Input.StylusEventArgs that contains the event data.
        protected virtual void OnStylusUp(StylusEventArgs e);
        //
        // Summary:
        //     Invoked when an unhandled System.Windows.Input.TextCompositionManager.TextInput
        //     attached event reaches an element in its route that is derived from this class.
        //     Implement this method to add class handling for this event.
        //
        // Parameters:
        //   e:
        //     The System.Windows.Input.TextCompositionEventArgs that contains the event data.
        protected virtual void OnTextInput(TextCompositionEventArgs e);
        //
        // Summary:
        //     Provides class handling for the System.Windows.UIElement.TouchDown routed event
        //     that occurs when a touch presses inside this element.
        //
        // Parameters:
        //   e:
        //     A System.Windows.Input.TouchEventArgs that contains the event data.
        protected virtual void OnTouchDown(TouchEventArgs e);
        //
        // Summary:
        //     Provides class handling for the System.Windows.UIElement.TouchEnter routed event
        //     that occurs when a touch moves from outside to inside the bounds of this element.
        //
        // Parameters:
        //   e:
        //     A System.Windows.Input.TouchEventArgs that contains the event data.
        protected virtual void OnTouchEnter(TouchEventArgs e);
        //
        // Summary:
        //     Provides class handling for the System.Windows.UIElement.TouchLeave routed event
        //     that occurs when a touch moves from inside to outside the bounds of this System.Windows.UIElement.
        //
        // Parameters:
        //   e:
        //     A System.Windows.Input.TouchEventArgs that contains the event data.
        protected virtual void OnTouchLeave(TouchEventArgs e);
        //
        // Summary:
        //     Provides class handling for the System.Windows.UIElement.TouchMove routed event
        //     that occurs when a touch moves while inside this element.
        //
        // Parameters:
        //   e:
        //     A System.Windows.Input.TouchEventArgs that contains the event data.
        protected virtual void OnTouchMove(TouchEventArgs e);
        //
        // Summary:
        //     Provides class handling for the System.Windows.UIElement.TouchUp routed event
        //     that occurs when a touch is released inside this element.
        //
        // Parameters:
        //   e:
        //     A System.Windows.Input.TouchEventArgs that contains the event data.
        protected virtual void OnTouchUp(TouchEventArgs e);
        //
        // Summary:
        //     When overridden in a derived class, returns an alternative user interface (UI)
        //     parent for this element if no visual parent exists.
        //
        // Returns:
        //     An object, if implementation of a derived class has an alternate parent connection
        //     to report.
        protected internal virtual DependencyObject GetUIParentCore();
        //
        // Summary:
        //     When overridden in a derived class, participates in rendering operations that
        //     are directed by the layout system. This method is invoked after layout update,
        //     and before rendering, if the element's System.Windows.UIElement.RenderSize has
        //     changed as a result of layout update.
        //
        // Parameters:
        //   info:
        //     The packaged parameters (System.Windows.SizeChangedInfo), which includes old
        //     and new sizes, and which dimension actually changes.
        protected internal virtual void OnRenderSizeChanged(SizeChangedInfo info);
        //
        // Summary:
        //     Invoked when the parent element of this System.Windows.UIElement reports a change
        //     to its underlying visual parent.
        //
        // Parameters:
        //   oldParent:
        //     The previous parent. This may be provided as null if the System.Windows.DependencyObject
        //     did not have a parent element previously.
        protected internal override void OnVisualParentChanged(DependencyObject oldParent);
    }
}