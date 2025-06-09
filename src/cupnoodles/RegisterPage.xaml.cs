namespace cupnoodles;

/// <summary>
/// An empty page that can be used on its own or navigated to within a Frame.
/// </summary>
public sealed partial class RegisterPage : Page
{
    public RegisterPage()
    {
        this.InitializeComponent();
    }

    private void RegisterButton_Click(object sender, RoutedEventArgs e)
    {
        this.Frame.Navigate(typeof(LoginPage));
    }

    private void GoToLogin_Click(object sender, RoutedEventArgs e)
    {
        this.Frame.Navigate(typeof(LoginPage));
    }
}
