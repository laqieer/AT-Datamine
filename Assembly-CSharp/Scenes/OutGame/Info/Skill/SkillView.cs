// Decompiled with JetBrains decompiler
// Type: Scenes.OutGame.Info.Skill.SkillView
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.MasterData;
using Il2CppDummyDll;
using Scenes.OutGame.Info.Common.UI;
using Scenes.OutGame.Info.Skill.UI;
using Scenes.OutGame.OutGameMenu;
using System;

#nullable disable
namespace Scenes.OutGame.Info.Skill
{
  [Token(Token = "0x2003581")]
  public class SkillView
  {
    [Token(Token = "0x170045B6")]
    public SkillInfoUI SkillInfoUI
    {
      [Token(Token = "0x6015017"), Address(RVA = "0x4AA451C", Offset = "0x4AA451C", VA = "0x4AA451C")] private get
      {
        return (SkillInfoUI) null;
      }
      [Token(Token = "0x6015018"), Address(RVA = "0x4AA4524", Offset = "0x4AA4524", VA = "0x4AA4524")] set
      {
      }
    }

    [Token(Token = "0x170045B7")]
    public DetailSkillListThumb SkillListThumb
    {
      [Token(Token = "0x6015019"), Address(RVA = "0x4AA452C", Offset = "0x4AA452C", VA = "0x4AA452C")] private get
      {
        return (DetailSkillListThumb) null;
      }
      [Token(Token = "0x601501A"), Address(RVA = "0x4AA4534", Offset = "0x4AA4534", VA = "0x4AA4534")] set
      {
      }
    }

    [Token(Token = "0x170045B8")]
    public IAssetProvider AssetProvider
    {
      [Token(Token = "0x601501B"), Address(RVA = "0x4AA453C", Offset = "0x4AA453C", VA = "0x4AA453C")] private get
      {
        return (IAssetProvider) null;
      }
      [Token(Token = "0x601501C"), Address(RVA = "0x4AA4544", Offset = "0x4AA4544", VA = "0x4AA4544")] set
      {
      }
    }

    [Token(Token = "0x601501D")]
    [Address(RVA = "0x4AA32A4", Offset = "0x4AA32A4", VA = "0x4AA32A4")]
    public void Initialize()
    {
    }

    [Token(Token = "0x601501E")]
    [Address(RVA = "0x4A9D860", Offset = "0x4A9D860", VA = "0x4A9D860")]
    public void RegisterShowDetailAction(Action onShowDetail)
    {
    }

    [Token(Token = "0x601501F")]
    [Address(RVA = "0x4AA454C", Offset = "0x4AA454C", VA = "0x4AA454C")]
    private void RegisterShowDetailActionSkillInfoUI(Action onShowDetail)
    {
    }

    [Token(Token = "0x6015020")]
    [Address(RVA = "0x4AA45E0", Offset = "0x4AA45E0", VA = "0x4AA45E0")]
    private void RegisterShowDetailActionSkillListThumb(Action onShowDetail)
    {
    }

    [Token(Token = "0x6015021")]
    [Address(RVA = "0x4AA3558", Offset = "0x4AA3558", VA = "0x4AA3558")]
    public void SetSkillIcon(int skillID)
    {
    }

    [Token(Token = "0x6015022")]
    [Address(RVA = "0x4AA3540", Offset = "0x4AA3540", VA = "0x4AA3540")]
    public void Show()
    {
    }

    [Token(Token = "0x6015023")]
    [Address(RVA = "0x4AA47C8", Offset = "0x4AA47C8", VA = "0x4AA47C8")]
    private void ShowSkillInfoUI()
    {
    }

    [Token(Token = "0x6015024")]
    [Address(RVA = "0x4AA485C", Offset = "0x4AA485C", VA = "0x4AA485C")]
    private void ShowSkillListThumb()
    {
    }

    [Token(Token = "0x6015025")]
    [Address(RVA = "0x4AA32A8", Offset = "0x4AA32A8", VA = "0x4AA32A8")]
    public void Hide()
    {
    }

    [Token(Token = "0x6015026")]
    [Address(RVA = "0x4AA48F0", Offset = "0x4AA48F0", VA = "0x4AA48F0")]
    private void HideSkillInfoUI()
    {
    }

    [Token(Token = "0x6015027")]
    [Address(RVA = "0x4AA4984", Offset = "0x4AA4984", VA = "0x4AA4984")]
    private void HideSkillListThumb()
    {
    }

    [Token(Token = "0x6015028")]
    [Address(RVA = "0x4AA3780", Offset = "0x4AA3780", VA = "0x4AA3780")]
    public void SetTitle(string value)
    {
    }

