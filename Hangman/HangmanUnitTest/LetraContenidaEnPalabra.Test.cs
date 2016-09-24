using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Hangman.UnitTest
{
    [TestClass]
    public class LetraContenidaEnPalabra
    {
        [TestMethod]
        public void LetraASiEstaContenidaEnPalabraMama()
        {

            // definimos el escenario de los valores a enviar

            char laLetra = 'a';
            string laPalabra = "mama";
            bool elResultadoEsperado = true;

            // invocamos el metodo correspondiente

            var laReferenciaDinamica = new BusinessLogic.Herramientas();
            bool elResultadoReal = laReferenciaDinamica.UnaLetraEsContenidaEnUnaPalabra(laLetra, laPalabra);

            // comparar el resultado real con el esperado

            Assert.AreEqual(elResultadoEsperado, elResultadoReal);



        }
    

    [TestMethod]
    public void LetraAMayusculaSiEstaContenidaEnPalabraMama()
    {

        // definimos el escenario de los valores a enviar

        char laLetra = 'A';
        string laPalabra = "mama";
        bool elResultadoEsperado = true;

        // invocamos el metodo correspondiente

        var laReferenciaDinamica = new BusinessLogic.Herramientas();
        bool elResultadoReal = laReferenciaDinamica.UnaLetraEsContenidaEnUnaPalabra(laLetra, laPalabra);

        // comparar el resultado real con el esperado

        Assert.AreEqual(elResultadoEsperado, elResultadoReal);

        }

    }


    [TestMethod]
    public void LetraXNoEstaContenidaEnPalabraMama()
    {

        // definimos el escenario de los valores a enviar

        char laLetra = 'A';
        string laPalabra = "mama";
        bool elResultadoEsperado = true;

        // invocamos el metodo correspondiente

        var laReferenciaDinamica = new BusinessLogic.Herramientas();
        bool elResultadoReal = laReferenciaDinamica.UnaLetraEsContenidaEnUnaPalabra(laLetra, laPalabra);

        // comparar el resultado real con el esperado

        Assert.AreEqual(elResultadoEsperado, elResultadoReal);

    }

}



