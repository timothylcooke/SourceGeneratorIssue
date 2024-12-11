using System.Windows;

namespace SourceGeneratorIssue;

public partial class App : Application
{
    private void Application_Startup(object sender, StartupEventArgs e)
    {
        // This line makes a compiler error in LegacyApp, but builds in SdkStyleApp!
        // This error will not show up if any ReactiveAttributes are added to any fields.
        // error CS0234: The type or namespace name 'SourceGenerators' does not exist in the namespace 'ReactiveUI' (are you missing an assembly reference?)
        var reactiveAttributeTypeViaCompiler = typeof(ReactiveUI.SourceGenerators.ReactiveAttribute);

        // This works fine in both the LegacyApp *and* SdkStyleApp (if you comment out all references to SourceGenerators attributes/properties to get the project to build).
        var reactiveAttributeTypeViaReflection = GetType().Assembly.GetType("ReactiveUI.SourceGenerators.ReactiveAttribute");

        // The type is clearly getting compiled, but anything that references it (e.g. adding attributes to a ViewModel) fails to build.
    }
}
