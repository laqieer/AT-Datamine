// Decompiled with JetBrains decompiler
// Type: Scenes.OutGame.Info.Style.StylePopupView
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Battle.UI;
using GameCore.UIControls;
using Il2CppDummyDll;
using Scenes.OutGame.Info.Common.UI;
using Scenes.OutGame.Info.Skill;
using Scenes.OutGame.Info.Skill.UI;
using StaqData;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace Scenes.OutGame.Info.Style
{
  [Token(Token = "0x200355C")]
  public class StylePopupView
  {
    [Token(Token = "0x400E80F")]
    [FieldOffset(Offset = "0x10")]
    private Image thumbnail;
    [Token(Token = "0x400E810")]
    [FieldOffset(Offset = "0x18")]
    private SkillListUI skillList;
    [Token(Token = "0x400E811")]
    [FieldOffset(Offset = "0x20")]
    private IAssetProvider assetProvider;
    [Token(Token = "0x400E812")]
    [FieldOffset(Offset = "0x28")]
    private ItemIcon trustIcon;
    [Token(Token = "0x400E813")]
    [FieldOffset(Offset = "0x30")]
    private UIManager uiManager;

    [Token(Token = "0x6014F23")]
    [Address(RVA = "0x4A9D36C", Offset = "0x4A9D36C", VA = "0x4A9D36C")]
    public StylePopupView(
      Image thumbnail,
      SkillListUI skillList,
      IAssetProvider assetProvider,
      ItemIcon trustIcon,
      UIManager uiManager)
    {
    }

    [Token(Token = "0x6014F24")]
    [Address(RVA = "0x4A9D3BC", Offset = "0x4A9D3BC", VA = "0x4A9D3BC")]
    public void SetThumbnail(Sprite sprite)
    {
    }

    [Token(Token = "0x6014F25")]
    [Address(RVA = "0x4A9D3F4", Offset = "0x4A9D3F4", VA = "0x4A9D3F4")]
    public void ResetSkills()
    {
    }

    [Token(Token = "0x6014F26")]
    [Address(RVA = "0x4A9D5C4", Offset = "0x4A9D5C4", VA = "0x4A9D5C4")]
    public void SetTrustIcon(ItemUtility.Parameter param)
    {
    }

    [Token(Token = "0x6014F27")]
    [Address(RVA = "0x4A9D64C", Offset = "0x4A9D64C", VA = "0x4A9D64C")]
    public void SetSkill(SkillModelBase model, bool isUnlocked = true)
    {
    }

    [Token(Token = "0x6014F28")]
    [Address(RVA = "0x4A9D7B0", Offset = "0x4A9D7B0", VA = "0x4A9D7B0")]
    private SkillView AddSkillElement() => (SkillView) null;
  }
}
