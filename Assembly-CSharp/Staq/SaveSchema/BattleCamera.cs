// Decompiled with JetBrains decompiler
// Type: staq.SaveSchema.BattleCamera
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using FlatBuffers;
using Il2CppDummyDll;

#nullable disable
namespace staq.SaveSchema
{
  [Token(Token = "0x2003C82")]
  public struct BattleCamera : IFlatbufferObject
  {
    [Token(Token = "0x4010BE1")]
    [FieldOffset(Offset = "0x0")]
    private Table __p;

    [Token(Token = "0x17004E2D")]
    public ByteBuffer ByteBuffer
    {
      [Token(Token = "0x6017F54"), Address(RVA = "0x3B1769C", Offset = "0x3B1769C", VA = "0x3B1769C", Slot = "4")] get
      {
        return (ByteBuffer) null;
      }
    }

    [Token(Token = "0x6017F55")]
    [Address(RVA = "0x3B176A4", Offset = "0x3B176A4", VA = "0x3B176A4")]
    public static BattleCamera GetRootAsBattleCamera(ByteBuffer _bb) => new BattleCamera();

    [Token(Token = "0x6017F56")]
    [Address(RVA = "0x3B176B0", Offset = "0x3B176B0", VA = "0x3B176B0")]
    public static BattleCamera GetRootAsBattleCamera(ByteBuffer _bb, BattleCamera obj)
    {
      return new BattleCamera();
    }

    [Token(Token = "0x6017F57")]
    [Address(RVA = "0x3B176F4", Offset = "0x3B176F4", VA = "0x3B176F4", Slot = "5")]
    public void __init(int _i, ByteBuffer _bb)
    {
    }

    [Token(Token = "0x6017F58")]
    [Address(RVA = "0x3B16D90", Offset = "0x3B16D90", VA = "0x3B16D90")]
    public BattleCamera __assign(int _i, ByteBuffer _bb) => new BattleCamera();

    [Token(Token = "0x17004E2E")]
    public int Id
    {
      [Token(Token = "0x6017F59"), Address(RVA = "0x3B17700", Offset = "0x3B17700", VA = "0x3B17700")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17004E2F")]
    public float Distance
    {
      [Token(Token = "0x6017F5A"), Address(RVA = "0x3B17744", Offset = "0x3B17744", VA = "0x3B17744")] get
      {
        return new float();
      }
    }

    [Token(Token = "0x6017F5B")]
    [Address(RVA = "0x3B1778C", Offset = "0x3B1778C", VA = "0x3B1778C")]
    public static Offset<BattleCamera> CreateBattleCamera(
      FlatBufferBuilder builder,
      int id = 0,
      float distance = -1f)
    {
      return new Offset<BattleCamera>();
    }

    [Token(Token = "0x6017F5C")]
    [Address(RVA = "0x3B17878", Offset = "0x3B17878", VA = "0x3B17878")]
    public static void StartBattleCamera(FlatBufferBuilder builder)
    {
    }

    [Token(Token = "0x6017F5D")]
    [Address(RVA = "0x3B17808", Offset = "0x3B17808", VA = "0x3B17808")]
    public static void AddId(FlatBufferBuilder builder, int id)
    {
    }

    [Token(Token = "0x6017F5E")]
    [Address(RVA = "0x3B177EC", Offset = "0x3B177EC", VA = "0x3B177EC")]
    public static void AddDistance(FlatBufferBuilder builder, float distance)
    {
    }

    [Token(Token = "0x6017F5F")]
    [Address(RVA = "0x3B17828", Offset = "0x3B17828", VA = "0x3B17828")]
    public static Offset<BattleCamera> EndBattleCamera(FlatBufferBuilder builder)
    {
      return new Offset<BattleCamera>();
    }
  }
}
