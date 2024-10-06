// Decompiled with JetBrains decompiler
// Type: staq.SaveSchema.ChatSetting
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using FlatBuffers;
using Il2CppDummyDll;

#nullable disable
namespace staq.SaveSchema
{
  [Token(Token = "0x2003CA0")]
  public struct ChatSetting : IFlatbufferObject
  {
    [Token(Token = "0x4010BFF")]
    [FieldOffset(Offset = "0x0")]
    private Table __p;

    [Token(Token = "0x17004EF4")]
    public ByteBuffer ByteBuffer
    {
      [Token(Token = "0x6018263"), Address(RVA = "0x3B23BC0", Offset = "0x3B23BC0", VA = "0x3B23BC0", Slot = "4")] get
      {
        return (ByteBuffer) null;
      }
    }

    [Token(Token = "0x6018264")]
    [Address(RVA = "0x3B23BC8", Offset = "0x3B23BC8", VA = "0x3B23BC8")]
    public static ChatSetting GetRootAsChatSetting(ByteBuffer _bb) => new ChatSetting();

    [Token(Token = "0x6018265")]
    [Address(RVA = "0x3B23BD4", Offset = "0x3B23BD4", VA = "0x3B23BD4")]
    public static ChatSetting GetRootAsChatSetting(ByteBuffer _bb, ChatSetting obj)
    {
      return new ChatSetting();
    }

    [Token(Token = "0x6018266")]
    [Address(RVA = "0x3B23C30", Offset = "0x3B23C30", VA = "0x3B23C30")]
    public static bool ChatSettingBufferHasIdentifier(ByteBuffer _bb) => new bool();

    [Token(Token = "0x6018267")]
    [Address(RVA = "0x3B23C7C", Offset = "0x3B23C7C", VA = "0x3B23C7C", Slot = "5")]
    public void __init(int _i, ByteBuffer _bb)
    {
    }

    [Token(Token = "0x6018268")]
    [Address(RVA = "0x3B23C18", Offset = "0x3B23C18", VA = "0x3B23C18")]
    public ChatSetting __assign(int _i, ByteBuffer _bb) => new ChatSetting();

    [Token(Token = "0x17004EF5")]
    public bool SimpleMessage
    {
      [Token(Token = "0x6018269"), Address(RVA = "0x3B23C88", Offset = "0x3B23C88", VA = "0x3B23C88")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17004EF6")]
    public bool GuildNewbadge
    {
      [Token(Token = "0x601826A"), Address(RVA = "0x3B23CD0", Offset = "0x3B23CD0", VA = "0x3B23CD0")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x601826B")]
    [Address(RVA = "0x3B23D18", Offset = "0x3B23D18", VA = "0x3B23D18")]
    public static Offset<ChatSetting> CreateChatSetting(
      FlatBufferBuilder builder,
      bool simple_message = false,
      bool guild_newbadge = false)
    {
      return new Offset<ChatSetting>();
    }

    [Token(Token = "0x601826C")]
    [Address(RVA = "0x3B23E00", Offset = "0x3B23E00", VA = "0x3B23E00")]
    public static void StartChatSetting(FlatBufferBuilder builder)
    {
    }

    [Token(Token = "0x601826D")]
    [Address(RVA = "0x3B23D90", Offset = "0x3B23D90", VA = "0x3B23D90")]
    public static void AddSimpleMessage(FlatBufferBuilder builder, bool simpleMessage)
    {
    }

    [Token(Token = "0x601826E")]
    [Address(RVA = "0x3B23D70", Offset = "0x3B23D70", VA = "0x3B23D70")]
    public static void AddGuildNewbadge(FlatBufferBuilder builder, bool guildNewbadge)
    {
    }

    [Token(Token = "0x601826F")]
    [Address(RVA = "0x3B23DB0", Offset = "0x3B23DB0", VA = "0x3B23DB0")]
    public static Offset<ChatSetting> EndChatSetting(FlatBufferBuilder builder)
    {
      return new Offset<ChatSetting>();
    }

    [Token(Token = "0x6018270")]
    [Address(RVA = "0x3B23E18", Offset = "0x3B23E18", VA = "0x3B23E18")]
    public static void FinishChatSettingBuffer(
      FlatBufferBuilder builder,
      Offset<ChatSetting> offset)
    {
    }

    [Token(Token = "0x6018271")]
    [Address(RVA = "0x3B23E74", Offset = "0x3B23E74", VA = "0x3B23E74")]
    public static void FinishSizePrefixedChatSettingBuffer(
      FlatBufferBuilder builder,
      Offset<ChatSetting> offset)
    {
    }
  }
}
