// Decompiled with JetBrains decompiler
// Type: staq.SaveSchema.GuildFacilitySaveData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using FlatBuffers;
using Il2CppDummyDll;

#nullable disable
namespace staq.SaveSchema
{
  [Token(Token = "0x2003CB4")]
  public struct GuildFacilitySaveData : IFlatbufferObject
  {
    [Token(Token = "0x4010C12")]
    [FieldOffset(Offset = "0x0")]
    private Table __p;

    [Token(Token = "0x17004F48")]
    public ByteBuffer ByteBuffer
    {
      [Token(Token = "0x60183D0"), Address(RVA = "0x26D6B78", Offset = "0x26D6B78", VA = "0x26D6B78", Slot = "4")] get
      {
        return (ByteBuffer) null;
      }
    }

    [Token(Token = "0x60183D1")]
    [Address(RVA = "0x26D6B80", Offset = "0x26D6B80", VA = "0x26D6B80")]
    public static GuildFacilitySaveData GetRootAsGuildFacilitySaveData(ByteBuffer _bb)
    {
      return new GuildFacilitySaveData();
    }

    [Token(Token = "0x60183D2")]
    [Address(RVA = "0x26D6B8C", Offset = "0x26D6B8C", VA = "0x26D6B8C")]
    public static GuildFacilitySaveData GetRootAsGuildFacilitySaveData(
      ByteBuffer _bb,
      GuildFacilitySaveData obj)
    {
      return new GuildFacilitySaveData();
    }

    [Token(Token = "0x60183D3")]
    [Address(RVA = "0x26D6BE8", Offset = "0x26D6BE8", VA = "0x26D6BE8")]
    public static bool GuildFacilitySaveDataBufferHasIdentifier(ByteBuffer _bb) => new bool();

    [Token(Token = "0x60183D4")]
    [Address(RVA = "0x26D6C34", Offset = "0x26D6C34", VA = "0x26D6C34", Slot = "5")]
    public void __init(int _i, ByteBuffer _bb)
    {
    }

    [Token(Token = "0x60183D5")]
    [Address(RVA = "0x26D6BD0", Offset = "0x26D6BD0", VA = "0x26D6BD0")]
    public GuildFacilitySaveData __assign(int _i, ByteBuffer _bb) => new GuildFacilitySaveData();

    [Token(Token = "0x60183D6")]
    [Address(RVA = "0x26D6C40", Offset = "0x26D6C40", VA = "0x26D6C40")]
    public ConfirmLevelupEffectEveryFacility? ConfirmLevelupEffectData(int j)
    {
      return new ConfirmLevelupEffectEveryFacility?();
    }

    [Token(Token = "0x17004F49")]
    public int ConfirmLevelupEffectDataLength
    {
      [Token(Token = "0x60183D7"), Address(RVA = "0x26D6D0C", Offset = "0x26D6D0C", VA = "0x26D6D0C")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x60183D8")]
    [Address(RVA = "0x26D6D40", Offset = "0x26D6D40", VA = "0x26D6D40")]
    public static Offset<GuildFacilitySaveData> CreateGuildFacilitySaveData(
      FlatBufferBuilder builder,
      VectorOffset confirmLevelupEffectDataOffset = default (VectorOffset))
    {
      return new Offset<GuildFacilitySaveData>();
    }

    [Token(Token = "0x60183D9")]
    [Address(RVA = "0x26D6DF8", Offset = "0x26D6DF8", VA = "0x26D6DF8")]
    public static void StartGuildFacilitySaveData(FlatBufferBuilder builder)
    {
    }

    [Token(Token = "0x60183DA")]
    [Address(RVA = "0x26D6D88", Offset = "0x26D6D88", VA = "0x26D6D88")]
    public static void AddConfirmLevelupEffectData(
      FlatBufferBuilder builder,
      VectorOffset confirmLevelupEffectDataOffset)
    {
    }

    [Token(Token = "0x60183DB")]
    [Address(RVA = "0x26D6E10", Offset = "0x26D6E10", VA = "0x26D6E10")]
    public static VectorOffset CreateConfirmLevelupEffectDataVector(
      FlatBufferBuilder builder,
      Offset<ConfirmLevelupEffectEveryFacility>[] data)
    {
      return new VectorOffset();
    }

    [Token(Token = "0x60183DC")]
    [Address(RVA = "0x26D6EB8", Offset = "0x26D6EB8", VA = "0x26D6EB8")]
    public static VectorOffset CreateConfirmLevelupEffectDataVectorBlock(
      FlatBufferBuilder builder,
      Offset<ConfirmLevelupEffectEveryFacility>[] data)
    {
      return new VectorOffset();
    }

    [Token(Token = "0x60183DD")]
    [Address(RVA = "0x26D6F40", Offset = "0x26D6F40", VA = "0x26D6F40")]
    public static void StartConfirmLevelupEffectDataVector(FlatBufferBuilder builder, int numElems)
    {
    }

    [Token(Token = "0x60183DE")]
    [Address(RVA = "0x26D6DA8", Offset = "0x26D6DA8", VA = "0x26D6DA8")]
    public static Offset<GuildFacilitySaveData> EndGuildFacilitySaveData(FlatBufferBuilder builder)
    {
      return new Offset<GuildFacilitySaveData>();
    }

    [Token(Token = "0x60183DF")]
    [Address(RVA = "0x26D6F60", Offset = "0x26D6F60", VA = "0x26D6F60")]
    public static void FinishGuildFacilitySaveDataBuffer(
      FlatBufferBuilder builder,
      Offset<GuildFacilitySaveData> offset)
    {
    }

    [Token(Token = "0x60183E0")]
    [Address(RVA = "0x26D6FBC", Offset = "0x26D6FBC", VA = "0x26D6FBC")]
    public static void FinishSizePrefixedGuildFacilitySaveDataBuffer(
      FlatBufferBuilder builder,
      Offset<GuildFacilitySaveData> offset)
    {
    }
  }
}
