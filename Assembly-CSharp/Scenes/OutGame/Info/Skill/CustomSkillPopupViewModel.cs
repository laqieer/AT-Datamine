// Decompiled with JetBrains decompiler
// Type: Scenes.OutGame.Info.Skill.CustomSkillPopupViewModel
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using Scenes.OutGame.Info.Common.UI;
using Scenes.OutGame.Info.Equipment;

#nullable disable
namespace Scenes.OutGame.Info.Skill
{
  [Token(Token = "0x2003576")]
  public class CustomSkillPopupViewModel
  {
    [Token(Token = "0x400E87A")]
    [FieldOffset(Offset = "0x10")]
    private EquipmentCommonModel commonModel;
    [Token(Token = "0x400E87B")]
    [FieldOffset(Offset = "0x18")]
    private SkillModel skillModel;
    [Token(Token = "0x400E87C")]
    [FieldOffset(Offset = "0x20")]
    private CustomSkillPopupView view;

    [Token(Token = "0x17004593")]
    public IAssetProvider AssetProvider
    {
      [Token(Token = "0x6014FB5"), Address(RVA = "0x4AA1774", Offset = "0x4AA1774", VA = "0x4AA1774")] private get
      {
        return (IAssetProvider) null;
      }
      [Token(Token = "0x6014FB6"), Address(RVA = "0x4AA177C", Offset = "0x4AA177C", VA = "0x4AA177C")] set
      {
      }
    }

    [Token(Token = "0x6014FB7")]
    [Address(RVA = "0x4AA1784", Offset = "0x4AA1784", VA = "0x4AA1784")]
    public void SetModel(EquipmentCommonModel commonModel)
    {
    }

    [Token(Token = "0x6014FB8")]
    [Address(RVA = "0x4AA178C", Offset = "0x4AA178C", VA = "0x4AA178C")]
    public void SetModel(SkillModel skillModel)
    {
    }

    [Token(Token = "0x6014FB9")]
    [Address(RVA = "0x4AA1794", Offset = "0x4AA1794", VA = "0x4AA1794")]
    public void SetView(CustomSkillPopupView view)
    {
    }

    [Token(Token = "0x6014FBA")]
    [Address(RVA = "0x4AA179C", Offset = "0x4AA179C", VA = "0x4AA179C")]
    public void OnChange()
    {
    }

    [Token(Token = "0x6014FBB")]
    [Address(RVA = "0x4AA1AA8", Offset = "0x4AA1AA8", VA = "0x4AA1AA8")]
    public CustomSkillPopupViewModel()
    {
    }
  }
}
