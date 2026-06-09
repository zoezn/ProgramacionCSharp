// Instancio nuevo doc Documento asignandole como estrategia de procesamiento inicial
// encripcion EncryptionStrategy
Document doc =
    new Document(
        new EncryptionStrategy()
    );
// Proceso el doc e imprime por consola "Encriptando"
doc.Procesar();
// Modifico la estrategia a compresion CompressionStrategy en tiempo de ejecucion
doc.SetStrategy(
    new CompressionStrategy()
);
// Proceso el doc con la estrategia nueva e imprime por consola "Comprimiendo"
doc.Procesar();
