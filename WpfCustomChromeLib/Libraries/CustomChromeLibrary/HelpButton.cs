using System.Windows;

namespace CustomChromeLibrary
{
	public class HelpButton : CaptionButton
    {
        static HelpButton()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(HelpButton), new FrameworkPropertyMetadata(typeof(HelpButton)));
        }
    }
}
