using Optional;

namespace LRToolkit.Parsing;

public class LR0ParserBuilderBehavior<TSymbol> : ILRParserBuilderBehavior<TSymbol> where TSymbol : notnull
{
    public ILookaheadFactory<TSymbol> LookaheadFactory { get; } = new NoLookaheadFactory<TSymbol>();

    public bool IsMergeable(ItemSet<TSymbol> first, ItemSet<TSymbol> second) => first == second;

    public Option<ItemSet<TSymbol>, BuilderError> Merge(ItemSet<TSymbol> first, ItemSet<TSymbol> second) =>
        first.Some<ItemSet<TSymbol>, BuilderError>();
}