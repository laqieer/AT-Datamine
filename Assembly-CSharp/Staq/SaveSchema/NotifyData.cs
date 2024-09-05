// Decompiled with JetBrains decompiler
// Type: staq.SaveSchema.NotifyData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using FlatBuffers;
using Il2CppDummyDll;

#nullable disable
namespace staq.SaveSchema
{
  [Token(Token = "0x2003CAB")]
  public struct NotifyData : IFlatbufferObject
  {
    [Token(Token = "0x4010C09")]
    [FieldOffset(Offset = "0x0")]
    private Table __p;

    [Token(Token = "0x17004F28")]
    public ByteBuffer ByteBuffer
    {
      [Token(Token = "0x601832F"), Address(RVA = "0x26D4568", Offset = "0x26D4568", VA = "0x26D4568", Slot = "4")] get
      {
        return (ByteBuffer) null;
      }
    }

    [Token(Token = "0x6018330")]
    [Address(RVA = "0x26D4570", Offset = "0x26D4570", VA = "0x26D4570")]
    public static NotifyData GetRootAsNotifyData(ByteBuffer _bb) => new NotifyData();

    [Token(Token = "0x6018331")]
    [Address(RVA = "0x26D457C", Offset = "0x26D457C", VA = "0x26D457C")]
    public static NotifyData GetRootAsNotifyData(ByteBuffer _bb, NotifyData obj)
    {
      return new NotifyData();
    }

    [Token(Token = "0x6018332")]
    [Address(RVA = "0x26D45D8", Offset = "0x26D45D8", VA = "0x26D45D8", Slot = "5")]
    public void __init(int _i, ByteBuffer _bb)
    {
    }

    [Token(Token = "0x6018333")]
    [Address(RVA = "0x26D45C0", Offset = "0x26D45C0", VA = "0x26D45C0")]
    public NotifyData __assign(int _i, ByteBuffer _bb) => new NotifyData();

    [Token(Token = "0x17004F29")]
    public int Type
    {
      [Token(Token = "0x6018334"), Address(RVA = "0x26D45E4", Offset = "0x26D45E4", VA = "0x26D45E4")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17004F2A")]
    public int CapterId
    {
      [Token(Token = "0x6018335"), Address(RVA = "0x26D4628", Offset = "0x26D4628", VA = "0x26D4628")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17004F2B")]
    public int Id
    {
      [Token(Token = "0x6018336"), Address(RVA = "0x26D466C", Offset = "0x26D466C", VA = "0x26D466C")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x6018337")]
    [Address(RVA = "0x26D46B0", Offset = "0x26D46B0", VA = "0x26D46B0")]
    public static Offset<NotifyData> CreateNotifyData(
      FlatBufferBuilder builder,
      int type = 0,
      int capter_id = 0,
      int id = 0)
    {
      return new Offset<NotifyData>();
    }

    [Token(Token = "0x6018338")]
    [Address(RVA = "0x26D47D0", Offset = "0x26D47D0", VA = "0x26D47D0")]
    public static void StartNotifyData(FlatBufferBuilder builder)
    {
    }

    [Token(Token = "0x6018339")]
    [Address(RVA = "0x26D4760", Offset = "0x26D4760", VA = "0x26D4760")]
    public static void AddType(FlatBufferBuilder builder, int type)
    {
    }

    [Token(Token = "0x601833A")]
    [Address(RVA = "0x26D4740", Offset = "0x26D4740", VA = "0x26D4740")]
    public static void AddCapterId(FlatBufferBuilder builder, int capterId)
    {
    }

    [Token(Token = "0x601833B")]
    [Address(RVA = "0x26D4720", Offset = "0x26D4720", VA = "0x26D4720")]
    public static void AddId(FlatBufferBuilder builder, int id)
    {
    }

    [Token(Token = "0x601833C")]
    [Address(RVA = "0x26D4780", Offset = "0x26D4780", VA = "0x26D4780")]
    public static Offset<NotifyData> EndNotifyData(FlatBufferBuilder builder)
    {
      return new Offset<NotifyData>();
    }
  }
}
