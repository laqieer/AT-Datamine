// Decompiled with JetBrains decompiler
// Type: staq.SaveData.DownloadSettingSaveData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace staq.SaveData
{
  [Token(Token = "0x2003D0A")]
  public class DownloadSettingSaveData
  {
    [Token(Token = "0x4010CC6")]
    [FieldOffset(Offset = "0x11")]
    public bool downloadVoiceData;
    [Token(Token = "0x4010CC7")]
    [FieldOffset(Offset = "0x12")]
    public bool IsLightMode;

    [Token(Token = "0x17005023")]
    public bool loaded
    {
      [Token(Token = "0x6018881"), Address(RVA = "0x293ECB8", Offset = "0x293ECB8", VA = "0x293ECB8")] get
      {
        return new bool();
      }
      [Token(Token = "0x6018882"), Address(RVA = "0x293ECC0", Offset = "0x293ECC0", VA = "0x293ECC0")] private set
      {
      }
    }

    [Token(Token = "0x17005024")]
    public static string Path
    {
      [Token(Token = "0x6018883"), Address(RVA = "0x293ECCC", Offset = "0x293ECCC", VA = "0x293ECCC")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x6018884")]
    [Address(RVA = "0x293ED1C", Offset = "0x293ED1C", VA = "0x293ED1C")]
    public string GetPath() => (string) null;

    [Token(Token = "0x6018885")]
    [Address(RVA = "0x293ED64", Offset = "0x293ED64", VA = "0x293ED64")]
    public void DeleteFile()
    {
    }

    [Token(Token = "0x6018886")]
    [Address(RVA = "0x293ED94", Offset = "0x293ED94", VA = "0x293ED94")]
    public void Delete()
    {
    }

    [Token(Token = "0x6018887")]
    [Address(RVA = "0x293EDB0", Offset = "0x293EDB0", VA = "0x293EDB0")]
    public void Load()
    {
    }

    [Token(Token = "0x6018888")]
    [Address(RVA = "0x293EF48", Offset = "0x293EF48", VA = "0x293EF48")]
    public void Save()
    {
    }

    [Token(Token = "0x6018889")]
    [Address(RVA = "0x293F018", Offset = "0x293F018", VA = "0x293F018")]
    public DownloadSettingSaveData()
    {
    }
  }
}
