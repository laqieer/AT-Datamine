// Decompiled with JetBrains decompiler
// Type: Scenes.OutGame.Info.Skill.UI.SkillInfoUI
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Battle.Data;
using Battle.Data.Board;
using GameCore.MasterData;
using GameCore.UIControls;
using Il2CppDummyDll;
using Scenes.OutGame.Info.Common.UI;
using Scenes.OutGame.OutGameMenu;
using StaqData;
using System;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace Scenes.OutGame.Info.Skill.UI
{
  [Token(Token = "0x200358A")]
  public class SkillInfoUI : MonoBehaviour
  {
    [Token(Token = "0x400E8B7")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private GameObject[] titleGroupObjects;
    [Token(Token = "0x400E8B8")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private GameObject[] backgroundObjects;
    [Token(Token = "0x400E8B9")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private GameObject[] buttonGroupObjects;
    [Token(Token = "0x400E8BA")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    private SkillInfoTitleUI[] titleUIs;
    [Token(Token = "0x400E8BB")]
    [FieldOffset(Offset = "0x38")]
    [SerializeField]
    private Text cost;
    [Token(Token = "0x400E8BC")]
    [FieldOffset(Offset = "0x40")]
    [SerializeField]
    private Text consumeDurability;
    [Token(Token = "0x400E8BD")]
    [FieldOffset(Offset = "0x48")]
    [SerializeField]
    private Text coolTime;
    [Token(Token = "0x400E8BE")]
    [FieldOffset(Offset = "0x50")]
    [SerializeField]
    private GameObject coolTimeTxt;
    [Token(Token = "0x400E8BF")]
    [FieldOffset(Offset = "0x58")]
    [SerializeField]
    private Text usableCount;
    [Token(Token = "0x400E8C0")]
    [FieldOffset(Offset = "0x60")]
    [SerializeField]
    private Text description;
    [Token(Token = "0x400E8C1")]
    [FieldOffset(Offset = "0x68")]
    [SerializeField]
    private IconUI[] rangeTypeIcons;
    [Token(Token = "0x400E8C2")]
    [FieldOffset(Offset = "0x70")]
    [SerializeField]
    private Text rangeMin;
    [Token(Token = "0x400E8C3")]
    [FieldOffset(Offset = "0x78")]
    [SerializeField]
    private Text rangeMax;
    [Token(Token = "0x400E8C4")]
    [FieldOffset(Offset = "0x80")]
    [SerializeField]
    private IconUI classificationIcon;
    [Token(Token = "0x400E8C5")]
    [FieldOffset(Offset = "0x88")]
    [SerializeField]
    private Text classificationText;
    [Token(Token = "0x400E8C6")]
    [FieldOffset(Offset = "0x90")]
    [SerializeField]
    private SkillCategoryUI category;
    [Token(Token = "0x400E8C7")]
    [FieldOffset(Offset = "0x98")]
    [SerializeField]
    private SkillEffectTagUI tagUI;
    [Token(Token = "0x400E8C8")]
    [FieldOffset(Offset = "0xA0")]
    [SerializeField]
    private SkillRangeView skillRangeView;
    [Token(Token = "0x400E8C9")]
    [FieldOffset(Offset = "0xA8")]
    [SerializeField]
    private SkillInfoUI.SkillInfoViewType viewType;
    [Token(Token = "0x400E8CB")]
    [FieldOffset(Offset = "0xB8")]
    private BoardData boardData;
    [Token(Token = "0x400E8CC")]
    [FieldOffset(Offset = "0xC0")]
    private Battle.Data.Board.BattleData battleData;

    [Token(Token = "0x1400020F")]
    public event Action OnShowSkillDetail
    {
      [Token(Token = "0x601505C"), Address(RVA = "0x4AA4724", Offset = "0x4AA4724", VA = "0x4AA4724")] add
      {
      }
      [Token(Token = "0x601505D"), Address(RVA = "0x4AA7170", Offset = "0x4AA7170", VA = "0x4AA7170")] remove
      {
      }
    }

    [Token(Token = "0x601505E")]
    [Address(RVA = "0x4AA720C", Offset = "0x4AA720C", VA = "0x4AA720C")]
    public void ShowSkillDetail()
    {
    }

    [Token(Token = "0x601505F")]
    [Address(RVA = "0x4AA7228", Offset = "0x4AA7228", VA = "0x4AA7228")]
    public SkillView CreateSkillView(IAssetProvider assetProvider) => (SkillView) null;

    [Token(Token = "0x6015060")]
    [Address(RVA = "0x4AA729C", Offset = "0x4AA729C", VA = "0x4AA729C")]
    private void Start()
    {
    }

    [Token(Token = "0x6015061")]
    [Address(RVA = "0x4AA6718", Offset = "0x4AA6718", VA = "0x4AA6718")]
    public void Initialize()
    {
    }

    [Token(Token = "0x6015062")]
    [Address(RVA = "0x4AA7378", Offset = "0x4AA7378", VA = "0x4AA7378")]
    public void SetSkillIcon(Sprite sprite)
    {
    }

    [Token(Token = "0x6015063")]
    [Address(RVA = "0x4AA4A18", Offset = "0x4AA4A18", VA = "0x4AA4A18")]
    public void SetTitle(string title)
    {
    }

    [Token(Token = "0x6015064")]
    [Address(RVA = "0x4AA4A60", Offset = "0x4AA4A60", VA = "0x4AA4A60")]
    public void SetDescription(string text)
    {
    }

    [Token(Token = "0x6015065")]
    [Address(RVA = "0x4AA4BA4", Offset = "0x4AA4BA4", VA = "0x4AA4BA4")]
    public void SetLevel(int level)
    {
    }

    [Token(Token = "0x6015066")]
    [Address(RVA = "0x4AA4BEC", Offset = "0x4AA4BEC", VA = "0x4AA4BEC")]
    public void SetLevelNothing()
    {
    }

    [Token(Token = "0x6015067")]
    [Address(RVA = "0x4AA4B00", Offset = "0x4AA4B00", VA = "0x4AA4B00")]
    public void SetConsumeDurability(int consumeDurability)
    {
    }

    [Token(Token = "0x6015068")]
    [Address(RVA = "0x4AA4CC8", Offset = "0x4AA4CC8", VA = "0x4AA4CC8")]
    public void SetCost(int cost)
    {
    }

    [Token(Token = "0x6015069")]
    [Address(RVA = "0x4AA4D6C", Offset = "0x4AA4D6C", VA = "0x4AA4D6C")]
    public void SetCoolTime(int coolTime)
    {
    }

    [Token(Token = "0x601506A")]
    [Address(RVA = "0x4AA4E78", Offset = "0x4AA4E78", VA = "0x4AA4E78")]
    public void SetRange(int rangeTypeID)
    {
    }

    [Token(Token = "0x601506B")]
    [Address(RVA = "0x4AA73C0", Offset = "0x4AA73C0", VA = "0x4AA73C0")]
    public void SetRange(int min, int max)
    {
    }

    [Token(Token = "0x601506C")]
    [Address(RVA = "0x4AA63CC", Offset = "0x4AA63CC", VA = "0x4AA63CC")]
    public void SetWeaponType(
      EquipmentClassificationData equipmentClassificationData)
    {
    }

    [Token(Token = "0x601506D")]
    [Address(RVA = "0x4AA74FC", Offset = "0x4AA74FC", VA = "0x4AA74FC")]
    private void SetWeaponClassification(bool show, Sprite sprite)
    {
    }

    [Token(Token = "0x601506E")]
    [Address(RVA = "0x4AA6184", Offset = "0x4AA6184", VA = "0x4AA6184")]
    public void SetUsableCount(int useCount)
    {
    }

    [Token(Token = "0x601506F")]
    [Address(RVA = "0x4AA6270", Offset = "0x4AA6270", VA = "0x4AA6270")]
    public void SetSkillType(SkillTypeEnum skillType)
    {
    }

    [Token(Token = "0x6015070")]
    [Address(RVA = "0x4AA6320", Offset = "0x4AA6320", VA = "0x4AA6320")]
    public void ResetSubIcon()
    {
    }

    [Token(Token = "0x6015071")]
    [Address(RVA = "0x4AA6370", Offset = "0x4AA6370", VA = "0x4AA6370")]
    public void SetSubIconNone(bool isActive)
    {
    }

    [Token(Token = "0x6015072")]
    [Address(RVA = "0x4AA6568", Offset = "0x4AA6568", VA = "0x4AA6568")]
    public void AddSubIcon(Sprite icon, SkillIconSub.BgColor bgColor)
    {
    }

    [Token(Token = "0x6015073")]
    [Address(RVA = "0x4AA6488", Offset = "0x4AA6488", VA = "0x4AA6488")]
    public void SetTag(string tag1, string tag2)
    {
    }

    [Token(Token = "0x6015074")]
    [Address(RVA = "0x4AA779C", Offset = "0x4AA779C", VA = "0x4AA779C")]
    public void SetRarityBaseImage(Sprite baseImage)
    {
    }

    [Token(Token = "0x6015075")]
    [Address(RVA = "0x4AA508C", Offset = "0x4AA508C", VA = "0x4AA508C")]
    public void SetSkill(int skillID, int skillLevel)
    {
    }

    [Token(Token = "0x6015076")]
    [Address(RVA = "0x4AA7930", Offset = "0x4AA7930", VA = "0x4AA7930")]
    public void SetSkill(EquipmentSkill equipmentSkill)
    {
    }

    [Token(Token = "0x6015077")]
    [Address(RVA = "0x4AA5A34", Offset = "0x4AA5A34", VA = "0x4AA5A34")]
    public void SetSkill(SkillModelBase skill)
    {
    }

    [Token(Token = "0x6015078")]
    [Address(RVA = "0x4AA78A8", Offset = "0x4AA78A8", VA = "0x4AA78A8")]
    private void SetRangeTypeIcon(RangeTypeEnum rangeType)
    {
    }

    [Token(Token = "0x6015079")]
    [Address(RVA = "0x4AA77E4", Offset = "0x4AA77E4", VA = "0x4AA77E4")]
    public void SetSkill(
      IBasicRangeData firingRange,
      EffectData[] effectDatas = null,
      TargettableUnitTypeEnum? targettableUnitType = null)
    {
    }

    [Token(Token = "0x601507A")]
    [Address(RVA = "0x4AA80AC", Offset = "0x4AA80AC", VA = "0x4AA80AC")]
    public SkillInfoUI()
    {
    }

    [Token(Token = "0x200358B")]
    public enum SkillInfoViewType
    {
      [Token(Token = "0x400E8CE")] Normal,
      [Token(Token = "0x400E8CF")] Popup,
    }
  }
}
