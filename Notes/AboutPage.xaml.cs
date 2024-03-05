namespace Notes;

public partial class AboutPage : ContentPage
{
    public AboutPage()
    {
        InitializeComponent();
    }
    private async void LearnMore_Clicked(object sander, EventArgs e)
    {
        // Navigate to the specified URL in the system browser.
        await Launcher.Default.OpenAsync("https://www.google.com/search?q=friv&rlz=1C1FCXM_pt-PTBR998BR998&oq=&aqs=chrome.0.69i59i450l4.25080j0j7&sourceid=chrome&ie=UTF-8");
    }
}