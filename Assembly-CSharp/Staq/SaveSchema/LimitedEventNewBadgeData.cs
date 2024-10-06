// Decompiled with JetBrains decompiler
// Type: staq.SaveSchema.LimitedEventNewBadgeData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using FlatBuffers;
using Il2CppDummyDll;
using System;

#nullable disable
namespace staq.SaveSchema
{
  [Token(Token = "0x2003CBF")]
  public struct LimitedEventNewBadgeData : IFlatbufferObject
  {
    [Token(Token = "0x4010C1D")]
    [FieldOffset(Offset = "0x0")]
    private Table __p;

    [Token(Token = "0x17004F64")]
    public ByteBuffer ByteBuffer
    {
      [Token(Token = "0x6018471"), Address(RVA = "0x26D8F5C", Offset = "0x26D8F5C", VA = "0x26D8F5C", Slot = "4")] get
      {
        return (ByteBuffer) null;
      }
    }

    [Token(Token = "0x6018472")]
    [Address(RVA = "0x26D8F64", Offset = "0x26D8F64", VA = "0x26D8F64")]
    public static LimitedEventNewBadgeData GetRootAsLimitedEventNewBadgeData(ByteBuffer _bb)
    {
      return new LimitedEventNewBadgeData();
    }

    [Token(Token = "0x6018473")]
    [Address(RVA = "0x26D8F70", Offset = "0x26D8F70", VA = "0x26D8F70")]
    public static LimitedEventNewBadgeData GetRootAsLimitedEventNewBadgeData(
      ByteBuffer _bb,
      LimitedEventNewBadgeData obj)
    {
      return new LimitedEventNewBadgeData();
    }

    [Token(Token = "0x6018474")]
    [Address(RVA = "0x26D8FCC", Offset = "0x26D8FCC", VA = "0x26D8FCC")]
    public static bool LimitedEventNewBadgeDataBufferHasIdentifier(ByteBuffer _bb) => new bool();

    [Token(Token = "0x6018475")]
    [Address(RVA = "0x26D9018", Offset = "0x26D9018", VA = "0x26D9018", Slot = "5")]
    public void __init(int _i, ByteBuffer _bb)
    {
    }

    [Token(Token = "0x6018476")]
    [Address(RVA = "0x26D8FB4", Offset = "0x26D8FB4", VA = "0x26D8FB4")]
    public LimitedEventNewBadgeData __assign(int _i, ByteBuffer _bb)
    {
      return new LimitedEventNewBadgeData();
    }

    [Token(Token = "0x6018477")]
    [Address(RVA = "0x26D9024", Offset = "0x26D9024", VA = "0x26D9024")]
    public int EventIds(int j) => new int();

