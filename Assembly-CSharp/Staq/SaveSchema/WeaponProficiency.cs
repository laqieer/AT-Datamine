// Decompiled with JetBrains decompiler
// Type: staq.SaveSchema.WeaponProficiency
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using FlatBuffers;
using Il2CppDummyDll;

#nullable disable
namespace staq.SaveSchema
{
  [Token(Token = "0x2003C95")]
  public struct WeaponProficiency : IFlatbufferObject
  {
    [Token(Token = "0x4010BF4")]
    [FieldOffset(Offset = "0x0")]
    private Table __p;

    [Token(Token = "0x17004ECC")]
    public ByteBuffer ByteBuffer
    {
      [Token(Token = "0x6018192"), Address(RVA = "0x3B20B18", Offset = "0x3B20B18", VA = "0x3B20B18", Slot = "4")] get
      {
        return (ByteBuffer) null;
      }
    }

    [Token(Token = "0x6018193")]
    [Address(RVA = "0x3B20B20", Offset = "0x3B20B20", VA = "0x3B20B20")]
    public static WeaponProficiency GetRootAsWeaponProficiency(ByteBuffer _bb)
    {
      return new WeaponProficiency();
    }

    [Token(Token = "0x6018194")]
    [Address(RVA = "0x3B20B2C", Offset = "0x3B20B2C", VA = "0x3B20B2C")]
    public static WeaponProficiency GetRootAsWeaponProficiency(
      ByteBuffer _bb,
      WeaponProficiency obj)
    {
      return new WeaponProficiency();
    }

    [Token(Token = "0x6018195")]
    [Address(RVA = "0x3B20B70", Offset = "0x3B20B70", VA = "0x3B20B70", Slot = "5")]
    public void __init(int _i, ByteBuffer _bb)
    {
    }

    [Token(Token = "0x6018196")]
    [Address(RVA = "0x3B1D948", Offset = "0x3B1D948", VA = "0x3B1D948")]
    public WeaponProficiency __assign(int _i, ByteBuffer _bb) => new WeaponProficiency();

    [Token(Token = "0x17004ECD")]
    public int Weapontypeenum
    {
      [Token(Token = "0x6018197"), Address(RVA = "0x3B20B7C", Offset = "0x3B20B7C", VA = "0x3B20B7C")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17004ECE")]
    public int Count
    {
      [Token(Token = "0x6018198"), Address(RVA = "0x3B20BC0", Offset = "0x3B20BC0", VA = "0x3B20BC0")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x6018199")]
    [Address(RVA = "0x3B20C04", Offset = "0x3B20C04", VA = "0x3B20C04")]
    public static Offset<WeaponProficiency> CreateWeaponProficiency(
      FlatBufferBuilder builder,
      int weapontypeenum = 0,
      int count = 0)
    {
      return new Offset<WeaponProficiency>();
    }

    [Token(Token = "0x601819A")]
    [Address(RVA = "0x3B20CEC", Offset = "0x3B20CEC", VA = "0x3B20CEC")]
    public static void StartWeaponProficiency(FlatBufferBuilder builder)
    {
    }

    [Token(Token = "0x601819B")]
    [Address(RVA = "0x3B20C7C", Offset = "0x3B20C7C", VA = "0x3B20C7C")]
    public static void AddWeapontypeenum(FlatBufferBuilder builder, int weapontypeenum)
    {
    }

    [Token(Token = "0x601819C")]
    [Address(RVA = "0x3B20C5C", Offset = "0x3B20C5C", VA = "0x3B20C5C")]
    public static void AddCount(FlatBufferBuilder builder, int count)
    {
    }

    [Token(Token = "0x601819D")]
    [Address(RVA = "0x3B20C9C", Offset = "0x3B20C9C", VA = "0x3B20C9C")]
    public static Offset<WeaponProficiency> EndWeaponProficiency(FlatBufferBuilder builder)
    {
      return new Offset<WeaponProficiency>();
    }
  }
}
