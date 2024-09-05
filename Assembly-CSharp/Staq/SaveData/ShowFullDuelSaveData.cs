// Decompiled with JetBrains decompiler
// Type: staq.SaveData.ShowFullDuelSaveData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.MasterData;
using Il2CppDummyDll;
using System.Collections.Generic;

#nullable disable
namespace staq.SaveData
{
  [Token(Token = "0x2003D45")]
  public class ShowFullDuelSaveData
  {
    [Token(Token = "0x4010D60")]
    [FieldOffset(Offset = "0x10")]
    public List<int> ShowFullDuelIDList;

    [Token(Token = "0x1700507A")]
    public static string Path
    {
      [Token(Token = "0x6018A72"), Address(RVA = "0x263CEEC", Offset = "0x263CEEC", VA = "0x263CEEC")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x6018A73")]
    [Address(RVA = "0x263CF3C", Offset = "0x263CF3C", VA = "0x263CF3C")]
    public string GetPath() => (string) null;

    [Token(Token = "0x6018A74")]
    [Address(RVA = "0x263CF84", Offset = "0x263CF84", VA = "0x263CF84")]
    public void DeleteFile()
    {
    }

    [Token(Token = "0x6018A75")]
    [Address(RVA = "0x263CFB4", Offset = "0x263CFB4", VA = "0x263CFB4")]
    public void Delete()
    {
    }

    [Token(Token = "0x6018A76")]
    [Address(RVA = "0x263CFCC", Offset = "0x263CFCC", VA = "0x263CFCC")]
    public void Load()
    {
    }

    [Token(Token = "0x6018A77")]
    [Address(RVA = "0x263D200", Offset = "0x263D200", VA = "0x263D200")]
    public void Save()
    {
    }

    [Token(Token = "0x6018A78")]
    [Address(RVA = "0x263D2D4", Offset = "0x263D2D4", VA = "0x263D2D4")]
    public void ShowDuelIdSet(SkillCategoryTypeEnum category, int skillId)
    {
    }

    [Token(Token = "0x6018A79")]
    [Address(RVA = "0x263D3D8", Offset = "0x263D3D8", VA = "0x263D3D8")]
    public bool ShowDuelListCheck(int skillId) => new bool();

    [Token(Token = "0x6018A7A")]
    [Address(RVA = "0x263D3CC", Offset = "0x263D3CC", VA = "0x263D3CC")]
    public bool ShowDuelCategoryCheck(SkillCategoryTypeEnum category) => new bool();

    [Token(Token = "0x6018A7B")]
    [Address(RVA = "0x263D430", Offset = "0x263D430", VA = "0x263D430")]
    public ShowFullDuelSaveData()
    {
    }
  }
}
