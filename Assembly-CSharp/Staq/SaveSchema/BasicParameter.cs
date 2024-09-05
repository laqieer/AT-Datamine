// Decompiled with JetBrains decompiler
// Type: staq.SaveSchema.BasicParameter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using FlatBuffers;
using Il2CppDummyDll;

#nullable disable
namespace staq.SaveSchema
{
  [Token(Token = "0x2003C73")]
  public struct BasicParameter : IFlatbufferObject
  {
    [Token(Token = "0x4010BD2")]
    [FieldOffset(Offset = "0x0")]
    private Table __p;

    [Token(Token = "0x17004DC5")]
    public ByteBuffer ByteBuffer
    {
      [Token(Token = "0x6017DCF"), Address(RVA = "0x37BE308", Offset = "0x37BE308", VA = "0x37BE308", Slot = "4")] get
      {
        return (ByteBuffer) null;
      }
    }

    [Token(Token = "0x6017DD0")]
    [Address(RVA = "0x37BE310", Offset = "0x37BE310", VA = "0x37BE310")]
    public static BasicParameter GetRootAsBasicParameter(ByteBuffer _bb) => new BasicParameter();

    [Token(Token = "0x6017DD1")]
    [Address(RVA = "0x37BE31C", Offset = "0x37BE31C", VA = "0x37BE31C")]
    public static BasicParameter GetRootAsBasicParameter(ByteBuffer _bb, BasicParameter obj)
    {
      return new BasicParameter();
    }

    [Token(Token = "0x6017DD2")]
    [Address(RVA = "0x37BE360", Offset = "0x37BE360", VA = "0x37BE360", Slot = "5")]
    public void __init(int _i, ByteBuffer _bb)
    {
    }

    [Token(Token = "0x6017DD3")]
    [Address(RVA = "0x37B90D4", Offset = "0x37B90D4", VA = "0x37B90D4")]
    public BasicParameter __assign(int _i, ByteBuffer _bb) => new BasicParameter();

    [Token(Token = "0x17004DC6")]
    public int Life
    {
      [Token(Token = "0x6017DD4"), Address(RVA = "0x37BE36C", Offset = "0x37BE36C", VA = "0x37BE36C")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17004DC7")]
    public int Strength
    {
      [Token(Token = "0x6017DD5"), Address(RVA = "0x37BE3B0", Offset = "0x37BE3B0", VA = "0x37BE3B0")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17004DC8")]
    public int Intelligence
    {
      [Token(Token = "0x6017DD6"), Address(RVA = "0x37BE3F4", Offset = "0x37BE3F4", VA = "0x37BE3F4")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17004DC9")]
    public int Vitality
    {
      [Token(Token = "0x6017DD7"), Address(RVA = "0x37BE438", Offset = "0x37BE438", VA = "0x37BE438")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17004DCA")]
    public int Mind
    {
      [Token(Token = "0x6017DD8"), Address(RVA = "0x37BE47C", Offset = "0x37BE47C", VA = "0x37BE47C")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17004DCB")]
    public int Agility
    {
      [Token(Token = "0x6017DD9"), Address(RVA = "0x37BE4C0", Offset = "0x37BE4C0", VA = "0x37BE4C0")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17004DCC")]
    public int Dexterity
    {
      [Token(Token = "0x6017DDA"), Address(RVA = "0x37BE504", Offset = "0x37BE504", VA = "0x37BE504")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17004DCD")]
    public int Lucky
    {
      [Token(Token = "0x6017DDB"), Address(RVA = "0x37BE548", Offset = "0x37BE548", VA = "0x37BE548")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x6017DDC")]
    [Address(RVA = "0x37BE58C", Offset = "0x37BE58C", VA = "0x37BE58C")]
    public static Offset<BasicParameter> CreateBasicParameter(
      FlatBufferBuilder builder,
      int life = 0,
      int strength = 0,
      int intelligence = 0,
      int vitality = 0,
      int mind = 0,
      int agility = 0,
      int dexterity = 0,
      int lucky = 0)
    {
      return new Offset<BasicParameter>();
    }

    [Token(Token = "0x6017DDD")]
    [Address(RVA = "0x37BE7AC", Offset = "0x37BE7AC", VA = "0x37BE7AC")]
    public static void StartBasicParameter(FlatBufferBuilder builder)
    {
    }

    [Token(Token = "0x6017DDE")]
    [Address(RVA = "0x37BE73C", Offset = "0x37BE73C", VA = "0x37BE73C")]
    public static void AddLife(FlatBufferBuilder builder, int life)
    {
    }

    [Token(Token = "0x6017DDF")]
    [Address(RVA = "0x37BE71C", Offset = "0x37BE71C", VA = "0x37BE71C")]
    public static void AddStrength(FlatBufferBuilder builder, int strength)
    {
    }

    [Token(Token = "0x6017DE0")]
    [Address(RVA = "0x37BE6FC", Offset = "0x37BE6FC", VA = "0x37BE6FC")]
    public static void AddIntelligence(FlatBufferBuilder builder, int intelligence)
    {
    }

    [Token(Token = "0x6017DE1")]
    [Address(RVA = "0x37BE6DC", Offset = "0x37BE6DC", VA = "0x37BE6DC")]
    public static void AddVitality(FlatBufferBuilder builder, int vitality)
    {
    }

    [Token(Token = "0x6017DE2")]
    [Address(RVA = "0x37BE6BC", Offset = "0x37BE6BC", VA = "0x37BE6BC")]
    public static void AddMind(FlatBufferBuilder builder, int mind)
    {
    }

    [Token(Token = "0x6017DE3")]
    [Address(RVA = "0x37BE69C", Offset = "0x37BE69C", VA = "0x37BE69C")]
    public static void AddAgility(FlatBufferBuilder builder, int agility)
    {
    }

    [Token(Token = "0x6017DE4")]
    [Address(RVA = "0x37BE67C", Offset = "0x37BE67C", VA = "0x37BE67C")]
    public static void AddDexterity(FlatBufferBuilder builder, int dexterity)
    {
    }

    [Token(Token = "0x6017DE5")]
    [Address(RVA = "0x37BE65C", Offset = "0x37BE65C", VA = "0x37BE65C")]
    public static void AddLucky(FlatBufferBuilder builder, int lucky)
    {
    }

    [Token(Token = "0x6017DE6")]
    [Address(RVA = "0x37BE75C", Offset = "0x37BE75C", VA = "0x37BE75C")]
    public static Offset<BasicParameter> EndBasicParameter(FlatBufferBuilder builder)
    {
      return new Offset<BasicParameter>();
    }
  }
}
