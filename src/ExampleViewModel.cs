using ReactiveUI;

namespace SourceGeneratorIssue;

public partial class ExampleViewModel : ReactiveObject
{
    public ExampleViewModel()
    {
        MyIntProperty = 3;
    }

    [ReactiveUI.SourceGenerators.Reactive]
    private int _myIntProperty;
}