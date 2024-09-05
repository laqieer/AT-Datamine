// Decompiled with JetBrains decompiler
// Type: staq.SaveSchema.BadgeFilter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using FlatBuffers;
using Il2CppDummyDll;

#nullable disable
namespace staq.SaveSchema
{
  [Token(Token = "0x2003C67")]
  public struct BadgeFilter : IFlatbufferObject
  {
    [Token(Token = "0x4010BC6")]
    [FieldOffset(Offset = "0x0")]
    private Table __p;

    [Token(Token = "0x17004D62")]
    public ByteBuffer ByteBuffer
    {
      [Token(Token = "0x6017C25"), Address(RVA = "0x37B6EFC", Offset = "0x37B6EFC", VA = "0x37B6EFC", Slot = "4")] get
      {
        return (ByteBuffer) null;
      }
    }

    [Token(Token = "0x6017C26")]
    [Address(RVA = "0x37B6F04", Offset = "0x37B6F04", VA = "0x37B6F04")]
    public static BadgeFilter GetRootAsBadgeFilter(ByteBuffer _bb) => new BadgeFilter();

    [Token(Token = "0x6017C27")]
    [Address(RVA = "0x37B6F10", Offset = "0x37B6F10", VA = "0x37B6F10")]
    public static BadgeFilter GetRootAsBadgeFilter(ByteBuffer _bb, BadgeFilter obj)
    {
      return new BadgeFilter();
    }

    [Token(Token = "0x6017C28")]
    [Address(RVA = "0x37B6F6C", Offset = "0x37B6F6C", VA = "0x37B6F6C")]
    public static bool BadgeFilterBufferHasIdentifier(ByteBuffer _bb) => new bool();

    [Token(Token = "0x6017C29")]
    [Address(RVA = "0x37B6FB8", Offset = "0x37B6FB8", VA = "0x37B6FB8", Slot = "5")]
    public void __init(int _i, ByteBuffer _bb)
    {
    }

    [Token(Token = "0x6017C2A")]
    [Address(RVA = "0x37B6F54", Offset = "0x37B6F54", VA = "0x37B6F54")]
    public BadgeFilter __assign(int _i, ByteBuffer _bb) => new BadgeFilter();

    [Token(Token = "0x17004D63")]
    public bool IsValidStyle
    {
      [Token(Token = "0x6017C2B"), Address(RVA = "0x37B6FC4", Offset = "0x37B6FC4", VA = "0x37B6FC4")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17004D64")]
    public bool IsValidWeapon
    {
      [Token(Token = "0x6017C2C"), Address(RVA = "0x37B700C", Offset = "0x37B700C", VA = "0x37B700C")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17004D65")]
    public bool IsValidAccessory
    {
      [Token(Token = "0x6017C2D"), Address(RVA = "0x37B7054", Offset = "0x37B7054", VA = "0x37B7054")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17004D66")]
    public bool IsValidMindEquipment
    {
      [Token(Token = "0x6017C2E"), Address(RVA = "0x37B709C", Offset = "0x37B709C", VA = "0x37B709C")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x6017C2F")]
    [Address(RVA = "0x37B70E4", Offset = "0x37B70E4", VA = "0x37B70E4")]
    public static Offset<BadgeFilter> CreateBadgeFilter(
      FlatBufferBuilder builder,
      bool is_valid_style = false,
      bool is_valid_weapon = false,
      bool is_valid_accessory = false,
      bool is_valid_mind_equipment = false)
    {
      return new Offset<BadgeFilter>();
    }

    [Token(Token = "0x6017C30")]
    [Address(RVA = "0x37B7234", Offset = "0x37B7234", VA = "0x37B7234")]
    public static void StartBadgeFilter(FlatBufferBuilder builder)
    {
    }

    [Token(Token = "0x6017C31")]
    [Address(RVA = "0x37B71C4", Offset = "0x37B71C4", VA = "0x37B71C4")]
    public static void AddIsValidStyle(FlatBufferBuilder builder, bool isValidStyle)
    {
    }

    [Token(Token = "0x6017C32")]
    [Address(RVA = "0x37B71A4", Offset = "0x37B71A4", VA = "0x37B71A4")]
    public static void AddIsValidWeapon(FlatBufferBuilder builder, bool isValidWeapon)
    {
    }

    [Token(Token = "0x6017C33")]
    [Address(RVA = "0x37B7184", Offset = "0x37B7184", VA = "0x37B7184")]
    public static void AddIsValidAccessory(FlatBufferBuilder builder, bool isValidAccessory)
    {
    }

    [Token(Token = "0x6017C34")]
    [Address(RVA = "0x37B7164", Offset = "0x37B7164", VA = "0x37B7164")]
    public static void AddIsValidMindEquipment(FlatBufferBuilder builder, bool isValidMindEquipment)
    {
    }

    [Token(Token = "0x6017C35")]
    [Address(RVA = "0x37B71E4", Offset = "0x37B71E4", VA = "0x37B71E4")]
    public static Offset<BadgeFilter> EndBadgeFilter(FlatBufferBuilder builder)
    {
      return new Offset<BadgeFilter>();
    }

    [Token(Token = "0x6017C36")]
    [Address(RVA = "0x37B724C", Offset = "0x37B724C", VA = "0x37B724C")]
    public static void FinishBadgeFilterBuffer(
      FlatBufferBuilder builder,
      Offset<BadgeFilter> offset)
    {
    }

    [Token(Token = "0x6017C37")]
    [Address(RVA = "0x37B72A8", Offset = "0x37B72A8", VA = "0x37B72A8")]
    public static void FinishSizePrefixedBadgeFilterBuffer(
      FlatBufferBuilder builder,
      Offset<BadgeFilter> offset)
    {
    }
  }
}
