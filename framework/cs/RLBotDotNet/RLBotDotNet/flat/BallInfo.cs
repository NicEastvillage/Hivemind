// <auto-generated>
//  automatically generated by the FlatBuffers compiler, do not modify
// </auto-generated>

namespace rlbot.flat
{

using global::System;
using global::FlatBuffers;

public struct BallInfo : IFlatbufferObject
{
  private Table __p;
  public ByteBuffer ByteBuffer { get { return __p.bb; } }
  public static BallInfo GetRootAsBallInfo(ByteBuffer _bb) { return GetRootAsBallInfo(_bb, new BallInfo()); }
  public static BallInfo GetRootAsBallInfo(ByteBuffer _bb, BallInfo obj) { return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public void __init(int _i, ByteBuffer _bb) { __p.bb_pos = _i; __p.bb = _bb; }
  public BallInfo __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }

  public Physics? Physics { get { int o = __p.__offset(4); return o != 0 ? (Physics?)(new Physics()).__assign(__p.__indirect(o + __p.bb_pos), __p.bb) : null; } }
  public Touch? LatestTouch { get { int o = __p.__offset(6); return o != 0 ? (Touch?)(new Touch()).__assign(__p.__indirect(o + __p.bb_pos), __p.bb) : null; } }
  public DropShotBallInfo? DropShotInfo { get { int o = __p.__offset(8); return o != 0 ? (DropShotBallInfo?)(new DropShotBallInfo()).__assign(__p.__indirect(o + __p.bb_pos), __p.bb) : null; } }
  public CollisionShape ShapeType { get { int o = __p.__offset(10); return o != 0 ? (CollisionShape)__p.bb.Get(o + __p.bb_pos) : CollisionShape.NONE; } }
  public TTable? Shape<TTable>() where TTable : struct, IFlatbufferObject { int o = __p.__offset(12); return o != 0 ? (TTable?)__p.__union<TTable>(o) : null; }

  public static Offset<BallInfo> CreateBallInfo(FlatBufferBuilder builder,
      Offset<Physics> physicsOffset = default(Offset<Physics>),
      Offset<Touch> latestTouchOffset = default(Offset<Touch>),
      Offset<DropShotBallInfo> dropShotInfoOffset = default(Offset<DropShotBallInfo>),
      CollisionShape shape_type = CollisionShape.NONE,
      int shapeOffset = 0) {
    builder.StartObject(5);
    BallInfo.AddShape(builder, shapeOffset);
    BallInfo.AddDropShotInfo(builder, dropShotInfoOffset);
    BallInfo.AddLatestTouch(builder, latestTouchOffset);
    BallInfo.AddPhysics(builder, physicsOffset);
    BallInfo.AddShapeType(builder, shape_type);
    return BallInfo.EndBallInfo(builder);
  }

  public static void StartBallInfo(FlatBufferBuilder builder) { builder.StartObject(5); }
  public static void AddPhysics(FlatBufferBuilder builder, Offset<Physics> physicsOffset) { builder.AddOffset(0, physicsOffset.Value, 0); }
  public static void AddLatestTouch(FlatBufferBuilder builder, Offset<Touch> latestTouchOffset) { builder.AddOffset(1, latestTouchOffset.Value, 0); }
  public static void AddDropShotInfo(FlatBufferBuilder builder, Offset<DropShotBallInfo> dropShotInfoOffset) { builder.AddOffset(2, dropShotInfoOffset.Value, 0); }
  public static void AddShapeType(FlatBufferBuilder builder, CollisionShape shapeType) { builder.AddByte(3, (byte)shapeType, 0); }
  public static void AddShape(FlatBufferBuilder builder, int shapeOffset) { builder.AddOffset(4, shapeOffset, 0); }
  public static Offset<BallInfo> EndBallInfo(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<BallInfo>(o);
  }
};


}
