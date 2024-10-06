// Decompiled with JetBrains decompiler
// Type: staq.SaveSchema.DisplaySettings
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using FlatBuffers;
using Il2CppDummyDll;

#nullable disable
namespace staq.SaveSchema
{
  [Token(Token = "0x2003CA3")]
  public struct DisplaySettings : IFlatbufferObject
  {
    [Token(Token = "0x4010C02")]
    [FieldOffset(Offset = "0x0")]
    private Table __p;

    [Token(Token = "0x17004F14")]
    public ByteBuffer ByteBuffer
    {
      [Token(Token = "0x60182C0"), Address(RVA = "0x3B2509C", Offset = "0x3B2509C", VA = "0x3B2509C", Slot = "4")] get
      {
        return (ByteBuffer) null;
      }
    }

    [Token(Token = "0x60182C1")]
    [Address(RVA = "0x3B250A4", Offset = "0x3B250A4", VA = "0x3B250A4")]
    public static DisplaySettings GetRootAsDisplaySettings(ByteBuffer _bb) => new DisplaySettings();

    [Token(Token = "0x60182C2")]
    [Address(RVA = "0x3B250B0", Offset = "0x3B250B0", VA = "0x3B250B0")]
    public static DisplaySettings GetRootAsDisplaySettings(ByteBuffer _bb, DisplaySettings obj)
    {
      return new DisplaySettings();
    }

    [Token(Token = "0x60182C3")]
    [Address(RVA = "0x3B2510C", Offset = "0x3B2510C", VA = "0x3B2510C")]
    public static bool DisplaySettingsBufferHasIdentifier(ByteBuffer _bb) => new bool();

    [Token(Token = "0x60182C4")]
    [Address(RVA = "0x3B25158", Offset = "0x3B25158", VA = "0x3B25158", Slot = "5")]
    public void __init(int _i, ByteBuffer _bb)
    {
    }

    [Token(Token = "0x60182C5")]
    [Address(RVA = "0x3B250F4", Offset = "0x3B250F4", VA = "0x3B250F4")]
    public DisplaySettings __assign(int _i, ByteBuffer _bb) => new DisplaySettings();

    [Token(Token = "0x17004F15")]
    public int QualitySettings
    {
      [Token(Token = "0x60182C6"), Address(RVA = "0x3B25164", Offset = "0x3B25164", VA = "0x3B25164")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17004F16")]
    public bool ShowMoveDirection
    {
      [Token(Token = "0x60182C7"), Address(RVA = "0x3B251A8", Offset = "0x3B251A8", VA = "0x3B251A8")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17004F17")]
    public bool FpsSettings
    {
      [Token(Token = "0x60182C8"), Address(RVA = "0x3B251F8", Offset = "0x3B251F8", VA = "0x3B251F8")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x60182C9")]
    [Address(RVA = "0x3B25248", Offset = "0x3B25248", VA = "0x3B25248")]
    public static Offset<DisplaySettings> CreateDisplaySettings(
      FlatBufferBuilder builder,
      int quality_settings = 0,
      bool show_move_direction = true,
      bool fps_settings = true)
    {
      return new Offset<DisplaySettings>();
    }

    [Token(Token = "0x60182CA")]
    [Address(RVA = "0x3B25368", Offset = "0x3B25368", VA = "0x3B25368")]
    public static void StartDisplaySettings(FlatBufferBuilder builder)
    {
    }

    [Token(Token = "0x60182CB")]
    [Address(RVA = "0x3B252B8", Offset = "0x3B252B8", VA = "0x3B252B8")]
    public static void AddQualitySettings(FlatBufferBuilder builder, int qualitySettings)
    {
    }

    [Token(Token = "0x60182CC")]
    [Address(RVA = "0x3B252F8", Offset = "0x3B252F8", VA = "0x3B252F8")]
    public static void AddShowMoveDirection(FlatBufferBuilder builder, bool showMoveDirection)
    {
    }

    [Token(Token = "0x60182CD")]
    [Address(RVA = "0x3B252D8", Offset = "0x3B252D8", VA = "0x3B252D8")]
    public static void AddFpsSettings(FlatBufferBuilder builder, bool fpsSettings)
    {
    }

    [Token(Token = "0x60182CE")]
    [Address(RVA = "0x3B25318", Offset = "0x3B25318", VA = "0x3B25318")]
    public static Offset<DisplaySettings> EndDisplaySettings(FlatBufferBuilder builder)
    {
      return new Offset<DisplaySettings>();
    }

    [Token(Token = "0x60182CF")]
    [Address(RVA = "0x3B25380", Offset = "0x3B25380", VA = "0x3B25380")]
    public static void FinishDisplaySettingsBuffer(
      FlatBufferBuilder builder,
      Offset<DisplaySettings> offset)
    {
    }

    [Token(Token = "0x60182D0")]
    [Address(RVA = "0x3B253DC", Offset = "0x3B253DC", VA = "0x3B253DC")]
    public static void FinishSizePrefixedDisplaySettingsBuffer(
      FlatBufferBuilder builder,
      Offset<DisplaySettings> offset)
    {
    }
  }
}
