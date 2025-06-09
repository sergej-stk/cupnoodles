namespace cupnoodles;

/// <summary>
/// An empty page that can be used on its own or navigated to within a Frame.
/// </summary>
public sealed partial class LoginPage : Page
{
    public LoginPage()
    {
        this.InitializeComponent();
    }

    private void LoginButton_Click(object sender, RoutedEventArgs e)
    {
        if (UsernameTextBox.Text == "admin" && PasswordBox.Password == "passwort")
        {

            (Application.Current as App).RootFrame.Navigate(typeof(MainPage));
            ErrorTextBlock.Text = ""; 
        }
        else
        {
            // Bei Fehler eine Nachricht anzeigen.
            ErrorTextBlock.Text = "Benutzername oder Passwort ist falsch.";
        }
    }

    private void RegisterButton_Click(object sender, RoutedEventArgs e)
    {

        this.Frame.Navigate(typeof(RegisterPage));
    }
}
