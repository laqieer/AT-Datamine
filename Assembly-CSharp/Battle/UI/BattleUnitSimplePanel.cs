// Decompiled with JetBrains decompiler
// Type: Battle.UI.BattleUnitSimplePanel
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Battle.Data;
using Battle.Data.Board;
using GameCore;
using GameCore.MasterData;
using Il2CppDummyDll;
using UI.Utilities.SerializeUI;
using UnityEngine;

#nullable disable
namespace Battle.UI
{
  [Token(Token = "0x2002427")]
  public sealed class BattleUnitSimplePanel : MonoBehaviour
  {
    [Token(Token = "0x4009AAF")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private HpGaugeController hpGaugeController;
    [Token(Token = "0x4009AB0")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private ImageContainer elementTypeIcon;
    [Token(Token = "0x4009AB1")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private ImageContainer weaponTypeIcon;
    [Token(Token = "0x4009AB2")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    private ImageContainer buffDebuffIcon;
    [Token(Token = "0x4009AB3")]
    [FieldOffset(Offset = "0x38")]
    [SerializeField]
    private ImageContainer badStatusIcon;
    [Token(Token = "0x4009AB4")]
    [FieldOffset(Offset = "0x40")]
    [SerializeField]
    private BattleUnitNumber battleUnitNumber;
    [Token(Token = "0x4009AB5")]
    [FieldOffset(Offset = "0x48")]
    [SerializeField]
    public BattleUnitSimplePanelTween panelTween;
    [Token(Token = "0x4009AB6")]
    [FieldOffset(Offset = "0x50")]
    [SerializeField]
    private GameObject hpStockRoot;
    [Token(Token = "0x4009AB7")]
    [FieldOffset(Offset = "0x58")]
    [SerializeField]
    public ImageContainer hpStockIcon;
    [Token(Token = "0x4009AB8")]
    [FieldOffset(Offset = "0x60")]
    [SerializeField]
    public ImageContainer hpStockIcon2;
    [Token(Token = "0x4009AB9")]
    [FieldOffset(Offset = "0x68")]
    private BattleUnitSimplePanel.DisplayMode mode;
    [Token(Token = "0x4009ABA")]
    [FieldOffset(Offset = "0x6C")]
    private BattleBadStatusTypeEnum? badStatus;
    [Token(Token = "0x4009ABB")]
    [FieldOffset(Offset = "0x74")]
    private BattleIconTypeEnum? battleIconType;
    [Token(Token = "0x4009ABC")]
    [FieldOffset(Offset = "0x7C")]
    private bool hasDealSlay;
    [Token(Token = "0x4009ABD")]
    [FieldOffset(Offset = "0x7D")]
    private bool hasTakeSlay;
    [Token(Token = "0x4009ABE")]
    [FieldOffset(Offset = "0x7E")]
    private bool hasElementAdvantage;
    [Token(Token = "0x4009ABF")]
    [FieldOffset(Offset = "0x7F")]
    private bool hasElementDisAdvantage;

    [Token(Token = "0x17002F8B")]
    public HpGaugeController HpGaugeController
    {
      [Token(Token = "0x600DD81"), Address(RVA = "0x1E28D64", Offset = "0x1E28D64", VA = "0x1E28D64")] get
      {
        return (HpGaugeController) null;
      }
    }

    [Token(Token = "0x17002F8C")]
    public bool Visible
    {
      [Token(Token = "0x600DD82"), Address(RVA = "0x1E28D6C", Offset = "0x1E28D6C", VA = "0x1E28D6C")] get
      {
        return new bool();
      }
      [Token(Token = "0x600DD83"), Address(RVA = "0x1E28D8C", Offset = "0x1E28D8C", VA = "0x1E28D8C")] set
      {
      }
    }

    [Token(Token = "0x17002F8D")]
    public int HPStock
    {
      [Token(Token = "0x600DD84"), Address(RVA = "0x1E28DB4", Offset = "0x1E28DB4", VA = "0x1E28DB4")] set
      {
      }
    }

    [Token(Token = "0x17002F8E")]
    public ElementTypeEnum ElementType
    {
      [Token(Token = "0x600DD85"), Address(RVA = "0x1E291C4", Offset = "0x1E291C4", VA = "0x1E291C4")] set
      {
      }
    }

    [Token(Token = "0x17002F8F")]
    public int WeaponSystem
    {
      [Token(Token = "0x600DD86"), Address(RVA = "0x1E29274", Offset = "0x1E29274", VA = "0x1E29274")] set
      {
      }
    }

    [Token(Token = "0x17002F90")]
    public BattleBadStatusTypeEnum? BadStatus
    {
      [Token(Token = "0x600DD87"), Address(RVA = "0x1E29368", Offset = "0x1E29368", VA = "0x1E29368")] set
      {
      }
    }

    [Token(Token = "0x17002F91")]
    public bool HasDealSlay
    {
      [Token(Token = "0x600DD88"), Address(RVA = "0x1E294BC", Offset = "0x1E294BC", VA = "0x1E294BC")] set
      {
      }
    }

    [Token(Token = "0x17002F92")]
    public bool HasTakeSlay
    {
      [Token(Token = "0x600DD89"), Address(RVA = "0x1E29514", Offset = "0x1E29514", VA = "0x1E29514")] set
      {
      }
    }

    [Token(Token = "0x17002F93")]
    public bool HasElementAdvantage
    {
      [Token(Token = "0x600DD8A"), Address(RVA = "0x1E29520", Offset = "0x1E29520", VA = "0x1E29520")] set
      {
      }
    }

    [Token(Token = "0x17002F94")]
    public bool HasElementDisAdvantage
    {
      [Token(Token = "0x600DD8B"), Address(RVA = "0x1E29590", Offset = "0x1E29590", VA = "0x1E29590")] set
      {
      }
    }

    [Token(Token = "0x600DD8C")]
    [Address(RVA = "0x1E2959C", Offset = "0x1E2959C", VA = "0x1E2959C")]
    public static BattleUnitSimplePanel Create(
      string assetBundleLabel,
      string assetName,
      Transform parent,
      ISystemFlags systemFlags,
      BattleConfigAsset config,
      UnitParameterData unit)
    {
      return (BattleUnitSimplePanel) null;
    }

    [Token(Token = "0x600DD8D")]
    [Address(RVA = "0x1E296CC", Offset = "0x1E296CC", VA = "0x1E296CC")]
    public void Initialize(
      ISystemFlags sys,
      BattleConfigAsset battleConfig,
      UnitParameterData unit)
    {
    }

    [Token(Token = "0x600DD8E")]
    [Address(RVA = "0x1E29EE8", Offset = "0x1E29EE8", VA = "0x1E29EE8")]
    public void SetPredictionHp(int maxHP, int currentHP, int afterHP)
    {
    }

    [Token(Token = "0x600DD8F")]
    [Address(RVA = "0x1E29148", Offset = "0x1E29148", VA = "0x1E29148")]
    public void SetHpStockGauge(bool hasStock)
    {
    }

    [Token(Token = "0x600DD90")]
    [Address(RVA = "0x1E2A038", Offset = "0x1E2A038", VA = "0x1E2A038")]
    public void SetHpGaugeAnimation(int damage)
    {
    }

    [Token(Token = "0x600DD91")]
    [Address(RVA = "0x1E2A0A0", Offset = "0x1E2A0A0", VA = "0x1E2A0A0")]
    public float GetHpGaugeValue() => new float();

    [Token(Token = "0x600DD92")]
    [Address(RVA = "0x1E2A0E4", Offset = "0x1E2A0E4", VA = "0x1E2A0E4")]
    public void Release()
    {
    }

    [Token(Token = "0x600DD93")]
    [Address(RVA = "0x1E29838", Offset = "0x1E29838", VA = "0x1E29838")]
    public void OnSwitchSystemStatusIcon(bool statusIcon)
    {
    }

    [Token(Token = "0x600DD94")]
    [Address(RVA = "0x1E2A150", Offset = "0x1E2A150", VA = "0x1E2A150")]
    private void ChangeDisplayMode(BattleUnitSimplePanel.DisplayMode mode)
    {
    }

    [Token(Token = "0x600DD95")]
    [Address(RVA = "0x1E294C8", Offset = "0x1E294C8", VA = "0x1E294C8")]
    private void OnChangeSlayDisplay()
    {
    }

    [Token(Token = "0x600DD96")]
    [Address(RVA = "0x1E2952C", Offset = "0x1E2952C", VA = "0x1E2952C")]
    private void OnChangeHasAdvantageDisplay()
    {
    }

    [Token(Token = "0x600DD97")]
    [Address(RVA = "0x1E2A6A8", Offset = "0x1E2A6A8", VA = "0x1E2A6A8")]
    public void SetBuffDebuffIcon(bool hasBuff, bool hasDebuff)
    {
    }

    [Token(Token = "0x600DD98")]
    [Address(RVA = "0x1E2A864", Offset = "0x1E2A864", VA = "0x1E2A864")]
    public void SetUnitNumber(int num)
    {
    }

    [Token(Token = "0x600DD99")]
    [Address(RVA = "0x1E2902C", Offset = "0x1E2902C", VA = "0x1E2902C")]
    private int GetNumberOfDigits(int value) => new int();

    [Token(Token = "0x600DD9A")]
    [Address(RVA = "0x1E29164", Offset = "0x1E29164", VA = "0x1E29164")]
    private int GetDigits(int num, int digit) => new int();

    [Token(Token = "0x600DD9B")]
    [Address(RVA = "0x1E2A87C", Offset = "0x1E2A87C", VA = "0x1E2A87C")]
    public BattleUnitSimplePanel()
    {
    }

    [Token(Token = "0x2002428")]
    public enum DisplayMode
    {
      [Token(Token = "0x4009AC1")] Normal,
      [Token(Token = "0x4009AC2")] StatusIcon,
    }
  }
}
