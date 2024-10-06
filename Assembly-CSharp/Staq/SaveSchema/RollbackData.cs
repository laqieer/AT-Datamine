// Decompiled with JetBrains decompiler
// Type: staq.SaveSchema.RollbackData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using FlatBuffers;
using Il2CppDummyDll;
using System;

#nullable disable
namespace staq.SaveSchema
{
  [Token(Token = "0x2003C97")]
  public struct RollbackData : IFlatbufferObject
  {
    [Token(Token = "0x4010BF6")]
    [FieldOffset(Offset = "0x0")]
    private Table __p;

    [Token(Token = "0x17004ED2")]
    public ByteBuffer ByteBuffer
    {
      [Token(Token = "0x60181AA"), Address(RVA = "0x3B20EF0", Offset = "0x3B20EF0", VA = "0x3B20EF0", Slot = "4")] get
      {
        return (ByteBuffer) null;
      }
    }

    [Token(Token = "0x60181AB")]
    [Address(RVA = "0x3B20EF8", Offset = "0x3B20EF8", VA = "0x3B20EF8")]
    public static RollbackData GetRootAsRollbackData(ByteBuffer _bb) => new RollbackData();

    [Token(Token = "0x60181AC")]
    [Address(RVA = "0x3B20F04", Offset = "0x3B20F04", VA = "0x3B20F04")]
    public static RollbackData GetRootAsRollbackData(ByteBuffer _bb, RollbackData obj)
    {
      return new RollbackData();
    }

    [Token(Token = "0x60181AD")]
    [Address(RVA = "0x3B20F60", Offset = "0x3B20F60", VA = "0x3B20F60")]
    public static bool RollbackDataBufferHasIdentifier(ByteBuffer _bb) => new bool();

    [Token(Token = "0x60181AE")]
    [Address(RVA = "0x3B20FAC", Offset = "0x3B20FAC", VA = "0x3B20FAC", Slot = "5")]
    public void __init(int _i, ByteBuffer _bb)
    {
    }

    [Token(Token = "0x60181AF")]
    [Address(RVA = "0x3B20F48", Offset = "0x3B20F48", VA = "0x3B20F48")]
    public RollbackData __assign(int _i, ByteBuffer _bb) => new RollbackData();

