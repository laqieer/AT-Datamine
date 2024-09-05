// Decompiled with JetBrains decompiler
// Type: staq.SaveData.CalendarSaveData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections.Generic;

#nullable disable
namespace staq.SaveData
{
  [Token(Token = "0x2003CFA")]
  public class CalendarSaveData
  {
    [Token(Token = "0x4010C81")]
    [FieldOffset(Offset = "0x18")]
    public List<int> CalendarDirectingIDList;

    [Token(Token = "0x17005011")]
    public bool loaded
    {
      [Token(Token = "0x6018816"), Address(RVA = "0x293AA90", Offset = "0x293AA90", VA = "0x293AA90")] get
      {
        return new bool();
      }
      [Token(Token = "0x6018817"), Address(RVA = "0x293AA98", Offset = "0x293AA98", VA = "0x293AA98")] private set
      {
      }
    }

    [Token(Token = "0x17005012")]
    public int CalendarID
    {
      [Token(Token = "0x6018818"), Address(RVA = "0x293AAA4", Offset = "0x293AAA4", VA = "0x293AAA4")] get
      {
        return new int();
      }
      [Token(Token = "0x6018819"), Address(RVA = "0x293AAAC", Offset = "0x293AAAC", VA = "0x293AAAC")] set
      {
      }
    }

    [Token(Token = "0x17005013")]
    public static string Path
    {
      [Token(Token = "0x601881A"), Address(RVA = "0x293AAB4", Offset = "0x293AAB4", VA = "0x293AAB4")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x601881B")]
    [Address(RVA = "0x293AB04", Offset = "0x293AB04", VA = "0x293AB04")]
    public string GetPath() => (string) null;

    [Token(Token = "0x601881C")]
    [Address(RVA = "0x293AB4C", Offset = "0x293AB4C", VA = "0x293AB4C")]
    public void DeleteFile()
    {
    }

    [Token(Token = "0x601881D")]
    [Address(RVA = "0x293AB7C", Offset = "0x293AB7C", VA = "0x293AB7C")]
    public void Delete()
    {
    }

    [Token(Token = "0x601881E")]
    [Address(RVA = "0x293AB98", Offset = "0x293AB98", VA = "0x293AB98")]
    public void Load()
    {
    }

    [Token(Token = "0x601881F")]
    [Address(RVA = "0x293ADF0", Offset = "0x293ADF0", VA = "0x293ADF0")]
    public void Save()
    {
    }

    [Token(Token = "0x6018820")]
    [Address(RVA = "0x293AED0", Offset = "0x293AED0", VA = "0x293AED0")]
    public void Set(List<int> calendarDirectingIdList)
    {
    }

    [Token(Token = "0x6018821")]
    [Address(RVA = "0x293AF54", Offset = "0x293AF54", VA = "0x293AF54")]
    public CalendarSaveData()
    {
    }
  }
}
