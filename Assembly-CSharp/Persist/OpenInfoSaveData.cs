// Decompiled with JetBrains decompiler
// Type: Persist.OpenInfoSaveData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.IO;

#nullable disable
namespace Persist
{
  [Token(Token = "0x20009E8")]
  public class OpenInfoSaveData
  {
    [Token(Token = "0x4002DE5")]
    [FieldOffset(Offset = "0x0")]
    public static OpenInfoSaveData InfoSaveData;
    [Token(Token = "0x4002DE6")]
    [FieldOffset(Offset = "0x10")]
    private int version;
    [Token(Token = "0x4002DE7")]
    [FieldOffset(Offset = "0x18")]
    private string fileName;

    [Token(Token = "0x170007F8")]
    public bool IsDontShowToday
    {
      [Token(Token = "0x6003860"), Address(RVA = "0x310BF98", Offset = "0x310BF98", VA = "0x310BF98")] get
      {
        return new bool();
      }
      [Token(Token = "0x6003861"), Address(RVA = "0x310BFA0", Offset = "0x310BFA0", VA = "0x310BFA0")] private set
      {
      }
    }

    [Token(Token = "0x170007F9")]
    public DateTime LastShowTime
    {
      [Token(Token = "0x6003862"), Address(RVA = "0x310BFAC", Offset = "0x310BFAC", VA = "0x310BFAC")] get
      {
        return new DateTime();
      }
      [Token(Token = "0x6003863"), Address(RVA = "0x310BFB4", Offset = "0x310BFB4", VA = "0x310BFB4")] private set
      {
      }
    }

    [Token(Token = "0x170007FA")]
    public string FilePath
    {
      [Token(Token = "0x6003864"), Address(RVA = "0x310BFBC", Offset = "0x310BFBC", VA = "0x310BFBC")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x6003865")]
    [Address(RVA = "0x310C07C", Offset = "0x310C07C", VA = "0x310C07C")]
    public OpenInfoSaveData(string fileName)
    {
    }

    [Token(Token = "0x6003866")]
    [Address(RVA = "0x310C0A4", Offset = "0x310C0A4", VA = "0x310C0A4")]
    private void CreateDirectory()
    {
    }

    [Token(Token = "0x6003867")]
    [Address(RVA = "0x310C12C", Offset = "0x310C12C", VA = "0x310C12C")]
    public void Save()
    {
    }

    [Token(Token = "0x6003868")]
    [Address(RVA = "0x310C35C", Offset = "0x310C35C", VA = "0x310C35C")]
    public void Load()
    {
    }

    [Token(Token = "0x6003869")]
    [Address(RVA = "0x310C598", Offset = "0x310C598", VA = "0x310C598")]
    private void LoadVer0(BinaryReader reader)
    {
    }

    [Token(Token = "0x600386A")]
    [Address(RVA = "0x310C638", Offset = "0x310C638", VA = "0x310C638")]
    public void SetLastShowTime(DateTime dateTime)
    {
    }

    [Token(Token = "0x600386B")]
    [Address(RVA = "0x310C640", Offset = "0x310C640", VA = "0x310C640")]
    public void SetDontShowTodayFlag(bool flag)
    {
    }

    [Token(Token = "0x600386C")]
    [Address(RVA = "0x310C64C", Offset = "0x310C64C", VA = "0x310C64C")]
    static OpenInfoSaveData()
    {
    }
  }
}
