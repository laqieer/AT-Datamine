// Decompiled with JetBrains decompiler
// Type: staq.SaveSchema.LvUpParamInfo
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using FlatBuffers;
using Il2CppDummyDll;
using System;

#nullable disable
namespace staq.SaveSchema
{
  [Token(Token = "0x2003C7C")]
  public struct LvUpParamInfo : IFlatbufferObject
  {
    [Token(Token = "0x4010BDB")]
    [FieldOffset(Offset = "0x0")]
    private Table __p;

    [Token(Token = "0x17004DFA")]
    public ByteBuffer ByteBuffer
    {
      [Token(Token = "0x6017E9E"), Address(RVA = "0x37C1388", Offset = "0x37C1388", VA = "0x37C1388", Slot = "4")] get
      {
        return (ByteBuffer) null;
      }
    }

    [Token(Token = "0x6017E9F")]
    [Address(RVA = "0x37C1390", Offset = "0x37C1390", VA = "0x37C1390")]
    public static LvUpParamInfo GetRootAsLvUpParamInfo(ByteBuffer _bb) => new LvUpParamInfo();

    [Token(Token = "0x6017EA0")]
    [Address(RVA = "0x37C139C", Offset = "0x37C139C", VA = "0x37C139C")]
    public static LvUpParamInfo GetRootAsLvUpParamInfo(ByteBuffer _bb, LvUpParamInfo obj)
    {
      return new LvUpParamInfo();
    }

    [Token(Token = "0x6017EA1")]
    [Address(RVA = "0x37C13F8", Offset = "0x37C13F8", VA = "0x37C13F8", Slot = "5")]
    public void __init(int _i, ByteBuffer _bb)
    {
    }

    [Token(Token = "0x6017EA2")]
    [Address(RVA = "0x37C13E0", Offset = "0x37C13E0", VA = "0x37C13E0")]
    public LvUpParamInfo __assign(int _i, ByteBuffer _bb) => new LvUpParamInfo();

    [Token(Token = "0x17004DFB")]
    public string UnitId
    {
      [Token(Token = "0x6017EA3"), Address(RVA = "0x37C1404", Offset = "0x37C1404", VA = "0x37C1404")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x6017EA4")]
    [Address(RVA = "0x37C1440", Offset = "0x37C1440", VA = "0x37C1440")]
    public ArraySegment<byte>? GetUnitIdBytes() => new ArraySegment<byte>?();

    [Token(Token = "0x6017EA5")]
    [Address(RVA = "0x37C1478", Offset = "0x37C1478", VA = "0x37C1478")]
    public byte[] GetUnitIdArray() => (byte[]) null;

    [Token(Token = "0x6017EA6")]
    [Address(RVA = "0x37C14C4", Offset = "0x37C14C4", VA = "0x37C14C4")]
    public LvUpParam? LvUpParams(int j) => new LvUpParam?();

    [Token(Token = "0x17004DFC")]
    public int LvUpParamsLength
    {
      [Token(Token = "0x6017EA7"), Address(RVA = "0x37C1578", Offset = "0x37C1578", VA = "0x37C1578")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x6017EA8")]
    [Address(RVA = "0x37C15AC", Offset = "0x37C15AC", VA = "0x37C15AC")]
    public static Offset<LvUpParamInfo> CreateLvUpParamInfo(
      FlatBufferBuilder builder,
      StringOffset unitIdOffset = default (StringOffset),
      VectorOffset lvUpParamsOffset = default (VectorOffset))
    {
      return new Offset<LvUpParamInfo>();
    }

    [Token(Token = "0x6017EA9")]
    [Address(RVA = "0x37C1694", Offset = "0x37C1694", VA = "0x37C1694")]
    public static void StartLvUpParamInfo(FlatBufferBuilder builder)
    {
    }

    [Token(Token = "0x6017EAA")]
    [Address(RVA = "0x37C1624", Offset = "0x37C1624", VA = "0x37C1624")]
    public static void AddUnitId(FlatBufferBuilder builder, StringOffset unitIdOffset)
    {
    }

    [Token(Token = "0x6017EAB")]
    [Address(RVA = "0x37C1604", Offset = "0x37C1604", VA = "0x37C1604")]
    public static void AddLvUpParams(FlatBufferBuilder builder, VectorOffset lvUpParamsOffset)
    {
    }

    [Token(Token = "0x6017EAC")]
    [Address(RVA = "0x37C16AC", Offset = "0x37C16AC", VA = "0x37C16AC")]
    public static VectorOffset CreateLvUpParamsVector(
      FlatBufferBuilder builder,
      Offset<LvUpParam>[] data)
    {
      return new VectorOffset();
    }

    [Token(Token = "0x6017EAD")]
    [Address(RVA = "0x37C1754", Offset = "0x37C1754", VA = "0x37C1754")]
    public static VectorOffset CreateLvUpParamsVectorBlock(
      FlatBufferBuilder builder,
      Offset<LvUpParam>[] data)
    {
      return new VectorOffset();
    }

    [Token(Token = "0x6017EAE")]
    [Address(RVA = "0x37C17DC", Offset = "0x37C17DC", VA = "0x37C17DC")]
    public static void StartLvUpParamsVector(FlatBufferBuilder builder, int numElems)
    {
    }

    [Token(Token = "0x6017EAF")]
    [Address(RVA = "0x37C1644", Offset = "0x37C1644", VA = "0x37C1644")]
    public static Offset<LvUpParamInfo> EndLvUpParamInfo(FlatBufferBuilder builder)
    {
      return new Offset<LvUpParamInfo>();
    }
  }
}
