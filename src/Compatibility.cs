#if !NET5_0_OR_GREATER

namespace System.Runtime.CompilerServices;

// This class is necessary for anything older than net5.0 that references ReactiveUI.SourceGenerators
internal static class IsExternalInit { }

#endif