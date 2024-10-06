// Decompiled with JetBrains decompiler
// Type: staq.SaveSchema.AdvTutorialReaded
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using FlatBuffers;
using Il2CppDummyDll;

#nullable disable
namespace staq.SaveSchema
{
  [Token(Token = "0x2003C63")]
  public struct AdvTutorialReaded : IFlatbufferObject
  {
    [Token(Token = "0x4010BC2")]
    [FieldOffset(Offset = "0x0")]
    private Table __p;

    [Token(Token = "0x17004D4F")]
    public ByteBuffer ByteBuffer
    {
      [Token(Token = "0x6017BD7"), Address(RVA = "0x37B5D50", Offset = "0x37B5D50", VA = "0x37B5D50", Slot = "4")] get
      {
        return (ByteBuffer) null;
      }
    }

    [Token(Token = "0x6017BD8")]
    [Address(RVA = "0x37B5D58", Offset = "0x37B5D58", VA = "0x37B5D58")]
    public static AdvTutorialReaded GetRootAsAdvTutorialReaded(ByteBuffer _bb)
    {
      return new AdvTutorialReaded();
    }

    [Token(Token = "0x6017BD9")]
    [Address(RVA = "0x37B5D64", Offset = "0x37B5D64", VA = "0x37B5D64")]
    public static AdvTutorialReaded GetRootAsAdvTutorialReaded(
      ByteBuffer _bb,
      AdvTutorialReaded obj)
    {
      return new AdvTutorialReaded();
    }

    [Token(Token = "0x6017BDA")]
    [Address(RVA = "0x37B5DC0", Offset = "0x37B5DC0", VA = "0x37B5DC0")]
    public static bool AdvTutorialReadedBufferHasIdentifier(ByteBuffer _bb) => new bool();

    [Token(Token = "0x6017BDB")]
    [Address(RVA = "0x37B5E0C", Offset = "0x37B5E0C", VA = "0x37B5E0C", Slot = "5")]
    public void __init(int _i, ByteBuffer _bb)
    {
    }

    [Token(Token = "0x6017BDC")]
    [Address(RVA = "0x37B5DA8", Offset = "0x37B5DA8", VA = "0x37B5DA8")]
    public AdvTutorialReaded __assign(int _i, ByteBuffer _bb) => new AdvTutorialReaded();

    [Token(Token = "0x17004D50")]
    public bool ReadedBackHome
    {
      [Token(Token = "0x6017BDD"), Address(RVA = "0x37B5E18", Offset = "0x37B5E18", VA = "0x37B5E18")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x6017BDE")]
    [Address(RVA = "0x37B5E60", Offset = "0x37B5E60", VA = "0x37B5E60")]
    public static Offset<AdvTutorialReaded> CreateAdvTutorialReaded(
      FlatBufferBuilder builder,
      bool readed_back_home = false)
    {
      return new Offset<AdvTutorialReaded>();
    }

    [Token(Token = "0x6017BDF")]
    [Address(RVA = "0x37B5F18", Offset = "0x37B5F18", VA = "0x37B5F18")]
    public static void StartAdvTutorialReaded(FlatBufferBuilder builder)
    {
    }

    [Token(Token = "0x6017BE0")]
    [Address(RVA = "0x37B5EA8", Offset = "0x37B5EA8", VA = "0x37B5EA8")]
    public static void AddReadedBackHome(FlatBufferBuilder builder, bool readedBackHome)
    {
    }

    [Token(Token = "0x6017BE1")]
    [Address(RVA = "0x37B5EC8", Offset = "0x37B5EC8", VA = "0x37B5EC8")]
    public static Offset<AdvTutorialReaded> EndAdvTutorialReaded(FlatBufferBuilder builder)
    {
      return new Offset<AdvTutorialReaded>();
    }

    [Token(Token = "0x6017BE2")]
    [Address(RVA = "0x37B5F30", Offset = "0x37B5F30", VA = "0x37B5F30")]
    public static void FinishAdvTutorialReadedBuffer(
      FlatBufferBuilder builder,
      Offset<AdvTutorialReaded> offset)
    {
    }

    [Token(Token = "0x6017BE3")]
    [Address(RVA = "0x37B5F8C", Offset = "0x37B5F8C", VA = "0x37B5F8C")]
    public static void FinishSizePrefixedAdvTutorialReadedBuffer(
      FlatBufferBuilder builder,
      Offset<AdvTutorialReaded> offset)
    {
    }
  }
}
