// Decompiled with JetBrains decompiler
// Type: staq.SaveSchema.EventTop
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using FlatBuffers;
using Il2CppDummyDll;

#nullable disable
namespace staq.SaveSchema
{
  [Token(Token = "0x2003CA5")]
  public struct EventTop : IFlatbufferObject
  {
    [Token(Token = "0x4010C04")]
    [FieldOffset(Offset = "0x0")]
    private Table __p;

    [Token(Token = "0x17004F1B")]
    public ByteBuffer ByteBuffer
    {
      [Token(Token = "0x60182E0"), Address(RVA = "0x26D3418", Offset = "0x26D3418", VA = "0x26D3418", Slot = "4")] get
      {
        return (ByteBuffer) null;
      }
    }

    [Token(Token = "0x60182E1")]
    [Address(RVA = "0x26D3420", Offset = "0x26D3420", VA = "0x26D3420")]
    public static EventTop GetRootAsEventTop(ByteBuffer _bb) => new EventTop();

    [Token(Token = "0x60182E2")]
    [Address(RVA = "0x26D342C", Offset = "0x26D342C", VA = "0x26D342C")]
    public static EventTop GetRootAsEventTop(ByteBuffer _bb, EventTop obj) => new EventTop();

    [Token(Token = "0x60182E3")]
    [Address(RVA = "0x26D3488", Offset = "0x26D3488", VA = "0x26D3488", Slot = "5")]
    public void __init(int _i, ByteBuffer _bb)
    {
    }

    [Token(Token = "0x60182E4")]
    [Address(RVA = "0x26D3470", Offset = "0x26D3470", VA = "0x26D3470")]
    public EventTop __assign(int _i, ByteBuffer _bb) => new EventTop();

    [Token(Token = "0x17004F1C")]
    public int EventId
    {
      [Token(Token = "0x60182E5"), Address(RVA = "0x26D3494", Offset = "0x26D3494", VA = "0x26D3494")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17004F1D")]
    public bool IsOpenFreeBattle
    {
      [Token(Token = "0x60182E6"), Address(RVA = "0x26D34D8", Offset = "0x26D34D8", VA = "0x26D34D8")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17004F1E")]
    public bool IsOpenSpecialBattle
    {
      [Token(Token = "0x60182E7"), Address(RVA = "0x26D3520", Offset = "0x26D3520", VA = "0x26D3520")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17004F1F")]
    public bool IsOpenScoreChallenge
    {
      [Token(Token = "0x60182E8"), Address(RVA = "0x26D3568", Offset = "0x26D3568", VA = "0x26D3568")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x60182E9")]
    [Address(RVA = "0x26D35B0", Offset = "0x26D35B0", VA = "0x26D35B0")]
    public static Offset<EventTop> CreateEventTop(
      FlatBufferBuilder builder,
      int eventId = 0,
      bool isOpenFreeBattle = false,
      bool isOpenSpecialBattle = false,
      bool isOpenScoreChallenge = false)
    {
      return new Offset<EventTop>();
    }

    [Token(Token = "0x60182EA")]
    [Address(RVA = "0x26D3700", Offset = "0x26D3700", VA = "0x26D3700")]
    public static void StartEventTop(FlatBufferBuilder builder)
    {
    }

    [Token(Token = "0x60182EB")]
    [Address(RVA = "0x26D3630", Offset = "0x26D3630", VA = "0x26D3630")]
    public static void AddEventId(FlatBufferBuilder builder, int eventId)
    {
    }

    [Token(Token = "0x60182EC")]
    [Address(RVA = "0x26D3690", Offset = "0x26D3690", VA = "0x26D3690")]
    public static void AddIsOpenFreeBattle(FlatBufferBuilder builder, bool isOpenFreeBattle)
    {
    }

    [Token(Token = "0x60182ED")]
    [Address(RVA = "0x26D3670", Offset = "0x26D3670", VA = "0x26D3670")]
    public static void AddIsOpenSpecialBattle(FlatBufferBuilder builder, bool isOpenSpecialBattle)
    {
    }

    [Token(Token = "0x60182EE")]
    [Address(RVA = "0x26D3650", Offset = "0x26D3650", VA = "0x26D3650")]
    public static void AddIsOpenScoreChallenge(FlatBufferBuilder builder, bool isOpenScoreChallenge)
    {
    }

    [Token(Token = "0x60182EF")]
    [Address(RVA = "0x26D36B0", Offset = "0x26D36B0", VA = "0x26D36B0")]
    public static Offset<EventTop> EndEventTop(FlatBufferBuilder builder) => new Offset<EventTop>();
  }
}
