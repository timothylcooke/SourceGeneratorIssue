using System.Windows;

namespace SourceGeneratorIssue;

public partial class App : Application
{
    private void Application_Startup(object sender, StartupEventArgs e)
    {
        var reactiveAttributeTypeViaCompiler = typeof(ReactiveUI.SourceGenerators.ReactiveAttribute);

        var reactiveAttributeTypeViaReflection = GetType().Assembly.GetType("ReactiveUI.SourceGenerators.ReactiveAttribute");
    }
}
