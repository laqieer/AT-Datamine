// Decompiled with JetBrains decompiler
// Type: staq.SaveData.DisplaySaveData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace staq.SaveData
{
  [Token(Token = "0x2003D09")]
  public class DisplaySaveData
  {
    [Token(Token = "0x4010CC2")]
    [FieldOffset(Offset = "0x10")]
    public int QualityLevel;
    [Token(Token = "0x4010CC3")]
    [FieldOffset(Offset = "0x14")]
    public bool ShowMoveDirection;
    [Token(Token = "0x4010CC4")]
    [FieldOffset(Offset = "0x15")]
    public bool FpsSetting;

    [Token(Token = "0x17005021")]
    public int FPS
    {
      [Token(Token = "0x6018879"), Address(RVA = "0x293E948", Offset = "0x293E948", VA = "0x293E948")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17005022")]
    public static string Path
    {
      [Token(Token = "0x601887A"), Address(RVA = "0x293E960", Offset = "0x293E960", VA = "0x293E960")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x601887B")]
    [Address(RVA = "0x293E9B0", Offset = "0x293E9B0", VA = "0x293E9B0")]
    public string getPath() => (string) null;

    [Token(Token = "0x601887C")]
    [Address(RVA = "0x293E9F8", Offset = "0x293E9F8", VA = "0x293E9F8")]
    public void delete()
    {
    }

    [Token(Token = "0x601887D")]
    [Address(RVA = "0x293EA10", Offset = "0x293EA10", VA = "0x293EA10")]
    public void deleteFile()
    {
    }

    [Token(Token = "0x601887E")]
    [Address(RVA = "0x293EA3C", Offset = "0x293EA3C", VA = "0x293EA3C")]
    public void load()
    {
    }

    [Token(Token = "0x601887F")]
    [Address(RVA = "0x293EBD8", Offset = "0x293EBD8", VA = "0x293EBD8")]
    public void save()
    {
    }

    [Token(Token = "0x6018880")]
    [Address(RVA = "0x293ECB0", Offset = "0x293ECB0", VA = "0x293ECB0")]
    public DisplaySaveData()
    {
    }
  }
}
