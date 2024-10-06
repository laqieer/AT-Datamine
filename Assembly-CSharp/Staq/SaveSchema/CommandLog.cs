// Decompiled with JetBrains decompiler
// Type: staq.SaveSchema.CommandLog
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using FlatBuffers;
using Il2CppDummyDll;

#nullable disable
namespace staq.SaveSchema
{
  [Token(Token = "0x2003C84")]
  public struct CommandLog : IFlatbufferObject
  {
    [Token(Token = "0x4010BE3")]
    [FieldOffset(Offset = "0x0")]
    private Table __p;

    [Token(Token = "0x17004E43")]
    public ByteBuffer ByteBuffer
    {
      [Token(Token = "0x6017FBF"), Address(RVA = "0x3B19994", Offset = "0x3B19994", VA = "0x3B19994", Slot = "4")] get
      {
        return (ByteBuffer) null;
      }
    }

    [Token(Token = "0x6017FC0")]
    [Address(RVA = "0x3B1999C", Offset = "0x3B1999C", VA = "0x3B1999C")]
    public static CommandLog GetRootAsCommandLog(ByteBuffer _bb) => new CommandLog();

    [Token(Token = "0x6017FC1")]
    [Address(RVA = "0x3B199A8", Offset = "0x3B199A8", VA = "0x3B199A8")]
    public static CommandLog GetRootAsCommandLog(ByteBuffer _bb, CommandLog obj)
    {
      return new CommandLog();
    }

    [Token(Token = "0x6017FC2")]
    [Address(RVA = "0x3B199EC", Offset = "0x3B199EC", VA = "0x3B199EC", Slot = "5")]
    public void __init(int _i, ByteBuffer _bb)
    {
    }

    [Token(Token = "0x6017FC3")]
    [Address(RVA = "0x3B18554", Offset = "0x3B18554", VA = "0x3B18554")]
    public CommandLog __assign(int _i, ByteBuffer _bb) => new CommandLog();

