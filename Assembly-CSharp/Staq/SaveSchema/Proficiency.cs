// Decompiled with JetBrains decompiler
// Type: staq.SaveSchema.Proficiency
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using FlatBuffers;
using Il2CppDummyDll;

#nullable disable
namespace staq.SaveSchema
{
  [Token(Token = "0x2003C6F")]
  public struct Proficiency : IFlatbufferObject
  {
    [Token(Token = "0x4010BCE")]
    [FieldOffset(Offset = "0x0")]
    private Table __p;

    [Token(Token = "0x17004DAC")]
    public ByteBuffer ByteBuffer
    {
      [Token(Token = "0x6017D67"), Address(RVA = "0x37BCA98", Offset = "0x37BCA98", VA = "0x37BCA98", Slot = "4")] get
      {
        return (ByteBuffer) null;
      }
    }

    [Token(Token = "0x6017D68")]
    [Address(RVA = "0x37BCAA0", Offset = "0x37BCAA0", VA = "0x37BCAA0")]
    public static Proficiency GetRootAsProficiency(ByteBuffer _bb) => new Proficiency();

    [Token(Token = "0x6017D69")]
    [Address(RVA = "0x37BCAAC", Offset = "0x37BCAAC", VA = "0x37BCAAC")]
    public static Proficiency GetRootAsProficiency(ByteBuffer _bb, Proficiency obj)
    {
      return new Proficiency();
    }

    [Token(Token = "0x6017D6A")]
    [Address(RVA = "0x37BCAF0", Offset = "0x37BCAF0", VA = "0x37BCAF0", Slot = "5")]
    public void __init(int _i, ByteBuffer _bb)
    {
    }

    [Token(Token = "0x6017D6B")]
    [Address(RVA = "0x37B9CF4", Offset = "0x37B9CF4", VA = "0x37B9CF4")]
    public Proficiency __assign(int _i, ByteBuffer _bb) => new Proficiency();

    [Token(Token = "0x17004DAD")]
    public int WeaponType
    {
      [Token(Token = "0x6017D6C"), Address(RVA = "0x37BCAFC", Offset = "0x37BCAFC", VA = "0x37BCAFC")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17004DAE")]
    public int ProficiencyType
    {
      [Token(Token = "0x6017D6D"), Address(RVA = "0x37BCB40", Offset = "0x37BCB40", VA = "0x37BCB40")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x6017D6E")]
    [Address(RVA = "0x37BCB84", Offset = "0x37BCB84", VA = "0x37BCB84")]
    public static Offset<Proficiency> CreateProficiency(
      FlatBufferBuilder builder,
      int weaponType = 0,
      int proficiencyType = 0)
    {
      return new Offset<Proficiency>();
    }

    [Token(Token = "0x6017D6F")]
    [Address(RVA = "0x37BCC6C", Offset = "0x37BCC6C", VA = "0x37BCC6C")]
    public static void StartProficiency(FlatBufferBuilder builder)
    {
    }

    [Token(Token = "0x6017D70")]
    [Address(RVA = "0x37BCBFC", Offset = "0x37BCBFC", VA = "0x37BCBFC")]
    public static void AddWeaponType(FlatBufferBuilder builder, int weaponType)
    {
    }

    [Token(Token = "0x6017D71")]
    [Address(RVA = "0x37BCBDC", Offset = "0x37BCBDC", VA = "0x37BCBDC")]
    public static void AddProficiencyType(FlatBufferBuilder builder, int proficiencyType)
    {
    }

    [Token(Token = "0x6017D72")]
    [Address(RVA = "0x37BCC1C", Offset = "0x37BCC1C", VA = "0x37BCC1C")]
    public static Offset<Proficiency> EndProficiency(FlatBufferBuilder builder)
    {
      return new Offset<Proficiency>();
    }
  }
}
