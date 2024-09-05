// Decompiled with JetBrains decompiler
// Type: UrlResourceUtility
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
[Token(Token = "0x200024E")]
public static class UrlResourceUtility
{
  [Token(Token = "0x4000DBB")]
  private const string RAW_DATA_URL = "https://{0}/raw_data/";
  [Token(Token = "0x4000DBC")]
  private const string RAW_SERVER_URL_DEFAULT = "dlc-dev.staq-dev.gu3.jp";
  [Token(Token = "0x4000DBD")]
  private const string OFFICIAL_INFO_IMAGE_URL = "https://officialinfo.staq-dev.gu3.jp/images";

  [Token(Token = "0x17000136")]
  public static string RawDataUrl
  {
    [Token(Token = "0x6000E94"), Address(RVA = "0x1C9039C", Offset = "0x1C9039C", VA = "0x1C9039C")] get
    {
      return (string) null;
    }
  }

  [Token(Token = "0x17000137")]
  public static string OfficialInfoImageUrl
  {
    [Token(Token = "0x6000E95"), Address(RVA = "0x1C90440", Offset = "0x1C90440", VA = "0x1C90440")] get
    {
      return (string) null;
    }
  }

  [Token(Token = "0x6000E96")]
  [Address(RVA = "0x1C90480", Offset = "0x1C90480", VA = "0x1C90480")]
  public static string ReplaceToOfficialInfoImageUrl(string str, string keyword = "{IMAGE_URL}")
  {
    return (string) null;
  }
}
