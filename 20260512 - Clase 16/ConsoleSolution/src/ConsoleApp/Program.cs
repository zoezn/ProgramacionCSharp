INadador pato = new Pato();

//pato.Volar();
//pato.Nadar();
//pato.Cuack();


PatoDeGoma patoDeGoma = new PatoDeGoma();
// patoDeGoma.Nadar(); 

RecibirNadadores(patoDeGoma);

RecibirNadadores(pato);


static void RecibirNadadores(INadador objNadador)
{
    objNadador.Nadar();
}