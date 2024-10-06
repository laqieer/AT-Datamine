// Decompiled with JetBrains decompiler
// Type: PersonalEmblemResourceUtility
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
[Token(Token = "0x2000248")]
public class PersonalEmblemResourceUtility
{
  [Token(Token = "0x4000D97")]
  private const string AB_NAME_FORMAT = "content_playertitle_{0}_image";
  [Token(Token = "0x4000D98")]
  private const string ASSET_NAME_FORMAT = "{0}_PlayerTitleImage";

  [Token(Token = "0x6000E6C")]
  [Address(RVA = "0x1C8EF50", Offset = "0x1C8EF50", VA = "0x1C8EF50")]
  public static string GetEmblemAssetBundleNameById(int emblemId) => (string) null;

  [Token(Token = "0x6000E6D")]
  [Address(RVA = "0x1C8F0B0", Offset = "0x1C8F0B0", VA = "0x1C8F0B0")]
  public static string GetEmblemAssetNameById(int emblemId) => (string) null;

  [Token(Token = "0x6000E6E")]
  [Address(RVA = "0x1C8EFE4", Offset = "0x1C8EFE4", VA = "0x1C8EFE4")]
  private static bool OverrideToResourceId(int emblemId, out int resourceId) => new bool();

  [Token(Token = "0x6000E6F")]
  [Address(RVA = "0x1C8F144", Offset = "0x1C8F144", VA = "0x1C8F144")]
  public PersonalEmblemResourceUtility()
  {
  }
}