    [Token(Token = "0x6015029")]
    [Address(RVA = "0x4AA4168", Offset = "0x4AA4168", VA = "0x4AA4168")]
    public void SetDescription(string value)
    {
    }

    [Token(Token = "0x601502A")]
    [Address(RVA = "0x4AA3928", Offset = "0x4AA3928", VA = "0x4AA3928")]
    public void SetConsumeDurability(int value)
    {
    }

    [Token(Token = "0x601502B")]
    [Address(RVA = "0x4AA3894", Offset = "0x4AA3894", VA = "0x4AA3894")]
    public void SetLevel(int value)
    {
    }

    [Token(Token = "0x601502C")]
    [Address(RVA = "0x4AA3814", Offset = "0x4AA3814", VA = "0x4AA3814")]
    public void SetLevelNothing()
    {
    }

    [Token(Token = "0x601502D")]
    [Address(RVA = "0x4AA4C34", Offset = "0x4AA4C34", VA = "0x4AA4C34")]
    public void SetCost(int value)
    {
    }

    [Token(Token = "0x601502E")]
    [Address(RVA = "0x4AA4040", Offset = "0x4AA4040", VA = "0x4AA4040")]
    public void SetCoolTime(int value)
    {
    }

    [Token(Token = "0x601502F")]
    [Address(RVA = "0x4AA40D4", Offset = "0x4AA40D4", VA = "0x4AA40D4")]
    public void SetRange(int rangeTypeID)
    {
    }

    [Token(Token = "0x6015030")]
    [Address(RVA = "0x4AA4F1C", Offset = "0x4AA4F1C", VA = "0x4AA4F1C")]
    public void SetSkill(int skillID, int skillLevel)
    {
    }

    [Token(Token = "0x6015031")]
    [Address(RVA = "0x4AA4F4C", Offset = "0x4AA4F4C", VA = "0x4AA4F4C")]
    private void SetSkillSkillInfoUI(int skillID, int skillLevel)
    {
    }

    [Token(Token = "0x6015032")]
    [Address(RVA = "0x4AA4FE8", Offset = "0x4AA4FE8", VA = "0x4AA4FE8")]
    private void SetSkillSkillListThumb(int skillID, int skillLevel)
    {
    }

    [Token(Token = "0x6015033")]
    [Address(RVA = "0x4A9D830", Offset = "0x4A9D830", VA = "0x4A9D830")]
    public void SetSkill(SkillModelBase skill, bool isUnlocked = true)
    {
    }

    [Token(Token = "0x6015034")]
    [Address(RVA = "0x4AA5854", Offset = "0x4AA5854", VA = "0x4AA5854")]
    private void SetSkillSkillInfoUI(SkillModelBase skill)
    {
    }

    [Token(Token = "0x6015035")]
    [Address(RVA = "0x4AA58E8", Offset = "0x4AA58E8", VA = "0x4AA58E8")]
    private void SetSkillSkillListThumb(SkillModelBase skill, bool isUnlocked = true)
    {
    }

    [Token(Token = "0x6015036")]
    [Address(RVA = "0x4AA3FAC", Offset = "0x4AA3FAC", VA = "0x4AA3FAC")]
    public void SetUsableCount(int value)
    {
    }

    [Token(Token = "0x6015037")]
    [Address(RVA = "0x4AA3A50", Offset = "0x4AA3A50", VA = "0x4AA3A50")]
    public void SetSkillType(SkillTypeEnum type)
    {
    }

    [Token(Token = "0x6015038")]
    [Address(RVA = "0x4AA3AE4", Offset = "0x4AA3AE4", VA = "0x4AA3AE4")]
    public void SetSubIcons(
      SkillEffectIconNameUtility.SkillEffectIconData[] skillEffectIconData)
    {
    }

    [Token(Token = "0x6015039")]
    [Address(RVA = "0x4AA39BC", Offset = "0x4AA39BC", VA = "0x4AA39BC")]
    public void SetWeaponType(
      EquipmentClassificationData equipmentClassificationData)
    {
    }

    [Token(Token = "0x601503A")]
    [Address(RVA = "0x4AA3D34", Offset = "0x4AA3D34", VA = "0x4AA3D34")]
    public void SetTags(string[] tags)
    {
    }

    [Token(Token = "0x601503B")]
    [Address(RVA = "0x4AA3E30", Offset = "0x4AA3E30", VA = "0x4AA3E30")]
    public void SetRarity(RarityTypeEnum rarity)
    {
    }

    [Token(Token = "0x601503C")]
    [Address(RVA = "0x4A9DA4C", Offset = "0x4A9DA4C", VA = "0x4A9DA4C")]
    public SkillView()
    {
    }
  }
}
