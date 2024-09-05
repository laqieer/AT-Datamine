// Decompiled with JetBrains decompiler
// Type: WaterfallConfiguration
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
[Token(Token = "0x2000083")]
public class WaterfallConfiguration
{
  [Token(Token = "0x400022B")]
  [FieldOffset(Offset = "0x10")]
  private readonly double? ceiling;
  [Token(Token = "0x400022C")]
  [FieldOffset(Offset = "0x20")]
  private readonly double? floor;

  [Token(Token = "0x17000021")]
  public double? Ceiling
  {
    [Token(Token = "0x60004BA"), Address(RVA = "0x44ADA54", Offset = "0x44ADA54", VA = "0x44ADA54")] get
    {
      return new double?();
    }
  }

  [Token(Token = "0x17000022")]
  public double? Floor
  {
    [Token(Token = "0x60004BB"), Address(RVA = "0x44ADA60", Offset = "0x44ADA60", VA = "0x44ADA60")] get
    {
      return new double?();
    }
  }

  [Token(Token = "0x60004BC")]
  [Address(RVA = "0x44ADA6C", Offset = "0x44ADA6C", VA = "0x44ADA6C")]
  private WaterfallConfiguration(double? ceiling, double? floor)
  {
  }

  [Token(Token = "0x60004BD")]
  [Address(RVA = "0x44ADAAC", Offset = "0x44ADAAC", VA = "0x44ADAAC")]
  public static WaterfallConfiguration.WaterfallConfigurationBuilder Builder()
  {
    return (WaterfallConfiguration.WaterfallConfigurationBuilder) null;
  }

  [Token(Token = "0x60004BE")]
  [Address(RVA = "0x44ADB10", Offset = "0x44ADB10", VA = "0x44ADB10")]
  public static WaterfallConfiguration Empty() => (WaterfallConfiguration) null;

  [Token(Token = "0x2000084")]
  public class WaterfallConfigurationBuilder
  {
    [Token(Token = "0x400022D")]
    [FieldOffset(Offset = "0x10")]
    private double? ceiling;
    [Token(Token = "0x400022E")]
    [FieldOffset(Offset = "0x20")]
    private double? floor;

    [Token(Token = "0x60004BF")]
    [Address(RVA = "0x44ADB08", Offset = "0x44ADB08", VA = "0x44ADB08")]
    internal WaterfallConfigurationBuilder()
    {
    }

    [Token(Token = "0x60004C0")]
    [Address(RVA = "0x44ADBD8", Offset = "0x44ADBD8", VA = "0x44ADBD8")]
    public WaterfallConfiguration.WaterfallConfigurationBuilder SetCeiling(double ceiling)
    {
      return (WaterfallConfiguration.WaterfallConfigurationBuilder) null;
    }

    [Token(Token = "0x60004C1")]
    [Address(RVA = "0x44ADC4C", Offset = "0x44ADC4C", VA = "0x44ADC4C")]
    public WaterfallConfiguration.WaterfallConfigurationBuilder SetFloor(double floor)
    {
      return (WaterfallConfiguration.WaterfallConfigurationBuilder) null;
    }

    [Token(Token = "0x60004C2")]
    [Address(RVA = "0x44ADCC0", Offset = "0x44ADCC0", VA = "0x44ADCC0")]
    public WaterfallConfiguration Build() => (WaterfallConfiguration) null;
  }
}
