// Decompiled with JetBrains decompiler
// Type: staq.SaveData.StoryArchiveMemorySaveData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections.Generic;

#nullable disable
namespace staq.SaveData
{
  [Token(Token = "0x2003D4A")]
  public class StoryArchiveMemorySaveData
  {
    [Token(Token = "0x4010D7B")]
    [FieldOffset(Offset = "0x1D")]
    private bool loaded;

    [Token(Token = "0x17005092")]
    public List<int> PlayedArchiveIds
    {
      [Token(Token = "0x6018AA2"), Address(RVA = "0x263EC28", Offset = "0x263EC28", VA = "0x263EC28")] get
      {
        return (List<int>) null;
      }
      [Token(Token = "0x6018AA3"), Address(RVA = "0x263EC30", Offset = "0x263EC30", VA = "0x263EC30")] set
      {
      }
    }

    [Token(Token = "0x17005093")]
    public bool IsIntroUnlocked
    {
      [Token(Token = "0x6018AA4"), Address(RVA = "0x263EC38", Offset = "0x263EC38", VA = "0x263EC38")] get
      {
        return new bool();
      }
      [Token(Token = "0x6018AA5"), Address(RVA = "0x263EC40", Offset = "0x263EC40", VA = "0x263EC40")] set
      {
      }
    }

    [Token(Token = "0x17005094")]
    public bool IsCommonUnlocked
    {
      [Token(Token = "0x6018AA6"), Address(RVA = "0x263EC4C", Offset = "0x263EC4C", VA = "0x263EC4C")] get
      {
        return new bool();
      }
      [Token(Token = "0x6018AA7"), Address(RVA = "0x263EC54", Offset = "0x263EC54", VA = "0x263EC54")] set
      {
      }
    }

    [Token(Token = "0x17005095")]
    public bool IsDinatanUnlocked
    {
      [Token(Token = "0x6018AA8"), Address(RVA = "0x263EC60", Offset = "0x263EC60", VA = "0x263EC60")] get
      {
        return new bool();
      }
      [Token(Token = "0x6018AA9"), Address(RVA = "0x263EC68", Offset = "0x263EC68", VA = "0x263EC68")] set
      {
      }
    }

    [Token(Token = "0x17005096")]
    public bool IsLanslotUnlocked
    {
      [Token(Token = "0x6018AAA"), Address(RVA = "0x263EC74", Offset = "0x263EC74", VA = "0x263EC74")] get
      {
        return new bool();
      }
      [Token(Token = "0x6018AAB"), Address(RVA = "0x263EC7C", Offset = "0x263EC7C", VA = "0x263EC7C")] set
      {
      }
    }

    [Token(Token = "0x17005097")]
    public bool IsGuinevereUnlocked
    {
      [Token(Token = "0x6018AAC"), Address(RVA = "0x263EC88", Offset = "0x263EC88", VA = "0x263EC88")] get
      {
        return new bool();
      }
      [Token(Token = "0x6018AAD"), Address(RVA = "0x263EC90", Offset = "0x263EC90", VA = "0x263EC90")] set
      {
      }
    }

    [Token(Token = "0x17005098")]
    private static string Path
    {
      [Token(Token = "0x6018AAE"), Address(RVA = "0x263EC9C", Offset = "0x263EC9C", VA = "0x263EC9C")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x6018AAF")]
    [Address(RVA = "0x263ECEC", Offset = "0x263ECEC", VA = "0x263ECEC")]
    public string GetPath() => (string) null;

    [Token(Token = "0x6018AB0")]
    [Address(RVA = "0x263ED34", Offset = "0x263ED34", VA = "0x263ED34")]
    public void DeleteFile()
    {
    }

    [Token(Token = "0x6018AB1")]
    [Address(RVA = "0x263ED64", Offset = "0x263ED64", VA = "0x263ED64")]
    public void Delete()
    {
    }

    [Token(Token = "0x6018AB2")]
    [Address(RVA = "0x263ED80", Offset = "0x263ED80", VA = "0x263ED80")]
    public void Load()
    {
    }

    [Token(Token = "0x6018AB3")]
    [Address(RVA = "0x263F018", Offset = "0x263F018", VA = "0x263F018")]
    public void Save()
    {
    }

    [Token(Token = "0x6018AB4")]
    [Address(RVA = "0x263F160", Offset = "0x263F160", VA = "0x263F160")]
    public StoryArchiveMemorySaveData()
    {
    }
  }
}
