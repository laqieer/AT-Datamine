// Decompiled with JetBrains decompiler
// Type: staq.SaveSchema.ChallengeGuildRaidData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using FlatBuffers;
using Il2CppDummyDll;

#nullable disable
namespace staq.SaveSchema
{
  [Token(Token = "0x2003C99")]
  public struct ChallengeGuildRaidData : IFlatbufferObject
  {
    [Token(Token = "0x4010BF8")]
    [FieldOffset(Offset = "0x0")]
    private Table __p;

    [Token(Token = "0x17004EDB")]
    public ByteBuffer ByteBuffer
    {
      [Token(Token = "0x60181DE"), Address(RVA = "0x3B21CF4", Offset = "0x3B21CF4", VA = "0x3B21CF4", Slot = "4")] get
      {
        return (ByteBuffer) null;
      }
    }

    [Token(Token = "0x60181DF")]
    [Address(RVA = "0x3B21CFC", Offset = "0x3B21CFC", VA = "0x3B21CFC")]
    public static ChallengeGuildRaidData GetRootAsChallengeGuildRaidData(ByteBuffer _bb)
    {
      return new ChallengeGuildRaidData();
    }

    [Token(Token = "0x60181E0")]
    [Address(RVA = "0x3B21D08", Offset = "0x3B21D08", VA = "0x3B21D08")]
    public static ChallengeGuildRaidData GetRootAsChallengeGuildRaidData(
      ByteBuffer _bb,
      ChallengeGuildRaidData obj)
    {
      return new ChallengeGuildRaidData();
    }

    [Token(Token = "0x60181E1")]
    [Address(RVA = "0x3B21D64", Offset = "0x3B21D64", VA = "0x3B21D64")]
    public static bool ChallengeGuildRaidDataBufferHasIdentifier(ByteBuffer _bb) => new bool();

    [Token(Token = "0x60181E2")]
    [Address(RVA = "0x3B21DB0", Offset = "0x3B21DB0", VA = "0x3B21DB0", Slot = "5")]
    public void __init(int _i, ByteBuffer _bb)
    {
    }

    [Token(Token = "0x60181E3")]
    [Address(RVA = "0x3B21D4C", Offset = "0x3B21D4C", VA = "0x3B21D4C")]
    public ChallengeGuildRaidData __assign(int _i, ByteBuffer _bb) => new ChallengeGuildRaidData();

    [Token(Token = "0x17004EDC")]
    public int RaidId
    {
      [Token(Token = "0x60181E4"), Address(RVA = "0x3B21DBC", Offset = "0x3B21DBC", VA = "0x3B21DBC")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17004EDD")]
    public int Lap
    {
      [Token(Token = "0x60181E5"), Address(RVA = "0x3B21E00", Offset = "0x3B21E00", VA = "0x3B21E00")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17004EDE")]
    public int PositionId
    {
      [Token(Token = "0x60181E6"), Address(RVA = "0x3B21E44", Offset = "0x3B21E44", VA = "0x3B21E44")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17004EDF")]
    public bool IsMock
    {
      [Token(Token = "0x60181E7"), Address(RVA = "0x3B21E88", Offset = "0x3B21E88", VA = "0x3B21E88")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17004EE0")]
    public int MockLap
    {
      [Token(Token = "0x60181E8"), Address(RVA = "0x3B21ED0", Offset = "0x3B21ED0", VA = "0x3B21ED0")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x60181E9")]
    [Address(RVA = "0x3B21F14", Offset = "0x3B21F14", VA = "0x3B21F14")]
    public static Offset<ChallengeGuildRaidData> CreateChallengeGuildRaidData(
      FlatBufferBuilder builder,
      int raid_id = 0,
      int lap = 0,
      int position_id = 0,
      bool is_mock = false,
      int mock_lap = 0)
    {
      return new Offset<ChallengeGuildRaidData>();
    }

    [Token(Token = "0x60181EA")]
    [Address(RVA = "0x3B2209C", Offset = "0x3B2209C", VA = "0x3B2209C")]
    public static void StartChallengeGuildRaidData(FlatBufferBuilder builder)
    {
    }

    [Token(Token = "0x60181EB")]
    [Address(RVA = "0x3B2200C", Offset = "0x3B2200C", VA = "0x3B2200C")]
    public static void AddRaidId(FlatBufferBuilder builder, int raidId)
    {
    }

    [Token(Token = "0x60181EC")]
    [Address(RVA = "0x3B21FEC", Offset = "0x3B21FEC", VA = "0x3B21FEC")]
    public static void AddLap(FlatBufferBuilder builder, int lap)
    {
    }

    [Token(Token = "0x60181ED")]
    [Address(RVA = "0x3B21FCC", Offset = "0x3B21FCC", VA = "0x3B21FCC")]
    public static void AddPositionId(FlatBufferBuilder builder, int positionId)
    {
    }

    [Token(Token = "0x60181EE")]
    [Address(RVA = "0x3B2202C", Offset = "0x3B2202C", VA = "0x3B2202C")]
    public static void AddIsMock(FlatBufferBuilder builder, bool isMock)
    {
    }

    [Token(Token = "0x60181EF")]
    [Address(RVA = "0x3B21FAC", Offset = "0x3B21FAC", VA = "0x3B21FAC")]
    public static void AddMockLap(FlatBufferBuilder builder, int mockLap)
    {
    }

    [Token(Token = "0x60181F0")]
    [Address(RVA = "0x3B2204C", Offset = "0x3B2204C", VA = "0x3B2204C")]
    public static Offset<ChallengeGuildRaidData> EndChallengeGuildRaidData(FlatBufferBuilder builder)
    {
      return new Offset<ChallengeGuildRaidData>();
    }

    [Token(Token = "0x60181F1")]
    [Address(RVA = "0x3B220B4", Offset = "0x3B220B4", VA = "0x3B220B4")]
    public static void FinishChallengeGuildRaidDataBuffer(
      FlatBufferBuilder builder,
      Offset<ChallengeGuildRaidData> offset)
    {
    }

    [Token(Token = "0x60181F2")]
    [Address(RVA = "0x3B22110", Offset = "0x3B22110", VA = "0x3B22110")]
    public static void FinishSizePrefixedChallengeGuildRaidDataBuffer(
      FlatBufferBuilder builder,
      Offset<ChallengeGuildRaidData> offset)
    {
    }
  }
}
