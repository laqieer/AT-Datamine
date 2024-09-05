// Decompiled with JetBrains decompiler
// Type: staq.SaveSchema.EnemyDropInfo
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using FlatBuffers;
using Il2CppDummyDll;

#nullable disable
namespace staq.SaveSchema
{
  [Token(Token = "0x2003C7F")]
  public struct EnemyDropInfo : IFlatbufferObject
  {
    [Token(Token = "0x4010BDE")]
    [FieldOffset(Offset = "0x0")]
    private Table __p;

    [Token(Token = "0x17004E03")]
    public ByteBuffer ByteBuffer
    {
      [Token(Token = "0x6017EC8"), Address(RVA = "0x37C1C04", Offset = "0x37C1C04", VA = "0x37C1C04", Slot = "4")] get
      {
        return (ByteBuffer) null;
      }
    }

    [Token(Token = "0x6017EC9")]
    [Address(RVA = "0x37C1C0C", Offset = "0x37C1C0C", VA = "0x37C1C0C")]
    public static EnemyDropInfo GetRootAsEnemyDropInfo(ByteBuffer _bb) => new EnemyDropInfo();

    [Token(Token = "0x6017ECA")]
    [Address(RVA = "0x37C1C18", Offset = "0x37C1C18", VA = "0x37C1C18")]
    public static EnemyDropInfo GetRootAsEnemyDropInfo(ByteBuffer _bb, EnemyDropInfo obj)
    {
      return new EnemyDropInfo();
    }

    [Token(Token = "0x6017ECB")]
    [Address(RVA = "0x37C1C74", Offset = "0x37C1C74", VA = "0x37C1C74", Slot = "5")]
    public void __init(int _i, ByteBuffer _bb)
    {
    }

    [Token(Token = "0x6017ECC")]
    [Address(RVA = "0x37C1C5C", Offset = "0x37C1C5C", VA = "0x37C1C5C")]
    public EnemyDropInfo __assign(int _i, ByteBuffer _bb) => new EnemyDropInfo();

    [Token(Token = "0x17004E04")]
    public int EnemyId
    {
      [Token(Token = "0x6017ECD"), Address(RVA = "0x37C1C80", Offset = "0x37C1C80", VA = "0x37C1C80")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17004E05")]
    public int BattleDropRewardTypeId
    {
      [Token(Token = "0x6017ECE"), Address(RVA = "0x37C1CC4", Offset = "0x37C1CC4", VA = "0x37C1CC4")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x6017ECF")]
    [Address(RVA = "0x37C1D08", Offset = "0x37C1D08", VA = "0x37C1D08")]
    public static Offset<EnemyDropInfo> CreateEnemyDropInfo(
      FlatBufferBuilder builder,
      int enemyId = 0,
      int battleDropRewardTypeId = 0)
    {
      return new Offset<EnemyDropInfo>();
    }

    [Token(Token = "0x6017ED0")]
    [Address(RVA = "0x37C1DF0", Offset = "0x37C1DF0", VA = "0x37C1DF0")]
    public static void StartEnemyDropInfo(FlatBufferBuilder builder)
    {
    }

    [Token(Token = "0x6017ED1")]
    [Address(RVA = "0x37C1D80", Offset = "0x37C1D80", VA = "0x37C1D80")]
    public static void AddEnemyId(FlatBufferBuilder builder, int enemyId)
    {
    }

    [Token(Token = "0x6017ED2")]
    [Address(RVA = "0x37C1D60", Offset = "0x37C1D60", VA = "0x37C1D60")]
    public static void AddBattleDropRewardTypeId(
      FlatBufferBuilder builder,
      int battleDropRewardTypeId)
    {
    }

    [Token(Token = "0x6017ED3")]
    [Address(RVA = "0x37C1DA0", Offset = "0x37C1DA0", VA = "0x37C1DA0")]
    public static Offset<EnemyDropInfo> EndEnemyDropInfo(FlatBufferBuilder builder)
    {
      return new Offset<EnemyDropInfo>();
    }
  }
}
