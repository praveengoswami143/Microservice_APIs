using Microsoft.AspNetCore.Mvc;

namespace ProductMicroservice.Controllers;

[ApiController]
[Route("api/[controller]")]
public class ProductMicroserviceController : ControllerBase
{
    private readonly ILogger<ProductMicroserviceController> _logger;

    public ProductMicroserviceController(ILogger<ProductMicroserviceController> logger)
    {
        _logger = logger;
    }

    public string GetProducts()
    {
        return "hie";
    }
}