// Decompiled with JetBrains decompiler
// Type: staq.SaveSchema.BattleParameter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using FlatBuffers;
using Il2CppDummyDll;

#nullable disable
namespace staq.SaveSchema
{
  [Token(Token = "0x2003C74")]
  public struct BattleParameter : IFlatbufferObject
  {
    [Token(Token = "0x4010BD3")]
    [FieldOffset(Offset = "0x0")]
    private Table __p;

    [Token(Token = "0x17004DCE")]
    public ByteBuffer ByteBuffer
    {
      [Token(Token = "0x6017DE7"), Address(RVA = "0x37BE7C4", Offset = "0x37BE7C4", VA = "0x37BE7C4", Slot = "4")] get
      {
        return (ByteBuffer) null;
      }
    }

    [Token(Token = "0x6017DE8")]
    [Address(RVA = "0x37BE7CC", Offset = "0x37BE7CC", VA = "0x37BE7CC")]
    public static BattleParameter GetRootAsBattleParameter(ByteBuffer _bb) => new BattleParameter();

    [Token(Token = "0x6017DE9")]
    [Address(RVA = "0x37BE7D8", Offset = "0x37BE7D8", VA = "0x37BE7D8")]
    public static BattleParameter GetRootAsBattleParameter(ByteBuffer _bb, BattleParameter obj)
    {
      return new BattleParameter();
    }

    [Token(Token = "0x6017DEA")]
    [Address(RVA = "0x37BE81C", Offset = "0x37BE81C", VA = "0x37BE81C", Slot = "5")]
    public void __init(int _i, ByteBuffer _bb)
    {
    }

    [Token(Token = "0x6017DEB")]
    [Address(RVA = "0x37B9A7C", Offset = "0x37B9A7C", VA = "0x37B9A7C")]
    public BattleParameter __assign(int _i, ByteBuffer _bb) => new BattleParameter();

    [Token(Token = "0x17004DCF")]
    public int Hp
    {
      [Token(Token = "0x6017DEC"), Address(RVA = "0x37BE828", Offset = "0x37BE828", VA = "0x37BE828")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17004DD0")]
    public int PhysicalAtk
    {
      [Token(Token = "0x6017DED"), Address(RVA = "0x37BE86C", Offset = "0x37BE86C", VA = "0x37BE86C")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17004DD1")]
    public int PhysicalDef
    {
      [Token(Token = "0x6017DEE"), Address(RVA = "0x37BE8B0", Offset = "0x37BE8B0", VA = "0x37BE8B0")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17004DD2")]
    public int MagicalAtk
    {
      [Token(Token = "0x6017DEF"), Address(RVA = "0x37BE8F4", Offset = "0x37BE8F4", VA = "0x37BE8F4")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17004DD3")]
    public int MagicalDef
    {
      [Token(Token = "0x6017DF0"), Address(RVA = "0x37BE938", Offset = "0x37BE938", VA = "0x37BE938")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17004DD4")]
    public int Hit
    {
      [Token(Token = "0x6017DF1"), Address(RVA = "0x37BE97C", Offset = "0x37BE97C", VA = "0x37BE97C")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17004DD5")]
    public int Avoid
    {
      [Token(Token = "0x6017DF2"), Address(RVA = "0x37BE9C0", Offset = "0x37BE9C0", VA = "0x37BE9C0")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17004DD6")]
    public int Critical
    {
      [Token(Token = "0x6017DF3"), Address(RVA = "0x37BEA04", Offset = "0x37BEA04", VA = "0x37BEA04")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17004DD7")]
    public int CriticalAvoid
    {
      [Token(Token = "0x6017DF4"), Address(RVA = "0x37BEA48", Offset = "0x37BEA48", VA = "0x37BEA48")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17004DD8")]
    public int AtkSpeed
    {
      [Token(Token = "0x6017DF5"), Address(RVA = "0x37BEA8C", Offset = "0x37BEA8C", VA = "0x37BEA8C")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x6017DF6")]
    [Address(RVA = "0x37BEAD0", Offset = "0x37BEAD0", VA = "0x37BEAD0")]
    public static Offset<BattleParameter> CreateBattleParameter(
      FlatBufferBuilder builder,
      int hp = 0,
      int physicalAtk = 0,
      int physicalDef = 0,
      int magicalAtk = 0,
      int magicalDef = 0,
      int hit = 0,
      int avoid = 0,
      int critical = 0,
      int criticalAvoid = 0,
      int atkSpeed = 0)
    {
      return new Offset<BattleParameter>();
    }

    [Token(Token = "0x6017DF7")]
    [Address(RVA = "0x37BED58", Offset = "0x37BED58", VA = "0x37BED58")]
    public static void StartBattleParameter(FlatBufferBuilder builder)
    {
    }

    [Token(Token = "0x6017DF8")]
    [Address(RVA = "0x37BECE8", Offset = "0x37BECE8", VA = "0x37BECE8")]
    public static void AddHp(FlatBufferBuilder builder, int hp)
    {
    }

    [Token(Token = "0x6017DF9")]
    [Address(RVA = "0x37BECC8", Offset = "0x37BECC8", VA = "0x37BECC8")]
    public static void AddPhysicalAtk(FlatBufferBuilder builder, int physicalAtk)
    {
    }

    [Token(Token = "0x6017DFA")]
    [Address(RVA = "0x37BECA8", Offset = "0x37BECA8", VA = "0x37BECA8")]
    public static void AddPhysicalDef(FlatBufferBuilder builder, int physicalDef)
    {
    }

    [Token(Token = "0x6017DFB")]
    [Address(RVA = "0x37BEC88", Offset = "0x37BEC88", VA = "0x37BEC88")]
    public static void AddMagicalAtk(FlatBufferBuilder builder, int magicalAtk)
    {
    }

    [Token(Token = "0x6017DFC")]
    [Address(RVA = "0x37BEC68", Offset = "0x37BEC68", VA = "0x37BEC68")]
    public static void AddMagicalDef(FlatBufferBuilder builder, int magicalDef)
    {
    }

    [Token(Token = "0x6017DFD")]
    [Address(RVA = "0x37BEC48", Offset = "0x37BEC48", VA = "0x37BEC48")]
    public static void AddHit(FlatBufferBuilder builder, int hit)
    {
    }

    [Token(Token = "0x6017DFE")]
    [Address(RVA = "0x37BEC28", Offset = "0x37BEC28", VA = "0x37BEC28")]
    public static void AddAvoid(FlatBufferBuilder builder, int avoid)
    {
    }

    [Token(Token = "0x6017DFF")]
    [Address(RVA = "0x37BEC08", Offset = "0x37BEC08", VA = "0x37BEC08")]
    public static void AddCritical(FlatBufferBuilder builder, int critical)
    {
    }

    [Token(Token = "0x6017E00")]
    [Address(RVA = "0x37BEBE8", Offset = "0x37BEBE8", VA = "0x37BEBE8")]
    public static void AddCriticalAvoid(FlatBufferBuilder builder, int criticalAvoid)
    {
    }

    [Token(Token = "0x6017E01")]
    [Address(RVA = "0x37BEBC8", Offset = "0x37BEBC8", VA = "0x37BEBC8")]
    public static void AddAtkSpeed(FlatBufferBuilder builder, int atkSpeed)
    {
    }

    [Token(Token = "0x6017E02")]
    [Address(RVA = "0x37BED08", Offset = "0x37BED08", VA = "0x37BED08")]
    public static Offset<BattleParameter> EndBattleParameter(FlatBufferBuilder builder)
    {
      return new Offset<BattleParameter>();
    }
  }
}
