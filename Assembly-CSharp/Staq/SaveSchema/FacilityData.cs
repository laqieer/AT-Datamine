// Decompiled with JetBrains decompiler
// Type: staq.SaveSchema.FacilityData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using FlatBuffers;
using Il2CppDummyDll;

#nullable disable
namespace staq.SaveSchema
{
  [Token(Token = "0x2003C85")]
  public struct FacilityData : IFlatbufferObject
  {
    [Token(Token = "0x4010BE4")]
    [FieldOffset(Offset = "0x0")]
    private Table __p;

    [Token(Token = "0x17004E4F")]
    public ByteBuffer ByteBuffer
    {
      [Token(Token = "0x6017FDC"), Address(RVA = "0x3B19F88", Offset = "0x3B19F88", VA = "0x3B19F88", Slot = "4")] get
      {
        return (ByteBuffer) null;
      }
    }

    [Token(Token = "0x6017FDD")]
    [Address(RVA = "0x3B19F90", Offset = "0x3B19F90", VA = "0x3B19F90")]
    public static FacilityData GetRootAsFacilityData(ByteBuffer _bb) => new FacilityData();

    [Token(Token = "0x6017FDE")]
    [Address(RVA = "0x3B19F9C", Offset = "0x3B19F9C", VA = "0x3B19F9C")]
    public static FacilityData GetRootAsFacilityData(ByteBuffer _bb, FacilityData obj)
    {
      return new FacilityData();
    }

    [Token(Token = "0x6017FDF")]
    [Address(RVA = "0x3B19FE0", Offset = "0x3B19FE0", VA = "0x3B19FE0", Slot = "5")]
    public void __init(int _i, ByteBuffer _bb)
    {
    }

    [Token(Token = "0x6017FE0")]
    [Address(RVA = "0x3B17EC8", Offset = "0x3B17EC8", VA = "0x3B17EC8")]
    public FacilityData __assign(int _i, ByteBuffer _bb) => new FacilityData();

    [Token(Token = "0x17004E50")]
    public int Placement
    {
      [Token(Token = "0x6017FE1"), Address(RVA = "0x3B19FEC", Offset = "0x3B19FEC", VA = "0x3B19FEC")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17004E51")]
    public bool SwitchState
    {
      [Token(Token = "0x6017FE2"), Address(RVA = "0x3B1A030", Offset = "0x3B1A030", VA = "0x3B1A030")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17004E52")]
    public int SkillParamId
    {
      [Token(Token = "0x6017FE3"), Address(RVA = "0x3B1A078", Offset = "0x3B1A078", VA = "0x3B1A078")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x6017FE4")]
    [Address(RVA = "0x3B1A0BC", Offset = "0x3B1A0BC", VA = "0x3B1A0BC")]
    public static Offset<FacilityData> CreateFacilityData(
      FlatBufferBuilder builder,
      int placement = 0,
      bool switchState = false,
      int skillParamId = 0)
    {
      return new Offset<FacilityData>();
    }

    [Token(Token = "0x6017FE5")]
    [Address(RVA = "0x3B1A1DC", Offset = "0x3B1A1DC", VA = "0x3B1A1DC")]
    public static void StartFacilityData(FlatBufferBuilder builder)
    {
    }

    [Token(Token = "0x6017FE6")]
    [Address(RVA = "0x3B1A14C", Offset = "0x3B1A14C", VA = "0x3B1A14C")]
    public static void AddPlacement(FlatBufferBuilder builder, int placement)
    {
    }

    [Token(Token = "0x6017FE7")]
    [Address(RVA = "0x3B1A16C", Offset = "0x3B1A16C", VA = "0x3B1A16C")]
    public static void AddSwitchState(FlatBufferBuilder builder, bool switchState)
    {
    }

    [Token(Token = "0x6017FE8")]
    [Address(RVA = "0x3B1A12C", Offset = "0x3B1A12C", VA = "0x3B1A12C")]
    public static void AddSkillParamId(FlatBufferBuilder builder, int skillParamId)
    {
    }

    [Token(Token = "0x6017FE9")]
    [Address(RVA = "0x3B1A18C", Offset = "0x3B1A18C", VA = "0x3B1A18C")]
    public static Offset<FacilityData> EndFacilityData(FlatBufferBuilder builder)
    {
      return new Offset<FacilityData>();
    }
  }
}
