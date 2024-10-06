// Decompiled with JetBrains decompiler
// Type: staq.SaveSchema.URLSchemeParameterDetail
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using FlatBuffers;
using Il2CppDummyDll;
using System;

#nullable disable
namespace staq.SaveSchema
{
  [Token(Token = "0x2003CE8")]
  public struct URLSchemeParameterDetail : IFlatbufferObject
  {
    [Token(Token = "0x4010C49")]
    [FieldOffset(Offset = "0x0")]
    private Table __p;

    [Token(Token = "0x17004FF8")]
    public ByteBuffer ByteBuffer
    {
      [Token(Token = "0x601878D"), Address(RVA = "0x2936F48", Offset = "0x2936F48", VA = "0x2936F48", Slot = "4")] get
      {
        return (ByteBuffer) null;
      }
    }

    [Token(Token = "0x601878E")]
    [Address(RVA = "0x2936F50", Offset = "0x2936F50", VA = "0x2936F50")]
    public static URLSchemeParameterDetail GetRootAsURLSchemeParameterDetail(ByteBuffer _bb)
    {
      return new URLSchemeParameterDetail();
    }

    [Token(Token = "0x601878F")]
    [Address(RVA = "0x2936F5C", Offset = "0x2936F5C", VA = "0x2936F5C")]
    public static URLSchemeParameterDetail GetRootAsURLSchemeParameterDetail(
      ByteBuffer _bb,
      URLSchemeParameterDetail obj)
    {
      return new URLSchemeParameterDetail();
    }

    [Token(Token = "0x6018790")]
    [Address(RVA = "0x2936FB8", Offset = "0x2936FB8", VA = "0x2936FB8", Slot = "5")]
    public void __init(int _i, ByteBuffer _bb)
    {
    }

    [Token(Token = "0x6018791")]
    [Address(RVA = "0x2936FA0", Offset = "0x2936FA0", VA = "0x2936FA0")]
    public URLSchemeParameterDetail __assign(int _i, ByteBuffer _bb)
    {
      return new URLSchemeParameterDetail();
    }

    [Token(Token = "0x17004FF9")]
    public string Url
    {
      [Token(Token = "0x6018792"), Address(RVA = "0x2936FC4", Offset = "0x2936FC4", VA = "0x2936FC4")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x6018793")]
    [Address(RVA = "0x2937000", Offset = "0x2937000", VA = "0x2937000")]
    public ArraySegment<byte>? GetUrlBytes() => new ArraySegment<byte>?();

    [Token(Token = "0x6018794")]
    [Address(RVA = "0x2937038", Offset = "0x2937038", VA = "0x2937038")]
    public byte[] GetUrlArray() => (byte[]) null;

    [Token(Token = "0x6018795")]
    [Address(RVA = "0x2937084", Offset = "0x2937084", VA = "0x2937084")]
    public static Offset<URLSchemeParameterDetail> CreateURLSchemeParameterDetail(
      FlatBufferBuilder builder,
      StringOffset urlOffset = default (StringOffset))
    {
      return new Offset<URLSchemeParameterDetail>();
    }

    [Token(Token = "0x6018796")]
    [Address(RVA = "0x293713C", Offset = "0x293713C", VA = "0x293713C")]
    public static void StartURLSchemeParameterDetail(FlatBufferBuilder builder)
    {
    }

    [Token(Token = "0x6018797")]
    [Address(RVA = "0x29370CC", Offset = "0x29370CC", VA = "0x29370CC")]
    public static void AddUrl(FlatBufferBuilder builder, StringOffset urlOffset)
    {
    }

    [Token(Token = "0x6018798")]
    [Address(RVA = "0x29370EC", Offset = "0x29370EC", VA = "0x29370EC")]
    public static Offset<URLSchemeParameterDetail> EndURLSchemeParameterDetail(
      FlatBufferBuilder builder)
    {
      return new Offset<URLSchemeParameterDetail>();
    }
  }
}
