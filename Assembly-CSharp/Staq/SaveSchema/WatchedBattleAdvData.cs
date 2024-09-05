// Decompiled with JetBrains decompiler
// Type: staq.SaveSchema.WatchedBattleAdvData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using FlatBuffers;
using Il2CppDummyDll;
using System;

#nullable disable
namespace staq.SaveSchema
{
  [Token(Token = "0x2003C7B")]
  public struct WatchedBattleAdvData : IFlatbufferObject
  {
    [Token(Token = "0x4010BDA")]
    [FieldOffset(Offset = "0x0")]
    private Table __p;

    [Token(Token = "0x17004DF6")]
    public ByteBuffer ByteBuffer
    {
      [Token(Token = "0x6017E84"), Address(RVA = "0x37C0CD8", Offset = "0x37C0CD8", VA = "0x37C0CD8", Slot = "4")] get
      {
        return (ByteBuffer) null;
      }
    }

    [Token(Token = "0x6017E85")]
    [Address(RVA = "0x37C0CE0", Offset = "0x37C0CE0", VA = "0x37C0CE0")]
    public static WatchedBattleAdvData GetRootAsWatchedBattleAdvData(ByteBuffer _bb)
    {
      return new WatchedBattleAdvData();
    }

    [Token(Token = "0x6017E86")]
    [Address(RVA = "0x37C0CEC", Offset = "0x37C0CEC", VA = "0x37C0CEC")]
    public static WatchedBattleAdvData GetRootAsWatchedBattleAdvData(
      ByteBuffer _bb,
      WatchedBattleAdvData obj)
    {
      return new WatchedBattleAdvData();
    }

    [Token(Token = "0x6017E87")]
    [Address(RVA = "0x37C0D30", Offset = "0x37C0D30", VA = "0x37C0D30", Slot = "5")]
    public void __init(int _i, ByteBuffer _bb)
    {
    }

    [Token(Token = "0x6017E88")]
    [Address(RVA = "0x37BFC6C", Offset = "0x37BFC6C", VA = "0x37BFC6C")]
    public WatchedBattleAdvData __assign(int _i, ByteBuffer _bb) => new WatchedBattleAdvData();

