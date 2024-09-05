// Decompiled with JetBrains decompiler
// Type: staq.SaveSchema.PlayEvent
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using FlatBuffers;
using Il2CppDummyDll;

#nullable disable
namespace staq.SaveSchema
{
  [Token(Token = "0x2003CC0")]
  public struct PlayEvent : IFlatbufferObject
  {
    [Token(Token = "0x4010C1E")]
    [FieldOffset(Offset = "0x0")]
    private Table __p;

    [Token(Token = "0x17004F67")]
    public ByteBuffer ByteBuffer
    {
      [Token(Token = "0x601848C"), Address(RVA = "0x26D96AC", Offset = "0x26D96AC", VA = "0x26D96AC", Slot = "4")] get
      {
        return (ByteBuffer) null;
      }
    }

    [Token(Token = "0x601848D")]
    [Address(RVA = "0x26D96B4", Offset = "0x26D96B4", VA = "0x26D96B4")]
    public static PlayEvent GetRootAsPlayEvent(ByteBuffer _bb) => new PlayEvent();

    [Token(Token = "0x601848E")]
    [Address(RVA = "0x26D96C0", Offset = "0x26D96C0", VA = "0x26D96C0")]
    public static PlayEvent GetRootAsPlayEvent(ByteBuffer _bb, PlayEvent obj) => new PlayEvent();

    [Token(Token = "0x601848F")]
    [Address(RVA = "0x26D971C", Offset = "0x26D971C", VA = "0x26D971C", Slot = "5")]
    public void __init(int _i, ByteBuffer _bb)
    {
    }

    [Token(Token = "0x6018490")]
    [Address(RVA = "0x26D9704", Offset = "0x26D9704", VA = "0x26D9704")]
    public PlayEvent __assign(int _i, ByteBuffer _bb) => new PlayEvent();

    [Token(Token = "0x17004F68")]
    public int TableId
    {
      [Token(Token = "0x6018491"), Address(RVA = "0x26D9728", Offset = "0x26D9728", VA = "0x26D9728")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17004F69")]
    public long PlayDate
    {
      [Token(Token = "0x6018492"), Address(RVA = "0x26D976C", Offset = "0x26D976C", VA = "0x26D976C")] get
      {
        return new long();
      }
    }

    [Token(Token = "0x6018493")]
    [Address(RVA = "0x26D97B4", Offset = "0x26D97B4", VA = "0x26D97B4")]
    public static Offset<PlayEvent> CreatePlayEvent(
      FlatBufferBuilder builder,
      int table_id = 0,
      long play_date = 0)
    {
      return new Offset<PlayEvent>();
    }

    [Token(Token = "0x6018494")]
    [Address(RVA = "0x26D989C", Offset = "0x26D989C", VA = "0x26D989C")]
    public static void StartPlayEvent(FlatBufferBuilder builder)
    {
    }

    [Token(Token = "0x6018495")]
    [Address(RVA = "0x26D982C", Offset = "0x26D982C", VA = "0x26D982C")]
    public static void AddTableId(FlatBufferBuilder builder, int tableId)
    {
    }

    [Token(Token = "0x6018496")]
    [Address(RVA = "0x26D980C", Offset = "0x26D980C", VA = "0x26D980C")]
    public static void AddPlayDate(FlatBufferBuilder builder, long playDate)
    {
    }

    [Token(Token = "0x6018497")]
    [Address(RVA = "0x26D984C", Offset = "0x26D984C", VA = "0x26D984C")]
    public static Offset<PlayEvent> EndPlayEvent(FlatBufferBuilder builder)
    {
      return new Offset<PlayEvent>();
    }
  }
}
