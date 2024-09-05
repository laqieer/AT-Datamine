// Decompiled with JetBrains decompiler
// Type: staq.SaveData.IntroChapterSaveData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace staq.SaveData
{
  [Token(Token = "0x2003D29")]
  public class IntroChapterSaveData
  {
    [Token(Token = "0x4010D06")]
    [FieldOffset(Offset = "0x14")]
    public int ProgressValue;
    [Token(Token = "0x4010D07")]
    [FieldOffset(Offset = "0x18")]
    public bool IsAgreedTermsOfService;

    [Token(Token = "0x1700503F")]
    public bool loaded
    {
      [Token(Token = "0x6018949"), Address(RVA = "0x294658C", Offset = "0x294658C", VA = "0x294658C")] get
      {
        return new bool();
      }
      [Token(Token = "0x601894A"), Address(RVA = "0x2946594", Offset = "0x2946594", VA = "0x2946594")] private set
      {
      }
    }

    [Token(Token = "0x17005040")]
    public static string Path
    {
      [Token(Token = "0x601894B"), Address(RVA = "0x29465A0", Offset = "0x29465A0", VA = "0x29465A0")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x601894C")]
    [Address(RVA = "0x29465F0", Offset = "0x29465F0", VA = "0x29465F0")]
    public string GetPath() => (string) null;

    [Token(Token = "0x601894D")]
    [Address(RVA = "0x2946638", Offset = "0x2946638", VA = "0x2946638")]
    public void DeleteFile()
    {
    }

    [Token(Token = "0x601894E")]
    [Address(RVA = "0x2946668", Offset = "0x2946668", VA = "0x2946668")]
    public void Delete()
    {
    }

    [Token(Token = "0x601894F")]
    [Address(RVA = "0x2946684", Offset = "0x2946684", VA = "0x2946684")]
    public void Load()
    {
    }

    [Token(Token = "0x6018950")]
    [Address(RVA = "0x2946818", Offset = "0x2946818", VA = "0x2946818")]
    public void Save()
    {
    }

    [Token(Token = "0x6018951")]
    [Address(RVA = "0x2946908", Offset = "0x2946908", VA = "0x2946908")]
    public IntroChapterSaveData()
    {
    }
  }
}
