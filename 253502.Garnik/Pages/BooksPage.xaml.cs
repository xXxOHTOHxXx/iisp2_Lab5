using _253502.Garnik.ViewModels;
using _253502.Garnik;
namespace _253502.Garnik.Pages;

public partial class BooksPage : ContentPage
{
    public BooksPage(BookViewModel viewModel)//
    {
        InitializeComponent();

        BindingContext = viewModel;
    }
}