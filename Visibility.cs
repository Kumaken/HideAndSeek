#region Assembly PresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// C:\Program Files (x86)\Reference Assemblies\Microsoft\Framework\.NETFramework\v4.0\PresentationCore.dll
#endregion

namespace System.Windows
{
    //
    // Summary:
    //     Specifies the display state of an element.
    public enum Visibility : byte
    {
        //
        // Summary:
        //     Display the element.
        Visible = 0,
        //
        // Summary:
        //     Do not display the element, but reserve space for the element in layout.
        Hidden = 1,
        //
        // Summary:
        //     Do not display the element, and do not reserve space for it in layout.
        Collapsed = 2
    }
}