// <auto-generated>
//  automatically generated by the FlatBuffers compiler, do not modify
// </auto-generated>

namespace rlbot.flat
{

using global::System;
using global::FlatBuffers;

public struct DesiredPhysics : IFlatbufferObject
{
  private Table __p;
  public ByteBuffer ByteBuffer { get { return __p.bb; } }
  public static DesiredPhysics GetRootAsDesiredPhysics(ByteBuffer _bb) { return GetRootAsDesiredPhysics(_bb, new DesiredPhysics()); }
  public static DesiredPhysics GetRootAsDesiredPhysics(ByteBuffer _bb, DesiredPhysics obj) { return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public void __init(int _i, ByteBuffer _bb) { __p.bb_pos = _i; __p.bb = _bb; }
  public DesiredPhysics __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }

  public Vector3Partial? Location { get { int o = __p.__offset(4); return o != 0 ? (Vector3Partial?)(new Vector3Partial()).__assign(__p.__indirect(o + __p.bb_pos), __p.bb) : null; } }
  public RotatorPartial? Rotation { get { int o = __p.__offset(6); return o != 0 ? (RotatorPartial?)(new RotatorPartial()).__assign(__p.__indirect(o + __p.bb_pos), __p.bb) : null; } }
  public Vector3Partial? Velocity { get { int o = __p.__offset(8); return o != 0 ? (Vector3Partial?)(new Vector3Partial()).__assign(__p.__indirect(o + __p.bb_pos), __p.bb) : null; } }
  public Vector3Partial? AngularVelocity { get { int o = __p.__offset(10); return o != 0 ? (Vector3Partial?)(new Vector3Partial()).__assign(__p.__indirect(o + __p.bb_pos), __p.bb) : null; } }

  public static Offset<DesiredPhysics> CreateDesiredPhysics(FlatBufferBuilder builder,
      Offset<Vector3Partial> locationOffset = default(Offset<Vector3Partial>),
      Offset<RotatorPartial> rotationOffset = default(Offset<RotatorPartial>),
      Offset<Vector3Partial> velocityOffset = default(Offset<Vector3Partial>),
      Offset<Vector3Partial> angularVelocityOffset = default(Offset<Vector3Partial>)) {
    builder.StartObject(4);
    DesiredPhysics.AddAngularVelocity(builder, angularVelocityOffset);
    DesiredPhysics.AddVelocity(builder, velocityOffset);
    DesiredPhysics.AddRotation(builder, rotationOffset);
    DesiredPhysics.AddLocation(builder, locationOffset);
    return DesiredPhysics.EndDesiredPhysics(builder);
  }

  public static void StartDesiredPhysics(FlatBufferBuilder builder) { builder.StartObject(4); }
  public static void AddLocation(FlatBufferBuilder builder, Offset<Vector3Partial> locationOffset) { builder.AddOffset(0, locationOffset.Value, 0); }
  public static void AddRotation(FlatBufferBuilder builder, Offset<RotatorPartial> rotationOffset) { builder.AddOffset(1, rotationOffset.Value, 0); }
  public static void AddVelocity(FlatBufferBuilder builder, Offset<Vector3Partial> velocityOffset) { builder.AddOffset(2, velocityOffset.Value, 0); }
  public static void AddAngularVelocity(FlatBufferBuilder builder, Offset<Vector3Partial> angularVelocityOffset) { builder.AddOffset(3, angularVelocityOffset.Value, 0); }
  public static Offset<DesiredPhysics> EndDesiredPhysics(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<DesiredPhysics>(o);
  }
};


}
