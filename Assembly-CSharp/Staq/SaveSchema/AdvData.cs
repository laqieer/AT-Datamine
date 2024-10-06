// Decompiled with JetBrains decompiler
// Type: staq.SaveSchema.AdvData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using FlatBuffers;
using Il2CppDummyDll;

#nullable disable
namespace staq.SaveSchema
{
  [Token(Token = "0x2003C61")]
  public struct AdvData : IFlatbufferObject
  {
    [Token(Token = "0x4010BC0")]
    [FieldOffset(Offset = "0x0")]
    private Table __p;

    [Token(Token = "0x17004D4A")]
    public ByteBuffer ByteBuffer
    {
      [Token(Token = "0x6017BBD"), Address(RVA = "0x37B57C4", Offset = "0x37B57C4", VA = "0x37B57C4", Slot = "4")] get
      {
        return (ByteBuffer) null;
      }
    }

    [Token(Token = "0x6017BBE")]
    [Address(RVA = "0x37B57CC", Offset = "0x37B57CC", VA = "0x37B57CC")]
    public static AdvData GetRootAsAdvData(ByteBuffer _bb) => new AdvData();

    [Token(Token = "0x6017BBF")]
    [Address(RVA = "0x37B57D8", Offset = "0x37B57D8", VA = "0x37B57D8")]
    public static AdvData GetRootAsAdvData(ByteBuffer _bb, AdvData obj) => new AdvData();

    [Token(Token = "0x6017BC0")]
    [Address(RVA = "0x37B5834", Offset = "0x37B5834", VA = "0x37B5834", Slot = "5")]
    public void __init(int _i, ByteBuffer _bb)
    {
    }

    [Token(Token = "0x6017BC1")]
    [Address(RVA = "0x37B581C", Offset = "0x37B581C", VA = "0x37B581C")]
    public AdvData __assign(int _i, ByteBuffer _bb) => new AdvData();

    [Token(Token = "0x17004D4B")]
    public int AdvId
    {
      [Token(Token = "0x6017BC2"), Address(RVA = "0x37B5840", Offset = "0x37B5840", VA = "0x37B5840")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17004D4C")]
    public bool Play
    {
      [Token(Token = "0x6017BC3"), Address(RVA = "0x37B5884", Offset = "0x37B5884", VA = "0x37B5884")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x6017BC4")]
    [Address(RVA = "0x37B58CC", Offset = "0x37B58CC", VA = "0x37B58CC")]
    public static Offset<AdvData> CreateAdvData(FlatBufferBuilder builder, int adv_id = 0, bool play = false)
    {
      return new Offset<AdvData>();
    }

    [Token(Token = "0x6017BC5")]
    [Address(RVA = "0x37B59B4", Offset = "0x37B59B4", VA = "0x37B59B4")]
    public static void StartAdvData(FlatBufferBuilder builder)
    {
    }

    [Token(Token = "0x6017BC6")]
    [Address(RVA = "0x37B5924", Offset = "0x37B5924", VA = "0x37B5924")]
    public static void AddAdvId(FlatBufferBuilder builder, int advId)
    {
    }

    [Token(Token = "0x6017BC7")]
    [Address(RVA = "0x37B5944", Offset = "0x37B5944", VA = "0x37B5944")]
    public static void AddPlay(FlatBufferBuilder builder, bool play)
    {
    }

    [Token(Token = "0x6017BC8")]
    [Address(RVA = "0x37B5964", Offset = "0x37B5964", VA = "0x37B5964")]
    public static Offset<AdvData> EndAdvData(FlatBufferBuilder builder) => new Offset<AdvData>();
  }
}
