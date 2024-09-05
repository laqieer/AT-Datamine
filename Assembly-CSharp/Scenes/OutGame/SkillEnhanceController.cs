// Decompiled with JetBrains decompiler
// Type: Scenes.OutGame.SkillEnhanceController
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore;
using GameCore.MasterData;
using GameCore.UIControls;
using Il2CppDummyDll;
using StaqData;
using System;
using System.Collections;
using UI.Common;
using UI.ItemDetail;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace Scenes.OutGame
{
  [Token(Token = "0x20031D2")]
  public class SkillEnhanceController : MonoBehaviour
  {
    [Token(Token = "0x400D45C")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private CommonButton enhanceButton;
    [Token(Token = "0x400D45D")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private CommonButton levelInfoButton;
    [Token(Token = "0x400D45E")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private CommonButton MinusButton;
    [Token(Token = "0x400D45F")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    private CommonButton MinButton;
    [Token(Token = "0x400D460")]
    [FieldOffset(Offset = "0x38")]
    [SerializeField]
    private CommonButton PlusButton;
    [Token(Token = "0x400D461")]
    [FieldOffset(Offset = "0x40")]
    [SerializeField]
    private CommonButton MaxButton;
    [Token(Token = "0x400D462")]
    [FieldOffset(Offset = "0x48")]
    [SerializeField]
    private CommonButton closeButton;
    [Token(Token = "0x400D463")]
    [FieldOffset(Offset = "0x50")]
    public Action OnClickCloseAction;
    [Token(Token = "0x400D464")]
    [FieldOffset(Offset = "0x58")]
    [SerializeField]
    private ItemIcon itemIcon;
    [Token(Token = "0x400D465")]
    [FieldOffset(Offset = "0x60")]
    [SerializeField]
    private Text needItemPossessionText;
    [Token(Token = "0x400D466")]
    [FieldOffset(Offset = "0x68")]
    [SerializeField]
    private Text tryCountText;
    [Token(Token = "0x400D467")]
    [FieldOffset(Offset = "0x70")]
    [SerializeField]
    private Text tryRateText;
    [Token(Token = "0x400D468")]
    [FieldOffset(Offset = "0x78")]
    [SerializeField]
    private GaugeScale enegrySlider;
    [Token(Token = "0x400D469")]
    [FieldOffset(Offset = "0x80")]
    private int tryCount;
    [Token(Token = "0x400D46A")]
    [FieldOffset(Offset = "0x84")]
    private int tryCountMax;
    [Token(Token = "0x400D46B")]
    [FieldOffset(Offset = "0x88")]
    private int itemPossessionCountMax;
    [Token(Token = "0x400D46C")]
    [FieldOffset(Offset = "0x8C")]
    private EquipmentSkill.EnhanceTypeEnum skillEnhanceType;
    [Token(Token = "0x400D46D")]
    [FieldOffset(Offset = "0x90")]
    private int skillID;
    [Token(Token = "0x400D46E")]
    [FieldOffset(Offset = "0x94")]
    private RarityTypeEnum rarityType;
    [Token(Token = "0x400D46F")]
    [FieldOffset(Offset = "0x98")]
    private int skillLevel;
    [Token(Token = "0x400D470")]
    [FieldOffset(Offset = "0x9C")]
    private int skillEnergy;
    [Token(Token = "0x400D471")]
    [FieldOffset(Offset = "0xA0")]
    private bool canSkillEnhance;
    [Token(Token = "0x400D472")]
    [FieldOffset(Offset = "0xA8")]
    private AssetCachedSpawner assetCachedSpawner;
    [Token(Token = "0x400D473")]
    [FieldOffset(Offset = "0xB0")]
    private EquipmentSkillEnhanceData useEnhanceData;
    [Token(Token = "0x400D474")]
    [FieldOffset(Offset = "0xB8")]
    private Action<int> onClickEnhance;
    [Token(Token = "0x400D475")]
    [FieldOffset(Offset = "0xC0")]
    private Action<int> onClickInvalidEnhance;
    [Token(Token = "0x400D476")]
    [FieldOffset(Offset = "0xC8")]
    private Action onClickLevelInfo;
    [Token(Token = "0x400D477")]
    [FieldOffset(Offset = "0xD0")]
    private bool isEnabledEnhanceButton;

    [Token(Token = "0x170040EA")]
    public CommonButton EnhanceButton
    {
      [Token(Token = "0x601371E"), Address(RVA = "0x4E0BCF0", Offset = "0x4E0BCF0", VA = "0x4E0BCF0")] get
      {
        return (CommonButton) null;
      }
    }

    [Token(Token = "0x170040EB")]
    public int TryCount
    {
      [Token(Token = "0x601371F"), Address(RVA = "0x4E0BCF8", Offset = "0x4E0BCF8", VA = "0x4E0BCF8")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x170040EC")]
    public bool enhancedMaxLv
    {
      [Token(Token = "0x6013720"), Address(RVA = "0x4E0BD00", Offset = "0x4E0BD00", VA = "0x4E0BD00")] get
      {
        return new bool();
      }
      [Token(Token = "0x6013721"), Address(RVA = "0x4E0BD08", Offset = "0x4E0BD08", VA = "0x4E0BD08")] set
      {
      }
    }

    [Token(Token = "0x170040ED")]
    public ItemDetailPopupProvider ItemDetailPopupProvider
    {
      [Token(Token = "0x6013722"), Address(RVA = "0x4E0BD14", Offset = "0x4E0BD14", VA = "0x4E0BD14")] get
      {
        return (ItemDetailPopupProvider) null;
      }
      [Token(Token = "0x6013723"), Address(RVA = "0x4E0BD1C", Offset = "0x4E0BD1C", VA = "0x4E0BD1C")] set
      {
      }
    }

    [Token(Token = "0x6013724")]
    [Address(RVA = "0x4E0BD24", Offset = "0x4E0BD24", VA = "0x4E0BD24")]
    private void Awake()
    {
    }

    [Token(Token = "0x6013725")]
    [Address(RVA = "0x4E0B278", Offset = "0x4E0B278", VA = "0x4E0B278")]
    public bool SetSkill(
      AssetCachedSpawner assetCachedSpawner,
      EquipmentSkill.EnhanceTypeEnum skillType,
      int skillID,
      RarityTypeEnum rarityType,
      int skillLevel,
      int skillEnergy,
      Action<int> onClickEnhance,
      Action<int> onClickInvalidEnhance,
      Action onClickLevelInfo = null)
    {
      return new bool();
    }

    [Token(Token = "0x6013726")]
    [Address(RVA = "0x4E0B92C", Offset = "0x4E0B92C", VA = "0x4E0B92C")]
    public IEnumerator StartConnecting() => (IEnumerator) null;

    [Token(Token = "0x6013727")]
    [Address(RVA = "0x4E0B994", Offset = "0x4E0B994", VA = "0x4E0B994")]
    public IEnumerator EndConnecting() => (IEnumerator) null;

    [Token(Token = "0x6013728")]
    [Address(RVA = "0x4E0BA8C", Offset = "0x4E0BA8C", VA = "0x4E0BA8C")]
    public void SetEnhancedParameter(int level, int energy)
    {
    }

    [Token(Token = "0x6013729")]
    [Address(RVA = "0x4E0CDAC", Offset = "0x4E0CDAC", VA = "0x4E0CDAC")]
    private void UpdateEnhanceParameter()
    {
    }

    [Token(Token = "0x601372A")]
    [Address(RVA = "0x4E0CDE8", Offset = "0x4E0CDE8", VA = "0x4E0CDE8")]
    private void OnClickPlus()
    {
    }

    [Token(Token = "0x601372B")]
    [Address(RVA = "0x4E0CEDC", Offset = "0x4E0CEDC", VA = "0x4E0CEDC")]
    private void OnClickMax()
    {
    }

    [Token(Token = "0x601372C")]
    [Address(RVA = "0x4E0CEF0", Offset = "0x4E0CEF0", VA = "0x4E0CEF0")]
    private void OnClickMinus()
    {
    }

    [Token(Token = "0x601372D")]
    [Address(RVA = "0x4E0CF70", Offset = "0x4E0CF70", VA = "0x4E0CF70")]
    private void OnClickMin()
    {
    }

    [Token(Token = "0x601372E")]
    [Address(RVA = "0x4E0CF84", Offset = "0x4E0CF84", VA = "0x4E0CF84")]
    private void OnClickEnhance()
    {
    }

    [Token(Token = "0x601372F")]
    [Address(RVA = "0x4E0CFBC", Offset = "0x4E0CFBC", VA = "0x4E0CFBC")]
    private void OnClickClose()
    {
    }

    [Token(Token = "0x6013730")]
    [Address(RVA = "0x4E0CFD8", Offset = "0x4E0CFD8", VA = "0x4E0CFD8")]
    private void OnLevelInfoButton()
    {
    }

    [Token(Token = "0x6013731")]
    [Address(RVA = "0x4E0C000", Offset = "0x4E0C000", VA = "0x4E0C000")]
    private bool SetUseEnhanceItem() => new bool();

    [Token(Token = "0x6013732")]
    [Address(RVA = "0x4E0C7B8", Offset = "0x4E0C7B8", VA = "0x4E0C7B8")]
    private void UpdateEnhanceTryParameter(int count)
    {
    }

    [Token(Token = "0x6013733")]
    [Address(RVA = "0x4E0C35C", Offset = "0x4E0C35C", VA = "0x4E0C35C")]
    private bool SetEnhanceCounter(bool canEnhance) => new bool();

    [Token(Token = "0x6013734")]
    [Address(RVA = "0x4E0CC7C", Offset = "0x4E0CC7C", VA = "0x4E0CC7C")]
    private int GetUseItemProsessionNumber(ItemTypeEnum type, int id) => new int();

    [Token(Token = "0x6013735")]
    [Address(RVA = "0x4E0CFF4", Offset = "0x4E0CFF4", VA = "0x4E0CFF4")]
    private EquipmentSkillEnhanceData GetUseEnhanceItem() => (EquipmentSkillEnhanceData) null;

    [Token(Token = "0x6013736")]
    [Address(RVA = "0x4E0D4D0", Offset = "0x4E0D4D0", VA = "0x4E0D4D0")]
    public SkillEnhanceController()
    {
    }
  }
}
