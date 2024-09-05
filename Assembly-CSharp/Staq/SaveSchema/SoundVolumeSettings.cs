// Decompiled with JetBrains decompiler
// Type: staq.SaveSchema.SoundVolumeSettings
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using FlatBuffers;
using Il2CppDummyDll;

#nullable disable
namespace staq.SaveSchema
{
  [Token(Token = "0x2003CE0")]
  public struct SoundVolumeSettings : IFlatbufferObject
  {
    [Token(Token = "0x4010C41")]
    [FieldOffset(Offset = "0x0")]
    private Table __p;

    [Token(Token = "0x17004FDC")]
    public ByteBuffer ByteBuffer
    {
      [Token(Token = "0x60186F9"), Address(RVA = "0x26E2E3C", Offset = "0x26E2E3C", VA = "0x26E2E3C", Slot = "4")] get
      {
        return (ByteBuffer) null;
      }
    }

    [Token(Token = "0x60186FA")]
    [Address(RVA = "0x26E2E44", Offset = "0x26E2E44", VA = "0x26E2E44")]
    public static SoundVolumeSettings GetRootAsSoundVolumeSettings(ByteBuffer _bb)
    {
      return new SoundVolumeSettings();
    }

    [Token(Token = "0x60186FB")]
    [Address(RVA = "0x26E2E50", Offset = "0x26E2E50", VA = "0x26E2E50")]
    public static SoundVolumeSettings GetRootAsSoundVolumeSettings(
      ByteBuffer _bb,
      SoundVolumeSettings obj)
    {
      return new SoundVolumeSettings();
    }

    [Token(Token = "0x60186FC")]
    [Address(RVA = "0x26E2EAC", Offset = "0x26E2EAC", VA = "0x26E2EAC")]
    public static bool SoundVolumeSettingsBufferHasIdentifier(ByteBuffer _bb) => new bool();

    [Token(Token = "0x60186FD")]
    [Address(RVA = "0x26E2EF8", Offset = "0x26E2EF8", VA = "0x26E2EF8", Slot = "5")]
    public void __init(int _i, ByteBuffer _bb)
    {
    }

    [Token(Token = "0x60186FE")]
    [Address(RVA = "0x26E2E94", Offset = "0x26E2E94", VA = "0x26E2E94")]
    public SoundVolumeSettings __assign(int _i, ByteBuffer _bb) => new SoundVolumeSettings();

    [Token(Token = "0x17004FDD")]
    public float BgmVolumeSettings
    {
      [Token(Token = "0x60186FF"), Address(RVA = "0x26E2F04", Offset = "0x26E2F04", VA = "0x26E2F04")] get
      {
        return new float();
      }
    }

    [Token(Token = "0x17004FDE")]
    public float SeVolumeSettings
    {
      [Token(Token = "0x6018700"), Address(RVA = "0x26E2F4C", Offset = "0x26E2F4C", VA = "0x26E2F4C")] get
      {
        return new float();
      }
    }

    [Token(Token = "0x17004FDF")]
    public float VoiceVolumeSettings
    {
      [Token(Token = "0x6018701"), Address(RVA = "0x26E2F94", Offset = "0x26E2F94", VA = "0x26E2F94")] get
      {
        return new float();
      }
    }

    [Token(Token = "0x6018702")]
    [Address(RVA = "0x26E2FDC", Offset = "0x26E2FDC", VA = "0x26E2FDC")]
    public static Offset<SoundVolumeSettings> CreateSoundVolumeSettings(
      FlatBufferBuilder builder,
      float bgm_volume_settings = 1f,
      float se_volume_settings = 1f,
      float voice_volume_settings = 1f)
    {
      return new Offset<SoundVolumeSettings>();
    }

    [Token(Token = "0x6018703")]
    [Address(RVA = "0x26E30F0", Offset = "0x26E30F0", VA = "0x26E30F0")]
    public static void StartSoundVolumeSettings(FlatBufferBuilder builder)
    {
    }

    [Token(Token = "0x6018704")]
    [Address(RVA = "0x26E3084", Offset = "0x26E3084", VA = "0x26E3084")]
    public static void AddBgmVolumeSettings(FlatBufferBuilder builder, float bgmVolumeSettings)
    {
    }

    [Token(Token = "0x6018705")]
    [Address(RVA = "0x26E3068", Offset = "0x26E3068", VA = "0x26E3068")]
    public static void AddSeVolumeSettings(FlatBufferBuilder builder, float seVolumeSettings)
    {
    }

    [Token(Token = "0x6018706")]
    [Address(RVA = "0x26E304C", Offset = "0x26E304C", VA = "0x26E304C")]
    public static void AddVoiceVolumeSettings(FlatBufferBuilder builder, float voiceVolumeSettings)
    {
    }

    [Token(Token = "0x6018707")]
    [Address(RVA = "0x26E30A0", Offset = "0x26E30A0", VA = "0x26E30A0")]
    public static Offset<SoundVolumeSettings> EndSoundVolumeSettings(FlatBufferBuilder builder)
    {
      return new Offset<SoundVolumeSettings>();
    }

    [Token(Token = "0x6018708")]
    [Address(RVA = "0x26E3108", Offset = "0x26E3108", VA = "0x26E3108")]
    public static void FinishSoundVolumeSettingsBuffer(
      FlatBufferBuilder builder,
      Offset<SoundVolumeSettings> offset)
    {
    }

    [Token(Token = "0x6018709")]
    [Address(RVA = "0x26E3164", Offset = "0x26E3164", VA = "0x26E3164")]
    public static void FinishSizePrefixedSoundVolumeSettingsBuffer(
      FlatBufferBuilder builder,
      Offset<SoundVolumeSettings> offset)
    {
    }
  }
}
