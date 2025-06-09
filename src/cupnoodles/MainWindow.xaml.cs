using Microsoft.UI.Windowing;
using Microsoft.UI;
using System;
using Windows.UI.WindowManagement;
using WinRT.Interop;

namespace cupnoodles;

/// <summary>
/// An empty window that can be used on its own or navigated to within a Frame.
/// </summary>
public sealed partial class MainWindow : Window
{
    public Frame RootFrame => rootFrame;

    public MainWindow()
    {
        this.InitializeComponent();
        this.SystemBackdrop = new MicaBackdrop();
    }
}