    [Token(Token = "0x17004DF7")]
    public int BattleAdvId
    {
      [Token(Token = "0x6017E89"), Address(RVA = "0x37C0D3C", Offset = "0x37C0D3C", VA = "0x37C0D3C")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x6017E8A")]
    [Address(RVA = "0x37C0D80", Offset = "0x37C0D80", VA = "0x37C0D80")]
    public int PlayerSelectedIds(int j) => new int();

    [Token(Token = "0x17004DF8")]
    public int PlayerSelectedIdsLength
    {
      [Token(Token = "0x6017E8B"), Address(RVA = "0x37C0DE0", Offset = "0x37C0DE0", VA = "0x37C0DE0")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x6017E8C")]
    [Address(RVA = "0x37C0E14", Offset = "0x37C0E14", VA = "0x37C0E14")]
    public ArraySegment<byte>? GetPlayerSelectedIdsBytes() => new ArraySegment<byte>?();

    [Token(Token = "0x6017E8D")]
    [Address(RVA = "0x37C0E4C", Offset = "0x37C0E4C", VA = "0x37C0E4C")]
    public int[] GetPlayerSelectedIdsArray() => (int[]) null;

    [Token(Token = "0x6017E8E")]
    [Address(RVA = "0x37C0E98", Offset = "0x37C0E98", VA = "0x37C0E98")]
    public int UnlockedOptions(int j) => new int();

    [Token(Token = "0x17004DF9")]
    public int UnlockedOptionsLength
    {
      [Token(Token = "0x6017E8F"), Address(RVA = "0x37C0EF8", Offset = "0x37C0EF8", VA = "0x37C0EF8")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x6017E90")]
    [Address(RVA = "0x37C0F2C", Offset = "0x37C0F2C", VA = "0x37C0F2C")]
    public ArraySegment<byte>? GetUnlockedOptionsBytes() => new ArraySegment<byte>?();

    [Token(Token = "0x6017E91")]
    [Address(RVA = "0x37C0F64", Offset = "0x37C0F64", VA = "0x37C0F64")]
    public int[] GetUnlockedOptionsArray() => (int[]) null;

    [Token(Token = "0x6017E92")]
    [Address(RVA = "0x37C0FB0", Offset = "0x37C0FB0", VA = "0x37C0FB0")]
    public static Offset<WatchedBattleAdvData> CreateWatchedBattleAdvData(
      FlatBufferBuilder builder,
      int battleAdvId = 0,
      VectorOffset playerSelectedIdsOffset = default (VectorOffset),
      VectorOffset unlockedOptionsOffset = default (VectorOffset))
    {
      return new Offset<WatchedBattleAdvData>();
    }

    [Token(Token = "0x6017E93")]
    [Address(RVA = "0x37C10D0", Offset = "0x37C10D0", VA = "0x37C10D0")]
    public static void StartWatchedBattleAdvData(FlatBufferBuilder builder)
    {
    }

    [Token(Token = "0x6017E94")]
    [Address(RVA = "0x37C1060", Offset = "0x37C1060", VA = "0x37C1060")]
    public static void AddBattleAdvId(FlatBufferBuilder builder, int battleAdvId)
    {
    }

    [Token(Token = "0x6017E95")]
    [Address(RVA = "0x37C1040", Offset = "0x37C1040", VA = "0x37C1040")]
    public static void AddPlayerSelectedIds(
      FlatBufferBuilder builder,
      VectorOffset playerSelectedIdsOffset)
    {
    }

    [Token(Token = "0x6017E96")]
    [Address(RVA = "0x37C10E8", Offset = "0x37C10E8", VA = "0x37C10E8")]
    public static VectorOffset CreatePlayerSelectedIdsVector(FlatBufferBuilder builder, int[] data)
    {
      return new VectorOffset();
    }

    [Token(Token = "0x6017E97")]
    [Address(RVA = "0x37C1190", Offset = "0x37C1190", VA = "0x37C1190")]
    public static VectorOffset CreatePlayerSelectedIdsVectorBlock(
      FlatBufferBuilder builder,
      int[] data)
    {
      return new VectorOffset();
    }

    [Token(Token = "0x6017E98")]
    [Address(RVA = "0x37C1218", Offset = "0x37C1218", VA = "0x37C1218")]
    public static void StartPlayerSelectedIdsVector(FlatBufferBuilder builder, int numElems)
    {
    }

    [Token(Token = "0x6017E99")]
    [Address(RVA = "0x37C1020", Offset = "0x37C1020", VA = "0x37C1020")]
    public static void AddUnlockedOptions(
      FlatBufferBuilder builder,
      VectorOffset unlockedOptionsOffset)
    {
    }

    [Token(Token = "0x6017E9A")]
    [Address(RVA = "0x37C1238", Offset = "0x37C1238", VA = "0x37C1238")]
    public static VectorOffset CreateUnlockedOptionsVector(FlatBufferBuilder builder, int[] data)
    {
      return new VectorOffset();
    }

    [Token(Token = "0x6017E9B")]
    [Address(RVA = "0x37C12E0", Offset = "0x37C12E0", VA = "0x37C12E0")]
    public static VectorOffset CreateUnlockedOptionsVectorBlock(
      FlatBufferBuilder builder,
      int[] data)
    {
      return new VectorOffset();
    }

    [Token(Token = "0x6017E9C")]
    [Address(RVA = "0x37C1368", Offset = "0x37C1368", VA = "0x37C1368")]
    public static void StartUnlockedOptionsVector(FlatBufferBuilder builder, int numElems)
    {
    }

    [Token(Token = "0x6017E9D")]
    [Address(RVA = "0x37C1080", Offset = "0x37C1080", VA = "0x37C1080")]
    public static Offset<WatchedBattleAdvData> EndWatchedBattleAdvData(FlatBufferBuilder builder)
    {
      return new Offset<WatchedBattleAdvData>();
    }
  }
}
