using Grpc.Core;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GrpcGreeter.Services
{
    public class CommentService : Comment.CommentBase
    {
        private readonly ILogger<CommentService> _logger;
        public CommentService(ILogger<CommentService> logger)
        {
            _logger = logger;
        }
        public override Task<CommentModel> GetCommentInfo(CommentLookupModel request, ServerCallContext context)
        {
            CommentModel output = new CommentModel();

            if (request.CommentId == 1)
            {
                output.Text = "De obicei in C++.";
                output.PostId = 1;
            }
            else if (request.CommentId == 2)
            {
                output.Text = "Eu folosesc C#.";
                output.PostId = 1;
            }
            else
            {
                output.Text = "Deobicei se pune dupa gust. Foarte putin.";
                output.PostId = 2;
            }
            return Task.FromResult(output);
        }
    }
}