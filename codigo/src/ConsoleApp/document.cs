class Document
{
    private IProcessingStrategy strategy;

    public Document(
        IProcessingStrategy strategy)
    {
        this.strategy = strategy;
    }

    public void Procesar()
    {
        strategy.Procesar(this);
    }

    public void SetStrategy(
        IProcessingStrategy strategy)
    {
        this.strategy = strategy;
    }
}