    [Token(Token = "0x17004ED3")]
    public string BattleUuid
    {
      [Token(Token = "0x60181B0"), Address(RVA = "0x3B20FB8", Offset = "0x3B20FB8", VA = "0x3B20FB8")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x60181B1")]
    [Address(RVA = "0x3B20FF4", Offset = "0x3B20FF4", VA = "0x3B20FF4")]
    public ArraySegment<byte>? GetBattleUuidBytes() => new ArraySegment<byte>?();

    [Token(Token = "0x60181B2")]
    [Address(RVA = "0x3B2102C", Offset = "0x3B2102C", VA = "0x3B2102C")]
    public byte[] GetBattleUuidArray() => (byte[]) null;

    [Token(Token = "0x60181B3")]
    [Address(RVA = "0x3B21078", Offset = "0x3B21078", VA = "0x3B21078")]
    public BoardData? BackupPerTurn(int j) => new BoardData?();

    [Token(Token = "0x17004ED4")]
    public int BackupPerTurnLength
    {
      [Token(Token = "0x60181B4"), Address(RVA = "0x3B2112C", Offset = "0x3B2112C", VA = "0x3B2112C")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x60181B5")]
    [Address(RVA = "0x3B21160", Offset = "0x3B21160", VA = "0x3B21160")]
    public BoardData? BackupPerAction(int j) => new BoardData?();

    [Token(Token = "0x17004ED5")]
    public int BackupPerActionLength
    {
      [Token(Token = "0x60181B6"), Address(RVA = "0x3B21214", Offset = "0x3B21214", VA = "0x3B21214")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17004ED6")]
    public int InitialCount
    {
      [Token(Token = "0x60181B7"), Address(RVA = "0x3B21248", Offset = "0x3B21248", VA = "0x3B21248")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17004ED7")]
    public int Count
    {
      [Token(Token = "0x60181B8"), Address(RVA = "0x3B2128C", Offset = "0x3B2128C", VA = "0x3B2128C")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x60181B9")]
    [Address(RVA = "0x3B212D0", Offset = "0x3B212D0", VA = "0x3B212D0")]
    public static Offset<RollbackData> CreateRollbackData(
      FlatBufferBuilder builder,
      StringOffset battleUuidOffset = default (StringOffset),
      VectorOffset backupPerTurnOffset = default (VectorOffset),
      VectorOffset backupPerActionOffset = default (VectorOffset),
      int initialCount = 0,
      int count = 0)
    {
      return new Offset<RollbackData>();
    }

    [Token(Token = "0x60181BA")]
    [Address(RVA = "0x3B21458", Offset = "0x3B21458", VA = "0x3B21458")]
    public static void StartRollbackData(FlatBufferBuilder builder)
    {
    }

    [Token(Token = "0x60181BB")]
    [Address(RVA = "0x3B213E8", Offset = "0x3B213E8", VA = "0x3B213E8")]
    public static void AddBattleUuid(FlatBufferBuilder builder, StringOffset battleUuidOffset)
    {
    }

    [Token(Token = "0x60181BC")]
    [Address(RVA = "0x3B213C8", Offset = "0x3B213C8", VA = "0x3B213C8")]
    public static void AddBackupPerTurn(FlatBufferBuilder builder, VectorOffset backupPerTurnOffset)
    {
    }

    [Token(Token = "0x60181BD")]
    [Address(RVA = "0x3B21470", Offset = "0x3B21470", VA = "0x3B21470")]
    public static VectorOffset CreateBackupPerTurnVector(
      FlatBufferBuilder builder,
      Offset<BoardData>[] data)
    {
      return new VectorOffset();
    }

    [Token(Token = "0x60181BE")]
    [Address(RVA = "0x3B21518", Offset = "0x3B21518", VA = "0x3B21518")]
    public static VectorOffset CreateBackupPerTurnVectorBlock(
      FlatBufferBuilder builder,
      Offset<BoardData>[] data)
    {
      return new VectorOffset();
    }

    [Token(Token = "0x60181BF")]
    [Address(RVA = "0x3B215A0", Offset = "0x3B215A0", VA = "0x3B215A0")]
    public static void StartBackupPerTurnVector(FlatBufferBuilder builder, int numElems)
    {
    }

    [Token(Token = "0x60181C0")]
    [Address(RVA = "0x3B213A8", Offset = "0x3B213A8", VA = "0x3B213A8")]
    public static void AddBackupPerAction(
      FlatBufferBuilder builder,
      VectorOffset backupPerActionOffset)
    {
    }

    [Token(Token = "0x60181C1")]
    [Address(RVA = "0x3B215C0", Offset = "0x3B215C0", VA = "0x3B215C0")]
    public static VectorOffset CreateBackupPerActionVector(
      FlatBufferBuilder builder,
      Offset<BoardData>[] data)
    {
      return new VectorOffset();
    }

    [Token(Token = "0x60181C2")]
    [Address(RVA = "0x3B21668", Offset = "0x3B21668", VA = "0x3B21668")]
    public static VectorOffset CreateBackupPerActionVectorBlock(
      FlatBufferBuilder builder,
      Offset<BoardData>[] data)
    {
      return new VectorOffset();
    }

    [Token(Token = "0x60181C3")]
    [Address(RVA = "0x3B216F0", Offset = "0x3B216F0", VA = "0x3B216F0")]
    public static void StartBackupPerActionVector(FlatBufferBuilder builder, int numElems)
    {
    }

    [Token(Token = "0x60181C4")]
    [Address(RVA = "0x3B21388", Offset = "0x3B21388", VA = "0x3B21388")]
    public static void AddInitialCount(FlatBufferBuilder builder, int initialCount)
    {
    }

    [Token(Token = "0x60181C5")]
    [Address(RVA = "0x3B21368", Offset = "0x3B21368", VA = "0x3B21368")]
    public static void AddCount(FlatBufferBuilder builder, int count)
    {
    }

    [Token(Token = "0x60181C6")]
    [Address(RVA = "0x3B21408", Offset = "0x3B21408", VA = "0x3B21408")]
    public static Offset<RollbackData> EndRollbackData(FlatBufferBuilder builder)
    {
      return new Offset<RollbackData>();
    }

    [Token(Token = "0x60181C7")]
    [Address(RVA = "0x3B21710", Offset = "0x3B21710", VA = "0x3B21710")]
    public static void FinishRollbackDataBuffer(
      FlatBufferBuilder builder,
      Offset<RollbackData> offset)
    {
    }

    [Token(Token = "0x60181C8")]
    [Address(RVA = "0x3B2176C", Offset = "0x3B2176C", VA = "0x3B2176C")]
    public static void FinishSizePrefixedRollbackDataBuffer(
      FlatBufferBuilder builder,
      Offset<RollbackData> offset)
    {
    }
  }
}
