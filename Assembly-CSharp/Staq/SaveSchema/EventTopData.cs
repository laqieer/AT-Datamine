// Decompiled with JetBrains decompiler
// Type: staq.SaveSchema.EventTopData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using FlatBuffers;
using Il2CppDummyDll;

#nullable disable
namespace staq.SaveSchema
{
  [Token(Token = "0x2003CA6")]
  public struct EventTopData : IFlatbufferObject
  {
    [Token(Token = "0x4010C05")]
    [FieldOffset(Offset = "0x0")]
    private Table __p;

    [Token(Token = "0x17004F20")]
    public ByteBuffer ByteBuffer
    {
      [Token(Token = "0x60182F0"), Address(RVA = "0x26D3718", Offset = "0x26D3718", VA = "0x26D3718", Slot = "4")] get
      {
        return (ByteBuffer) null;
      }
    }

    [Token(Token = "0x60182F1")]
    [Address(RVA = "0x26D3720", Offset = "0x26D3720", VA = "0x26D3720")]
    public static EventTopData GetRootAsEventTopData(ByteBuffer _bb) => new EventTopData();

    [Token(Token = "0x60182F2")]
    [Address(RVA = "0x26D372C", Offset = "0x26D372C", VA = "0x26D372C")]
    public static EventTopData GetRootAsEventTopData(ByteBuffer _bb, EventTopData obj)
    {
      return new EventTopData();
    }

    [Token(Token = "0x60182F3")]
    [Address(RVA = "0x26D3788", Offset = "0x26D3788", VA = "0x26D3788")]
    public static bool EventTopDataBufferHasIdentifier(ByteBuffer _bb) => new bool();

    [Token(Token = "0x60182F4")]
    [Address(RVA = "0x26D37D4", Offset = "0x26D37D4", VA = "0x26D37D4", Slot = "5")]
    public void __init(int _i, ByteBuffer _bb)
    {
    }

    [Token(Token = "0x60182F5")]
    [Address(RVA = "0x26D3770", Offset = "0x26D3770", VA = "0x26D3770")]
    public EventTopData __assign(int _i, ByteBuffer _bb) => new EventTopData();

    [Token(Token = "0x60182F6")]
    [Address(RVA = "0x26D37E0", Offset = "0x26D37E0", VA = "0x26D37E0")]
    public EventTop? EventDataList(int j) => new EventTop?();

    [Token(Token = "0x17004F21")]
    public int EventDataListLength
    {
      [Token(Token = "0x60182F7"), Address(RVA = "0x26D3894", Offset = "0x26D3894", VA = "0x26D3894")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x60182F8")]
    [Address(RVA = "0x26D38C8", Offset = "0x26D38C8", VA = "0x26D38C8")]
    public static Offset<EventTopData> CreateEventTopData(
      FlatBufferBuilder builder,
      VectorOffset event_data_listOffset = default (VectorOffset))
    {
      return new Offset<EventTopData>();
    }

    [Token(Token = "0x60182F9")]
    [Address(RVA = "0x26D3980", Offset = "0x26D3980", VA = "0x26D3980")]
    public static void StartEventTopData(FlatBufferBuilder builder)
    {
    }

    [Token(Token = "0x60182FA")]
    [Address(RVA = "0x26D3910", Offset = "0x26D3910", VA = "0x26D3910")]
    public static void AddEventDataList(FlatBufferBuilder builder, VectorOffset eventDataListOffset)
    {
    }

    [Token(Token = "0x60182FB")]
    [Address(RVA = "0x26D3998", Offset = "0x26D3998", VA = "0x26D3998")]
    public static VectorOffset CreateEventDataListVector(
      FlatBufferBuilder builder,
      Offset<EventTop>[] data)
    {
      return new VectorOffset();
    }

    [Token(Token = "0x60182FC")]
    [Address(RVA = "0x26D3A40", Offset = "0x26D3A40", VA = "0x26D3A40")]
    public static VectorOffset CreateEventDataListVectorBlock(
      FlatBufferBuilder builder,
      Offset<EventTop>[] data)
    {
      return new VectorOffset();
    }

    [Token(Token = "0x60182FD")]
    [Address(RVA = "0x26D3AC8", Offset = "0x26D3AC8", VA = "0x26D3AC8")]
    public static void StartEventDataListVector(FlatBufferBuilder builder, int numElems)
    {
    }

    [Token(Token = "0x60182FE")]
    [Address(RVA = "0x26D3930", Offset = "0x26D3930", VA = "0x26D3930")]
    public static Offset<EventTopData> EndEventTopData(FlatBufferBuilder builder)
    {
      return new Offset<EventTopData>();
    }

    [Token(Token = "0x60182FF")]
    [Address(RVA = "0x26D3AE8", Offset = "0x26D3AE8", VA = "0x26D3AE8")]
    public static void FinishEventTopDataBuffer(
      FlatBufferBuilder builder,
      Offset<EventTopData> offset)
    {
    }

    [Token(Token = "0x6018300")]
    [Address(RVA = "0x26D3B44", Offset = "0x26D3B44", VA = "0x26D3B44")]
    public static void FinishSizePrefixedEventTopDataBuffer(
      FlatBufferBuilder builder,
      Offset<EventTopData> offset)
    {
    }
  }
}
