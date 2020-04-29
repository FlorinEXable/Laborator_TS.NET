using System;
using System.Net.Http;
using System.Threading.Tasks;
using GrpcGreeter;
using Grpc.Net.Client;
namespace GrpcGreeterClient
{
    class Program
    {
        static async Task Main(string[] args)
        {
            // The port number(5001) must match the port of the gRPC server.
            using var channel = GrpcChannel.ForAddress("https://localhost:5001");
            var postClient = new Post.PostClient(channel);
            var commentClient = new Comment.CommentClient(channel);

            var postRequested = new PostLookupModel { PostId = 1 };
            var post = await postClient.GetPostInfoAsync(postRequested);
            var commentRequested = new CommentLookupModel { CommentId = 1 };
            var comment = await commentClient.GetCommentInfoAsync(commentRequested);
            var commentRequested2 = new CommentLookupModel { CommentId = 2 };
            var comment2 = await commentClient.GetCommentInfoAsync(commentRequested2);
            Console.WriteLine($"{ post.Date } {post.Description} {post.Domain}");
            Console.WriteLine($"     - { comment.Text }");
            Console.WriteLine($"     - { comment2.Text }");
            var postRequested2 = new PostLookupModel { PostId = 2 };
            var post2 = await postClient.GetPostInfoAsync(postRequested2);
            var commentRequested3 = new CommentLookupModel { CommentId = 3 };
            var comment3 = await commentClient.GetCommentInfoAsync(commentRequested3);
            Console.WriteLine($"{ post2.Date } {post2.Description} {post2.Domain}");
            Console.WriteLine($"     - { comment3.Text }");

            Console.ReadLine();
        }
    }
}