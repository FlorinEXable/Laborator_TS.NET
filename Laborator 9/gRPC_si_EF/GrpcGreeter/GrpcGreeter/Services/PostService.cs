using Grpc.Core;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GrpcGreeter.Services
{
    public class PostService : Post.PostBase
    {
        private readonly ILogger<PostService> _logger;
        public PostService(ILogger<PostService> logger)
        {
            _logger = logger;
        }
        public override Task<PostModel> GetPostInfo(PostLookupModel request, ServerCallContext context)
        {
            PostModel output = new PostModel();

            if(request.PostId == 1)
            {
                output.Date = "22.03.2020";
                output.Description = "Imi place sa programez. Voi in ce limbaje programati?";
                output.Domain = "IT";
            }
            else
            {
                output.Date = "25.03.2020";
                output.Description = "Cam cata sare se foloseste la prepararea unei supe?";
                output.Domain = "Gastronomie";
            }
            return Task.FromResult(output);
        }
    }
}
