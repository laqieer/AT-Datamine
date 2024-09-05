// Decompiled with JetBrains decompiler
// Type: IronSourceBannerSize
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
[Token(Token = "0x2000045")]
public class IronSourceBannerSize
{
  [Token(Token = "0x400013D")]
  [FieldOffset(Offset = "0x10")]
  private int width;
  [Token(Token = "0x400013E")]
  [FieldOffset(Offset = "0x14")]
  private int height;
  [Token(Token = "0x400013F")]
  [FieldOffset(Offset = "0x18")]
  private string description;
  [Token(Token = "0x4000140")]
  [FieldOffset(Offset = "0x20")]
  private bool isAdaptive;
  [Token(Token = "0x4000141")]
  [FieldOffset(Offset = "0x28")]
  private ISContainerParams isContainerParams;
  [Token(Token = "0x4000142")]
  [FieldOffset(Offset = "0x30")]
  private bool respectAndroidCutouts;
  [Token(Token = "0x4000143")]
  [FieldOffset(Offset = "0x0")]
  public static IronSourceBannerSize BANNER;
  [Token(Token = "0x4000144")]
  [FieldOffset(Offset = "0x8")]
  public static IronSourceBannerSize LARGE;
  [Token(Token = "0x4000145")]
  [FieldOffset(Offset = "0x10")]
  public static IronSourceBannerSize RECTANGLE;
  [Token(Token = "0x4000146")]
  [FieldOffset(Offset = "0x18")]
  public static IronSourceBannerSize SMART;

  [Token(Token = "0x600026F")]
  [Address(RVA = "0x2059258", Offset = "0x2059258", VA = "0x2059258")]
  private IronSourceBannerSize()
  {
  }

  [Token(Token = "0x6000270")]
  [Address(RVA = "0x20592E8", Offset = "0x20592E8", VA = "0x20592E8")]
  public IronSourceBannerSize(int width, int height)
  {
  }

  [Token(Token = "0x6000271")]
  [Address(RVA = "0x205938C", Offset = "0x205938C", VA = "0x205938C")]
  public IronSourceBannerSize(string description)
  {
  }

  [Token(Token = "0x6000272")]
  [Address(RVA = "0x2059410", Offset = "0x2059410", VA = "0x2059410")]
  public void SetAdaptive(bool adaptive)
  {
  }

  [Token(Token = "0x6000273")]
  [Address(RVA = "0x205941C", Offset = "0x205941C", VA = "0x205941C")]
  public bool IsAdaptiveEnabled() => new bool();

  [Token(Token = "0x6000274")]
  [Address(RVA = "0x2059424", Offset = "0x2059424", VA = "0x2059424")]
  public void setBannerContainerParams(ISContainerParams parameters)
  {
  }

  [Token(Token = "0x6000275")]
  [Address(RVA = "0x205942C", Offset = "0x205942C", VA = "0x205942C")]
  public ISContainerParams getBannerContainerParams() => (ISContainerParams) null;

  [Token(Token = "0x6000276")]
  [Address(RVA = "0x2059434", Offset = "0x2059434", VA = "0x2059434")]
  public void SetRespectAndroidCutouts(bool respectAndroidCutouts)
  {
  }

  [Token(Token = "0x6000277")]
  [Address(RVA = "0x2059440", Offset = "0x2059440", VA = "0x2059440")]
  public bool IsRespectAndroidCutoutsEnabled() => new bool();

  [Token(Token = "0x1700001C")]
  public string Description
  {
    [Token(Token = "0x6000278"), Address(RVA = "0x2059448", Offset = "0x2059448", VA = "0x2059448")] get
    {
      return (string) null;
    }
  }

  [Token(Token = "0x1700001D")]
  public int Width
  {
    [Token(Token = "0x6000279"), Address(RVA = "0x2059450", Offset = "0x2059450", VA = "0x2059450")] get
    {
      return new int();
    }
  }

  [Token(Token = "0x1700001E")]
  public int Height
  {
    [Token(Token = "0x600027A"), Address(RVA = "0x2059458", Offset = "0x2059458", VA = "0x2059458")] get
    {
      return new int();
    }
  }

  [Token(Token = "0x600027B")]
  [Address(RVA = "0x2059460", Offset = "0x2059460", VA = "0x2059460")]
  static IronSourceBannerSize()
  {
  }
}
