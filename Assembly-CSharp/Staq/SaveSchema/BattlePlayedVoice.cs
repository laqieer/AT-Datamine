// Decompiled with JetBrains decompiler
// Type: staq.SaveSchema.BattlePlayedVoice
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using FlatBuffers;
using Il2CppDummyDll;
using System;

#nullable disable
namespace staq.SaveSchema
{
  [Token(Token = "0x2003C79")]
  public struct BattlePlayedVoice : IFlatbufferObject
  {
    [Token(Token = "0x4010BD8")]
    [FieldOffset(Offset = "0x0")]
    private Table __p;

    [Token(Token = "0x17004DED")]
    public ByteBuffer ByteBuffer
    {
      [Token(Token = "0x6017E62"), Address(RVA = "0x37C0684", Offset = "0x37C0684", VA = "0x37C0684", Slot = "4")] get
      {
        return (ByteBuffer) null;
      }
    }

    [Token(Token = "0x6017E63")]
    [Address(RVA = "0x37C068C", Offset = "0x37C068C", VA = "0x37C068C")]
    public static BattlePlayedVoice GetRootAsBattlePlayedVoice(ByteBuffer _bb)
    {
      return new BattlePlayedVoice();
    }

    [Token(Token = "0x6017E64")]
    [Address(RVA = "0x37C0698", Offset = "0x37C0698", VA = "0x37C0698")]
    public static BattlePlayedVoice GetRootAsBattlePlayedVoice(
      ByteBuffer _bb,
      BattlePlayedVoice obj)
    {
      return new BattlePlayedVoice();
    }

    [Token(Token = "0x6017E65")]
    [Address(RVA = "0x37C06F4", Offset = "0x37C06F4", VA = "0x37C06F4", Slot = "5")]
    public void __init(int _i, ByteBuffer _bb)
    {
    }

    [Token(Token = "0x6017E66")]
    [Address(RVA = "0x37C06DC", Offset = "0x37C06DC", VA = "0x37C06DC")]
    public BattlePlayedVoice __assign(int _i, ByteBuffer _bb) => new BattlePlayedVoice();

    [Token(Token = "0x17004DEE")]
    public int Timing
    {
      [Token(Token = "0x6017E67"), Address(RVA = "0x37C0700", Offset = "0x37C0700", VA = "0x37C0700")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17004DEF")]
    public string VoicePaclId
    {
      [Token(Token = "0x6017E68"), Address(RVA = "0x37C0744", Offset = "0x37C0744", VA = "0x37C0744")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x6017E69")]
    [Address(RVA = "0x37C0780", Offset = "0x37C0780", VA = "0x37C0780")]
    public ArraySegment<byte>? GetVoicePaclIdBytes() => new ArraySegment<byte>?();

    [Token(Token = "0x6017E6A")]
    [Address(RVA = "0x37C07B8", Offset = "0x37C07B8", VA = "0x37C07B8")]
    public byte[] GetVoicePaclIdArray() => (byte[]) null;

    [Token(Token = "0x17004DF0")]
    public string TargetVoicePackId
    {
      [Token(Token = "0x6017E6B"), Address(RVA = "0x37C0804", Offset = "0x37C0804", VA = "0x37C0804")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x6017E6C")]
    [Address(RVA = "0x37C0840", Offset = "0x37C0840", VA = "0x37C0840")]
    public ArraySegment<byte>? GetTargetVoicePackIdBytes() => new ArraySegment<byte>?();

    [Token(Token = "0x6017E6D")]
    [Address(RVA = "0x37C0878", Offset = "0x37C0878", VA = "0x37C0878")]
    public byte[] GetTargetVoicePackIdArray() => (byte[]) null;

    [Token(Token = "0x17004DF1")]
    public int Turn
    {
      [Token(Token = "0x6017E6E"), Address(RVA = "0x37C08C4", Offset = "0x37C08C4", VA = "0x37C08C4")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17004DF2")]
    public int PlayerId
    {
      [Token(Token = "0x6017E6F"), Address(RVA = "0x37C0908", Offset = "0x37C0908", VA = "0x37C0908")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x6017E70")]
    [Address(RVA = "0x37C094C", Offset = "0x37C094C", VA = "0x37C094C")]
    public static Offset<BattlePlayedVoice> CreateBattlePlayedVoice(
      FlatBufferBuilder builder,
      int timing = 0,
      StringOffset voicePaclIdOffset = default (StringOffset),
      StringOffset targetVoicePackIdOffset = default (StringOffset),
      int turn = 0,
      int playerId = 0)
    {
      return new Offset<BattlePlayedVoice>();
    }

    [Token(Token = "0x6017E71")]
    [Address(RVA = "0x37C0AD4", Offset = "0x37C0AD4", VA = "0x37C0AD4")]
    public static void StartBattlePlayedVoice(FlatBufferBuilder builder)
    {
    }

    [Token(Token = "0x6017E72")]
    [Address(RVA = "0x37C0A64", Offset = "0x37C0A64", VA = "0x37C0A64")]
    public static void AddTiming(FlatBufferBuilder builder, int timing)
    {
    }

    [Token(Token = "0x6017E73")]
    [Address(RVA = "0x37C0A44", Offset = "0x37C0A44", VA = "0x37C0A44")]
    public static void AddVoicePaclId(FlatBufferBuilder builder, StringOffset voicePaclIdOffset)
    {
    }

    [Token(Token = "0x6017E74")]
    [Address(RVA = "0x37C0A24", Offset = "0x37C0A24", VA = "0x37C0A24")]
    public static void AddTargetVoicePackId(
      FlatBufferBuilder builder,
      StringOffset targetVoicePackIdOffset)
    {
    }

    [Token(Token = "0x6017E75")]
    [Address(RVA = "0x37C0A04", Offset = "0x37C0A04", VA = "0x37C0A04")]
    public static void AddTurn(FlatBufferBuilder builder, int turn)
    {
    }

    [Token(Token = "0x6017E76")]
    [Address(RVA = "0x37C09E4", Offset = "0x37C09E4", VA = "0x37C09E4")]
    public static void AddPlayerId(FlatBufferBuilder builder, int playerId)
    {
    }

    [Token(Token = "0x6017E77")]
    [Address(RVA = "0x37C0A84", Offset = "0x37C0A84", VA = "0x37C0A84")]
    public static Offset<BattlePlayedVoice> EndBattlePlayedVoice(FlatBufferBuilder builder)
    {
      return new Offset<BattlePlayedVoice>();
    }
  }
}
