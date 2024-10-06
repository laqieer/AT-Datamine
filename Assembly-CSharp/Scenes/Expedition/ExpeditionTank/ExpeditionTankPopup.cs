// Decompiled with JetBrains decompiler
// Type: Scenes.Expedition.ExpeditionTank.ExpeditionTankPopup
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore;
using GameCore.MasterData;
using GameCore.Popup;
using GameCore.Tween;
using Il2CppDummyDll;
using Network.Param;
using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace Scenes.Expedition.ExpeditionTank
{
  [Token(Token = "0x2002CF1")]
  public class ExpeditionTankPopup : PopupBase
  {
    [Token(Token = "0x400C02E")]
    [FieldOffset(Offset = "0x88")]
    [SerializeField]
    private CommonButton lawButton;
    [Token(Token = "0x400C02F")]
    [FieldOffset(Offset = "0x90")]
    [SerializeField]
    private GameObject strengtheningButtonObj;
    [Token(Token = "0x400C030")]
    [FieldOffset(Offset = "0x98")]
    [SerializeField]
    private GameObject blueTankStrengthenInfoObj;
    [Token(Token = "0x400C031")]
    [FieldOffset(Offset = "0xA0")]
    [SerializeField]
    private GameObject blueTankMaxInfoObj;
    [Token(Token = "0x400C032")]
    [FieldOffset(Offset = "0xA8")]
    [SerializeField]
    private GameObject redTankStrengthenInfoObj;
    [Token(Token = "0x400C033")]
    [FieldOffset(Offset = "0xB0")]
    [SerializeField]
    private GameObject redTankMaxInfoObj;
    [Token(Token = "0x400C034")]
    [FieldOffset(Offset = "0xB8")]
    [Header("青ソウル")]
    [SerializeField]
    private TextMeshProUGUI blueTankCostText;
    [Token(Token = "0x400C035")]
    [FieldOffset(Offset = "0xC0")]
    [SerializeField]
    private GameObject blueTankReinforcementLimit;
    [Token(Token = "0x400C036")]
    [FieldOffset(Offset = "0xC8")]
    [SerializeField]
    private GameObject blueTankChangeLevelGroup;
    [Token(Token = "0x400C037")]
    [FieldOffset(Offset = "0xD0")]
    [SerializeField]
    private TextMeshProUGUI blueTankLevelText;
    [Token(Token = "0x400C038")]
    [FieldOffset(Offset = "0xD8")]
    [SerializeField]
    private TextMeshProUGUI blueTankNextLevelText;
    [Token(Token = "0x400C039")]
    [FieldOffset(Offset = "0xE0")]
    [SerializeField]
    private TextMeshProUGUI blueTankMaxLevel;
    [Token(Token = "0x400C03A")]
    [FieldOffset(Offset = "0xE8")]
    [SerializeField]
    private Text blueTankStrageValueText;
    [Token(Token = "0x400C03B")]
    [FieldOffset(Offset = "0xF0")]
    [SerializeField]
    private Text blueTankNextStrageValueText;
    [Token(Token = "0x400C03C")]
    [FieldOffset(Offset = "0xF8")]
    [SerializeField]
    private GameObject blueTankStrageLimit;
    [Token(Token = "0x400C03D")]
    [FieldOffset(Offset = "0x100")]
    [SerializeField]
    private UITweenGroup blueCoinTween;
    [Token(Token = "0x400C03E")]
    [FieldOffset(Offset = "0x108")]
    [SerializeField]
    private UITweenGroup blueFreeCoinTween;
    [Token(Token = "0x400C03F")]
    [FieldOffset(Offset = "0x110")]
    [SerializeField]
    private Text blueCoinText;
    [Token(Token = "0x400C040")]
    [FieldOffset(Offset = "0x118")]
    [SerializeField]
    private Text blueFreeCoinText;
    [Token(Token = "0x400C041")]
    [FieldOffset(Offset = "0x120")]
    [SerializeField]
    private CommonButton blueTankButton;
    [Token(Token = "0x400C042")]
    [FieldOffset(Offset = "0x128")]
    [SerializeField]
    private TextMeshProUGUI blueTankMaxLevelText;
    [Token(Token = "0x400C043")]
    [FieldOffset(Offset = "0x130")]
    [SerializeField]
    private Text blueTankMaxStrageValueText;
    [Token(Token = "0x400C044")]
    [FieldOffset(Offset = "0x138")]
    [SerializeField]
    [Header("赤ソウル")]
    private TextMeshProUGUI redTankCostText;
    [Token(Token = "0x400C045")]
    [FieldOffset(Offset = "0x140")]
    [SerializeField]
    private GameObject redTankReinforcementLimit;
    [Token(Token = "0x400C046")]
    [FieldOffset(Offset = "0x148")]
    [SerializeField]
    private GameObject redTankChangeLevelGroup;
    [Token(Token = "0x400C047")]
    [FieldOffset(Offset = "0x150")]
    [SerializeField]
    private TextMeshProUGUI redTankLevelText;
    [Token(Token = "0x400C048")]
    [FieldOffset(Offset = "0x158")]
    [SerializeField]
    private TextMeshProUGUI redTankNextLevelText;
    [Token(Token = "0x400C049")]
    [FieldOffset(Offset = "0x160")]
    [SerializeField]
    private TextMeshProUGUI redTankMaxLevel;
    [Token(Token = "0x400C04A")]
    [FieldOffset(Offset = "0x168")]
    [SerializeField]
    private Text redTankStrageValueText;
    [Token(Token = "0x400C04B")]
    [FieldOffset(Offset = "0x170")]
    [SerializeField]
    private Text redTankNextStrageValueText;
    [Token(Token = "0x400C04C")]
    [FieldOffset(Offset = "0x178")]
    [SerializeField]
    private GameObject redTankStrageLimit;
    [Token(Token = "0x400C04D")]
    [FieldOffset(Offset = "0x180")]
    [SerializeField]
    private UITweenGroup redCoinTween;
    [Token(Token = "0x400C04E")]
    [FieldOffset(Offset = "0x188")]
    [SerializeField]
    private UITweenGroup redFreeCoinTween;
    [Token(Token = "0x400C04F")]
    [FieldOffset(Offset = "0x190")]
    [SerializeField]
    private Text redCoinText;
    [Token(Token = "0x400C050")]
    [FieldOffset(Offset = "0x198")]
    [SerializeField]
    private Text redFreeCoinText;
    [Token(Token = "0x400C051")]
    [FieldOffset(Offset = "0x1A0")]
    [SerializeField]
    private CommonButton redTankButton;
    [Token(Token = "0x400C052")]
    [FieldOffset(Offset = "0x1A8")]
    [SerializeField]
    private TextMeshProUGUI redTankMaxLevelText;
    [Token(Token = "0x400C053")]
    [FieldOffset(Offset = "0x1B0")]
    [SerializeField]
    private Text redTankMaxStrageValueText;
    [Token(Token = "0x400C054")]
    [FieldOffset(Offset = "0x1B8")]
    [SerializeField]
    private GameObject soulTankForcementEffectPopup;
    [Token(Token = "0x400C055")]
    [FieldOffset(Offset = "0x1C0")]
    private SoulTankForcementEffectPopup soulTankForcementEffectObj;
    [Token(Token = "0x400C056")]
    [FieldOffset(Offset = "0x1C8")]
    private List<PlayerExpeditionSoulTankType> currSoulTankType;
    [Token(Token = "0x400C057")]
    [FieldOffset(Offset = "0x1D0")]
    private ExpeditionTankPopup.TankParam blueTankParam;
    [Token(Token = "0x400C058")]
    [FieldOffset(Offset = "0x1D8")]
    private ExpeditionTankPopup.TankParam redTankParam;
    [Token(Token = "0x400C059")]
    [FieldOffset(Offset = "0x1E0")]
    private int blueTankLevelMax;
    [Token(Token = "0x400C05A")]
    [FieldOffset(Offset = "0x1E4")]
    private int redTankLevelMax;
    [Token(Token = "0x400C05B")]
    [FieldOffset(Offset = "0x1E8")]
    private bool isMoneyBlueEnough;
    [Token(Token = "0x400C05C")]
    [FieldOffset(Offset = "0x1E9")]
    private bool isMoneyRedEnough;
    [Token(Token = "0x400C05D")]
    [FieldOffset(Offset = "0x1EA")]
    private bool isClicked;
    [Token(Token = "0x400C05E")]
    [FieldOffset(Offset = "0x1F0")]
    private AssetCachedSpawner assetCachedSpawner;
    [Token(Token = "0x400C05F")]
    [FieldOffset(Offset = "0x1F8")]
    private Action tankLevelUpCallback;
    [Token(Token = "0x400C060")]
    [FieldOffset(Offset = "0x200")]
    private bool isOpenBlue;

    [Token(Token = "0x6011969")]
    [Address(RVA = "0x46A2450", Offset = "0x46A2450", VA = "0x46A2450")]
    public void Initialize(AssetCachedSpawner assetCachedSpawner, Action tankLevelUpCallback)
    {
    }

    [Token(Token = "0x601196A")]
    [Address(RVA = "0x46A2F4C", Offset = "0x46A2F4C", VA = "0x46A2F4C")]
    public void SetData(List<PlayerExpeditionSoulTankType> tanks, bool isOpenBlue)
    {
    }

    [Token(Token = "0x601196B")]
    [Address(RVA = "0x46A3900", Offset = "0x46A3900", VA = "0x46A3900")]
    public void OnStrengtheningButton()
    {
    }

    [Token(Token = "0x601196C")]
    [Address(RVA = "0x46A3910", Offset = "0x46A3910", VA = "0x46A3910")]
    public void OnStrengtheningBlueTank()
    {
    }

    [Token(Token = "0x601196D")]
    [Address(RVA = "0x46A3A18", Offset = "0x46A3A18", VA = "0x46A3A18")]
    public void OnStrengtheningRedTank()
    {
    }

    [Token(Token = "0x601196E")]
    [Address(RVA = "0x46A3BA4", Offset = "0x46A3BA4", VA = "0x46A3BA4")]
    private IEnumerator ForcementSoulTank(SoulTypeEnum soulType) => (IEnumerator) null;

    [Token(Token = "0x601196F")]
    [Address(RVA = "0x46A3C44", Offset = "0x46A3C44", VA = "0x46A3C44", Slot = "9")]
    public override void Close()
    {
    }

    [Token(Token = "0x6011970")]
    [Address(RVA = "0x46A3CD4", Offset = "0x46A3CD4", VA = "0x46A3CD4", Slot = "5")]
    public override void OnClickClose()
    {
    }

    [Token(Token = "0x6011971")]
    [Address(RVA = "0x46A3B20", Offset = "0x46A3B20", VA = "0x46A3B20")]
    private void OpenNotification(string text)
    {
    }

    [Token(Token = "0x6011972")]
    [Address(RVA = "0x46A2578", Offset = "0x46A2578", VA = "0x46A2578")]
    private void UpdateUI()
    {
    }

    [Token(Token = "0x6011973")]
    [Address(RVA = "0x46A3CE0", Offset = "0x46A3CE0", VA = "0x46A3CE0")]
    private IEnumerator PlaySoulTankForcementEffect(SoulTypeEnum soulType) => (IEnumerator) null;

    [Token(Token = "0x6011974")]
    [Address(RVA = "0x46A3D80", Offset = "0x46A3D80", VA = "0x46A3D80")]
    public ExpeditionTankPopup()
    {
    }

    [Token(Token = "0x2002CF2")]
    public class TankParam
    {
      [Token(Token = "0x17003C65")]
      public int LevelNow
      {
        [Token(Token = "0x6011979"), Address(RVA = "0x46A3E40", Offset = "0x46A3E40", VA = "0x46A3E40")] get
        {
          return new int();
        }
        [Token(Token = "0x601197A"), Address(RVA = "0x46A3E48", Offset = "0x46A3E48", VA = "0x46A3E48")] set
        {
        }
      }

      [Token(Token = "0x17003C66")]
      public int LevelNext
      {
        [Token(Token = "0x601197B"), Address(RVA = "0x46A3E50", Offset = "0x46A3E50", VA = "0x46A3E50")] get
        {
          return new int();
        }
        [Token(Token = "0x601197C"), Address(RVA = "0x46A3E58", Offset = "0x46A3E58", VA = "0x46A3E58")] set
        {
        }
      }

      [Token(Token = "0x17003C67")]
      public int StrageNow
      {
        [Token(Token = "0x601197D"), Address(RVA = "0x46A3E60", Offset = "0x46A3E60", VA = "0x46A3E60")] get
        {
          return new int();
        }
        [Token(Token = "0x601197E"), Address(RVA = "0x46A3E68", Offset = "0x46A3E68", VA = "0x46A3E68")] set
        {
        }
      }

      [Token(Token = "0x17003C68")]
      public int StrageNext
      {
        [Token(Token = "0x601197F"), Address(RVA = "0x46A3E70", Offset = "0x46A3E70", VA = "0x46A3E70")] get
        {
          return new int();
        }
        [Token(Token = "0x6011980"), Address(RVA = "0x46A3E78", Offset = "0x46A3E78", VA = "0x46A3E78")] set
        {
        }
      }

      [Token(Token = "0x17003C69")]
      public int CostNow
      {
        [Token(Token = "0x6011981"), Address(RVA = "0x46A3E80", Offset = "0x46A3E80", VA = "0x46A3E80")] get
        {
          return new int();
        }
        [Token(Token = "0x6011982"), Address(RVA = "0x46A3E88", Offset = "0x46A3E88", VA = "0x46A3E88")] set
        {
        }
      }

      [Token(Token = "0x17003C6A")]
      public int CostNeed
      {
        [Token(Token = "0x6011983"), Address(RVA = "0x46A3E90", Offset = "0x46A3E90", VA = "0x46A3E90")] get
        {
          return new int();
        }
        [Token(Token = "0x6011984"), Address(RVA = "0x46A3E98", Offset = "0x46A3E98", VA = "0x46A3E98")] set
        {
        }
      }

      [Token(Token = "0x6011985")]
      [Address(RVA = "0x46A38F8", Offset = "0x46A38F8", VA = "0x46A38F8")]
      public TankParam()
      {
      }
    }
  }
}
