// Decompiled with JetBrains decompiler
// Type: staq.SaveSchema.Log
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using FlatBuffers;
using Il2CppDummyDll;
using System;

#nullable disable
namespace staq.SaveSchema
{
  [Token(Token = "0x2003C9E")]
  public struct Log : IFlatbufferObject
  {
    [Token(Token = "0x4010BFD")]
    [FieldOffset(Offset = "0x0")]
    private Table __p;

    [Token(Token = "0x17004EEE")]
    public ByteBuffer ByteBuffer
    {
      [Token(Token = "0x6018240"), Address(RVA = "0x3B233C0", Offset = "0x3B233C0", VA = "0x3B233C0", Slot = "4")] get
      {
        return (ByteBuffer) null;
      }
    }

    [Token(Token = "0x6018241")]
    [Address(RVA = "0x3B233C8", Offset = "0x3B233C8", VA = "0x3B233C8")]
    public static Log GetRootAsLog(ByteBuffer _bb) => new Log();

    [Token(Token = "0x6018242")]
    [Address(RVA = "0x3B233D4", Offset = "0x3B233D4", VA = "0x3B233D4")]
    public static Log GetRootAsLog(ByteBuffer _bb, Log obj) => new Log();

    [Token(Token = "0x6018243")]
    [Address(RVA = "0x3B23430", Offset = "0x3B23430", VA = "0x3B23430", Slot = "5")]
    public void __init(int _i, ByteBuffer _bb)
    {
    }

    [Token(Token = "0x6018244")]
    [Address(RVA = "0x3B23418", Offset = "0x3B23418", VA = "0x3B23418")]
    public Log __assign(int _i, ByteBuffer _bb) => new Log();

    [Token(Token = "0x17004EEF")]
    public string ChatContent
    {
      [Token(Token = "0x6018245"), Address(RVA = "0x3B2343C", Offset = "0x3B2343C", VA = "0x3B2343C")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x6018246")]
    [Address(RVA = "0x3B23478", Offset = "0x3B23478", VA = "0x3B23478")]
    public ArraySegment<byte>? GetChatContentBytes() => new ArraySegment<byte>?();

    [Token(Token = "0x6018247")]
    [Address(RVA = "0x3B234B0", Offset = "0x3B234B0", VA = "0x3B234B0")]
    public byte[] GetChatContentArray() => (byte[]) null;

    [Token(Token = "0x17004EF0")]
    public int ChatType
    {
      [Token(Token = "0x6018248"), Address(RVA = "0x3B234FC", Offset = "0x3B234FC", VA = "0x3B234FC")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17004EF1")]
    public string ChatMessageID
    {
      [Token(Token = "0x6018249"), Address(RVA = "0x3B23540", Offset = "0x3B23540", VA = "0x3B23540")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x601824A")]
    [Address(RVA = "0x3B2357C", Offset = "0x3B2357C", VA = "0x3B2357C")]
    public ArraySegment<byte>? GetChatMessageIDBytes() => new ArraySegment<byte>?();

    [Token(Token = "0x601824B")]
    [Address(RVA = "0x3B235B4", Offset = "0x3B235B4", VA = "0x3B235B4")]
    public byte[] GetChatMessageIDArray() => (byte[]) null;

    [Token(Token = "0x601824C")]
    [Address(RVA = "0x3B23600", Offset = "0x3B23600", VA = "0x3B23600")]
    public static Offset<Log> CreateLog(
      FlatBufferBuilder builder,
      StringOffset chat_contentOffset = default (StringOffset),
      int chat_type = 0,
      StringOffset chat_messageIDOffset = default (StringOffset))
    {
      return new Offset<Log>();
    }

    [Token(Token = "0x601824D")]
    [Address(RVA = "0x3B23720", Offset = "0x3B23720", VA = "0x3B23720")]
    public static void StartLog(FlatBufferBuilder builder)
    {
    }

    [Token(Token = "0x601824E")]
    [Address(RVA = "0x3B236B0", Offset = "0x3B236B0", VA = "0x3B236B0")]
    public static void AddChatContent(FlatBufferBuilder builder, StringOffset chatContentOffset)
    {
    }

    [Token(Token = "0x601824F")]
    [Address(RVA = "0x3B23690", Offset = "0x3B23690", VA = "0x3B23690")]
    public static void AddChatType(FlatBufferBuilder builder, int chatType)
    {
    }

    [Token(Token = "0x6018250")]
    [Address(RVA = "0x3B23670", Offset = "0x3B23670", VA = "0x3B23670")]
    public static void AddChatMessageID(FlatBufferBuilder builder, StringOffset chatMessageIDOffset)
    {
    }

    [Token(Token = "0x6018251")]
    [Address(RVA = "0x3B236D0", Offset = "0x3B236D0", VA = "0x3B236D0")]
    public static Offset<Log> EndLog(FlatBufferBuilder builder) => new Offset<Log>();
  }
}
