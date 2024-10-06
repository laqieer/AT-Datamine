// Decompiled with JetBrains decompiler
// Type: staq.SaveSchema.SkillData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using FlatBuffers;
using Il2CppDummyDll;

#nullable disable
namespace staq.SaveSchema
{
  [Token(Token = "0x2003C6A")]
  public struct SkillData : IFlatbufferObject
  {
    [Token(Token = "0x4010BC9")]
    [FieldOffset(Offset = "0x0")]
    private Table __p;

    [Token(Token = "0x17004D76")]
    public ByteBuffer ByteBuffer
    {
      [Token(Token = "0x6017C87"), Address(RVA = "0x37B8CA0", Offset = "0x37B8CA0", VA = "0x37B8CA0", Slot = "4")] get
      {
        return (ByteBuffer) null;
      }
    }

    [Token(Token = "0x6017C88")]
    [Address(RVA = "0x37B8CA8", Offset = "0x37B8CA8", VA = "0x37B8CA8")]
    public static SkillData GetRootAsSkillData(ByteBuffer _bb) => new SkillData();

    [Token(Token = "0x6017C89")]
    [Address(RVA = "0x37B8CB4", Offset = "0x37B8CB4", VA = "0x37B8CB4")]
    public static SkillData GetRootAsSkillData(ByteBuffer _bb, SkillData obj) => new SkillData();

    [Token(Token = "0x6017C8A")]
    [Address(RVA = "0x37B8CF8", Offset = "0x37B8CF8", VA = "0x37B8CF8", Slot = "5")]
    public void __init(int _i, ByteBuffer _bb)
    {
    }

    [Token(Token = "0x6017C8B")]
    [Address(RVA = "0x37B77A8", Offset = "0x37B77A8", VA = "0x37B77A8")]
    public SkillData __assign(int _i, ByteBuffer _bb) => new SkillData();

    [Token(Token = "0x17004D77")]
    public int Id
    {
      [Token(Token = "0x6017C8C"), Address(RVA = "0x37B8D04", Offset = "0x37B8D04", VA = "0x37B8D04")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17004D78")]
    public int Skill
    {
      [Token(Token = "0x6017C8D"), Address(RVA = "0x37B8D48", Offset = "0x37B8D48", VA = "0x37B8D48")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17004D79")]
    public int Rarity
    {
      [Token(Token = "0x6017C8E"), Address(RVA = "0x37B8D8C", Offset = "0x37B8D8C", VA = "0x37B8D8C")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17004D7A")]
    public int Level
    {
      [Token(Token = "0x6017C8F"), Address(RVA = "0x37B8DD0", Offset = "0x37B8DD0", VA = "0x37B8DD0")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x6017C90")]
    [Address(RVA = "0x37B8E14", Offset = "0x37B8E14", VA = "0x37B8E14")]
    public static Offset<SkillData> CreateSkillData(
      FlatBufferBuilder builder,
      int id = 0,
      int skill = 0,
      int rarity = 0,
      int level = 0)
    {
      return new Offset<SkillData>();
    }

    [Token(Token = "0x6017C91")]
    [Address(RVA = "0x37B8F64", Offset = "0x37B8F64", VA = "0x37B8F64")]
    public static void StartSkillData(FlatBufferBuilder builder)
    {
    }

    [Token(Token = "0x6017C92")]
    [Address(RVA = "0x37B8EF4", Offset = "0x37B8EF4", VA = "0x37B8EF4")]
    public static void AddId(FlatBufferBuilder builder, int id)
    {
    }

    [Token(Token = "0x6017C93")]
    [Address(RVA = "0x37B8ED4", Offset = "0x37B8ED4", VA = "0x37B8ED4")]
    public static void AddSkill(FlatBufferBuilder builder, int skill)
    {
    }

    [Token(Token = "0x6017C94")]
    [Address(RVA = "0x37B8EB4", Offset = "0x37B8EB4", VA = "0x37B8EB4")]
    public static void AddRarity(FlatBufferBuilder builder, int rarity)
    {
    }

    [Token(Token = "0x6017C95")]
    [Address(RVA = "0x37B8E94", Offset = "0x37B8E94", VA = "0x37B8E94")]
    public static void AddLevel(FlatBufferBuilder builder, int level)
    {
    }

    [Token(Token = "0x6017C96")]
    [Address(RVA = "0x37B8F14", Offset = "0x37B8F14", VA = "0x37B8F14")]
    public static Offset<SkillData> EndSkillData(FlatBufferBuilder builder)
    {
      return new Offset<SkillData>();
    }
  }
}
