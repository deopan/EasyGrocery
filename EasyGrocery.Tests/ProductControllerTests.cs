using EasyGrocery.Api.Controllers;
using EasyGrocery.Service.Interface;
using ESasyGrocery.Service.Dto;
using Microsoft.AspNetCore.Mvc;
using Moq;
using Xunit;

public class ProductControllerTests
{
    [Fact]
    public async Task Get_ReturnsOkResultWithProductList()
    {

        var response = new ApiResponse<List<GroceryItem>>();


        // Arrange
        var productServiceMock = new Mock<IProductService>();
        var productList = new List<GroceryItem> 
        {
            new GroceryItem { ProductId = 1, Name = "Product 1", Price = 10.0M },
            new GroceryItem { ProductId = 2, Name = "Product 2", Price = 20.0M },
            // Add more products as needed
        };

        productServiceMock.Setup(service => service.GetProductList())
     .ReturnsAsync(response);

        var controller = new ProductController(productServiceMock.Object);

        // Act
        var actionResult = await controller.Get();

        // Assert
        var okResult = Assert.IsType<OkObjectResult>(actionResult);
 
        Assert.Equal(okResult.StatusCode, 200);
    }
}
