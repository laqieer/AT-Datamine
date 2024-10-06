// Decompiled with JetBrains decompiler
// Type: staq.SaveSchema.SkillParameterData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using FlatBuffers;
using Il2CppDummyDll;

#nullable disable
namespace staq.SaveSchema
{
  [Token(Token = "0x2003C92")]
  public struct SkillParameterData : IFlatbufferObject
  {
    [Token(Token = "0x4010BF1")]
    [FieldOffset(Offset = "0x0")]
    private Table __p;

    [Token(Token = "0x17004EB5")]
    public ByteBuffer ByteBuffer
    {
      [Token(Token = "0x6018144"), Address(RVA = "0x3B1F9A0", Offset = "0x3B1F9A0", VA = "0x3B1F9A0", Slot = "4")] get
      {
        return (ByteBuffer) null;
      }
    }

    [Token(Token = "0x6018145")]
    [Address(RVA = "0x3B1F9A8", Offset = "0x3B1F9A8", VA = "0x3B1F9A8")]
    public static SkillParameterData GetRootAsSkillParameterData(ByteBuffer _bb)
    {
      return new SkillParameterData();
    }

    [Token(Token = "0x6018146")]
    [Address(RVA = "0x3B1F9B4", Offset = "0x3B1F9B4", VA = "0x3B1F9B4")]
    public static SkillParameterData GetRootAsSkillParameterData(
      ByteBuffer _bb,
      SkillParameterData obj)
    {
      return new SkillParameterData();
    }

    [Token(Token = "0x6018147")]
    [Address(RVA = "0x3B1F9F8", Offset = "0x3B1F9F8", VA = "0x3B1F9F8", Slot = "5")]
    public void __init(int _i, ByteBuffer _bb)
    {
    }

    [Token(Token = "0x6018148")]
    [Address(RVA = "0x3B17DC8", Offset = "0x3B17DC8", VA = "0x3B17DC8")]
    public SkillParameterData __assign(int _i, ByteBuffer _bb) => new SkillParameterData();

    [Token(Token = "0x17004EB6")]
    public int Id
    {
      [Token(Token = "0x6018149"), Address(RVA = "0x3B1FA04", Offset = "0x3B1FA04", VA = "0x3B1FA04")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17004EB7")]
    public int Skill
    {
      [Token(Token = "0x601814A"), Address(RVA = "0x3B1FA48", Offset = "0x3B1FA48", VA = "0x3B1FA48")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17004EB8")]
    public int Amount
    {
      [Token(Token = "0x601814B"), Address(RVA = "0x3B1FA8C", Offset = "0x3B1FA8C", VA = "0x3B1FA8C")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17004EB9")]
    public bool IsActive
    {
      [Token(Token = "0x601814C"), Address(RVA = "0x3B1FAD0", Offset = "0x3B1FAD0", VA = "0x3B1FAD0")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17004EBA")]
    public int CoolTime
    {
      [Token(Token = "0x601814D"), Address(RVA = "0x3B1FB18", Offset = "0x3B1FB18", VA = "0x3B1FB18")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x601814E")]
    [Address(RVA = "0x3B1FB5C", Offset = "0x3B1FB5C", VA = "0x3B1FB5C")]
    public static Offset<SkillParameterData> CreateSkillParameterData(
      FlatBufferBuilder builder,
      int id = 0,
      int skill = 0,
      int amount = 0,
      bool isActive = false,
      int coolTime = 0)
    {
      return new Offset<SkillParameterData>();
    }

    [Token(Token = "0x601814F")]
    [Address(RVA = "0x3B1FCE4", Offset = "0x3B1FCE4", VA = "0x3B1FCE4")]
    public static void StartSkillParameterData(FlatBufferBuilder builder)
    {
    }

    [Token(Token = "0x6018150")]
    [Address(RVA = "0x3B1FC54", Offset = "0x3B1FC54", VA = "0x3B1FC54")]
    public static void AddId(FlatBufferBuilder builder, int id)
    {
    }

    [Token(Token = "0x6018151")]
    [Address(RVA = "0x3B1FC34", Offset = "0x3B1FC34", VA = "0x3B1FC34")]
    public static void AddSkill(FlatBufferBuilder builder, int skill)
    {
    }

    [Token(Token = "0x6018152")]
    [Address(RVA = "0x3B1FC14", Offset = "0x3B1FC14", VA = "0x3B1FC14")]
    public static void AddAmount(FlatBufferBuilder builder, int amount)
    {
    }

    [Token(Token = "0x6018153")]
    [Address(RVA = "0x3B1FC74", Offset = "0x3B1FC74", VA = "0x3B1FC74")]
    public static void AddIsActive(FlatBufferBuilder builder, bool isActive)
    {
    }

    [Token(Token = "0x6018154")]
    [Address(RVA = "0x3B1FBF4", Offset = "0x3B1FBF4", VA = "0x3B1FBF4")]
    public static void AddCoolTime(FlatBufferBuilder builder, int coolTime)
    {
    }

    [Token(Token = "0x6018155")]
    [Address(RVA = "0x3B1FC94", Offset = "0x3B1FC94", VA = "0x3B1FC94")]
    public static Offset<SkillParameterData> EndSkillParameterData(FlatBufferBuilder builder)
    {
      return new Offset<SkillParameterData>();
    }
  }
}
