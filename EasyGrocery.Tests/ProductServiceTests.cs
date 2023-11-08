﻿using System.Net;
using AutoMapper;
using EasyGrocery.Common.Entities;
using ESasyGrocery.Service.Dto;
using EShop.Application.Services;
using MediatR;
using Moq;
using Xunit;

public class ProductServiceTests
{
    [Fact]
    public async Task GetProductList_Returns_OK_Response_When_ProductsExist()
    {
        // Arrange
        var mediatorMock = new Mock<IMediator>();
        var mapperMock = new Mock<IMapper>();

        // Mock the behavior of IMediator to return a list of products
        var products = new List<GroceryItem>
    {
        new GroceryItem {  Name = "Product 1" },
        new GroceryItem { Name = "Product 2" }
    };

        mediatorMock.Setup(m => m.Send(It.IsAny<GroceryItemEntity>(), CancellationToken.None))
                    .ReturnsAsync(products); // Provide the correct instance of GetProductByQuery

        // Create an instance of ProductService with the mock dependencies
        var productService = new ProductService(mediatorMock.Object, mapperMock.Object);

        // Act
        var result = await productService.GetProductList();

        // Assert
        Assert.NotNull(result);
        Assert.Equal((int)HttpStatusCode.OK, result.StatusCode);
        Assert.False(result.HasError);
    }


}
