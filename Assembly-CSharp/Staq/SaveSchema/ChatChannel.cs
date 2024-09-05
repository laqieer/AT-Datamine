// Decompiled with JetBrains decompiler
// Type: staq.SaveSchema.ChatChannel
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using FlatBuffers;
using Il2CppDummyDll;

#nullable disable
namespace staq.SaveSchema
{
  [Token(Token = "0x2003C9C")]
  public struct ChatChannel : IFlatbufferObject
  {
    [Token(Token = "0x4010BFB")]
    [FieldOffset(Offset = "0x0")]
    private Table __p;

    [Token(Token = "0x17004EE8")]
    public ByteBuffer ByteBuffer
    {
      [Token(Token = "0x6018220"), Address(RVA = "0x3B22D30", Offset = "0x3B22D30", VA = "0x3B22D30", Slot = "4")] get
      {
        return (ByteBuffer) null;
      }
    }

    [Token(Token = "0x6018221")]
    [Address(RVA = "0x3B22D38", Offset = "0x3B22D38", VA = "0x3B22D38")]
    public static ChatChannel GetRootAsChatChannel(ByteBuffer _bb) => new ChatChannel();

    [Token(Token = "0x6018222")]
    [Address(RVA = "0x3B22D44", Offset = "0x3B22D44", VA = "0x3B22D44")]
    public static ChatChannel GetRootAsChatChannel(ByteBuffer _bb, ChatChannel obj)
    {
      return new ChatChannel();
    }

    [Token(Token = "0x6018223")]
    [Address(RVA = "0x3B22DA0", Offset = "0x3B22DA0", VA = "0x3B22DA0")]
    public static bool ChatChannelBufferHasIdentifier(ByteBuffer _bb) => new bool();

    [Token(Token = "0x6018224")]
    [Address(RVA = "0x3B22DEC", Offset = "0x3B22DEC", VA = "0x3B22DEC", Slot = "5")]
    public void __init(int _i, ByteBuffer _bb)
    {
    }

    [Token(Token = "0x6018225")]
    [Address(RVA = "0x3B22D88", Offset = "0x3B22D88", VA = "0x3B22D88")]
    public ChatChannel __assign(int _i, ByteBuffer _bb) => new ChatChannel();

    [Token(Token = "0x17004EE9")]
    public int ChatChannelCategory
    {
      [Token(Token = "0x6018226"), Address(RVA = "0x3B22DF8", Offset = "0x3B22DF8", VA = "0x3B22DF8")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17004EEA")]
    public int ChatSimpleChannelCategory
    {
      [Token(Token = "0x6018227"), Address(RVA = "0x3B22E3C", Offset = "0x3B22E3C", VA = "0x3B22E3C")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x6018228")]
    [Address(RVA = "0x3B22E80", Offset = "0x3B22E80", VA = "0x3B22E80")]
    public static Offset<ChatChannel> CreateChatChannel(
      FlatBufferBuilder builder,
      int chat_channel_category = 0,
      int chat_simple_channel_category = 0)
    {
      return new Offset<ChatChannel>();
    }

    [Token(Token = "0x6018229")]
    [Address(RVA = "0x3B22F68", Offset = "0x3B22F68", VA = "0x3B22F68")]
    public static void StartChatChannel(FlatBufferBuilder builder)
    {
    }

    [Token(Token = "0x601822A")]
    [Address(RVA = "0x3B22EF8", Offset = "0x3B22EF8", VA = "0x3B22EF8")]
    public static void AddChatChannelCategory(FlatBufferBuilder builder, int chatChannelCategory)
    {
    }

    [Token(Token = "0x601822B")]
    [Address(RVA = "0x3B22ED8", Offset = "0x3B22ED8", VA = "0x3B22ED8")]
    public static void AddChatSimpleChannelCategory(
      FlatBufferBuilder builder,
      int chatSimpleChannelCategory)
    {
    }

    [Token(Token = "0x601822C")]
    [Address(RVA = "0x3B22F18", Offset = "0x3B22F18", VA = "0x3B22F18")]
    public static Offset<ChatChannel> EndChatChannel(FlatBufferBuilder builder)
    {
      return new Offset<ChatChannel>();
    }

    [Token(Token = "0x601822D")]
    [Address(RVA = "0x3B22F80", Offset = "0x3B22F80", VA = "0x3B22F80")]
    public static void FinishChatChannelBuffer(
      FlatBufferBuilder builder,
      Offset<ChatChannel> offset)
    {
    }

    [Token(Token = "0x601822E")]
    [Address(RVA = "0x3B22FDC", Offset = "0x3B22FDC", VA = "0x3B22FDC")]
    public static void FinishSizePrefixedChatChannelBuffer(
      FlatBufferBuilder builder,
      Offset<ChatChannel> offset)
    {
    }
  }
}
