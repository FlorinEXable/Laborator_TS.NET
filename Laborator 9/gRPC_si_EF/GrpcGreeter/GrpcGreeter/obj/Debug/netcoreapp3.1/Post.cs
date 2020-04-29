// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: Protos/post.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace GrpcGreeter {

  /// <summary>Holder for reflection information generated from Protos/post.proto</summary>
  public static partial class PostReflection {

    #region Descriptor
    /// <summary>File descriptor for Protos/post.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static PostReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChFQcm90b3MvcG9zdC5wcm90bxIFZ3JlZXQiIQoPUG9zdExvb2t1cE1vZGVs",
            "Eg4KBnBvc3RJZBgBIAEoBSI+CglQb3N0TW9kZWwSEwoLZGVzY3JpcHRpb24Y",
            "ASABKAkSDgoGZG9tYWluGAIgASgJEgwKBGRhdGUYAyABKAkyQQoEUG9zdBI5",
            "CgtHZXRQb3N0SW5mbxIWLmdyZWV0LlBvc3RMb29rdXBNb2RlbBoQLmdyZWV0",
            "LlBvc3RNb2RlbCIAQg6qAgtHcnBjR3JlZXRlcmIGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::GrpcGreeter.PostLookupModel), global::GrpcGreeter.PostLookupModel.Parser, new[]{ "PostId" }, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::GrpcGreeter.PostModel), global::GrpcGreeter.PostModel.Parser, new[]{ "Description", "Domain", "Date" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class PostLookupModel : pb::IMessage<PostLookupModel> {
    private static readonly pb::MessageParser<PostLookupModel> _parser = new pb::MessageParser<PostLookupModel>(() => new PostLookupModel());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<PostLookupModel> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::GrpcGreeter.PostReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public PostLookupModel() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public PostLookupModel(PostLookupModel other) : this() {
      postId_ = other.postId_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public PostLookupModel Clone() {
      return new PostLookupModel(this);
    }

    /// <summary>Field number for the "postId" field.</summary>
    public const int PostIdFieldNumber = 1;
    private int postId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int PostId {
      get { return postId_; }
      set {
        postId_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as PostLookupModel);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(PostLookupModel other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (PostId != other.PostId) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (PostId != 0) hash ^= PostId.GetHashCode();
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (PostId != 0) {
        output.WriteRawTag(8);
        output.WriteInt32(PostId);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (PostId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(PostId);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(PostLookupModel other) {
      if (other == null) {
        return;
      }
      if (other.PostId != 0) {
        PostId = other.PostId;
      }
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 8: {
            PostId = input.ReadInt32();
            break;
          }
        }
      }
    }

  }

  public sealed partial class PostModel : pb::IMessage<PostModel> {
    private static readonly pb::MessageParser<PostModel> _parser = new pb::MessageParser<PostModel>(() => new PostModel());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<PostModel> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::GrpcGreeter.PostReflection.Descriptor.MessageTypes[1]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public PostModel() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public PostModel(PostModel other) : this() {
      description_ = other.description_;
      domain_ = other.domain_;
      date_ = other.date_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public PostModel Clone() {
      return new PostModel(this);
    }

    /// <summary>Field number for the "description" field.</summary>
    public const int DescriptionFieldNumber = 1;
    private string description_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Description {
      get { return description_; }
      set {
        description_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "domain" field.</summary>
    public const int DomainFieldNumber = 2;
    private string domain_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Domain {
      get { return domain_; }
      set {
        domain_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "date" field.</summary>
    public const int DateFieldNumber = 3;
    private string date_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Date {
      get { return date_; }
      set {
        date_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as PostModel);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(PostModel other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Description != other.Description) return false;
      if (Domain != other.Domain) return false;
      if (Date != other.Date) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Description.Length != 0) hash ^= Description.GetHashCode();
      if (Domain.Length != 0) hash ^= Domain.GetHashCode();
      if (Date.Length != 0) hash ^= Date.GetHashCode();
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (Description.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(Description);
      }
      if (Domain.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(Domain);
      }
      if (Date.Length != 0) {
        output.WriteRawTag(26);
        output.WriteString(Date);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (Description.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Description);
      }
      if (Domain.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Domain);
      }
      if (Date.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Date);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(PostModel other) {
      if (other == null) {
        return;
      }
      if (other.Description.Length != 0) {
        Description = other.Description;
      }
      if (other.Domain.Length != 0) {
        Domain = other.Domain;
      }
      if (other.Date.Length != 0) {
        Date = other.Date;
      }
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 10: {
            Description = input.ReadString();
            break;
          }
          case 18: {
            Domain = input.ReadString();
            break;
          }
          case 26: {
            Date = input.ReadString();
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code