using System;
using System.Collections.Generic;
using System.Text;
using LeilaoOnline.Core;
using Xunit;

namespace LeilaoOnline.Tests
{
    public class LanceCtor
    {
        [Fact]
        public void LancaInvalidArgumentExceptionDadoValorNegativo()
        {
            //Arranje
            var valorNegativo = -100;

            //Asssert
            Assert.Throws<System.ArgumentException>(
                //Act
                () => new Lance(null, valorNegativo));
        }
    }
}
