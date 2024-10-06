// Decompiled with JetBrains decompiler
// Type: staq.SaveData.LocationSaveData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Globalization;

#nullable disable
namespace staq.SaveData
{
  [Token(Token = "0x2003D2D")]
  [Serializable]
  public class LocationSaveData
  {
    [Token(Token = "0x17005044")]
    public string Region
    {
      [Token(Token = "0x601896B"), Address(RVA = "0x2947CC0", Offset = "0x2947CC0", VA = "0x2947CC0")] get
      {
        return (string) null;
      }
      [Token(Token = "0x601896C"), Address(RVA = "0x2947CC8", Offset = "0x2947CC8", VA = "0x2947CC8")] private set
      {
      }
    }

    [Token(Token = "0x17005045")]
    public string CurrentLanguage
    {
      [Token(Token = "0x601896D"), Address(RVA = "0x2947CD0", Offset = "0x2947CD0", VA = "0x2947CD0")] get
      {
        return (string) null;
      }
      [Token(Token = "0x601896E"), Address(RVA = "0x2947CD8", Offset = "0x2947CD8", VA = "0x2947CD8")] private set
      {
      }
    }

    [Token(Token = "0x17005046")]
    public CultureInfo cultureInfo
    {
      [Token(Token = "0x601896F"), Address(RVA = "0x2947CE0", Offset = "0x2947CE0", VA = "0x2947CE0")] private set
      {
      }
      [Token(Token = "0x6018970"), Address(RVA = "0x2947CE8", Offset = "0x2947CE8", VA = "0x2947CE8")] get
      {
        return (CultureInfo) null;
      }
    }

    [Token(Token = "0x17005047")]
    private static string Path
    {
      [Token(Token = "0x6018971"), Address(RVA = "0x2947CF0", Offset = "0x2947CF0", VA = "0x2947CF0")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x6018972")]
    [Address(RVA = "0x2947D40", Offset = "0x2947D40", VA = "0x2947D40")]
    public string getPath() => (string) null;

    [Token(Token = "0x6018973")]
    [Address(RVA = "0x2947D88", Offset = "0x2947D88", VA = "0x2947D88")]
    public void load()
    {
    }

    [Token(Token = "0x6018974")]
    [Address(RVA = "0x2947F34", Offset = "0x2947F34", VA = "0x2947F34")]
    public void save()
    {
    }

    [Token(Token = "0x6018975")]
    [Address(RVA = "0x294807C", Offset = "0x294807C", VA = "0x294807C")]
    public void Delete()
    {
    }

    [Token(Token = "0x6018976")]
    [Address(RVA = "0x2948094", Offset = "0x2948094", VA = "0x2948094")]
    public void deleteFile()
    {
    }

    [Token(Token = "0x6018977")]
    [Address(RVA = "0x2947EC8", Offset = "0x2947EC8", VA = "0x2947EC8")]
    private void SetDefaultParam()
    {
    }

    [Token(Token = "0x6018978")]
    [Address(RVA = "0x2948044", Offset = "0x2948044", VA = "0x2948044")]
    public void SetLanguage(string newLanguage, bool isSave = true)
    {
    }

    [Token(Token = "0x6018979")]
    [Address(RVA = "0x29480C0", Offset = "0x29480C0", VA = "0x29480C0")]
    private void SetCultureInfo(string lang)
    {
    }

    [Token(Token = "0x601897A")]
    [Address(RVA = "0x2948240", Offset = "0x2948240", VA = "0x2948240")]
    public LocationSaveData()
    {
    }
  }
}
