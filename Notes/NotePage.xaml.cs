namespace Notes;

public partial class NotePage : ContentPage
{
    string _fileName = Path.Combine(FileSystem.AppDataDirectory, "notes.txt");
    public NotePage()
    {
        InitializeComponent();
        if (File.Exists(_fileName))
            TextEditor.Text = File.ReadAllText(_fileName);


    }

    private void SaveButton_Clicked(object sender, EventArgs e) { 
        // Save the file.
File.WriteAllText(_fileName, TextEditor.Text);
  
    }
private async void DeleteButton_Clicked(object sender, EventArgs e)
{
    // Delete the file.
    if (File.Exists(_fileName))
        File.Delete(_fileName);
        await DisplayAlert("Deletar Arquivo", "você não tem esse arquivo...","sucesso");
        
    TextEditor.Text = string.Empty;
}

}