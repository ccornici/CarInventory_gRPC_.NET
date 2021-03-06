// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: CarInventory.proto
// </auto-generated>
#pragma warning disable 1591
#region Designer generated code

using System;
using System.Threading;
using System.Threading.Tasks;
using grpc = global::Grpc.Core;

namespace CarInventoryProto {
  public static partial class CarInventory
  {
    static readonly string __ServiceName = "CarInventoryProto.CarInventory";

    static readonly grpc::Marshaller<global::CarInventoryProto.Car> __Marshaller_Car = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::CarInventoryProto.Car.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Google.Protobuf.WellKnownTypes.Empty> __Marshaller_Empty = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Google.Protobuf.WellKnownTypes.Empty.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::CarInventoryProto.CarList> __Marshaller_CarList = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::CarInventoryProto.CarList.Parser.ParseFrom);

    static readonly grpc::Method<global::CarInventoryProto.Car, global::Google.Protobuf.WellKnownTypes.Empty> __Method_AddCar = new grpc::Method<global::CarInventoryProto.Car, global::Google.Protobuf.WellKnownTypes.Empty>(
        grpc::MethodType.Unary,
        __ServiceName,
        "AddCar",
        __Marshaller_Car,
        __Marshaller_Empty);

    static readonly grpc::Method<global::CarInventoryProto.Car, global::CarInventoryProto.Car> __Method_RemoveCar = new grpc::Method<global::CarInventoryProto.Car, global::CarInventoryProto.Car>(
        grpc::MethodType.Unary,
        __ServiceName,
        "RemoveCar",
        __Marshaller_Car,
        __Marshaller_Car);

    static readonly grpc::Method<global::CarInventoryProto.Car, global::CarInventoryProto.CarList> __Method_ListAllCars = new grpc::Method<global::CarInventoryProto.Car, global::CarInventoryProto.CarList>(
        grpc::MethodType.Unary,
        __ServiceName,
        "ListAllCars",
        __Marshaller_Car,
        __Marshaller_CarList);

    /// <summary>Service descriptor</summary>
    public static global::Google.Protobuf.Reflection.ServiceDescriptor Descriptor
    {
      get { return global::CarInventoryProto.CarInventoryReflection.Descriptor.Services[0]; }
    }

    /// <summary>Base class for server-side implementations of CarInventory</summary>
    public abstract partial class CarInventoryBase
    {
      public virtual global::System.Threading.Tasks.Task<global::Google.Protobuf.WellKnownTypes.Empty> AddCar(global::CarInventoryProto.Car request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      public virtual global::System.Threading.Tasks.Task<global::CarInventoryProto.Car> RemoveCar(global::CarInventoryProto.Car request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      public virtual global::System.Threading.Tasks.Task<global::CarInventoryProto.CarList> ListAllCars(global::CarInventoryProto.Car request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

    }

    /// <summary>Client for CarInventory</summary>
    public partial class CarInventoryClient : grpc::ClientBase<CarInventoryClient>
    {
      /// <summary>Creates a new client for CarInventory</summary>
      /// <param name="channel">The channel to use to make remote calls.</param>
      public CarInventoryClient(grpc::Channel channel) : base(channel)
      {
      }
      /// <summary>Creates a new client for CarInventory that uses a custom <c>CallInvoker</c>.</summary>
      /// <param name="callInvoker">The callInvoker to use to make remote calls.</param>
      public CarInventoryClient(grpc::CallInvoker callInvoker) : base(callInvoker)
      {
      }
      /// <summary>Protected parameterless constructor to allow creation of test doubles.</summary>
      protected CarInventoryClient() : base()
      {
      }
      /// <summary>Protected constructor to allow creation of configured clients.</summary>
      /// <param name="configuration">The client configuration.</param>
      protected CarInventoryClient(ClientBaseConfiguration configuration) : base(configuration)
      {
      }

      public virtual global::Google.Protobuf.WellKnownTypes.Empty AddCar(global::CarInventoryProto.Car request, grpc::Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return AddCar(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual global::Google.Protobuf.WellKnownTypes.Empty AddCar(global::CarInventoryProto.Car request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_AddCar, null, options, request);
      }
      public virtual grpc::AsyncUnaryCall<global::Google.Protobuf.WellKnownTypes.Empty> AddCarAsync(global::CarInventoryProto.Car request, grpc::Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return AddCarAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual grpc::AsyncUnaryCall<global::Google.Protobuf.WellKnownTypes.Empty> AddCarAsync(global::CarInventoryProto.Car request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_AddCar, null, options, request);
      }
      public virtual global::CarInventoryProto.Car RemoveCar(global::CarInventoryProto.Car request, grpc::Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return RemoveCar(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual global::CarInventoryProto.Car RemoveCar(global::CarInventoryProto.Car request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_RemoveCar, null, options, request);
      }
      public virtual grpc::AsyncUnaryCall<global::CarInventoryProto.Car> RemoveCarAsync(global::CarInventoryProto.Car request, grpc::Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return RemoveCarAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual grpc::AsyncUnaryCall<global::CarInventoryProto.Car> RemoveCarAsync(global::CarInventoryProto.Car request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_RemoveCar, null, options, request);
      }
      public virtual global::CarInventoryProto.CarList ListAllCars(global::CarInventoryProto.Car request, grpc::Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return ListAllCars(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual global::CarInventoryProto.CarList ListAllCars(global::CarInventoryProto.Car request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_ListAllCars, null, options, request);
      }
      public virtual grpc::AsyncUnaryCall<global::CarInventoryProto.CarList> ListAllCarsAsync(global::CarInventoryProto.Car request, grpc::Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return ListAllCarsAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual grpc::AsyncUnaryCall<global::CarInventoryProto.CarList> ListAllCarsAsync(global::CarInventoryProto.Car request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_ListAllCars, null, options, request);
      }
      /// <summary>Creates a new instance of client from given <c>ClientBaseConfiguration</c>.</summary>
      protected override CarInventoryClient NewInstance(ClientBaseConfiguration configuration)
      {
        return new CarInventoryClient(configuration);
      }
    }

    /// <summary>Creates service definition that can be registered with a server</summary>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    public static grpc::ServerServiceDefinition BindService(CarInventoryBase serviceImpl)
    {
      return grpc::ServerServiceDefinition.CreateBuilder()
          .AddMethod(__Method_AddCar, serviceImpl.AddCar)
          .AddMethod(__Method_RemoveCar, serviceImpl.RemoveCar)
          .AddMethod(__Method_ListAllCars, serviceImpl.ListAllCars).Build();
    }

  }
}
#endregion
