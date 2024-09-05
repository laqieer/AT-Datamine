// Decompiled with JetBrains decompiler
// Type: staq.SaveSchema.UnitLevelReached
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using FlatBuffers;
using Il2CppDummyDll;

#nullable disable
namespace staq.SaveSchema
{
  [Token(Token = "0x2003C96")]
  public struct UnitLevelReached : IFlatbufferObject
  {
    [Token(Token = "0x4010BF5")]
    [FieldOffset(Offset = "0x0")]
    private Table __p;

    [Token(Token = "0x17004ECF")]
    public ByteBuffer ByteBuffer
    {
      [Token(Token = "0x601819E"), Address(RVA = "0x3B20D04", Offset = "0x3B20D04", VA = "0x3B20D04", Slot = "4")] get
      {
        return (ByteBuffer) null;
      }
    }

    [Token(Token = "0x601819F")]
    [Address(RVA = "0x3B20D0C", Offset = "0x3B20D0C", VA = "0x3B20D0C")]
    public static UnitLevelReached GetRootAsUnitLevelReached(ByteBuffer _bb)
    {
      return new UnitLevelReached();
    }

    [Token(Token = "0x60181A0")]
    [Address(RVA = "0x3B20D18", Offset = "0x3B20D18", VA = "0x3B20D18")]
    public static UnitLevelReached GetRootAsUnitLevelReached(ByteBuffer _bb, UnitLevelReached obj)
    {
      return new UnitLevelReached();
    }

    [Token(Token = "0x60181A1")]
    [Address(RVA = "0x3B20D5C", Offset = "0x3B20D5C", VA = "0x3B20D5C", Slot = "5")]
    public void __init(int _i, ByteBuffer _bb)
    {
    }

    [Token(Token = "0x60181A2")]
    [Address(RVA = "0x3B18454", Offset = "0x3B18454", VA = "0x3B18454")]
    public UnitLevelReached __assign(int _i, ByteBuffer _bb) => new UnitLevelReached();

    [Token(Token = "0x17004ED0")]
    public int Unit
    {
      [Token(Token = "0x60181A3"), Address(RVA = "0x3B20D68", Offset = "0x3B20D68", VA = "0x3B20D68")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17004ED1")]
    public int Level
    {
      [Token(Token = "0x60181A4"), Address(RVA = "0x3B20DAC", Offset = "0x3B20DAC", VA = "0x3B20DAC")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x60181A5")]
    [Address(RVA = "0x3B20DF0", Offset = "0x3B20DF0", VA = "0x3B20DF0")]
    public static Offset<UnitLevelReached> CreateUnitLevelReached(
      FlatBufferBuilder builder,
      int unit = 0,
      int level = 0)
    {
      return new Offset<UnitLevelReached>();
    }

    [Token(Token = "0x60181A6")]
    [Address(RVA = "0x3B20ED8", Offset = "0x3B20ED8", VA = "0x3B20ED8")]
    public static void StartUnitLevelReached(FlatBufferBuilder builder)
    {
    }

    [Token(Token = "0x60181A7")]
    [Address(RVA = "0x3B20E68", Offset = "0x3B20E68", VA = "0x3B20E68")]
    public static void AddUnit(FlatBufferBuilder builder, int unit)
    {
    }

    [Token(Token = "0x60181A8")]
    [Address(RVA = "0x3B20E48", Offset = "0x3B20E48", VA = "0x3B20E48")]
    public static void AddLevel(FlatBufferBuilder builder, int level)
    {
    }

    [Token(Token = "0x60181A9")]
    [Address(RVA = "0x3B20E88", Offset = "0x3B20E88", VA = "0x3B20E88")]
    public static Offset<UnitLevelReached> EndUnitLevelReached(FlatBufferBuilder builder)
    {
      return new Offset<UnitLevelReached>();
    }
  }
}
