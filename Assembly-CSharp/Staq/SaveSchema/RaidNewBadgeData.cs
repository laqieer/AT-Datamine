// Decompiled with JetBrains decompiler
// Type: staq.SaveSchema.RaidNewBadgeData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using FlatBuffers;
using Il2CppDummyDll;

#nullable disable
namespace staq.SaveSchema
{
  [Token(Token = "0x2003CB6")]
  public struct RaidNewBadgeData : IFlatbufferObject
  {
    [Token(Token = "0x4010C14")]
    [FieldOffset(Offset = "0x0")]
    private Table __p;

    [Token(Token = "0x17004F4D")]
    public ByteBuffer ByteBuffer
    {
      [Token(Token = "0x60183ED"), Address(RVA = "0x26D7204", Offset = "0x26D7204", VA = "0x26D7204", Slot = "4")] get
      {
        return (ByteBuffer) null;
      }
    }

    [Token(Token = "0x60183EE")]
    [Address(RVA = "0x26D720C", Offset = "0x26D720C", VA = "0x26D720C")]
    public static RaidNewBadgeData GetRootAsRaidNewBadgeData(ByteBuffer _bb)
    {
      return new RaidNewBadgeData();
    }

    [Token(Token = "0x60183EF")]
    [Address(RVA = "0x26D7218", Offset = "0x26D7218", VA = "0x26D7218")]
    public static RaidNewBadgeData GetRootAsRaidNewBadgeData(ByteBuffer _bb, RaidNewBadgeData obj)
    {
      return new RaidNewBadgeData();
    }

    [Token(Token = "0x60183F0")]
    [Address(RVA = "0x26D7274", Offset = "0x26D7274", VA = "0x26D7274", Slot = "5")]
    public void __init(int _i, ByteBuffer _bb)
    {
    }

    [Token(Token = "0x60183F1")]
    [Address(RVA = "0x26D725C", Offset = "0x26D725C", VA = "0x26D725C")]
    public RaidNewBadgeData __assign(int _i, ByteBuffer _bb) => new RaidNewBadgeData();

    [Token(Token = "0x17004F4E")]
    public int RaidId
    {
      [Token(Token = "0x60183F2"), Address(RVA = "0x26D7280", Offset = "0x26D7280", VA = "0x26D7280")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17004F4F")]
    public bool IsOpen
    {
      [Token(Token = "0x60183F3"), Address(RVA = "0x26D72C4", Offset = "0x26D72C4", VA = "0x26D72C4")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17004F50")]
    public bool IsHeld
    {
      [Token(Token = "0x60183F4"), Address(RVA = "0x26D730C", Offset = "0x26D730C", VA = "0x26D730C")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x60183F5")]
    [Address(RVA = "0x26D7354", Offset = "0x26D7354", VA = "0x26D7354")]
    public static Offset<RaidNewBadgeData> CreateRaidNewBadgeData(
      FlatBufferBuilder builder,
      int raid_id = 0,
      bool is_open = false,
      bool is_held = false)
    {
      return new Offset<RaidNewBadgeData>();
    }

    [Token(Token = "0x60183F6")]
    [Address(RVA = "0x26D7474", Offset = "0x26D7474", VA = "0x26D7474")]
    public static void StartRaidNewBadgeData(FlatBufferBuilder builder)
    {
    }

    [Token(Token = "0x60183F7")]
    [Address(RVA = "0x26D73C4", Offset = "0x26D73C4", VA = "0x26D73C4")]
    public static void AddRaidId(FlatBufferBuilder builder, int raidId)
    {
    }

    [Token(Token = "0x60183F8")]
    [Address(RVA = "0x26D7404", Offset = "0x26D7404", VA = "0x26D7404")]
    public static void AddIsOpen(FlatBufferBuilder builder, bool isOpen)
    {
    }

    [Token(Token = "0x60183F9")]
    [Address(RVA = "0x26D73E4", Offset = "0x26D73E4", VA = "0x26D73E4")]
    public static void AddIsHeld(FlatBufferBuilder builder, bool isHeld)
    {
    }

    [Token(Token = "0x60183FA")]
    [Address(RVA = "0x26D7424", Offset = "0x26D7424", VA = "0x26D7424")]
    public static Offset<RaidNewBadgeData> EndRaidNewBadgeData(FlatBufferBuilder builder)
    {
      return new Offset<RaidNewBadgeData>();
    }
  }
}
