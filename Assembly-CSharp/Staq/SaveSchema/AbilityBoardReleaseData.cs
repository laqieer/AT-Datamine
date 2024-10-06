// Decompiled with JetBrains decompiler
// Type: staq.SaveSchema.AbilityBoardReleaseData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using FlatBuffers;
using Il2CppDummyDll;

#nullable disable
namespace staq.SaveSchema
{
  [Token(Token = "0x2003C60")]
  public struct AbilityBoardReleaseData : IFlatbufferObject
  {
    [Token(Token = "0x4010BBF")]
    [FieldOffset(Offset = "0x0")]
    private Table __p;

    [Token(Token = "0x17004D48")]
    public ByteBuffer ByteBuffer
    {
      [Token(Token = "0x6017BAC"), Address(RVA = "0x37B533C", Offset = "0x37B533C", VA = "0x37B533C", Slot = "4")] get
      {
        return (ByteBuffer) null;
      }
    }

    [Token(Token = "0x6017BAD")]
    [Address(RVA = "0x37B5344", Offset = "0x37B5344", VA = "0x37B5344")]
    public static AbilityBoardReleaseData GetRootAsAbilityBoardReleaseData(ByteBuffer _bb)
    {
      return new AbilityBoardReleaseData();
    }

    [Token(Token = "0x6017BAE")]
    [Address(RVA = "0x37B5350", Offset = "0x37B5350", VA = "0x37B5350")]
    public static AbilityBoardReleaseData GetRootAsAbilityBoardReleaseData(
      ByteBuffer _bb,
      AbilityBoardReleaseData obj)
    {
      return new AbilityBoardReleaseData();
    }

    [Token(Token = "0x6017BAF")]
    [Address(RVA = "0x37B53AC", Offset = "0x37B53AC", VA = "0x37B53AC")]
    public static bool AbilityBoardReleaseDataBufferHasIdentifier(ByteBuffer _bb) => new bool();

    [Token(Token = "0x6017BB0")]
    [Address(RVA = "0x37B53F8", Offset = "0x37B53F8", VA = "0x37B53F8", Slot = "5")]
    public void __init(int _i, ByteBuffer _bb)
    {
    }

    [Token(Token = "0x6017BB1")]
    [Address(RVA = "0x37B5394", Offset = "0x37B5394", VA = "0x37B5394")]
    public AbilityBoardReleaseData __assign(int _i, ByteBuffer _bb)
    {
      return new AbilityBoardReleaseData();
    }

    [Token(Token = "0x6017BB2")]
    [Address(RVA = "0x37B5404", Offset = "0x37B5404", VA = "0x37B5404")]
    public ReleaseData? ReleaseDataList(int j) => new ReleaseData?();

    [Token(Token = "0x17004D49")]
    public int ReleaseDataListLength
    {
      [Token(Token = "0x6017BB3"), Address(RVA = "0x37B54B8", Offset = "0x37B54B8", VA = "0x37B54B8")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x6017BB4")]
    [Address(RVA = "0x37B54EC", Offset = "0x37B54EC", VA = "0x37B54EC")]
    public static Offset<AbilityBoardReleaseData> CreateAbilityBoardReleaseData(
      FlatBufferBuilder builder,
      VectorOffset release_data_listOffset = default (VectorOffset))
    {
      return new Offset<AbilityBoardReleaseData>();
    }

    [Token(Token = "0x6017BB5")]
    [Address(RVA = "0x37B55A4", Offset = "0x37B55A4", VA = "0x37B55A4")]
    public static void StartAbilityBoardReleaseData(FlatBufferBuilder builder)
    {
    }

    [Token(Token = "0x6017BB6")]
    [Address(RVA = "0x37B5534", Offset = "0x37B5534", VA = "0x37B5534")]
    public static void AddReleaseDataList(
      FlatBufferBuilder builder,
      VectorOffset releaseDataListOffset)
    {
    }

    [Token(Token = "0x6017BB7")]
    [Address(RVA = "0x37B55BC", Offset = "0x37B55BC", VA = "0x37B55BC")]
    public static VectorOffset CreateReleaseDataListVector(
      FlatBufferBuilder builder,
      Offset<ReleaseData>[] data)
    {
      return new VectorOffset();
    }

    [Token(Token = "0x6017BB8")]
    [Address(RVA = "0x37B5664", Offset = "0x37B5664", VA = "0x37B5664")]
    public static VectorOffset CreateReleaseDataListVectorBlock(
      FlatBufferBuilder builder,
      Offset<ReleaseData>[] data)
    {
      return new VectorOffset();
    }

    [Token(Token = "0x6017BB9")]
    [Address(RVA = "0x37B56EC", Offset = "0x37B56EC", VA = "0x37B56EC")]
    public static void StartReleaseDataListVector(FlatBufferBuilder builder, int numElems)
    {
    }

    [Token(Token = "0x6017BBA")]
    [Address(RVA = "0x37B5554", Offset = "0x37B5554", VA = "0x37B5554")]
    public static Offset<AbilityBoardReleaseData> EndAbilityBoardReleaseData(
      FlatBufferBuilder builder)
    {
      return new Offset<AbilityBoardReleaseData>();
    }

    [Token(Token = "0x6017BBB")]
    [Address(RVA = "0x37B570C", Offset = "0x37B570C", VA = "0x37B570C")]
    public static void FinishAbilityBoardReleaseDataBuffer(
      FlatBufferBuilder builder,
      Offset<AbilityBoardReleaseData> offset)
    {
    }

    [Token(Token = "0x6017BBC")]
    [Address(RVA = "0x37B5768", Offset = "0x37B5768", VA = "0x37B5768")]
    public static void FinishSizePrefixedAbilityBoardReleaseDataBuffer(
      FlatBufferBuilder builder,
      Offset<AbilityBoardReleaseData> offset)
    {
    }
  }
}
