using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MovieManagement.Library.Commands;
using MovieManagement.Library.Models;
using MovieManagement.Library.Queries;

namespace MovieManagement.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MoviesController : ControllerBase
    {
        private readonly IMediator _mediator;

        public MoviesController(IMediator mediator)
        {
            _mediator = mediator;
        }

        // GET: api/Movies
        [HttpGet]
        public async Task<List<MovieModel>> Get()
        {
            return await _mediator.Send(new GetMovieListQuery());
        }
        // GET: api/Movies/Id
        [HttpGet("{id}")]
        public async Task<MovieModel> Get(Guid id)
        {
            return await _mediator.Send(new GetMovieByIdQuery(id));
        }

        // POST: api/Movie/add
        [HttpPost]
        public async Task<MovieModel> Add(MovieModel movie)
        {
            return await _mediator.Send(new AddMovieCommand(movie));
        }
    }
}
