using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
<<<<<<< HEAD
<<<<<<< HEAD
using UdemyJwtApp.Back.Core.Application.Features.CQRS.Commands;
=======
=======
>>>>>>> cab2227dde6026f0271e7c9b5bf05b2b4c1aef24
using System.Data;
using System.Reflection.Metadata.Ecma335;
using UdemyJwtApp.Back.Core.Application.Dto;
using UdemyJwtApp.Back.Core.Application.Features.CQRS.Commands;
using UdemyJwtApp.Back.Core.Application.Features.CQRS.Handlers;
<<<<<<< HEAD
>>>>>>> cab2227dde6026f0271e7c9b5bf05b2b4c1aef24
=======
>>>>>>> cab2227dde6026f0271e7c9b5bf05b2b4c1aef24
using UdemyJwtApp.Back.Core.Application.Features.CQRS.Queries;

namespace UdemyJwtApp.Back.Controllers
{
    [Authorize(Roles = "Admin")]
    [Route("api/[Controller]")]
    [ApiController]
<<<<<<< HEAD
<<<<<<< HEAD
    public class CategoriesController : ControllerBase
=======
    public class CategoriesController:ControllerBase
>>>>>>> cab2227dde6026f0271e7c9b5bf05b2b4c1aef24
=======
    public class CategoriesController:ControllerBase
>>>>>>> cab2227dde6026f0271e7c9b5bf05b2b4c1aef24
    {
        private readonly IMediator _mediator;

        public CategoriesController(IMediator mediator)
        {
            _mediator = mediator;
        }
        [HttpGet]
        public async Task<IActionResult> List()
        {
<<<<<<< HEAD
<<<<<<< HEAD
            var result = await _mediator.Send(new GetAllCategoryQueryRequest());
=======
           var result= await _mediator.Send(new GetAllCategoryQueryRequest());
>>>>>>> cab2227dde6026f0271e7c9b5bf05b2b4c1aef24
=======
           var result= await _mediator.Send(new GetAllCategoryQueryRequest());
>>>>>>> cab2227dde6026f0271e7c9b5bf05b2b4c1aef24
            return Ok(result);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
<<<<<<< HEAD
<<<<<<< HEAD
            var result = await _mediator.Send(new GetCategoryQueryRequest(id));
            return (result) == null ? NotFound() : Ok(result);


=======
=======
>>>>>>> cab2227dde6026f0271e7c9b5bf05b2b4c1aef24
           var result= await _mediator.Send(new GetCategoryQueryRequest(id));
            return (result) == null ? NotFound() : Ok(result);
           
           
<<<<<<< HEAD
>>>>>>> cab2227dde6026f0271e7c9b5bf05b2b4c1aef24
=======
>>>>>>> cab2227dde6026f0271e7c9b5bf05b2b4c1aef24
        }

        [HttpPost]

        public async Task<IActionResult> Create(CreateCategoryCommandRequest request)
        {
<<<<<<< HEAD
<<<<<<< HEAD
            await _mediator.Send(request);
=======
         await _mediator.Send(request);
>>>>>>> cab2227dde6026f0271e7c9b5bf05b2b4c1aef24
=======
         await _mediator.Send(request);
>>>>>>> cab2227dde6026f0271e7c9b5bf05b2b4c1aef24
            return Created("", request);

        }
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
<<<<<<< HEAD
<<<<<<< HEAD
            var result = await _mediator.Send(new DeleteCategoryCommandRequest(id));
=======
            var result=await _mediator.Send(new DeleteCategoryCommandRequest(id));
>>>>>>> cab2227dde6026f0271e7c9b5bf05b2b4c1aef24
=======
            var result=await _mediator.Send(new DeleteCategoryCommandRequest(id));
>>>>>>> cab2227dde6026f0271e7c9b5bf05b2b4c1aef24
            return Ok();
        }
        [HttpPut]
        public async Task<IActionResult> Update(UpdateCategoryCommandRequest request)
        {
<<<<<<< HEAD
<<<<<<< HEAD
            await _mediator.Send(request);
=======
             await _mediator.Send(request);
>>>>>>> cab2227dde6026f0271e7c9b5bf05b2b4c1aef24
=======
             await _mediator.Send(request);
>>>>>>> cab2227dde6026f0271e7c9b5bf05b2b4c1aef24
            return NoContent();
        }
    }
}
