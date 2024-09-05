// Decompiled with JetBrains decompiler
// Type: staq.SaveSchema.ChatGuideline
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using FlatBuffers;
using Il2CppDummyDll;
using System;

#nullable disable
namespace staq.SaveSchema
{
  [Token(Token = "0x2003C9D")]
  public struct ChatGuideline : IFlatbufferObject
  {
    [Token(Token = "0x4010BFC")]
    [FieldOffset(Offset = "0x0")]
    private Table __p;

    [Token(Token = "0x17004EEB")]
    public ByteBuffer ByteBuffer
    {
      [Token(Token = "0x601822F"), Address(RVA = "0x3B23038", Offset = "0x3B23038", VA = "0x3B23038", Slot = "4")] get
      {
        return (ByteBuffer) null;
      }
    }

    [Token(Token = "0x6018230")]
    [Address(RVA = "0x3B23040", Offset = "0x3B23040", VA = "0x3B23040")]
    public static ChatGuideline GetRootAsChatGuideline(ByteBuffer _bb) => new ChatGuideline();

    [Token(Token = "0x6018231")]
    [Address(RVA = "0x3B2304C", Offset = "0x3B2304C", VA = "0x3B2304C")]
    public static ChatGuideline GetRootAsChatGuideline(ByteBuffer _bb, ChatGuideline obj)
    {
      return new ChatGuideline();
    }

    [Token(Token = "0x6018232")]
    [Address(RVA = "0x3B230A8", Offset = "0x3B230A8", VA = "0x3B230A8")]
    public static bool ChatGuidelineBufferHasIdentifier(ByteBuffer _bb) => new bool();

    [Token(Token = "0x6018233")]
    [Address(RVA = "0x3B230F4", Offset = "0x3B230F4", VA = "0x3B230F4", Slot = "5")]
    public void __init(int _i, ByteBuffer _bb)
    {
    }

    [Token(Token = "0x6018234")]
    [Address(RVA = "0x3B23090", Offset = "0x3B23090", VA = "0x3B23090")]
    public ChatGuideline __assign(int _i, ByteBuffer _bb) => new ChatGuideline();

    [Token(Token = "0x17004EEC")]
    public bool ChatGuidelineState
    {
      [Token(Token = "0x6018235"), Address(RVA = "0x3B23100", Offset = "0x3B23100", VA = "0x3B23100")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17004EED")]
    public string ChatGuidelineVersion
    {
      [Token(Token = "0x6018236"), Address(RVA = "0x3B23148", Offset = "0x3B23148", VA = "0x3B23148")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x6018237")]
    [Address(RVA = "0x3B23184", Offset = "0x3B23184", VA = "0x3B23184")]
    public ArraySegment<byte>? GetChatGuidelineVersionBytes() => new ArraySegment<byte>?();

    [Token(Token = "0x6018238")]
    [Address(RVA = "0x3B231BC", Offset = "0x3B231BC", VA = "0x3B231BC")]
    public byte[] GetChatGuidelineVersionArray() => (byte[]) null;

    [Token(Token = "0x6018239")]
    [Address(RVA = "0x3B23208", Offset = "0x3B23208", VA = "0x3B23208")]
    public static Offset<ChatGuideline> CreateChatGuideline(
      FlatBufferBuilder builder,
      bool chat_guideline_state = false,
      StringOffset chat_guideline_versionOffset = default (StringOffset))
    {
      return new Offset<ChatGuideline>();
    }

    [Token(Token = "0x601823A")]
    [Address(RVA = "0x3B232F0", Offset = "0x3B232F0", VA = "0x3B232F0")]
    public static void StartChatGuideline(FlatBufferBuilder builder)
    {
    }

    [Token(Token = "0x601823B")]
    [Address(RVA = "0x3B23280", Offset = "0x3B23280", VA = "0x3B23280")]
    public static void AddChatGuidelineState(FlatBufferBuilder builder, bool chatGuidelineState)
    {
    }

    [Token(Token = "0x601823C")]
    [Address(RVA = "0x3B23260", Offset = "0x3B23260", VA = "0x3B23260")]
    public static void AddChatGuidelineVersion(
      FlatBufferBuilder builder,
      StringOffset chatGuidelineVersionOffset)
    {
    }

    [Token(Token = "0x601823D")]
    [Address(RVA = "0x3B232A0", Offset = "0x3B232A0", VA = "0x3B232A0")]
    public static Offset<ChatGuideline> EndChatGuideline(FlatBufferBuilder builder)
    {
      return new Offset<ChatGuideline>();
    }

    [Token(Token = "0x601823E")]
    [Address(RVA = "0x3B23308", Offset = "0x3B23308", VA = "0x3B23308")]
    public static void FinishChatGuidelineBuffer(
      FlatBufferBuilder builder,
      Offset<ChatGuideline> offset)
    {
    }

    [Token(Token = "0x601823F")]
    [Address(RVA = "0x3B23364", Offset = "0x3B23364", VA = "0x3B23364")]
    public static void FinishSizePrefixedChatGuidelineBuffer(
      FlatBufferBuilder builder,
      Offset<ChatGuideline> offset)
    {
    }
  }
}
