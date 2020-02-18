// <auto-generated>
//  automatically generated by the FlatBuffers compiler, do not modify
// </auto-generated>

namespace rlbot.flat
{

using global::System;
using global::FlatBuffers;

/// Expresses the rotation state of an object in Euler angles, with values in radians.
public struct Rotator : IFlatbufferObject
{
  private Struct __p;
  public ByteBuffer ByteBuffer { get { return __p.bb; } }
  public void __init(int _i, ByteBuffer _bb) { __p.bb_pos = _i; __p.bb = _bb; }
  public Rotator __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }

  public float Pitch { get { return __p.bb.GetFloat(__p.bb_pos + 0); } }
  public float Yaw { get { return __p.bb.GetFloat(__p.bb_pos + 4); } }
  public float Roll { get { return __p.bb.GetFloat(__p.bb_pos + 8); } }

  public static Offset<Rotator> CreateRotator(FlatBufferBuilder builder, float Pitch, float Yaw, float Roll) {
    builder.Prep(4, 12);
    builder.PutFloat(Roll);
    builder.PutFloat(Yaw);
    builder.PutFloat(Pitch);
    return new Offset<Rotator>(builder.Offset);
  }
};


}
