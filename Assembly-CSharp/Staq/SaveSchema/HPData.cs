// Decompiled with JetBrains decompiler
// Type: staq.SaveSchema.HPData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using FlatBuffers;
using Il2CppDummyDll;

#nullable disable
namespace staq.SaveSchema
{
  [Token(Token = "0x2003C8E")]
  public struct HPData : IFlatbufferObject
  {
    [Token(Token = "0x4010BED")]
    [FieldOffset(Offset = "0x0")]
    private Table __p;

    [Token(Token = "0x17004E7C")]
    public ByteBuffer ByteBuffer
    {
      [Token(Token = "0x6018089"), Address(RVA = "0x3B1C824", Offset = "0x3B1C824", VA = "0x3B1C824", Slot = "4")] get
      {
        return (ByteBuffer) null;
      }
    }

    [Token(Token = "0x601808A")]
    [Address(RVA = "0x3B1C82C", Offset = "0x3B1C82C", VA = "0x3B1C82C")]
    public static HPData GetRootAsHPData(ByteBuffer _bb) => new HPData();

    [Token(Token = "0x601808B")]
    [Address(RVA = "0x3B1C838", Offset = "0x3B1C838", VA = "0x3B1C838")]
    public static HPData GetRootAsHPData(ByteBuffer _bb, HPData obj) => new HPData();

    [Token(Token = "0x601808C")]
    [Address(RVA = "0x3B1C894", Offset = "0x3B1C894", VA = "0x3B1C894", Slot = "5")]
    public void __init(int _i, ByteBuffer _bb)
    {
    }

    [Token(Token = "0x601808D")]
    [Address(RVA = "0x3B1C87C", Offset = "0x3B1C87C", VA = "0x3B1C87C")]
    public HPData __assign(int _i, ByteBuffer _bb) => new HPData();

    [Token(Token = "0x17004E7D")]
    public int Current
    {
      [Token(Token = "0x601808E"), Address(RVA = "0x3B1C8A0", Offset = "0x3B1C8A0", VA = "0x3B1C8A0")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17004E7E")]
    public int Max
    {
      [Token(Token = "0x601808F"), Address(RVA = "0x3B1C8E4", Offset = "0x3B1C8E4", VA = "0x3B1C8E4")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17004E7F")]
    public int BaseHp
    {
      [Token(Token = "0x6018090"), Address(RVA = "0x3B1C928", Offset = "0x3B1C928", VA = "0x3B1C928")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x6018091")]
    [Address(RVA = "0x3B1C96C", Offset = "0x3B1C96C", VA = "0x3B1C96C")]
    public static Offset<HPData> CreateHPData(
      FlatBufferBuilder builder,
      int current = 0,
      int max = 0,
      int baseHp = 0)
    {
      return new Offset<HPData>();
    }

    [Token(Token = "0x6018092")]
    [Address(RVA = "0x3B1CA8C", Offset = "0x3B1CA8C", VA = "0x3B1CA8C")]
    public static void StartHPData(FlatBufferBuilder builder)
    {
    }

    [Token(Token = "0x6018093")]
    [Address(RVA = "0x3B1CA1C", Offset = "0x3B1CA1C", VA = "0x3B1CA1C")]
    public static void AddCurrent(FlatBufferBuilder builder, int current)
    {
    }

    [Token(Token = "0x6018094")]
    [Address(RVA = "0x3B1C9FC", Offset = "0x3B1C9FC", VA = "0x3B1C9FC")]
    public static void AddMax(FlatBufferBuilder builder, int max)
    {
    }

    [Token(Token = "0x6018095")]
    [Address(RVA = "0x3B1C9DC", Offset = "0x3B1C9DC", VA = "0x3B1C9DC")]
    public static void AddBaseHp(FlatBufferBuilder builder, int baseHp)
    {
    }

    [Token(Token = "0x6018096")]
    [Address(RVA = "0x3B1CA3C", Offset = "0x3B1CA3C", VA = "0x3B1CA3C")]
    public static Offset<HPData> EndHPData(FlatBufferBuilder builder) => new Offset<HPData>();
  }
}
