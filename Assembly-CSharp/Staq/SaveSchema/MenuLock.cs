// Decompiled with JetBrains decompiler
// Type: staq.SaveSchema.MenuLock
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using FlatBuffers;
using Il2CppDummyDll;

#nullable disable
namespace staq.SaveSchema
{
  [Token(Token = "0x2003CC3")]
  public struct MenuLock : IFlatbufferObject
  {
    [Token(Token = "0x4010C21")]
    [FieldOffset(Offset = "0x0")]
    private Table __p;

    [Token(Token = "0x17004F6F")]
    public ByteBuffer ByteBuffer
    {
      [Token(Token = "0x60184BC"), Address(RVA = "0x26DA13C", Offset = "0x26DA13C", VA = "0x26DA13C", Slot = "4")] get
      {
        return (ByteBuffer) null;
      }
    }

    [Token(Token = "0x60184BD")]
    [Address(RVA = "0x26DA144", Offset = "0x26DA144", VA = "0x26DA144")]
    public static MenuLock GetRootAsMenuLock(ByteBuffer _bb) => new MenuLock();

    [Token(Token = "0x60184BE")]
    [Address(RVA = "0x26DA150", Offset = "0x26DA150", VA = "0x26DA150")]
    public static MenuLock GetRootAsMenuLock(ByteBuffer _bb, MenuLock obj) => new MenuLock();

    [Token(Token = "0x60184BF")]
    [Address(RVA = "0x26DA1AC", Offset = "0x26DA1AC", VA = "0x26DA1AC")]
    public static bool MenuLockBufferHasIdentifier(ByteBuffer _bb) => new bool();

    [Token(Token = "0x60184C0")]
    [Address(RVA = "0x26DA1F8", Offset = "0x26DA1F8", VA = "0x26DA1F8", Slot = "5")]
    public void __init(int _i, ByteBuffer _bb)
    {
    }

    [Token(Token = "0x60184C1")]
    [Address(RVA = "0x26DA194", Offset = "0x26DA194", VA = "0x26DA194")]
    public MenuLock __assign(int _i, ByteBuffer _bb) => new MenuLock();

    [Token(Token = "0x17004F70")]
    public bool IsEventLock
    {
      [Token(Token = "0x60184C2"), Address(RVA = "0x26DA204", Offset = "0x26DA204", VA = "0x26DA204")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17004F71")]
    public bool IsGuildLock
    {
      [Token(Token = "0x60184C3"), Address(RVA = "0x26DA254", Offset = "0x26DA254", VA = "0x26DA254")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17004F72")]
    public bool IsArenaLock
    {
      [Token(Token = "0x60184C4"), Address(RVA = "0x26DA2A4", Offset = "0x26DA2A4", VA = "0x26DA2A4")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17004F73")]
    public bool IsStoryChartLock
    {
      [Token(Token = "0x60184C5"), Address(RVA = "0x26DA2F4", Offset = "0x26DA2F4", VA = "0x26DA2F4")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17004F74")]
    public bool IsStoryShopLock
    {
      [Token(Token = "0x60184C6"), Address(RVA = "0x26DA344", Offset = "0x26DA344", VA = "0x26DA344")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17004F75")]
    public bool IsMainLock
    {
      [Token(Token = "0x60184C7"), Address(RVA = "0x26DA394", Offset = "0x26DA394", VA = "0x26DA394")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17004F76")]
    public bool IsMain2Lock
    {
      [Token(Token = "0x60184C8"), Address(RVA = "0x26DA3E4", Offset = "0x26DA3E4", VA = "0x26DA3E4")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x60184C9")]
    [Address(RVA = "0x26DA434", Offset = "0x26DA434", VA = "0x26DA434")]
    public static Offset<MenuLock> CreateMenuLock(
      FlatBufferBuilder builder,
      bool is_event_lock = true,
      bool is_guild_lock = true,
      bool is_arena_lock = true,
      bool is_story_chart_lock = true,
      bool is_story_shop_lock = true,
      bool is_main_lock = true,
      bool is_main2_lock = true)
    {
      return new Offset<MenuLock>();
    }

    [Token(Token = "0x60184CA")]
    [Address(RVA = "0x26DA624", Offset = "0x26DA624", VA = "0x26DA624")]
    public static void StartMenuLock(FlatBufferBuilder builder)
    {
    }

    [Token(Token = "0x60184CB")]
    [Address(RVA = "0x26DA5B4", Offset = "0x26DA5B4", VA = "0x26DA5B4")]
    public static void AddIsEventLock(FlatBufferBuilder builder, bool isEventLock)
    {
    }

    [Token(Token = "0x60184CC")]
    [Address(RVA = "0x26DA594", Offset = "0x26DA594", VA = "0x26DA594")]
    public static void AddIsGuildLock(FlatBufferBuilder builder, bool isGuildLock)
    {
    }

    [Token(Token = "0x60184CD")]
    [Address(RVA = "0x26DA574", Offset = "0x26DA574", VA = "0x26DA574")]
    public static void AddIsArenaLock(FlatBufferBuilder builder, bool isArenaLock)
    {
    }

    [Token(Token = "0x60184CE")]
    [Address(RVA = "0x26DA554", Offset = "0x26DA554", VA = "0x26DA554")]
    public static void AddIsStoryChartLock(FlatBufferBuilder builder, bool isStoryChartLock)
    {
    }

    [Token(Token = "0x60184CF")]
    [Address(RVA = "0x26DA534", Offset = "0x26DA534", VA = "0x26DA534")]
    public static void AddIsStoryShopLock(FlatBufferBuilder builder, bool isStoryShopLock)
    {
    }

    [Token(Token = "0x60184D0")]
    [Address(RVA = "0x26DA514", Offset = "0x26DA514", VA = "0x26DA514")]
    public static void AddIsMainLock(FlatBufferBuilder builder, bool isMainLock)
    {
    }

    [Token(Token = "0x60184D1")]
    [Address(RVA = "0x26DA4F4", Offset = "0x26DA4F4", VA = "0x26DA4F4")]
    public static void AddIsMain2Lock(FlatBufferBuilder builder, bool isMain2Lock)
    {
    }

    [Token(Token = "0x60184D2")]
    [Address(RVA = "0x26DA5D4", Offset = "0x26DA5D4", VA = "0x26DA5D4")]
    public static Offset<MenuLock> EndMenuLock(FlatBufferBuilder builder) => new Offset<MenuLock>();

    [Token(Token = "0x60184D3")]
    [Address(RVA = "0x26DA63C", Offset = "0x26DA63C", VA = "0x26DA63C")]
    public static void FinishMenuLockBuffer(FlatBufferBuilder builder, Offset<MenuLock> offset)
    {
    }

    [Token(Token = "0x60184D4")]
    [Address(RVA = "0x26DA698", Offset = "0x26DA698", VA = "0x26DA698")]
    public static void FinishSizePrefixedMenuLockBuffer(
      FlatBufferBuilder builder,
      Offset<MenuLock> offset)
    {
    }
  }
}
