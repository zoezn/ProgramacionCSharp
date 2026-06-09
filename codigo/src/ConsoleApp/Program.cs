// Instancio nuevo doc Documento asignandole como estrategia de procesamiento inicial
// encripcion EncryptionStrategy
Document doc =
    new Document(
        new EncryptionStrategy()
    );
// Proceso el doc
doc.Procesar();
// Modifico la estrategia a compresion CompressionStrategy en tiempo de ejecucion
doc.SetStrategy(
    new CompressionStrategy()
);
// Proceso el doc con la estrategia nueva
doc.Procesar();