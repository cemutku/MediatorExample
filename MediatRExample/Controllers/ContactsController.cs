using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using MediatR;
using MediatRExample.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace MediatRExample.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ContactsController : ControllerBase
    {
        private readonly IMediator mediator;

        public ContactsController(IMediator mediator)
        {
            this.mediator = mediator;
        }

        [HttpGet("{id}")]
        public async Task<Contact> GetContact([FromRoute]Query query)
        {
            return await this.mediator.Send(query);
        }

        // expecting this type of response object
        public class Query : IRequest<Contact>
        {
            public int Id { get; set; }
        }

        // Handler
        public class ContactHandler : IRequestHandler<Query, Contact>
        {
            private ContactsDbContext dbContext;

            public ContactHandler(ContactsDbContext dbContext) => this.dbContext = dbContext;

            public Task<Contact> Handle(Query req, CancellationToken cancellationToken)
            {
                return this.dbContext.Contacts.Where(x => x.Id == req.Id).SingleOrDefaultAsync();
            }
        }
    }
}