// Decompiled with JetBrains decompiler
// Type: Scenes.OutGame.OutGameMenu.DetailSkillListThumb
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore;
using GameCore.MasterData;
using Il2CppDummyDll;
using Scenes.OutGame.Info.Common.UI;
using Scenes.OutGame.Info.Skill;
using StaqData;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

#nullable disable
namespace Scenes.OutGame.OutGameMenu
{
  [Token(Token = "0x2003A4B")]
  public class DetailSkillListThumb : SkillListThumbBase
  {
    [Token(Token = "0x400FF54")]
    [FieldOffset(Offset = "0xE0")]
    [SerializeField]
    private RectTransform subSkillIconParent;
    [Token(Token = "0x400FF55")]
    [FieldOffset(Offset = "0xE8")]
    [SerializeField]
    private Image typeIconImage;
    [Token(Token = "0x400FF56")]
    [FieldOffset(Offset = "0xF0")]
    [SerializeField]
    private GameObject disableObj;
    [Token(Token = "0x400FF57")]
    [FieldOffset(Offset = "0xF8")]
    [SerializeField]
    private Text openConditionText;
    [Token(Token = "0x400FF58")]
    [FieldOffset(Offset = "0x100")]
    private AssetCachedSpawner assetCachedSpawner;
    [Token(Token = "0x400FF59")]
    [FieldOffset(Offset = "0x108")]
    private bool IsStyleExSkill;

    [Token(Token = "0x17004B1F")]
    public RectTransform SubSkillIconParent
    {
      [Token(Token = "0x6016E73"), Address(RVA = "0x29BAC68", Offset = "0x29BAC68", VA = "0x29BAC68")] get
      {
        return (RectTransform) null;
      }
    }

    [Token(Token = "0x17004B20")]
    public GameObject EmptySubSkillObj
    {
      [Token(Token = "0x6016E74"), Address(RVA = "0x29BAC70", Offset = "0x29BAC70", VA = "0x29BAC70")] get
      {
        return (GameObject) null;
      }
    }

    [Token(Token = "0x17004B21")]
    public Image TypeIconImage
    {
      [Token(Token = "0x6016E75"), Address(RVA = "0x29BAC78", Offset = "0x29BAC78", VA = "0x29BAC78")] get
      {
        return (Image) null;
      }
    }

    [Token(Token = "0x17004B22")]
    public Text TypeText
    {
      [Token(Token = "0x6016E76"), Address(RVA = "0x29BAC80", Offset = "0x29BAC80", VA = "0x29BAC80")] get
      {
        return (Text) null;
      }
    }

    [Token(Token = "0x17004B23")]
    public GameObject DisbleObj
    {
      [Token(Token = "0x6016E77"), Address(RVA = "0x29BAC88", Offset = "0x29BAC88", VA = "0x29BAC88")] get
      {
        return (GameObject) null;
      }
    }

    [Token(Token = "0x6016E78")]
    [Address(RVA = "0x29BAC90", Offset = "0x29BAC90", VA = "0x29BAC90")]
    public void Initialize(SkillModelBase skill, IAssetProvider assetProvider = null)
    {
    }

    [Token(Token = "0x6016E79")]
    [Address(RVA = "0x29BB4B0", Offset = "0x29BB4B0", VA = "0x29BB4B0")]
    public void Initialize(EquipmentSkill skill, IAssetProvider assetProvider = null)
    {
    }

    [Token(Token = "0x6016E7A")]
    [Address(RVA = "0x29BB528", Offset = "0x29BB528", VA = "0x29BB528")]
    public void Initialize(int skillId, int skillLevel, IAssetProvider assetProvider = null)
    {
    }

    [Token(Token = "0x6016E7B")]
    [Address(RVA = "0x29BB538", Offset = "0x29BB538", VA = "0x29BB538")]
    public void Initialize(
      int skillId,
      int skillLevel,
      RarityTypeEnum rarityType,
      IAssetProvider assetProvider = null,
      bool isExSkill = false)
    {
    }

    [Token(Token = "0x6016E7C")]
    [Address(RVA = "0x29BB680", Offset = "0x29BB680", VA = "0x29BB680")]
    public void Initialize(CustomSkillData customSkillData, IAssetProvider assetProvider = null)
    {
    }

    [Token(Token = "0x6016E7D")]
    [Address(RVA = "0x29BB7A8", Offset = "0x29BB7A8", VA = "0x29BB7A8")]
    public void Initialize(StyleSkillSettingData styleSkill, IAssetProvider assetProvider = null)
    {
    }

    [Token(Token = "0x6016E7E")]
    [Address(RVA = "0x29BAD90", Offset = "0x29BAD90", VA = "0x29BAD90")]
    private void Initialize(
      SkillData skillData,
      SkillDetailData skillDetailData,
      RarityTypeEnum rarityType,
      int skillLevel,
      IAssetProvider assetProvider)
    {
    }

    [Token(Token = "0x6016E7F")]
    [Address(RVA = "0x29BB8D0", Offset = "0x29BB8D0", VA = "0x29BB8D0")]
    private void InitThumbnailImage(SkillData skillData)
    {
    }

    [Token(Token = "0x6016E80")]
    [Address(RVA = "0x29BBA30", Offset = "0x29BBA30", VA = "0x29BBA30")]
    private void InitRarityBaseImage(RarityTypeEnum rarityType)
    {
    }

    [Token(Token = "0x6016E81")]
    [Address(RVA = "0x29BC0E8", Offset = "0x29BC0E8", VA = "0x29BC0E8")]
    private void InitSkillIconSub(
      SkillIconSub subSkillIcon,
      string iconName,
      SkillIconSub.BgColor bgColor)
    {
    }

    [Token(Token = "0x6016E82")]
    [Address(RVA = "0x29BC314", Offset = "0x29BC314", VA = "0x29BC314")]
    public CommonButton GetButton() => (CommonButton) null;

    [Token(Token = "0x6016E83")]
    [Address(RVA = "0x29BC31C", Offset = "0x29BC31C", VA = "0x29BC31C")]
    public void SetOnClickButtonEvent(UnityAction callback)
    {
    }

    [Token(Token = "0x6016E84")]
    [Address(RVA = "0x29BC360", Offset = "0x29BC360", VA = "0x29BC360")]
    public void SetOpenCondition(bool isActive, string openCondition)
    {
    }

    [Token(Token = "0x6016E85")]
    [Address(RVA = "0x29BC424", Offset = "0x29BC424", VA = "0x29BC424")]
    public DetailSkillListThumb()
    {
    }
  }
}
