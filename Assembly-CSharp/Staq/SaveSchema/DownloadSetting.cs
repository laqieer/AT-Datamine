// Decompiled with JetBrains decompiler
// Type: staq.SaveSchema.DownloadSetting
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using FlatBuffers;
using Il2CppDummyDll;

#nullable disable
namespace staq.SaveSchema
{
  [Token(Token = "0x2003CA4")]
  public struct DownloadSetting : IFlatbufferObject
  {
    [Token(Token = "0x4010C03")]
    [FieldOffset(Offset = "0x0")]
    private Table __p;

    [Token(Token = "0x17004F18")]
    public ByteBuffer ByteBuffer
    {
      [Token(Token = "0x60182D1"), Address(RVA = "0x3B25438", Offset = "0x3B25438", VA = "0x3B25438", Slot = "4")] get
      {
        return (ByteBuffer) null;
      }
    }

    [Token(Token = "0x60182D2")]
    [Address(RVA = "0x3B25440", Offset = "0x3B25440", VA = "0x3B25440")]
    public static DownloadSetting GetRootAsDownloadSetting(ByteBuffer _bb) => new DownloadSetting();

    [Token(Token = "0x60182D3")]
    [Address(RVA = "0x3B2544C", Offset = "0x3B2544C", VA = "0x3B2544C")]
    public static DownloadSetting GetRootAsDownloadSetting(ByteBuffer _bb, DownloadSetting obj)
    {
      return new DownloadSetting();
    }

    [Token(Token = "0x60182D4")]
    [Address(RVA = "0x3B254A8", Offset = "0x3B254A8", VA = "0x3B254A8")]
    public static bool DownloadSettingBufferHasIdentifier(ByteBuffer _bb) => new bool();

    [Token(Token = "0x60182D5")]
    [Address(RVA = "0x3B254F4", Offset = "0x3B254F4", VA = "0x3B254F4", Slot = "5")]
    public void __init(int _i, ByteBuffer _bb)
    {
    }

    [Token(Token = "0x60182D6")]
    [Address(RVA = "0x3B25490", Offset = "0x3B25490", VA = "0x3B25490")]
    public DownloadSetting __assign(int _i, ByteBuffer _bb) => new DownloadSetting();

    [Token(Token = "0x17004F19")]
    public bool VoiceDownload
    {
      [Token(Token = "0x60182D7"), Address(RVA = "0x3B25500", Offset = "0x3B25500", VA = "0x3B25500")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17004F1A")]
    public bool IsLightMode
    {
      [Token(Token = "0x60182D8"), Address(RVA = "0x3B25550", Offset = "0x3B25550", VA = "0x3B25550")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x60182D9")]
    [Address(RVA = "0x3B25598", Offset = "0x3B25598", VA = "0x3B25598")]
    public static Offset<DownloadSetting> CreateDownloadSetting(
      FlatBufferBuilder builder,
      bool voice_download = true,
      bool is_light_mode = false)
    {
      return new Offset<DownloadSetting>();
    }

    [Token(Token = "0x60182DA")]
    [Address(RVA = "0x3B25680", Offset = "0x3B25680", VA = "0x3B25680")]
    public static void StartDownloadSetting(FlatBufferBuilder builder)
    {
    }

    [Token(Token = "0x60182DB")]
    [Address(RVA = "0x3B25610", Offset = "0x3B25610", VA = "0x3B25610")]
    public static void AddVoiceDownload(FlatBufferBuilder builder, bool voiceDownload)
    {
    }

    [Token(Token = "0x60182DC")]
    [Address(RVA = "0x3B255F0", Offset = "0x3B255F0", VA = "0x3B255F0")]
    public static void AddIsLightMode(FlatBufferBuilder builder, bool isLightMode)
    {
    }

    [Token(Token = "0x60182DD")]
    [Address(RVA = "0x3B25630", Offset = "0x3B25630", VA = "0x3B25630")]
    public static Offset<DownloadSetting> EndDownloadSetting(FlatBufferBuilder builder)
    {
      return new Offset<DownloadSetting>();
    }

    [Token(Token = "0x60182DE")]
    [Address(RVA = "0x3B25698", Offset = "0x3B25698", VA = "0x3B25698")]
    public static void FinishDownloadSettingBuffer(
      FlatBufferBuilder builder,
      Offset<DownloadSetting> offset)
    {
    }

    [Token(Token = "0x60182DF")]
    [Address(RVA = "0x3B256F4", Offset = "0x3B256F4", VA = "0x3B256F4")]
    public static void FinishSizePrefixedDownloadSettingBuffer(
      FlatBufferBuilder builder,
      Offset<DownloadSetting> offset)
    {
    }
  }
}
