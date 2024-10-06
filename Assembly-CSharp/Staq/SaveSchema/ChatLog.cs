// Decompiled with JetBrains decompiler
// Type: staq.SaveSchema.ChatLog
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using FlatBuffers;
using Il2CppDummyDll;

#nullable disable
namespace staq.SaveSchema
{
  [Token(Token = "0x2003C9F")]
  public struct ChatLog : IFlatbufferObject
  {
    [Token(Token = "0x4010BFE")]
    [FieldOffset(Offset = "0x0")]
    private Table __p;

    [Token(Token = "0x17004EF2")]
    public ByteBuffer ByteBuffer
    {
      [Token(Token = "0x6018252"), Address(RVA = "0x3B23738", Offset = "0x3B23738", VA = "0x3B23738", Slot = "4")] get
      {
        return (ByteBuffer) null;
      }
    }

    [Token(Token = "0x6018253")]
    [Address(RVA = "0x3B23740", Offset = "0x3B23740", VA = "0x3B23740")]
    public static ChatLog GetRootAsChatLog(ByteBuffer _bb) => new ChatLog();

    [Token(Token = "0x6018254")]
    [Address(RVA = "0x3B2374C", Offset = "0x3B2374C", VA = "0x3B2374C")]
    public static ChatLog GetRootAsChatLog(ByteBuffer _bb, ChatLog obj) => new ChatLog();

    [Token(Token = "0x6018255")]
    [Address(RVA = "0x3B237A8", Offset = "0x3B237A8", VA = "0x3B237A8")]
    public static bool ChatLogBufferHasIdentifier(ByteBuffer _bb) => new bool();

    [Token(Token = "0x6018256")]
    [Address(RVA = "0x3B237F4", Offset = "0x3B237F4", VA = "0x3B237F4", Slot = "5")]
    public void __init(int _i, ByteBuffer _bb)
    {
    }

    [Token(Token = "0x6018257")]
    [Address(RVA = "0x3B23790", Offset = "0x3B23790", VA = "0x3B23790")]
    public ChatLog __assign(int _i, ByteBuffer _bb) => new ChatLog();

    [Token(Token = "0x6018258")]
    [Address(RVA = "0x3B23800", Offset = "0x3B23800", VA = "0x3B23800")]
    public Log? ChatLogs(int j) => new Log?();

    [Token(Token = "0x17004EF3")]
    public int ChatLogsLength
    {
      [Token(Token = "0x6018259"), Address(RVA = "0x3B238B4", Offset = "0x3B238B4", VA = "0x3B238B4")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x601825A")]
    [Address(RVA = "0x3B238E8", Offset = "0x3B238E8", VA = "0x3B238E8")]
    public static Offset<ChatLog> CreateChatLog(
      FlatBufferBuilder builder,
      VectorOffset chat_logsOffset = default (VectorOffset))
    {
      return new Offset<ChatLog>();
    }

    [Token(Token = "0x601825B")]
    [Address(RVA = "0x3B239A0", Offset = "0x3B239A0", VA = "0x3B239A0")]
    public static void StartChatLog(FlatBufferBuilder builder)
    {
    }

    [Token(Token = "0x601825C")]
    [Address(RVA = "0x3B23930", Offset = "0x3B23930", VA = "0x3B23930")]
    public static void AddChatLogs(FlatBufferBuilder builder, VectorOffset chatLogsOffset)
    {
    }

    [Token(Token = "0x601825D")]
    [Address(RVA = "0x3B239B8", Offset = "0x3B239B8", VA = "0x3B239B8")]
    public static VectorOffset CreateChatLogsVector(FlatBufferBuilder builder, Offset<Log>[] data)
    {
      return new VectorOffset();
    }

    [Token(Token = "0x601825E")]
    [Address(RVA = "0x3B23A60", Offset = "0x3B23A60", VA = "0x3B23A60")]
    public static VectorOffset CreateChatLogsVectorBlock(
      FlatBufferBuilder builder,
      Offset<Log>[] data)
    {
      return new VectorOffset();
    }

    [Token(Token = "0x601825F")]
    [Address(RVA = "0x3B23AE8", Offset = "0x3B23AE8", VA = "0x3B23AE8")]
    public static void StartChatLogsVector(FlatBufferBuilder builder, int numElems)
    {
    }

    [Token(Token = "0x6018260")]
    [Address(RVA = "0x3B23950", Offset = "0x3B23950", VA = "0x3B23950")]
    public static Offset<ChatLog> EndChatLog(FlatBufferBuilder builder) => new Offset<ChatLog>();

    [Token(Token = "0x6018261")]
    [Address(RVA = "0x3B23B08", Offset = "0x3B23B08", VA = "0x3B23B08")]
    public static void FinishChatLogBuffer(FlatBufferBuilder builder, Offset<ChatLog> offset)
    {
    }

    [Token(Token = "0x6018262")]
    [Address(RVA = "0x3B23B64", Offset = "0x3B23B64", VA = "0x3B23B64")]
    public static void FinishSizePrefixedChatLogBuffer(
      FlatBufferBuilder builder,
      Offset<ChatLog> offset)
    {
    }
  }
}
