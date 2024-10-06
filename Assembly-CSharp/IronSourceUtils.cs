// Decompiled with JetBrains decompiler
// Type: IronSourceUtils
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
[Token(Token = "0x2000075")]
public class IronSourceUtils
{
  [Token(Token = "0x4000227")]
  private const string ERROR_CODE = "error_code";
  [Token(Token = "0x4000228")]
  private const string ERROR_DESCRIPTION = "error_description";
  [Token(Token = "0x4000229")]
  private const string INSTANCE_ID_KEY = "instanceId";
  [Token(Token = "0x400022A")]
  private const string PLACEMENT_KEY = "placement";

  [Token(Token = "0x60003F4")]
  [Address(RVA = "0x44A4988", Offset = "0x44A4988", VA = "0x44A4988")]
  public static IronSourceError getErrorFromErrorObject(object descriptionObject)
  {
    return (IronSourceError) null;
  }

  [Token(Token = "0x60003F5")]
  [Address(RVA = "0x44A7098", Offset = "0x44A7098", VA = "0x44A7098")]
  public static IronSourcePlacement getPlacementFromObject(object placementObject)
  {
    return (IronSourcePlacement) null;
  }

  [Token(Token = "0x60003F6")]
  [Address(RVA = "0x44AD820", Offset = "0x44AD820", VA = "0x44AD820")]
  public IronSourceUtils()
  {
  }
}