    [Token(Token = "0x17004E44")]
    public int MainCommand
    {
      [Token(Token = "0x6017FC4"), Address(RVA = "0x3B199F8", Offset = "0x3B199F8", VA = "0x3B199F8")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17004E45")]
    public int ActionUnitId
    {
      [Token(Token = "0x6017FC5"), Address(RVA = "0x3B19A3C", Offset = "0x3B19A3C", VA = "0x3B19A3C")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17004E46")]
    public int TargetId
    {
      [Token(Token = "0x6017FC6"), Address(RVA = "0x3B19A80", Offset = "0x3B19A80", VA = "0x3B19A80")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17004E47")]
    public int UseWeaponIdx
    {
      [Token(Token = "0x6017FC7"), Address(RVA = "0x3B19AC4", Offset = "0x3B19AC4", VA = "0x3B19AC4")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17004E48")]
    public int UseSkillId
    {
      [Token(Token = "0x6017FC8"), Address(RVA = "0x3B19B08", Offset = "0x3B19B08", VA = "0x3B19B08")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17004E49")]
    public int ChargeSkillId
    {
      [Token(Token = "0x6017FC9"), Address(RVA = "0x3B19B4C", Offset = "0x3B19B4C", VA = "0x3B19B4C")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17004E4A")]
    public int UseItemId
    {
      [Token(Token = "0x6017FCA"), Address(RVA = "0x3B19B90", Offset = "0x3B19B90", VA = "0x3B19B90")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17004E4B")]
    public Vec2Int? MoveTo
    {
      [Token(Token = "0x6017FCB"), Address(RVA = "0x3B19BD4", Offset = "0x3B19BD4", VA = "0x3B19BD4")] get
      {
        return new Vec2Int?();
      }
    }

    [Token(Token = "0x17004E4C")]
    public Vec2Int? TargetTo
    {
      [Token(Token = "0x6017FCC"), Address(RVA = "0x3B19C84", Offset = "0x3B19C84", VA = "0x3B19C84")] get
      {
        return new Vec2Int?();
      }
    }

    [Token(Token = "0x17004E4D")]
    public bool SwitchDouble
    {
      [Token(Token = "0x6017FCD"), Address(RVA = "0x3B19D34", Offset = "0x3B19D34", VA = "0x3B19D34")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17004E4E")]
    public int BackWeaponIdx
    {
      [Token(Token = "0x6017FCE"), Address(RVA = "0x3B19D7C", Offset = "0x3B19D7C", VA = "0x3B19D7C")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x6017FCF")]
    [Address(RVA = "0x3B19DC0", Offset = "0x3B19DC0", VA = "0x3B19DC0")]
    public static void StartCommandLog(FlatBufferBuilder builder)
    {
    }

    [Token(Token = "0x6017FD0")]
    [Address(RVA = "0x3B19DD8", Offset = "0x3B19DD8", VA = "0x3B19DD8")]
    public static void AddMainCommand(FlatBufferBuilder builder, int mainCommand)
    {
    }

    [Token(Token = "0x6017FD1")]
    [Address(RVA = "0x3B19DF8", Offset = "0x3B19DF8", VA = "0x3B19DF8")]
    public static void AddActionUnitId(FlatBufferBuilder builder, int actionUnitId)
    {
    }

    [Token(Token = "0x6017FD2")]
    [Address(RVA = "0x3B19E18", Offset = "0x3B19E18", VA = "0x3B19E18")]
    public static void AddTargetId(FlatBufferBuilder builder, int targetId)
    {
    }

    [Token(Token = "0x6017FD3")]
    [Address(RVA = "0x3B19E38", Offset = "0x3B19E38", VA = "0x3B19E38")]
    public static void AddUseWeaponIdx(FlatBufferBuilder builder, int useWeaponIdx)
    {
    }

    [Token(Token = "0x6017FD4")]
    [Address(RVA = "0x3B19E58", Offset = "0x3B19E58", VA = "0x3B19E58")]
    public static void AddUseSkillId(FlatBufferBuilder builder, int useSkillId)
    {
    }

    [Token(Token = "0x6017FD5")]
    [Address(RVA = "0x3B19E78", Offset = "0x3B19E78", VA = "0x3B19E78")]
    public static void AddChargeSkillId(FlatBufferBuilder builder, int chargeSkillId)
    {
    }

    [Token(Token = "0x6017FD6")]
    [Address(RVA = "0x3B19E98", Offset = "0x3B19E98", VA = "0x3B19E98")]
    public static void AddUseItemId(FlatBufferBuilder builder, int useItemId)
    {
    }

    [Token(Token = "0x6017FD7")]
    [Address(RVA = "0x3B19EB8", Offset = "0x3B19EB8", VA = "0x3B19EB8")]
    public static void AddMoveTo(FlatBufferBuilder builder, Offset<Vec2Int> moveToOffset)
    {
    }

    [Token(Token = "0x6017FD8")]
    [Address(RVA = "0x3B19ED8", Offset = "0x3B19ED8", VA = "0x3B19ED8")]
    public static void AddTargetTo(FlatBufferBuilder builder, Offset<Vec2Int> targetToOffset)
    {
    }

    [Token(Token = "0x6017FD9")]
    [Address(RVA = "0x3B19EF8", Offset = "0x3B19EF8", VA = "0x3B19EF8")]
    public static void AddSwitchDouble(FlatBufferBuilder builder, bool switchDouble)
    {
    }

    [Token(Token = "0x6017FDA")]
    [Address(RVA = "0x3B19F18", Offset = "0x3B19F18", VA = "0x3B19F18")]
    public static void AddBackWeaponIdx(FlatBufferBuilder builder, int backWeaponIdx)
    {
    }

    [Token(Token = "0x6017FDB")]
    [Address(RVA = "0x3B19F38", Offset = "0x3B19F38", VA = "0x3B19F38")]
    public static Offset<CommandLog> EndCommandLog(FlatBufferBuilder builder)
    {
      return new Offset<CommandLog>();
    }
  }
}
