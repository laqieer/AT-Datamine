// Decompiled with JetBrains decompiler
// Type: staq.SaveSchema.EquipmentOption
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using FlatBuffers;
using Il2CppDummyDll;

#nullable disable
namespace staq.SaveSchema
{
  [Token(Token = "0x2003C6E")]
  public struct EquipmentOption : IFlatbufferObject
  {
    [Token(Token = "0x4010BCD")]
    [FieldOffset(Offset = "0x0")]
    private Table __p;

    [Token(Token = "0x17004DA8")]
    public ByteBuffer ByteBuffer
    {
      [Token(Token = "0x6017D59"), Address(RVA = "0x37BC830", Offset = "0x37BC830", VA = "0x37BC830", Slot = "4")] get
      {
        return (ByteBuffer) null;
      }
    }

    [Token(Token = "0x6017D5A")]
    [Address(RVA = "0x37BC838", Offset = "0x37BC838", VA = "0x37BC838")]
    public static EquipmentOption GetRootAsEquipmentOption(ByteBuffer _bb) => new EquipmentOption();

    [Token(Token = "0x6017D5B")]
    [Address(RVA = "0x37BC844", Offset = "0x37BC844", VA = "0x37BC844")]
    public static EquipmentOption GetRootAsEquipmentOption(ByteBuffer _bb, EquipmentOption obj)
    {
      return new EquipmentOption();
    }

    [Token(Token = "0x6017D5C")]
    [Address(RVA = "0x37BC888", Offset = "0x37BC888", VA = "0x37BC888", Slot = "5")]
    public void __init(int _i, ByteBuffer _bb)
    {
    }

    [Token(Token = "0x6017D5D")]
    [Address(RVA = "0x37BC240", Offset = "0x37BC240", VA = "0x37BC240")]
    public EquipmentOption __assign(int _i, ByteBuffer _bb) => new EquipmentOption();

    [Token(Token = "0x17004DA9")]
    public int Slot
    {
      [Token(Token = "0x6017D5E"), Address(RVA = "0x37BC894", Offset = "0x37BC894", VA = "0x37BC894")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17004DAA")]
    public int EffectId
    {
      [Token(Token = "0x6017D5F"), Address(RVA = "0x37BC8D8", Offset = "0x37BC8D8", VA = "0x37BC8D8")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17004DAB")]
    public float Value
    {
      [Token(Token = "0x6017D60"), Address(RVA = "0x37BC91C", Offset = "0x37BC91C", VA = "0x37BC91C")] get
      {
        return new float();
      }
    }

    [Token(Token = "0x6017D61")]
    [Address(RVA = "0x37BC964", Offset = "0x37BC964", VA = "0x37BC964")]
    public static Offset<EquipmentOption> CreateEquipmentOption(
      FlatBufferBuilder builder,
      int slot = 0,
      int effectId = 0,
      float value = 0.0f)
    {
      return new Offset<EquipmentOption>();
    }

    [Token(Token = "0x6017D62")]
    [Address(RVA = "0x37BCA80", Offset = "0x37BCA80", VA = "0x37BCA80")]
    public static void StartEquipmentOption(FlatBufferBuilder builder)
    {
    }

    [Token(Token = "0x6017D63")]
    [Address(RVA = "0x37BCA10", Offset = "0x37BCA10", VA = "0x37BCA10")]
    public static void AddSlot(FlatBufferBuilder builder, int slot)
    {
    }

    [Token(Token = "0x6017D64")]
    [Address(RVA = "0x37BC9F0", Offset = "0x37BC9F0", VA = "0x37BC9F0")]
    public static void AddEffectId(FlatBufferBuilder builder, int effectId)
    {
    }

    [Token(Token = "0x6017D65")]
    [Address(RVA = "0x37BC9D4", Offset = "0x37BC9D4", VA = "0x37BC9D4")]
    public static void AddValue(FlatBufferBuilder builder, float value)
    {
    }

    [Token(Token = "0x6017D66")]
    [Address(RVA = "0x37BCA30", Offset = "0x37BCA30", VA = "0x37BCA30")]
    public static Offset<EquipmentOption> EndEquipmentOption(FlatBufferBuilder builder)
    {
      return new Offset<EquipmentOption>();
    }
  }
}