    [Token(Token = "0x17004F65")]
    public int EventIdsLength
    {
      [Token(Token = "0x6018478"), Address(RVA = "0x26D9084", Offset = "0x26D9084", VA = "0x26D9084")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x6018479")]
    [Address(RVA = "0x26D90B8", Offset = "0x26D90B8", VA = "0x26D90B8")]
    public ArraySegment<byte>? GetEventIdsBytes() => new ArraySegment<byte>?();

    [Token(Token = "0x601847A")]
    [Address(RVA = "0x26D90F0", Offset = "0x26D90F0", VA = "0x26D90F0")]
    public int[] GetEventIdsArray() => (int[]) null;

    [Token(Token = "0x601847B")]
    [Address(RVA = "0x26D913C", Offset = "0x26D913C", VA = "0x26D913C")]
    public int StageIds(int j) => new int();

    [Token(Token = "0x17004F66")]
    public int StageIdsLength
    {
      [Token(Token = "0x601847C"), Address(RVA = "0x26D919C", Offset = "0x26D919C", VA = "0x26D919C")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x601847D")]
    [Address(RVA = "0x26D91D0", Offset = "0x26D91D0", VA = "0x26D91D0")]
    public ArraySegment<byte>? GetStageIdsBytes() => new ArraySegment<byte>?();

    [Token(Token = "0x601847E")]
    [Address(RVA = "0x26D9208", Offset = "0x26D9208", VA = "0x26D9208")]
    public int[] GetStageIdsArray() => (int[]) null;

    [Token(Token = "0x601847F")]
    [Address(RVA = "0x26D9254", Offset = "0x26D9254", VA = "0x26D9254")]
    public static Offset<LimitedEventNewBadgeData> CreateLimitedEventNewBadgeData(
      FlatBufferBuilder builder,
      VectorOffset eventIdsOffset = default (VectorOffset),
      VectorOffset stageIdsOffset = default (VectorOffset))
    {
      return new Offset<LimitedEventNewBadgeData>();
    }

    [Token(Token = "0x6018480")]
    [Address(RVA = "0x26D933C", Offset = "0x26D933C", VA = "0x26D933C")]
    public static void StartLimitedEventNewBadgeData(FlatBufferBuilder builder)
    {
    }

    [Token(Token = "0x6018481")]
    [Address(RVA = "0x26D92CC", Offset = "0x26D92CC", VA = "0x26D92CC")]
    public static void AddEventIds(FlatBufferBuilder builder, VectorOffset eventIdsOffset)
    {
    }

    [Token(Token = "0x6018482")]
    [Address(RVA = "0x26D9354", Offset = "0x26D9354", VA = "0x26D9354")]
    public static VectorOffset CreateEventIdsVector(FlatBufferBuilder builder, int[] data)
    {
      return new VectorOffset();
    }

    [Token(Token = "0x6018483")]
    [Address(RVA = "0x26D93FC", Offset = "0x26D93FC", VA = "0x26D93FC")]
    public static VectorOffset CreateEventIdsVectorBlock(FlatBufferBuilder builder, int[] data)
    {
      return new VectorOffset();
    }

    [Token(Token = "0x6018484")]
    [Address(RVA = "0x26D9484", Offset = "0x26D9484", VA = "0x26D9484")]
    public static void StartEventIdsVector(FlatBufferBuilder builder, int numElems)
    {
    }

    [Token(Token = "0x6018485")]
    [Address(RVA = "0x26D92AC", Offset = "0x26D92AC", VA = "0x26D92AC")]
    public static void AddStageIds(FlatBufferBuilder builder, VectorOffset stageIdsOffset)
    {
    }

    [Token(Token = "0x6018486")]
    [Address(RVA = "0x26D94A4", Offset = "0x26D94A4", VA = "0x26D94A4")]
    public static VectorOffset CreateStageIdsVector(FlatBufferBuilder builder, int[] data)
    {
      return new VectorOffset();
    }

    [Token(Token = "0x6018487")]
    [Address(RVA = "0x26D954C", Offset = "0x26D954C", VA = "0x26D954C")]
    public static VectorOffset CreateStageIdsVectorBlock(FlatBufferBuilder builder, int[] data)
    {
      return new VectorOffset();
    }

    [Token(Token = "0x6018488")]
    [Address(RVA = "0x26D95D4", Offset = "0x26D95D4", VA = "0x26D95D4")]
    public static void StartStageIdsVector(FlatBufferBuilder builder, int numElems)
    {
    }

    [Token(Token = "0x6018489")]
    [Address(RVA = "0x26D92EC", Offset = "0x26D92EC", VA = "0x26D92EC")]
    public static Offset<LimitedEventNewBadgeData> EndLimitedEventNewBadgeData(
      FlatBufferBuilder builder)
    {
      return new Offset<LimitedEventNewBadgeData>();
    }

    [Token(Token = "0x601848A")]
    [Address(RVA = "0x26D95F4", Offset = "0x26D95F4", VA = "0x26D95F4")]
    public static void FinishLimitedEventNewBadgeDataBuffer(
      FlatBufferBuilder builder,
      Offset<LimitedEventNewBadgeData> offset)
    {
    }

    [Token(Token = "0x601848B")]
    [Address(RVA = "0x26D9650", Offset = "0x26D9650", VA = "0x26D9650")]
    public static void FinishSizePrefixedLimitedEventNewBadgeDataBuffer(
      FlatBufferBuilder builder,
      Offset<LimitedEventNewBadgeData> offset)
    {
    }
  }
}
