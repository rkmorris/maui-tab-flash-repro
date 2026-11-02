using Microsoft.Maui.Controls;
using Microsoft.Maui.Graphics;

namespace com.rkmresearch.dummy.Pages;

// Every tab contains only a black page and one white label
public abstract class BlackTabPage : ContentPage
{
    protected BlackTabPage(string title)
    {
        BackgroundColor = Colors.Black;

        Content = new Grid
        {
            BackgroundColor = Colors.Black,
            Children =
            {
                new Label
                {
                    Text = title,
                    TextColor = Colors.White,
                    FontSize = 30,
                    HorizontalOptions = LayoutOptions.Center,
                    VerticalOptions = LayoutOptions.Center
                }
            }
        };
    }
}

public sealed class HomePage : BlackTabPage
{
    public HomePage() : base("Home") { }
}

public sealed class DrawsPage : BlackTabPage
{
    public DrawsPage() : base("Draws") { }
}

public sealed class InvestmentsPage : BlackTabPage
{
    public InvestmentsPage() : base("Investments") { }
}

public sealed class HoldersPage : BlackTabPage
{
    public HoldersPage() : base("Holders") { }
}
