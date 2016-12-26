using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Moq;
using ExploreAspNetCore.api;
using Xunit;

namespace ExploreAspNetCore.Tests.UnitTests
{
    [Trait("Sample", "tests")]
    public class ValuesControllerTests
    {
        [Fact(DisplayName = "Passing Unit Test")]
        public void Passing_Unit_Test()
        {
            // Arrange
            var controller = new ValuesController();

            // Act
            var result = controller.Get();

            // Assert
            Assert.Equal(2, result.Count());
        }

    }
}