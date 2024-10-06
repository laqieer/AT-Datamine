// Decompiled with JetBrains decompiler
// Type: staq.SaveData.URLSchemeParameterSaveData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections.Generic;

#nullable disable
namespace staq.SaveData
{
  [Token(Token = "0x2003D53")]
  public class URLSchemeParameterSaveData
  {
    [Token(Token = "0x4010D91")]
    [FieldOffset(Offset = "0x10")]
    private URLSchemeParameterSaveData.URLSchemeParameterData Data;

    [Token(Token = "0x1700509D")]
    private static string Path
    {
      [Token(Token = "0x6018AE7"), Address(RVA = "0x2640F68", Offset = "0x2640F68", VA = "0x2640F68")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x6018AE8")]
    [Address(RVA = "0x2640FB8", Offset = "0x2640FB8", VA = "0x2640FB8")]
    public string GetPath() => (string) null;

    [Token(Token = "0x6018AE9")]
    [Address(RVA = "0x2641000", Offset = "0x2641000", VA = "0x2641000")]
    public void DeleteFile()
    {
    }

    [Token(Token = "0x6018AEA")]
    [Address(RVA = "0x264102C", Offset = "0x264102C", VA = "0x264102C")]
    public void Delete()
    {
    }

    [Token(Token = "0x6018AEB")]
    [Address(RVA = "0x2641194", Offset = "0x2641194", VA = "0x2641194")]
    public bool IsExist() => new bool();

    [Token(Token = "0x6018AEC")]
    [Address(RVA = "0x2641044", Offset = "0x2641044", VA = "0x2641044")]
    public void Load()
    {
    }

    [Token(Token = "0x6018AED")]
    [Address(RVA = "0x26411A8", Offset = "0x26411A8", VA = "0x26411A8")]
    public void Save()
    {
    }

    [Token(Token = "0x6018AEE")]
    [Address(RVA = "0x2641244", Offset = "0x2641244", VA = "0x2641244")]
    public void AddURL(string url)
    {
    }

    [Token(Token = "0x6018AEF")]
    [Address(RVA = "0x2641468", Offset = "0x2641468", VA = "0x2641468")]
    public void RemoveURL(string url)
    {
    }

    [Token(Token = "0x6018AF0")]
    [Address(RVA = "0x264155C", Offset = "0x264155C", VA = "0x264155C")]
    public string[] GetURLs() => (string[]) null;

    [Token(Token = "0x6018AF1")]
    [Address(RVA = "0x264167C", Offset = "0x264167C", VA = "0x264167C")]
    public URLSchemeParameterSaveData()
    {
    }

    [Token(Token = "0x2003D54")]
    public class URLSchemeParameterData
    {
      [Token(Token = "0x1700509E")]
      public List<URLSchemeParameterSaveData.URLSchemeParameterDetail> Parameters
      {
        [Token(Token = "0x6018AF2"), Address(RVA = "0x2641684", Offset = "0x2641684", VA = "0x2641684")] get
        {
          return (List<URLSchemeParameterSaveData.URLSchemeParameterDetail>) null;
        }
        [Token(Token = "0x6018AF3"), Address(RVA = "0x264168C", Offset = "0x264168C", VA = "0x264168C")] private set
        {
        }
      }

      [Token(Token = "0x6018AF4")]
      [Address(RVA = "0x2640F18", Offset = "0x2640F18", VA = "0x2640F18")]
      public URLSchemeParameterData(
        List<URLSchemeParameterSaveData.URLSchemeParameterDetail> parameters)
      {
      }

      [Token(Token = "0x6018AF5")]
      [Address(RVA = "0x26412D8", Offset = "0x26412D8", VA = "0x26412D8")]
      public bool Contains(string url) => new bool();

      [Token(Token = "0x6018AF6")]
      [Address(RVA = "0x26413C0", Offset = "0x26413C0", VA = "0x26413C0")]
      public void Add(
        URLSchemeParameterSaveData.URLSchemeParameterDetail urlSchemeParameterDetail)
      {
      }

      [Token(Token = "0x6018AF7")]
      [Address(RVA = "0x2641480", Offset = "0x2641480", VA = "0x2641480")]
      public void Remove(string url)
      {
      }
    }

    [Token(Token = "0x2003D57")]
    public class URLSchemeParameterDetail
    {
      [Token(Token = "0x1700509F")]
      public string URL
      {
        [Token(Token = "0x6018AFC"), Address(RVA = "0x26416EC", Offset = "0x26416EC", VA = "0x26416EC")] get
        {
          return (string) null;
        }
        [Token(Token = "0x6018AFD"), Address(RVA = "0x26416F4", Offset = "0x26416F4", VA = "0x26416F4")] private set
        {
        }
      }

      [Token(Token = "0x6018AFE")]
      [Address(RVA = "0x2640F40", Offset = "0x2640F40", VA = "0x2640F40")]
      public URLSchemeParameterDetail(string url)
      {
      }
    }
  }
}
