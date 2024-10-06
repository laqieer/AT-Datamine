// Decompiled with JetBrains decompiler
// Type: staq.SaveSchema.ContentData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using FlatBuffers;
using Il2CppDummyDll;

#nullable disable
namespace staq.SaveSchema
{
  [Token(Token = "0x2003CD7")]
  public struct ContentData : IFlatbufferObject
  {
    [Token(Token = "0x4010C38")]
    [FieldOffset(Offset = "0x0")]
    private Table __p;

    [Token(Token = "0x17004FB9")]
    public ByteBuffer ByteBuffer
    {
      [Token(Token = "0x601864F"), Address(RVA = "0x26E02AC", Offset = "0x26E02AC", VA = "0x26E02AC", Slot = "4")] get
      {
        return (ByteBuffer) null;
      }
    }

    [Token(Token = "0x6018650")]
    [Address(RVA = "0x26E02B4", Offset = "0x26E02B4", VA = "0x26E02B4")]
    public static ContentData GetRootAsContentData(ByteBuffer _bb) => new ContentData();

    [Token(Token = "0x6018651")]
    [Address(RVA = "0x26E02C0", Offset = "0x26E02C0", VA = "0x26E02C0")]
    public static ContentData GetRootAsContentData(ByteBuffer _bb, ContentData obj)
    {
      return new ContentData();
    }

    [Token(Token = "0x6018652")]
    [Address(RVA = "0x26E031C", Offset = "0x26E031C", VA = "0x26E031C", Slot = "5")]
    public void __init(int _i, ByteBuffer _bb)
    {
    }

    [Token(Token = "0x6018653")]
    [Address(RVA = "0x26E0304", Offset = "0x26E0304", VA = "0x26E0304")]
    public ContentData __assign(int _i, ByteBuffer _bb) => new ContentData();

    [Token(Token = "0x17004FBA")]
    public int ContentId
    {
      [Token(Token = "0x6018654"), Address(RVA = "0x26E0328", Offset = "0x26E0328", VA = "0x26E0328")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17004FBB")]
    public int Amount
    {
      [Token(Token = "0x6018655"), Address(RVA = "0x26E036C", Offset = "0x26E036C", VA = "0x26E036C")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x6018656")]
    [Address(RVA = "0x26E03B0", Offset = "0x26E03B0", VA = "0x26E03B0")]
    public static Offset<ContentData> CreateContentData(
      FlatBufferBuilder builder,
      int content_id = 0,
      int amount = 0)
    {
      return new Offset<ContentData>();
    }

    [Token(Token = "0x6018657")]
    [Address(RVA = "0x26E0498", Offset = "0x26E0498", VA = "0x26E0498")]
    public static void StartContentData(FlatBufferBuilder builder)
    {
    }

    [Token(Token = "0x6018658")]
    [Address(RVA = "0x26E0428", Offset = "0x26E0428", VA = "0x26E0428")]
    public static void AddContentId(FlatBufferBuilder builder, int contentId)
    {
    }

    [Token(Token = "0x6018659")]
    [Address(RVA = "0x26E0408", Offset = "0x26E0408", VA = "0x26E0408")]
    public static void AddAmount(FlatBufferBuilder builder, int amount)
    {
    }

    [Token(Token = "0x601865A")]
    [Address(RVA = "0x26E0448", Offset = "0x26E0448", VA = "0x26E0448")]
    public static Offset<ContentData> EndContentData(FlatBufferBuilder builder)
    {
      return new Offset<ContentData>();
    }
  }
}
