using Proje.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Proje.Tests
{
    public class StokServiceTests
    {
        [Fact]
        public void StokDusur_DogruAzaltiyorMu()
        {
            // Arrange
            var servis = new StokService();

            // Act
            int sonuc = servis.StokDusur(10, 3);

            // Assert
            Assert.Equal(7, sonuc); 
        }
    }
}




