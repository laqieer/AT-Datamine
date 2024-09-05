// Decompiled with JetBrains decompiler
// Type: Battle.UI.BattleUnitDetail.BattleUnitSkillDetailPanel
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Battle.Data.Board;
using GameCore.UIControls;
using Il2CppDummyDll;
using System.Collections.Generic;
using UnitDetail.Customize;
using UnitDetail.Data.ScriptableObjects;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace Battle.UI.BattleUnitDetail
{
  [Token(Token = "0x2002443")]
  public sealed class BattleUnitSkillDetailPanel : MonoBehaviour
  {
    [Token(Token = "0x4009B52")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private SkillIcon skillIcon;
    [Token(Token = "0x4009B53")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private SkillCategoryImageSwitcher skillCategory;
    [Token(Token = "0x4009B54")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private Text skillName;
    [Token(Token = "0x4009B55")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    private Text skillLevel;
    [Token(Token = "0x4009B56")]
    [FieldOffset(Offset = "0x38")]
    [SerializeField]
    private Image equipedUnitFaceImage;
    [Token(Token = "0x4009B57")]
    [FieldOffset(Offset = "0x40")]
    [SerializeField]
    private GameObject skillRangeViewRoot;
    [Token(Token = "0x4009B58")]
    [FieldOffset(Offset = "0x48")]
    [SerializeField]
    private SkillRangeView skillRangeView;
    [Token(Token = "0x4009B59")]
    [FieldOffset(Offset = "0x50")]
    [SerializeField]
    private FeatureIcon elementFeatureImage;
    [Token(Token = "0x4009B5A")]
    [FieldOffset(Offset = "0x58")]
    [SerializeField]
    private List<SkillTagImageSwitcher> skillTagImages;
    [Token(Token = "0x4009B5B")]
    [FieldOffset(Offset = "0x60")]
    [SerializeField]
    private GameObject usageCountViewRoot;
    [Token(Token = "0x4009B5C")]
    [FieldOffset(Offset = "0x68")]
    [SerializeField]
    private Text usageCount;
    [Token(Token = "0x4009B5D")]
    [FieldOffset(Offset = "0x70")]
    [SerializeField]
    private GameObject consumeDurableCountViewRoot;
    [Token(Token = "0x4009B5E")]
    [FieldOffset(Offset = "0x78")]
    [SerializeField]
    private Text consumeDurableCount;
    [Token(Token = "0x4009B5F")]
    [FieldOffset(Offset = "0x80")]
    [SerializeField]
    private GameObject viewAvailableForDagger;
    [Token(Token = "0x4009B60")]
    [FieldOffset(Offset = "0x88")]
    [SerializeField]
    private GameObject viewAvailableForOneHandedSword;
    [Token(Token = "0x4009B61")]
    [FieldOffset(Offset = "0x90")]
    [SerializeField]
    private GameObject viewAvailableForLargeSword;
    [Token(Token = "0x4009B62")]
    [FieldOffset(Offset = "0x98")]
    [SerializeField]
    private GameObject viewAvailableForOneHandAxe;
    [Token(Token = "0x4009B63")]
    [FieldOffset(Offset = "0xA0")]
    [SerializeField]
    private GameObject viewAvailableForLageAxe;
    [Token(Token = "0x4009B64")]
    [FieldOffset(Offset = "0xA8")]
    [SerializeField]
    private GameObject viewAvailableForTwoHandedHammer;
    [Token(Token = "0x4009B65")]
    [FieldOffset(Offset = "0xB0")]
    [SerializeField]
    private GameObject viewAvailableForSpear;
    [Token(Token = "0x4009B66")]
    [FieldOffset(Offset = "0xB8")]
    [SerializeField]
    private GameObject viewAvailableForLance;
    [Token(Token = "0x4009B67")]
    [FieldOffset(Offset = "0xC0")]
    [SerializeField]
    private GameObject viewAvailableForBow;
    [Token(Token = "0x4009B68")]
    [FieldOffset(Offset = "0xC8")]
    [SerializeField]
    private GameObject viewAvailableForCrossbow;
    [Token(Token = "0x4009B69")]
    [FieldOffset(Offset = "0xD0")]
    [SerializeField]
    private GameObject viewAvailableForGun;
    [Token(Token = "0x4009B6A")]
    [FieldOffset(Offset = "0xD8")]
    [SerializeField]
    private GameObject viewAvailableForFireBook;
    [Token(Token = "0x4009B6B")]
    [FieldOffset(Offset = "0xE0")]
    [SerializeField]
    private GameObject viewAvailableForIceBook;
    [Token(Token = "0x4009B6C")]
    [FieldOffset(Offset = "0xE8")]
    [SerializeField]
    private GameObject viewAvailableForThunderBook;
    [Token(Token = "0x4009B6D")]
    [FieldOffset(Offset = "0xF0")]
    [SerializeField]
    private GameObject viewAvailableForWindBook;
    [Token(Token = "0x4009B6E")]
    [FieldOffset(Offset = "0xF8")]
    [SerializeField]
    private GameObject viewAvailableForLightBook;
    [Token(Token = "0x4009B6F")]
    [FieldOffset(Offset = "0x100")]
    [SerializeField]
    private GameObject viewAvailableForDarkBook;
    [Token(Token = "0x4009B70")]
    [FieldOffset(Offset = "0x108")]
    [SerializeField]
    private GameObject viewAvailableForRod;
    [Token(Token = "0x4009B71")]
    [FieldOffset(Offset = "0x110")]
    [SerializeField]
    private Text skillDetail;
    [Token(Token = "0x4009B72")]
    [FieldOffset(Offset = "0x118")]
    [SerializeField]
    private GameObject expViewGroup;
    [Token(Token = "0x4009B73")]
    [FieldOffset(Offset = "0x120")]
    [SerializeField]
    private GameObject[] expStars;
    [Token(Token = "0x4009B74")]
    [FieldOffset(Offset = "0x128")]
    [SerializeField]
    private Text expRate;
    [Token(Token = "0x4009B75")]
    [FieldOffset(Offset = "0x130")]
    [SerializeField]
    private Slider expSlider;
    [Token(Token = "0x4009B76")]
    [FieldOffset(Offset = "0x138")]
    [SerializeField]
    private GameObject enhancementViewGroup;
    [Token(Token = "0x4009B77")]
    [FieldOffset(Offset = "0x140")]
    private UnitFeatureTable featureTable;

    [Token(Token = "0x600DE41")]
    [Address(RVA = "0x1E2FF64", Offset = "0x1E2FF64", VA = "0x1E2FF64")]
    public void Initialize(UnitFeatureTable featureTable)
    {
    }

    [Token(Token = "0x600DE42")]
    [Address(RVA = "0x1E2FF88", Offset = "0x1E2FF88", VA = "0x1E2FF88")]
    public void Set(Sprite equipedUnitFaceImage, SkillData skill)
    {
    }

    [Token(Token = "0x600DE43")]
    [Address(RVA = "0x1E302C0", Offset = "0x1E302C0", VA = "0x1E302C0")]
    private void Set(ActiveSkillData skill)
    {
    }

    [Token(Token = "0x600DE44")]
    [Address(RVA = "0x1E30348", Offset = "0x1E30348", VA = "0x1E30348")]
    private void Set(PassiveSkillData skill)
    {
    }

    [Token(Token = "0x600DE45")]
    [Address(RVA = "0x1E30088", Offset = "0x1E30088", VA = "0x1E30088")]
    private void SetEquipedUnitInformation(Sprite equipedUnitFaceImage)
    {
    }

    [Token(Token = "0x600DE46")]
    [Address(RVA = "0x1E30140", Offset = "0x1E30140", VA = "0x1E30140")]
    private void SetCommonInformation(SkillData skill)
    {
    }

    [Token(Token = "0x600DE47")]
    [Address(RVA = "0x1E3038C", Offset = "0x1E3038C", VA = "0x1E3038C")]
    private void UpdateSkillElementType(SkillData skill)
    {
    }

    [Token(Token = "0x600DE48")]
    [Address(RVA = "0x1E30418", Offset = "0x1E30418", VA = "0x1E30418")]
    private void UpdateSkillTags(SkillData skill)
    {
    }

    [Token(Token = "0x600DE49")]
    [Address(RVA = "0x1E30528", Offset = "0x1E30528", VA = "0x1E30528")]
    private void UpdateUsableWeaponTypes(SkillData skill)
    {
    }

    [Token(Token = "0x600DE4A")]
    [Address(RVA = "0x1E30FBC", Offset = "0x1E30FBC", VA = "0x1E30FBC")]
    public BattleUnitSkillDetailPanel()
    {
    }
  }
}
