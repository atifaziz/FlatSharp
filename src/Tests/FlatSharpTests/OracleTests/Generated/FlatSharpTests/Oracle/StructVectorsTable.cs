// <auto-generated>
//  automatically generated by the FlatBuffers compiler, do not modify
// </auto-generated>

namespace FlatSharpTests.Oracle
{

using global::System;
using global::System.Collections.Generic;
using global::FlatBuffers;

public struct StructVectorsTable : IFlatbufferObject
{
  private Table __p;
  public ByteBuffer ByteBuffer { get { return __p.bb; } }
  public static void ValidateVersion() { FlatBufferConstants.FLATBUFFERS_1_12_0(); }
  public static StructVectorsTable GetRootAsStructVectorsTable(ByteBuffer _bb) { return GetRootAsStructVectorsTable(_bb, new StructVectorsTable()); }
  public static StructVectorsTable GetRootAsStructVectorsTable(ByteBuffer _bb, StructVectorsTable obj) { return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public void __init(int _i, ByteBuffer _bb) { __p = new Table(_i, _bb); }
  public StructVectorsTable __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }

  public FlatSharpTests.Oracle.StructVectors? Vec { get { int o = __p.__offset(4); return o != 0 ? (FlatSharpTests.Oracle.StructVectors?)(new FlatSharpTests.Oracle.StructVectors()).__assign(o + __p.bb_pos, __p.bb) : null; } }

  public static void StartStructVectorsTable(FlatBufferBuilder builder) { builder.StartTable(1); }
  public static void AddVec(FlatBufferBuilder builder, Offset<FlatSharpTests.Oracle.StructVectors> VecOffset) { builder.AddStruct(0, VecOffset.Value, 0); }
  public static Offset<FlatSharpTests.Oracle.StructVectorsTable> EndStructVectorsTable(FlatBufferBuilder builder) {
    int o = builder.EndTable();
    return new Offset<FlatSharpTests.Oracle.StructVectorsTable>(o);
  }
  public StructVectorsTableT UnPack() {
    var _o = new StructVectorsTableT();
    this.UnPackTo(_o);
    return _o;
  }
  public void UnPackTo(StructVectorsTableT _o) {
    _o.Vec = this.Vec.HasValue ? this.Vec.Value.UnPack() : null;
  }
  public static Offset<FlatSharpTests.Oracle.StructVectorsTable> Pack(FlatBufferBuilder builder, StructVectorsTableT _o) {
    if (_o == null) return default(Offset<FlatSharpTests.Oracle.StructVectorsTable>);
    StartStructVectorsTable(builder);
    AddVec(builder, FlatSharpTests.Oracle.StructVectors.Pack(builder, _o.Vec));
    return EndStructVectorsTable(builder);
  }
};

public class StructVectorsTableT
{
  public FlatSharpTests.Oracle.StructVectorsT Vec { get; set; }

  public StructVectorsTableT() {
    this.Vec = new FlatSharpTests.Oracle.StructVectorsT();
  }
}


}