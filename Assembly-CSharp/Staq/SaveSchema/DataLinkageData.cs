// Decompiled with JetBrains decompiler
// Type: staq.SaveSchema.DataLinkageData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using FlatBuffers;
using Il2CppDummyDll;

#nullable disable
namespace staq.SaveSchema
{
  [Token(Token = "0x2003CA1")]
  public struct DataLinkageData : IFlatbufferObject
  {
    [Token(Token = "0x4010C00")]
    [FieldOffset(Offset = "0x0")]
    private Table __p;

    [Token(Token = "0x17004EF7")]
    public ByteBuffer ByteBuffer
    {
      [Token(Token = "0x6018272"), Address(RVA = "0x3B23ED0", Offset = "0x3B23ED0", VA = "0x3B23ED0", Slot = "4")] get
      {
        return (ByteBuffer) null;
      }
    }

    [Token(Token = "0x6018273")]
    [Address(RVA = "0x3B23ED8", Offset = "0x3B23ED8", VA = "0x3B23ED8")]
    public static DataLinkageData GetRootAsDataLinkageData(ByteBuffer _bb) => new DataLinkageData();

    [Token(Token = "0x6018274")]
    [Address(RVA = "0x3B23EE4", Offset = "0x3B23EE4", VA = "0x3B23EE4")]
    public static DataLinkageData GetRootAsDataLinkageData(ByteBuffer _bb, DataLinkageData obj)
    {
      return new DataLinkageData();
    }

    [Token(Token = "0x6018275")]
    [Address(RVA = "0x3B23F40", Offset = "0x3B23F40", VA = "0x3B23F40")]
    public static bool DataLinkageDataBufferHasIdentifier(ByteBuffer _bb) => new bool();

    [Token(Token = "0x6018276")]
    [Address(RVA = "0x3B23F8C", Offset = "0x3B23F8C", VA = "0x3B23F8C", Slot = "5")]
    public void __init(int _i, ByteBuffer _bb)
    {
    }

    [Token(Token = "0x6018277")]
    [Address(RVA = "0x3B23F28", Offset = "0x3B23F28", VA = "0x3B23F28")]
    public DataLinkageData __assign(int _i, ByteBuffer _bb) => new DataLinkageData();

    [Token(Token = "0x17004EF8")]
    public int DataLinkageNoteStatus
    {
      [Token(Token = "0x6018278"), Address(RVA = "0x3B23F98", Offset = "0x3B23F98", VA = "0x3B23F98")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x6018279")]
    [Address(RVA = "0x3B23FDC", Offset = "0x3B23FDC", VA = "0x3B23FDC")]
    public static Offset<DataLinkageData> CreateDataLinkageData(
      FlatBufferBuilder builder,
      int data_linkage_note_status = 0)
    {
      return new Offset<DataLinkageData>();
    }

    [Token(Token = "0x601827A")]
    [Address(RVA = "0x3B24094", Offset = "0x3B24094", VA = "0x3B24094")]
    public static void StartDataLinkageData(FlatBufferBuilder builder)
    {
    }

    [Token(Token = "0x601827B")]
    [Address(RVA = "0x3B24024", Offset = "0x3B24024", VA = "0x3B24024")]
    public static void AddDataLinkageNoteStatus(
      FlatBufferBuilder builder,
      int dataLinkageNoteStatus)
    {
    }

    [Token(Token = "0x601827C")]
    [Address(RVA = "0x3B24044", Offset = "0x3B24044", VA = "0x3B24044")]
    public static Offset<DataLinkageData> EndDataLinkageData(FlatBufferBuilder builder)
    {
      return new Offset<DataLinkageData>();
    }

    [Token(Token = "0x601827D")]
    [Address(RVA = "0x3B240AC", Offset = "0x3B240AC", VA = "0x3B240AC")]
    public static void FinishDataLinkageDataBuffer(
      FlatBufferBuilder builder,
      Offset<DataLinkageData> offset)
    {
    }

    [Token(Token = "0x601827E")]
    [Address(RVA = "0x3B24108", Offset = "0x3B24108", VA = "0x3B24108")]
    public static void FinishSizePrefixedDataLinkageDataBuffer(
      FlatBufferBuilder builder,
      Offset<DataLinkageData> offset)
    {
    }
  }
}
