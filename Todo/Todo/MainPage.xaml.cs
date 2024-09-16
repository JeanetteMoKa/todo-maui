using Todo.ViewModel;

namespace Todo;

public partial class MainPage : ContentPage
{

    public MainPage(MainViewModel vm)
    {
        InitializeComponent();
        BindingContext = vm;
    }

}