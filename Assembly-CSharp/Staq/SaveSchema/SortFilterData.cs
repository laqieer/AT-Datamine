// Decompiled with JetBrains decompiler
// Type: staq.SaveSchema.SortFilterData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using FlatBuffers;
using Il2CppDummyDll;

#nullable disable
namespace staq.SaveSchema
{
  [Token(Token = "0x2003CDE")]
  public struct SortFilterData : IFlatbufferObject
  {
    [Token(Token = "0x4010C3F")]
    [FieldOffset(Offset = "0x0")]
    private Table __p;

    [Token(Token = "0x17004FD4")]
    public ByteBuffer ByteBuffer
    {
      [Token(Token = "0x60186D3"), Address(RVA = "0x26E253C", Offset = "0x26E253C", VA = "0x26E253C", Slot = "4")] get
      {
        return (ByteBuffer) null;
      }
    }

    [Token(Token = "0x60186D4")]
    [Address(RVA = "0x26E2544", Offset = "0x26E2544", VA = "0x26E2544")]
    public static SortFilterData GetRootAsSortFilterData(ByteBuffer _bb) => new SortFilterData();

    [Token(Token = "0x60186D5")]
    [Address(RVA = "0x26E2550", Offset = "0x26E2550", VA = "0x26E2550")]
    public static SortFilterData GetRootAsSortFilterData(ByteBuffer _bb, SortFilterData obj)
    {
      return new SortFilterData();
    }

    [Token(Token = "0x60186D6")]
    [Address(RVA = "0x26E2594", Offset = "0x26E2594", VA = "0x26E2594", Slot = "5")]
    public void __init(int _i, ByteBuffer _bb)
    {
    }

    [Token(Token = "0x60186D7")]
    [Address(RVA = "0x26E1C78", Offset = "0x26E1C78", VA = "0x26E1C78")]
    public SortFilterData __assign(int _i, ByteBuffer _bb) => new SortFilterData();

    [Token(Token = "0x17004FD5")]
    public int SortCondition
    {
      [Token(Token = "0x60186D8"), Address(RVA = "0x26E25A0", Offset = "0x26E25A0", VA = "0x26E25A0")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17004FD6")]
    public bool SortOrder
    {
      [Token(Token = "0x60186D9"), Address(RVA = "0x26E25E4", Offset = "0x26E25E4", VA = "0x26E25E4")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17004FD7")]
    public bool SortEquip
    {
      [Token(Token = "0x60186DA"), Address(RVA = "0x26E262C", Offset = "0x26E262C", VA = "0x26E262C")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x60186DB")]
    [Address(RVA = "0x26E2674", Offset = "0x26E2674", VA = "0x26E2674")]
    public FilterData? FilterDatas(int j) => new FilterData?();

    [Token(Token = "0x17004FD8")]
    public int FilterDatasLength
    {
      [Token(Token = "0x60186DC"), Address(RVA = "0x26E2740", Offset = "0x26E2740", VA = "0x26E2740")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x60186DD")]
    [Address(RVA = "0x26E2774", Offset = "0x26E2774", VA = "0x26E2774")]
    public static Offset<SortFilterData> CreateSortFilterData(
      FlatBufferBuilder builder,
      int sort_condition = 0,
      bool sort_order = false,
      bool sort_equip = false,
      VectorOffset filter_datasOffset = default (VectorOffset))
    {
      return new Offset<SortFilterData>();
    }

    [Token(Token = "0x60186DE")]
    [Address(RVA = "0x26E28C4", Offset = "0x26E28C4", VA = "0x26E28C4")]
    public static void StartSortFilterData(FlatBufferBuilder builder)
    {
    }

    [Token(Token = "0x60186DF")]
    [Address(RVA = "0x26E2814", Offset = "0x26E2814", VA = "0x26E2814")]
    public static void AddSortCondition(FlatBufferBuilder builder, int sortCondition)
    {
    }

    [Token(Token = "0x60186E0")]
    [Address(RVA = "0x26E2854", Offset = "0x26E2854", VA = "0x26E2854")]
    public static void AddSortOrder(FlatBufferBuilder builder, bool sortOrder)
    {
    }

    [Token(Token = "0x60186E1")]
    [Address(RVA = "0x26E2834", Offset = "0x26E2834", VA = "0x26E2834")]
    public static void AddSortEquip(FlatBufferBuilder builder, bool sortEquip)
    {
    }

    [Token(Token = "0x60186E2")]
    [Address(RVA = "0x26E27F4", Offset = "0x26E27F4", VA = "0x26E27F4")]
    public static void AddFilterDatas(FlatBufferBuilder builder, VectorOffset filterDatasOffset)
    {
    }

    [Token(Token = "0x60186E3")]
    [Address(RVA = "0x26E28DC", Offset = "0x26E28DC", VA = "0x26E28DC")]
    public static VectorOffset CreateFilterDatasVector(
      FlatBufferBuilder builder,
      Offset<FilterData>[] data)
    {
      return new VectorOffset();
    }

    [Token(Token = "0x60186E4")]
    [Address(RVA = "0x26E2984", Offset = "0x26E2984", VA = "0x26E2984")]
    public static VectorOffset CreateFilterDatasVectorBlock(
      FlatBufferBuilder builder,
      Offset<FilterData>[] data)
    {
      return new VectorOffset();
    }

    [Token(Token = "0x60186E5")]
    [Address(RVA = "0x26E2A0C", Offset = "0x26E2A0C", VA = "0x26E2A0C")]
    public static void StartFilterDatasVector(FlatBufferBuilder builder, int numElems)
    {
    }

    [Token(Token = "0x60186E6")]
    [Address(RVA = "0x26E2874", Offset = "0x26E2874", VA = "0x26E2874")]
    public static Offset<SortFilterData> EndSortFilterData(FlatBufferBuilder builder)
    {
      return new Offset<SortFilterData>();
    }
  }
}
