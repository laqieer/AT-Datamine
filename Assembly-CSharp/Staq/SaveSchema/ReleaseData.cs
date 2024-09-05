// Decompiled with JetBrains decompiler
// Type: staq.SaveSchema.ReleaseData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using FlatBuffers;
using Il2CppDummyDll;

#nullable disable
namespace staq.SaveSchema
{
  [Token(Token = "0x2003C5F")]
  public struct ReleaseData : IFlatbufferObject
  {
    [Token(Token = "0x4010BBE")]
    [FieldOffset(Offset = "0x0")]
    private Table __p;

    [Token(Token = "0x17004D45")]
    public ByteBuffer ByteBuffer
    {
      [Token(Token = "0x6017BA0"), Address(RVA = "0x37B5138", Offset = "0x37B5138", VA = "0x37B5138", Slot = "4")] get
      {
        return (ByteBuffer) null;
      }
    }

    [Token(Token = "0x6017BA1")]
    [Address(RVA = "0x37B5140", Offset = "0x37B5140", VA = "0x37B5140")]
    public static ReleaseData GetRootAsReleaseData(ByteBuffer _bb) => new ReleaseData();

    [Token(Token = "0x6017BA2")]
    [Address(RVA = "0x37B514C", Offset = "0x37B514C", VA = "0x37B514C")]
    public static ReleaseData GetRootAsReleaseData(ByteBuffer _bb, ReleaseData obj)
    {
      return new ReleaseData();
    }

    [Token(Token = "0x6017BA3")]
    [Address(RVA = "0x37B51A8", Offset = "0x37B51A8", VA = "0x37B51A8", Slot = "5")]
    public void __init(int _i, ByteBuffer _bb)
    {
    }

    [Token(Token = "0x6017BA4")]
    [Address(RVA = "0x37B5190", Offset = "0x37B5190", VA = "0x37B5190")]
    public ReleaseData __assign(int _i, ByteBuffer _bb) => new ReleaseData();

    [Token(Token = "0x17004D46")]
    public int StyleId
    {
      [Token(Token = "0x6017BA5"), Address(RVA = "0x37B51B4", Offset = "0x37B51B4", VA = "0x37B51B4")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17004D47")]
    public int BoardId
    {
      [Token(Token = "0x6017BA6"), Address(RVA = "0x37B51F8", Offset = "0x37B51F8", VA = "0x37B51F8")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x6017BA7")]
    [Address(RVA = "0x37B523C", Offset = "0x37B523C", VA = "0x37B523C")]
    public static Offset<ReleaseData> CreateReleaseData(
      FlatBufferBuilder builder,
      int style_id = 0,
      int board_id = 0)
    {
      return new Offset<ReleaseData>();
    }

    [Token(Token = "0x6017BA8")]
    [Address(RVA = "0x37B5324", Offset = "0x37B5324", VA = "0x37B5324")]
    public static void StartReleaseData(FlatBufferBuilder builder)
    {
    }

    [Token(Token = "0x6017BA9")]
    [Address(RVA = "0x37B52B4", Offset = "0x37B52B4", VA = "0x37B52B4")]
    public static void AddStyleId(FlatBufferBuilder builder, int styleId)
    {
    }

    [Token(Token = "0x6017BAA")]
    [Address(RVA = "0x37B5294", Offset = "0x37B5294", VA = "0x37B5294")]
    public static void AddBoardId(FlatBufferBuilder builder, int boardId)
    {
    }

    [Token(Token = "0x6017BAB")]
    [Address(RVA = "0x37B52D4", Offset = "0x37B52D4", VA = "0x37B52D4")]
    public static Offset<ReleaseData> EndReleaseData(FlatBufferBuilder builder)
    {
      return new Offset<ReleaseData>();
    }
  }
}
