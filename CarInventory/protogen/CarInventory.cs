// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: CarInventory.proto
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace CarInventoryProto {

  /// <summary>Holder for reflection information generated from CarInventory.proto</summary>
  public static partial class CarInventoryReflection {

    #region Descriptor
    /// <summary>File descriptor for CarInventory.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static CarInventoryReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChJDYXJJbnZlbnRvcnkucHJvdG8SEUNhckludmVudG9yeVByb3RvGgtFbXB0",
            "eS5wcm90byIvCgdDYXJMaXN0EiQKBGNhcnMYASADKAsyFi5DYXJJbnZlbnRv",
            "cnlQcm90by5DYXIiQgoDQ2FyEgoKAmlkGAEgASgFEg0KBWJyYW5kGAIgASgJ",
            "Eg0KBW1vZGVsGAMgASgJEhEKCW1vZGVsWWVhchgEIAEoBTLOAQoMQ2FySW52",
            "ZW50b3J5EjoKBkFkZENhchIWLkNhckludmVudG9yeVByb3RvLkNhchoWLmdv",
            "b2dsZS5wcm90b2J1Zi5FbXB0eSIAEj0KCVJlbW92ZUNhchIWLkNhckludmVu",
            "dG9yeVByb3RvLkNhchoWLkNhckludmVudG9yeVByb3RvLkNhciIAEkMKC0xp",
            "c3RBbGxDYXJzEhYuQ2FySW52ZW50b3J5UHJvdG8uQ2FyGhouQ2FySW52ZW50",
            "b3J5UHJvdG8uQ2FyTGlzdCIAYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Google.Protobuf.WellKnownTypes.EmptyReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::CarInventoryProto.CarList), global::CarInventoryProto.CarList.Parser, new[]{ "Cars" }, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::CarInventoryProto.Car), global::CarInventoryProto.Car.Parser, new[]{ "Id", "Brand", "Model", "ModelYear" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class CarList : pb::IMessage<CarList> {
    private static readonly pb::MessageParser<CarList> _parser = new pb::MessageParser<CarList>(() => new CarList());
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<CarList> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::CarInventoryProto.CarInventoryReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public CarList() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public CarList(CarList other) : this() {
      cars_ = other.cars_.Clone();
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public CarList Clone() {
      return new CarList(this);
    }

    /// <summary>Field number for the "cars" field.</summary>
    public const int CarsFieldNumber = 1;
    private static readonly pb::FieldCodec<global::CarInventoryProto.Car> _repeated_cars_codec
        = pb::FieldCodec.ForMessage(10, global::CarInventoryProto.Car.Parser);
    private readonly pbc::RepeatedField<global::CarInventoryProto.Car> cars_ = new pbc::RepeatedField<global::CarInventoryProto.Car>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<global::CarInventoryProto.Car> Cars {
      get { return cars_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as CarList);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(CarList other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if(!cars_.Equals(other.cars_)) return false;
      return true;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      hash ^= cars_.GetHashCode();
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      cars_.WriteTo(output, _repeated_cars_codec);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      size += cars_.CalculateSize(_repeated_cars_codec);
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(CarList other) {
      if (other == null) {
        return;
      }
      cars_.Add(other.cars_);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            input.SkipLastField();
            break;
          case 10: {
            cars_.AddEntriesFrom(input, _repeated_cars_codec);
            break;
          }
        }
      }
    }

  }

  public sealed partial class Car : pb::IMessage<Car> {
    private static readonly pb::MessageParser<Car> _parser = new pb::MessageParser<Car>(() => new Car());
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<Car> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::CarInventoryProto.CarInventoryReflection.Descriptor.MessageTypes[1]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Car() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Car(Car other) : this() {
      id_ = other.id_;
      brand_ = other.brand_;
      model_ = other.model_;
      modelYear_ = other.modelYear_;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Car Clone() {
      return new Car(this);
    }

    /// <summary>Field number for the "id" field.</summary>
    public const int IdFieldNumber = 1;
    private int id_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int Id {
      get { return id_; }
      set {
        id_ = value;
      }
    }

    /// <summary>Field number for the "brand" field.</summary>
    public const int BrandFieldNumber = 2;
    private string brand_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Brand {
      get { return brand_; }
      set {
        brand_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "model" field.</summary>
    public const int ModelFieldNumber = 3;
    private string model_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Model {
      get { return model_; }
      set {
        model_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "modelYear" field.</summary>
    public const int ModelYearFieldNumber = 4;
    private int modelYear_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int ModelYear {
      get { return modelYear_; }
      set {
        modelYear_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as Car);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(Car other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Id != other.Id) return false;
      if (Brand != other.Brand) return false;
      if (Model != other.Model) return false;
      if (ModelYear != other.ModelYear) return false;
      return true;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Id != 0) hash ^= Id.GetHashCode();
      if (Brand.Length != 0) hash ^= Brand.GetHashCode();
      if (Model.Length != 0) hash ^= Model.GetHashCode();
      if (ModelYear != 0) hash ^= ModelYear.GetHashCode();
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (Id != 0) {
        output.WriteRawTag(8);
        output.WriteInt32(Id);
      }
      if (Brand.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(Brand);
      }
      if (Model.Length != 0) {
        output.WriteRawTag(26);
        output.WriteString(Model);
      }
      if (ModelYear != 0) {
        output.WriteRawTag(32);
        output.WriteInt32(ModelYear);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (Id != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(Id);
      }
      if (Brand.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Brand);
      }
      if (Model.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Model);
      }
      if (ModelYear != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(ModelYear);
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(Car other) {
      if (other == null) {
        return;
      }
      if (other.Id != 0) {
        Id = other.Id;
      }
      if (other.Brand.Length != 0) {
        Brand = other.Brand;
      }
      if (other.Model.Length != 0) {
        Model = other.Model;
      }
      if (other.ModelYear != 0) {
        ModelYear = other.ModelYear;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            input.SkipLastField();
            break;
          case 8: {
            Id = input.ReadInt32();
            break;
          }
          case 18: {
            Brand = input.ReadString();
            break;
          }
          case 26: {
            Model = input.ReadString();
            break;
          }
          case 32: {
            ModelYear = input.ReadInt32();
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code
