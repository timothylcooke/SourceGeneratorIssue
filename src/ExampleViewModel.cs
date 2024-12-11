using ReactiveUI;

namespace SourceGeneratorIssue;

public partial class ExampleViewModel : ReactiveObject
{
    public ExampleViewModel()
    {
        // Compiler error in LegacyApp (If ReactiveAttribute is not added to field):
        // error CS0103: The name 'MyIntProperty' does not exist in the current context
        MyIntProperty = 3;
    }

    // Compiler error in LegacyApp:
    // error CS0234: The type or namespace name 'SourceGenerators' does not exist in the namespace 'ReactiveUI' (are you missing an assembly reference?)
    [ReactiveUI.SourceGenerators.Reactive]
    private int _myIntProperty;
}