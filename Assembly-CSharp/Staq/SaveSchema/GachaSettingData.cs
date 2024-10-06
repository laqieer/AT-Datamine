// Decompiled with JetBrains decompiler
// Type: staq.SaveSchema.GachaSettingData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using FlatBuffers;
using Il2CppDummyDll;

#nullable disable
namespace staq.SaveSchema
{
  [Token(Token = "0x2003CB2")]
  public struct GachaSettingData : IFlatbufferObject
  {
    [Token(Token = "0x4010C10")]
    [FieldOffset(Offset = "0x0")]
    private Table __p;

    [Token(Token = "0x17004F43")]
    public ByteBuffer ByteBuffer
    {
      [Token(Token = "0x60183B0"), Address(RVA = "0x26D64E0", Offset = "0x26D64E0", VA = "0x26D64E0", Slot = "4")] get
      {
        return (ByteBuffer) null;
      }
    }

    [Token(Token = "0x60183B1")]
    [Address(RVA = "0x26D64E8", Offset = "0x26D64E8", VA = "0x26D64E8")]
    public static GachaSettingData GetRootAsGachaSettingData(ByteBuffer _bb)
    {
      return new GachaSettingData();
    }

    [Token(Token = "0x60183B2")]
    [Address(RVA = "0x26D64F4", Offset = "0x26D64F4", VA = "0x26D64F4")]
    public static GachaSettingData GetRootAsGachaSettingData(ByteBuffer _bb, GachaSettingData obj)
    {
      return new GachaSettingData();
    }

    [Token(Token = "0x60183B3")]
    [Address(RVA = "0x26D6550", Offset = "0x26D6550", VA = "0x26D6550")]
    public static bool GachaSettingDataBufferHasIdentifier(ByteBuffer _bb) => new bool();

    [Token(Token = "0x60183B4")]
    [Address(RVA = "0x26D659C", Offset = "0x26D659C", VA = "0x26D659C", Slot = "5")]
    public void __init(int _i, ByteBuffer _bb)
    {
    }

    [Token(Token = "0x60183B5")]
    [Address(RVA = "0x26D6538", Offset = "0x26D6538", VA = "0x26D6538")]
    public GachaSettingData __assign(int _i, ByteBuffer _bb) => new GachaSettingData();

    [Token(Token = "0x17004F44")]
    public bool IsSkipPlayback
    {
      [Token(Token = "0x60183B6"), Address(RVA = "0x26D65A8", Offset = "0x26D65A8", VA = "0x26D65A8")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x60183B7")]
    [Address(RVA = "0x26D65F0", Offset = "0x26D65F0", VA = "0x26D65F0")]
    public static Offset<GachaSettingData> CreateGachaSettingData(
      FlatBufferBuilder builder,
      bool isSkipPlayback = false)
    {
      return new Offset<GachaSettingData>();
    }

    [Token(Token = "0x60183B8")]
    [Address(RVA = "0x26D66A8", Offset = "0x26D66A8", VA = "0x26D66A8")]
    public static void StartGachaSettingData(FlatBufferBuilder builder)
    {
    }

    [Token(Token = "0x60183B9")]
    [Address(RVA = "0x26D6638", Offset = "0x26D6638", VA = "0x26D6638")]
    public static void AddIsSkipPlayback(FlatBufferBuilder builder, bool isSkipPlayback)
    {
    }

    [Token(Token = "0x60183BA")]
    [Address(RVA = "0x26D6658", Offset = "0x26D6658", VA = "0x26D6658")]
    public static Offset<GachaSettingData> EndGachaSettingData(FlatBufferBuilder builder)
    {
      return new Offset<GachaSettingData>();
    }

    [Token(Token = "0x60183BB")]
    [Address(RVA = "0x26D66C0", Offset = "0x26D66C0", VA = "0x26D66C0")]
    public static void FinishGachaSettingDataBuffer(
      FlatBufferBuilder builder,
      Offset<GachaSettingData> offset)
    {
    }

    [Token(Token = "0x60183BC")]
    [Address(RVA = "0x26D671C", Offset = "0x26D671C", VA = "0x26D671C")]
    public static void FinishSizePrefixedGachaSettingDataBuffer(
      FlatBufferBuilder builder,
      Offset<GachaSettingData> offset)
    {
    }
  }
}
