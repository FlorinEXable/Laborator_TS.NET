// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: Protos/post - Copy.proto
// </auto-generated>
#pragma warning disable 0414, 1591
#region Designer generated code

using grpc = global::Grpc.Core;

namespace GrpcGreeter {
  public static partial class Post
  {
    static readonly string __ServiceName = "greet.Post";

    static readonly grpc::Marshaller<global::GrpcGreeter.PostLookupModel> __Marshaller_greet_PostLookupModel = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::GrpcGreeter.PostLookupModel.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::GrpcGreeter.PostModel> __Marshaller_greet_PostModel = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::GrpcGreeter.PostModel.Parser.ParseFrom);

    static readonly grpc::Method<global::GrpcGreeter.PostLookupModel, global::GrpcGreeter.PostModel> __Method_GetPostInfo = new grpc::Method<global::GrpcGreeter.PostLookupModel, global::GrpcGreeter.PostModel>(
        grpc::MethodType.Unary,
        __ServiceName,
        "GetPostInfo",
        __Marshaller_greet_PostLookupModel,
        __Marshaller_greet_PostModel);

    /// <summary>Service descriptor</summary>
    public static global::Google.Protobuf.Reflection.ServiceDescriptor Descriptor
    {
      get { return global::GrpcGreeter.PostCopyReflection.Descriptor.Services[0]; }
    }

    /// <summary>Base class for server-side implementations of Post</summary>
    [grpc::BindServiceMethod(typeof(Post), "BindService")]
    public abstract partial class PostBase
    {
      public virtual global::System.Threading.Tasks.Task<global::GrpcGreeter.PostModel> GetPostInfo(global::GrpcGreeter.PostLookupModel request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

    }

    /// <summary>Creates service definition that can be registered with a server</summary>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    public static grpc::ServerServiceDefinition BindService(PostBase serviceImpl)
    {
      return grpc::ServerServiceDefinition.CreateBuilder()
          .AddMethod(__Method_GetPostInfo, serviceImpl.GetPostInfo).Build();
    }

    /// <summary>Register service method with a service binder with or without implementation. Useful when customizing the  service binding logic.
    /// Note: this method is part of an experimental API that can change or be removed without any prior notice.</summary>
    /// <param name="serviceBinder">Service methods will be bound by calling <c>AddMethod</c> on this object.</param>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    public static void BindService(grpc::ServiceBinderBase serviceBinder, PostBase serviceImpl)
    {
      serviceBinder.AddMethod(__Method_GetPostInfo, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::GrpcGreeter.PostLookupModel, global::GrpcGreeter.PostModel>(serviceImpl.GetPostInfo));
    }

  }
}
#endregion