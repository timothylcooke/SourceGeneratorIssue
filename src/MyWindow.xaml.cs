using System.Windows;

namespace SourceGeneratorIssue
{
    public partial class MainWindow : Window
    {
        // This window doesn't do anything, but simply having the <Page> resource in the legacy csproj causes the build to fail.

        public MainWindow()
        {
            InitializeComponent();
        }
    }
}