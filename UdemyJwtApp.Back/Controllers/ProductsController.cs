using MediatR;
using Microsoft.AspNetCore.Authorization;
<<<<<<< HEAD
<<<<<<< HEAD
=======
using Microsoft.AspNetCore.Http;
>>>>>>> cab2227dde6026f0271e7c9b5bf05b2b4c1aef24
=======
using Microsoft.AspNetCore.Http;
>>>>>>> cab2227dde6026f0271e7c9b5bf05b2b4c1aef24
using Microsoft.AspNetCore.Mvc;
using UdemyJwtApp.Back.Core.Application.Features.CQRS.Commands;
using UdemyJwtApp.Back.Core.Application.Features.CQRS.Queries;

namespace UdemyJwtApp.Back.Controllers
{
    [Authorize(Roles = "Admin,Member")]
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly IMediator _mediator;

        public ProductsController(IMediator mediator)
        {
            _mediator = mediator;
        }
        [HttpGet]

<<<<<<< HEAD
<<<<<<< HEAD
        public async Task<ActionResult> List()
        {
            var result = await _mediator.Send(new GetAllProductsQueryRequest());
            return Ok(result);
=======
=======
>>>>>>> cab2227dde6026f0271e7c9b5bf05b2b4c1aef24
        public async Task<ActionResult> List() 
        {
        var result= await _mediator.Send(new GetAllProductsQueryRequest());
         return Ok(result);
<<<<<<< HEAD
>>>>>>> cab2227dde6026f0271e7c9b5bf05b2b4c1aef24
=======
>>>>>>> cab2227dde6026f0271e7c9b5bf05b2b4c1aef24
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            var result = await _mediator.Send(new GetProductQueryRequest(id));
            return result == null ? NotFound() : Ok(result);
        }
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
<<<<<<< HEAD
<<<<<<< HEAD
            var result = await _mediator.Send(new DeleteProductCommandRequest(id));
            return Ok(result) == null ? NotFound() : Ok(result);
=======
            var result=await _mediator.Send(new DeleteProductCommandRequest(id));
            return Ok(result)==null? NotFound() : Ok(result);
>>>>>>> cab2227dde6026f0271e7c9b5bf05b2b4c1aef24
=======
            var result=await _mediator.Send(new DeleteProductCommandRequest(id));
            return Ok(result)==null? NotFound() : Ok(result);
>>>>>>> cab2227dde6026f0271e7c9b5bf05b2b4c1aef24
        }
        [HttpPost]
        public async Task<IActionResult> Create(CreateProductCommandRequest request)
        {
<<<<<<< HEAD
<<<<<<< HEAD
            await _mediator.Send(request);
            return Created("", request);

=======
             await _mediator.Send(request);
            return Created("", request);
                
>>>>>>> cab2227dde6026f0271e7c9b5bf05b2b4c1aef24
=======
             await _mediator.Send(request);
            return Created("", request);
                
>>>>>>> cab2227dde6026f0271e7c9b5bf05b2b4c1aef24
        }
        [HttpPut]
        public async Task<IActionResult> Update(UpdateProductCommandRequest request)
        {
            await _mediator.Send(request);
            return NoContent();
        }
    }
}
