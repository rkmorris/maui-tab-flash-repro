using Microsoft.Maui;
using Microsoft.Maui.Controls;

namespace com.rkmresearch.dummy;

public sealed class App : Application
{
    protected override Window CreateWindow(IActivationState? activationState)
    {
        return new Window(new AppShell());
    }
}
