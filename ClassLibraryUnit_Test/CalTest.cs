using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Calculator_Library;

namespace ClassLibraryUnit_Test
{
    public class CalTest
    {
        public void Add_SimpleValueShouldCalculate()
        {
            // Arrange

            double expected = 5;

            // Act

            double actual = Cal.Add(3, 2);

            // Assert
        }
    }
}
