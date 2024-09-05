// Decompiled with JetBrains decompiler
// Type: staq.SaveSchema.CalendarData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using FlatBuffers;
using Il2CppDummyDll;
using System;

#nullable disable
namespace staq.SaveSchema
{
  [Token(Token = "0x2003C98")]
  public struct CalendarData : IFlatbufferObject
  {
    [Token(Token = "0x4010BF7")]
    [FieldOffset(Offset = "0x0")]
    private Table __p;

    [Token(Token = "0x17004ED8")]
    public ByteBuffer ByteBuffer
    {
      [Token(Token = "0x60181C9"), Address(RVA = "0x3B217C8", Offset = "0x3B217C8", VA = "0x3B217C8", Slot = "4")] get
      {
        return (ByteBuffer) null;
      }
    }

    [Token(Token = "0x60181CA")]
    [Address(RVA = "0x3B217D0", Offset = "0x3B217D0", VA = "0x3B217D0")]
    public static CalendarData GetRootAsCalendarData(ByteBuffer _bb) => new CalendarData();

    [Token(Token = "0x60181CB")]
    [Address(RVA = "0x3B217DC", Offset = "0x3B217DC", VA = "0x3B217DC")]
    public static CalendarData GetRootAsCalendarData(ByteBuffer _bb, CalendarData obj)
    {
      return new CalendarData();
    }

    [Token(Token = "0x60181CC")]
    [Address(RVA = "0x3B21838", Offset = "0x3B21838", VA = "0x3B21838")]
    public static bool CalendarDataBufferHasIdentifier(ByteBuffer _bb) => new bool();

    [Token(Token = "0x60181CD")]
    [Address(RVA = "0x3B21884", Offset = "0x3B21884", VA = "0x3B21884", Slot = "5")]
    public void __init(int _i, ByteBuffer _bb)
    {
    }

    [Token(Token = "0x60181CE")]
    [Address(RVA = "0x3B21820", Offset = "0x3B21820", VA = "0x3B21820")]
    public CalendarData __assign(int _i, ByteBuffer _bb) => new CalendarData();

    [Token(Token = "0x17004ED9")]
    public int CalendarId
    {
      [Token(Token = "0x60181CF"), Address(RVA = "0x3B21890", Offset = "0x3B21890", VA = "0x3B21890")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x60181D0")]
    [Address(RVA = "0x3B218D4", Offset = "0x3B218D4", VA = "0x3B218D4")]
    public int CalendarDirectingId(int j) => new int();

    [Token(Token = "0x17004EDA")]
    public int CalendarDirectingIdLength
    {
      [Token(Token = "0x60181D1"), Address(RVA = "0x3B21934", Offset = "0x3B21934", VA = "0x3B21934")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x60181D2")]
    [Address(RVA = "0x3B21968", Offset = "0x3B21968", VA = "0x3B21968")]
    public ArraySegment<byte>? GetCalendarDirectingIdBytes() => new ArraySegment<byte>?();

    [Token(Token = "0x60181D3")]
    [Address(RVA = "0x3B219A0", Offset = "0x3B219A0", VA = "0x3B219A0")]
    public int[] GetCalendarDirectingIdArray() => (int[]) null;

    [Token(Token = "0x60181D4")]
    [Address(RVA = "0x3B219EC", Offset = "0x3B219EC", VA = "0x3B219EC")]
    public static Offset<CalendarData> CreateCalendarData(
      FlatBufferBuilder builder,
      int calendar_id = 0,
      VectorOffset calendar_directing_idOffset = default (VectorOffset))
    {
      return new Offset<CalendarData>();
    }

    [Token(Token = "0x60181D5")]
    [Address(RVA = "0x3B21AD4", Offset = "0x3B21AD4", VA = "0x3B21AD4")]
    public static void StartCalendarData(FlatBufferBuilder builder)
    {
    }

    [Token(Token = "0x60181D6")]
    [Address(RVA = "0x3B21A64", Offset = "0x3B21A64", VA = "0x3B21A64")]
    public static void AddCalendarId(FlatBufferBuilder builder, int calendarId)
    {
    }

    [Token(Token = "0x60181D7")]
    [Address(RVA = "0x3B21A44", Offset = "0x3B21A44", VA = "0x3B21A44")]
    public static void AddCalendarDirectingId(
      FlatBufferBuilder builder,
      VectorOffset calendarDirectingIdOffset)
    {
    }

    [Token(Token = "0x60181D8")]
    [Address(RVA = "0x3B21AEC", Offset = "0x3B21AEC", VA = "0x3B21AEC")]
    public static VectorOffset CreateCalendarDirectingIdVector(
      FlatBufferBuilder builder,
      int[] data)
    {
      return new VectorOffset();
    }

    [Token(Token = "0x60181D9")]
    [Address(RVA = "0x3B21B94", Offset = "0x3B21B94", VA = "0x3B21B94")]
    public static VectorOffset CreateCalendarDirectingIdVectorBlock(
      FlatBufferBuilder builder,
      int[] data)
    {
      return new VectorOffset();
    }

    [Token(Token = "0x60181DA")]
    [Address(RVA = "0x3B21C1C", Offset = "0x3B21C1C", VA = "0x3B21C1C")]
    public static void StartCalendarDirectingIdVector(FlatBufferBuilder builder, int numElems)
    {
    }

    [Token(Token = "0x60181DB")]
    [Address(RVA = "0x3B21A84", Offset = "0x3B21A84", VA = "0x3B21A84")]
    public static Offset<CalendarData> EndCalendarData(FlatBufferBuilder builder)
    {
      return new Offset<CalendarData>();
    }

    [Token(Token = "0x60181DC")]
    [Address(RVA = "0x3B21C3C", Offset = "0x3B21C3C", VA = "0x3B21C3C")]
    public static void FinishCalendarDataBuffer(
      FlatBufferBuilder builder,
      Offset<CalendarData> offset)
    {
    }

    [Token(Token = "0x60181DD")]
    [Address(RVA = "0x3B21C98", Offset = "0x3B21C98", VA = "0x3B21C98")]
    public static void FinishSizePrefixedCalendarDataBuffer(
      FlatBufferBuilder builder,
      Offset<CalendarData> offset)
    {
    }
  }
}
