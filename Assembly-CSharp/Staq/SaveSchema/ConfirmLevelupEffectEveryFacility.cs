// Decompiled with JetBrains decompiler
// Type: staq.SaveSchema.ConfirmLevelupEffectEveryFacility
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using FlatBuffers;
using Il2CppDummyDll;

#nullable disable
namespace staq.SaveSchema
{
  [Token(Token = "0x2003CB5")]
  public struct ConfirmLevelupEffectEveryFacility : IFlatbufferObject
  {
    [Token(Token = "0x4010C13")]
    [FieldOffset(Offset = "0x0")]
    private Table __p;

    [Token(Token = "0x17004F4A")]
    public ByteBuffer ByteBuffer
    {
      [Token(Token = "0x60183E1"), Address(RVA = "0x26D7018", Offset = "0x26D7018", VA = "0x26D7018", Slot = "4")] get
      {
        return (ByteBuffer) null;
      }
    }

    [Token(Token = "0x60183E2")]
    [Address(RVA = "0x26D7020", Offset = "0x26D7020", VA = "0x26D7020")]
    public static ConfirmLevelupEffectEveryFacility GetRootAsConfirmLevelupEffectEveryFacility(
      ByteBuffer _bb)
    {
      return new ConfirmLevelupEffectEveryFacility();
    }

    [Token(Token = "0x60183E3")]
    [Address(RVA = "0x26D702C", Offset = "0x26D702C", VA = "0x26D702C")]
    public static ConfirmLevelupEffectEveryFacility GetRootAsConfirmLevelupEffectEveryFacility(
      ByteBuffer _bb,
      ConfirmLevelupEffectEveryFacility obj)
    {
      return new ConfirmLevelupEffectEveryFacility();
    }

    [Token(Token = "0x60183E4")]
    [Address(RVA = "0x26D7070", Offset = "0x26D7070", VA = "0x26D7070", Slot = "5")]
    public void __init(int _i, ByteBuffer _bb)
    {
    }

    [Token(Token = "0x60183E5")]
    [Address(RVA = "0x26D6CF4", Offset = "0x26D6CF4", VA = "0x26D6CF4")]
    public ConfirmLevelupEffectEveryFacility __assign(int _i, ByteBuffer _bb)
    {
      return new ConfirmLevelupEffectEveryFacility();
    }

    [Token(Token = "0x17004F4B")]
    public int FacilitiId
    {
      [Token(Token = "0x60183E6"), Address(RVA = "0x26D707C", Offset = "0x26D707C", VA = "0x26D707C")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17004F4C")]
    public int ConfirmLevel
    {
      [Token(Token = "0x60183E7"), Address(RVA = "0x26D70C0", Offset = "0x26D70C0", VA = "0x26D70C0")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x60183E8")]
    [Address(RVA = "0x26D7104", Offset = "0x26D7104", VA = "0x26D7104")]
    public static Offset<ConfirmLevelupEffectEveryFacility> CreateConfirmLevelupEffectEveryFacility(
      FlatBufferBuilder builder,
      int facilitiId = 0,
      int confirmLevel = 0)
    {
      return new Offset<ConfirmLevelupEffectEveryFacility>();
    }

    [Token(Token = "0x60183E9")]
    [Address(RVA = "0x26D71EC", Offset = "0x26D71EC", VA = "0x26D71EC")]
    public static void StartConfirmLevelupEffectEveryFacility(FlatBufferBuilder builder)
    {
    }

    [Token(Token = "0x60183EA")]
    [Address(RVA = "0x26D717C", Offset = "0x26D717C", VA = "0x26D717C")]
    public static void AddFacilitiId(FlatBufferBuilder builder, int facilitiId)
    {
    }

    [Token(Token = "0x60183EB")]
    [Address(RVA = "0x26D715C", Offset = "0x26D715C", VA = "0x26D715C")]
    public static void AddConfirmLevel(FlatBufferBuilder builder, int confirmLevel)
    {
    }

    [Token(Token = "0x60183EC")]
    [Address(RVA = "0x26D719C", Offset = "0x26D719C", VA = "0x26D719C")]
    public static Offset<ConfirmLevelupEffectEveryFacility> EndConfirmLevelupEffectEveryFacility(
      FlatBufferBuilder builder)
    {
      return new Offset<ConfirmLevelupEffectEveryFacility>();
    }
  }
}
