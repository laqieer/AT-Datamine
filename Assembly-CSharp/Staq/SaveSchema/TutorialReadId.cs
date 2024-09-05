// Decompiled with JetBrains decompiler
// Type: staq.SaveSchema.TutorialReadId
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using FlatBuffers;
using Il2CppDummyDll;
using System;

#nullable disable
namespace staq.SaveSchema
{
  [Token(Token = "0x2003CE7")]
  public struct TutorialReadId : IFlatbufferObject
  {
    [Token(Token = "0x4010C48")]
    [FieldOffset(Offset = "0x0")]
    private Table __p;

    [Token(Token = "0x17004FF6")]
    public ByteBuffer ByteBuffer
    {
      [Token(Token = "0x601877A"), Address(RVA = "0x2936A90", Offset = "0x2936A90", VA = "0x2936A90", Slot = "4")] get
      {
        return (ByteBuffer) null;
      }
    }

    [Token(Token = "0x601877B")]
    [Address(RVA = "0x2936A98", Offset = "0x2936A98", VA = "0x2936A98")]
    public static TutorialReadId GetRootAsTutorialReadId(ByteBuffer _bb) => new TutorialReadId();

    [Token(Token = "0x601877C")]
    [Address(RVA = "0x2936AA4", Offset = "0x2936AA4", VA = "0x2936AA4")]
    public static TutorialReadId GetRootAsTutorialReadId(ByteBuffer _bb, TutorialReadId obj)
    {
      return new TutorialReadId();
    }

    [Token(Token = "0x601877D")]
    [Address(RVA = "0x2936B00", Offset = "0x2936B00", VA = "0x2936B00")]
    public static bool TutorialReadIdBufferHasIdentifier(ByteBuffer _bb) => new bool();

    [Token(Token = "0x601877E")]
    [Address(RVA = "0x2936B4C", Offset = "0x2936B4C", VA = "0x2936B4C", Slot = "5")]
    public void __init(int _i, ByteBuffer _bb)
    {
    }

    [Token(Token = "0x601877F")]
    [Address(RVA = "0x2936AE8", Offset = "0x2936AE8", VA = "0x2936AE8")]
    public TutorialReadId __assign(int _i, ByteBuffer _bb) => new TutorialReadId();

    [Token(Token = "0x6018780")]
    [Address(RVA = "0x2936B58", Offset = "0x2936B58", VA = "0x2936B58")]
    public int IdList(int j) => new int();

    [Token(Token = "0x17004FF7")]
    public int IdListLength
    {
      [Token(Token = "0x6018781"), Address(RVA = "0x2936BB8", Offset = "0x2936BB8", VA = "0x2936BB8")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x6018782")]
    [Address(RVA = "0x2936BEC", Offset = "0x2936BEC", VA = "0x2936BEC")]
    public ArraySegment<byte>? GetIdListBytes() => new ArraySegment<byte>?();

    [Token(Token = "0x6018783")]
    [Address(RVA = "0x2936C24", Offset = "0x2936C24", VA = "0x2936C24")]
    public int[] GetIdListArray() => (int[]) null;

    [Token(Token = "0x6018784")]
    [Address(RVA = "0x2936C70", Offset = "0x2936C70", VA = "0x2936C70")]
    public static Offset<TutorialReadId> CreateTutorialReadId(
      FlatBufferBuilder builder,
      VectorOffset IdListOffset = default (VectorOffset))
    {
      return new Offset<TutorialReadId>();
    }

    [Token(Token = "0x6018785")]
    [Address(RVA = "0x2936D28", Offset = "0x2936D28", VA = "0x2936D28")]
    public static void StartTutorialReadId(FlatBufferBuilder builder)
    {
    }

    [Token(Token = "0x6018786")]
    [Address(RVA = "0x2936CB8", Offset = "0x2936CB8", VA = "0x2936CB8")]
    public static void AddIdList(FlatBufferBuilder builder, VectorOffset IdListOffset)
    {
    }

    [Token(Token = "0x6018787")]
    [Address(RVA = "0x2936D40", Offset = "0x2936D40", VA = "0x2936D40")]
    public static VectorOffset CreateIdListVector(FlatBufferBuilder builder, int[] data)
    {
      return new VectorOffset();
    }

    [Token(Token = "0x6018788")]
    [Address(RVA = "0x2936DE8", Offset = "0x2936DE8", VA = "0x2936DE8")]
    public static VectorOffset CreateIdListVectorBlock(FlatBufferBuilder builder, int[] data)
    {
      return new VectorOffset();
    }

    [Token(Token = "0x6018789")]
    [Address(RVA = "0x2936E70", Offset = "0x2936E70", VA = "0x2936E70")]
    public static void StartIdListVector(FlatBufferBuilder builder, int numElems)
    {
    }

    [Token(Token = "0x601878A")]
    [Address(RVA = "0x2936CD8", Offset = "0x2936CD8", VA = "0x2936CD8")]
    public static Offset<TutorialReadId> EndTutorialReadId(FlatBufferBuilder builder)
    {
      return new Offset<TutorialReadId>();
    }

    [Token(Token = "0x601878B")]
    [Address(RVA = "0x2936E90", Offset = "0x2936E90", VA = "0x2936E90")]
    public static void FinishTutorialReadIdBuffer(
      FlatBufferBuilder builder,
      Offset<TutorialReadId> offset)
    {
    }

    [Token(Token = "0x601878C")]
    [Address(RVA = "0x2936EEC", Offset = "0x2936EEC", VA = "0x2936EEC")]
    public static void FinishSizePrefixedTutorialReadIdBuffer(
      FlatBufferBuilder builder,
      Offset<TutorialReadId> offset)
    {
    }
  }
}
