// Decompiled with JetBrains decompiler
// Type: staq.SaveSchema.BattleLogDataList
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using FlatBuffers;
using Il2CppDummyDll;
using System;

#nullable disable
namespace staq.SaveSchema
{
  [Token(Token = "0x2003C75")]
  public struct BattleLogDataList : IFlatbufferObject
  {
    [Token(Token = "0x4010BD4")]
    [FieldOffset(Offset = "0x0")]
    private Table __p;

    [Token(Token = "0x17004DD9")]
    public ByteBuffer ByteBuffer
    {
      [Token(Token = "0x6017E03"), Address(RVA = "0x37BED70", Offset = "0x37BED70", VA = "0x37BED70", Slot = "4")] get
      {
        return (ByteBuffer) null;
      }
    }

    [Token(Token = "0x6017E04")]
    [Address(RVA = "0x37BED78", Offset = "0x37BED78", VA = "0x37BED78")]
    public static BattleLogDataList GetRootAsBattleLogDataList(ByteBuffer _bb)
    {
      return new BattleLogDataList();
    }

    [Token(Token = "0x6017E05")]
    [Address(RVA = "0x37BED84", Offset = "0x37BED84", VA = "0x37BED84")]
    public static BattleLogDataList GetRootAsBattleLogDataList(
      ByteBuffer _bb,
      BattleLogDataList obj)
    {
      return new BattleLogDataList();
    }

    [Token(Token = "0x6017E06")]
    [Address(RVA = "0x37BEDE0", Offset = "0x37BEDE0", VA = "0x37BEDE0")]
    public static bool BattleLogDataListBufferHasIdentifier(ByteBuffer _bb) => new bool();

    [Token(Token = "0x6017E07")]
    [Address(RVA = "0x37BEE2C", Offset = "0x37BEE2C", VA = "0x37BEE2C", Slot = "5")]
    public void __init(int _i, ByteBuffer _bb)
    {
    }

    [Token(Token = "0x6017E08")]
    [Address(RVA = "0x37BEDC8", Offset = "0x37BEDC8", VA = "0x37BEDC8")]
    public BattleLogDataList __assign(int _i, ByteBuffer _bb) => new BattleLogDataList();

    [Token(Token = "0x17004DDA")]
    public string BattleUuid
    {
      [Token(Token = "0x6017E09"), Address(RVA = "0x37BEE38", Offset = "0x37BEE38", VA = "0x37BEE38")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x6017E0A")]
    [Address(RVA = "0x37BEE74", Offset = "0x37BEE74", VA = "0x37BEE74")]
    public ArraySegment<byte>? GetBattleUuidBytes() => new ArraySegment<byte>?();

    [Token(Token = "0x6017E0B")]
    [Address(RVA = "0x37BEEAC", Offset = "0x37BEEAC", VA = "0x37BEEAC")]
    public byte[] GetBattleUuidArray() => (byte[]) null;

    [Token(Token = "0x6017E0C")]
    [Address(RVA = "0x37BEEF8", Offset = "0x37BEEF8", VA = "0x37BEEF8")]
    public BattleLogData? LogDataList(int j) => new BattleLogData?();

    [Token(Token = "0x17004DDB")]
    public int LogDataListLength
    {
      [Token(Token = "0x6017E0D"), Address(RVA = "0x37BEFC4", Offset = "0x37BEFC4", VA = "0x37BEFC4")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x6017E0E")]
    [Address(RVA = "0x37BEFF8", Offset = "0x37BEFF8", VA = "0x37BEFF8")]
    public static Offset<BattleLogDataList> CreateBattleLogDataList(
      FlatBufferBuilder builder,
      StringOffset battleUuidOffset = default (StringOffset),
      VectorOffset logDataListOffset = default (VectorOffset))
    {
      return new Offset<BattleLogDataList>();
    }

    [Token(Token = "0x6017E0F")]
    [Address(RVA = "0x37BF0E0", Offset = "0x37BF0E0", VA = "0x37BF0E0")]
    public static void StartBattleLogDataList(FlatBufferBuilder builder)
    {
    }

    [Token(Token = "0x6017E10")]
    [Address(RVA = "0x37BF070", Offset = "0x37BF070", VA = "0x37BF070")]
    public static void AddBattleUuid(FlatBufferBuilder builder, StringOffset battleUuidOffset)
    {
    }

    [Token(Token = "0x6017E11")]
    [Address(RVA = "0x37BF050", Offset = "0x37BF050", VA = "0x37BF050")]
    public static void AddLogDataList(FlatBufferBuilder builder, VectorOffset logDataListOffset)
    {
    }

    [Token(Token = "0x6017E12")]
    [Address(RVA = "0x37BF0F8", Offset = "0x37BF0F8", VA = "0x37BF0F8")]
    public static VectorOffset CreateLogDataListVector(
      FlatBufferBuilder builder,
      Offset<BattleLogData>[] data)
    {
      return new VectorOffset();
    }

    [Token(Token = "0x6017E13")]
    [Address(RVA = "0x37BF1A0", Offset = "0x37BF1A0", VA = "0x37BF1A0")]
    public static VectorOffset CreateLogDataListVectorBlock(
      FlatBufferBuilder builder,
      Offset<BattleLogData>[] data)
    {
      return new VectorOffset();
    }

    [Token(Token = "0x6017E14")]
    [Address(RVA = "0x37BF228", Offset = "0x37BF228", VA = "0x37BF228")]
    public static void StartLogDataListVector(FlatBufferBuilder builder, int numElems)
    {
    }

    [Token(Token = "0x6017E15")]
    [Address(RVA = "0x37BF090", Offset = "0x37BF090", VA = "0x37BF090")]
    public static Offset<BattleLogDataList> EndBattleLogDataList(FlatBufferBuilder builder)
    {
      return new Offset<BattleLogDataList>();
    }

    [Token(Token = "0x6017E16")]
    [Address(RVA = "0x37BF248", Offset = "0x37BF248", VA = "0x37BF248")]
    public static void FinishBattleLogDataListBuffer(
      FlatBufferBuilder builder,
      Offset<BattleLogDataList> offset)
    {
    }

    [Token(Token = "0x6017E17")]
    [Address(RVA = "0x37BF2A4", Offset = "0x37BF2A4", VA = "0x37BF2A4")]
    public static void FinishSizePrefixedBattleLogDataListBuffer(
      FlatBufferBuilder builder,
      Offset<BattleLogDataList> offset)
    {
    }
  }
}
