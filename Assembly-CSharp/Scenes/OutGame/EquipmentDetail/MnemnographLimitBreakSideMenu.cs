// Decompiled with JetBrains decompiler
// Type: Scenes.OutGame.EquipmentDetail.MnemnographLimitBreakSideMenu
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore;
using Il2CppDummyDll;
using StaqData;
using System;
using System.Collections;
using UI.Common;
using UI.ItemDetail;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace Scenes.OutGame.EquipmentDetail
{
  [Token(Token = "0x20036E7")]
  public class MnemnographLimitBreakSideMenu : MnemnographDetailSideMenuBase
  {
    [Token(Token = "0x400EF9A")]
    [FieldOffset(Offset = "0x58")]
    [SerializeField]
    private CommonButton closeButton;
    [Token(Token = "0x400EF9B")]
    [FieldOffset(Offset = "0x60")]
    [SerializeField]
    private LimitBreakIcons beforeLimitBreakIcons;
    [Token(Token = "0x400EF9C")]
    [FieldOffset(Offset = "0x68")]
    [SerializeField]
    private LimitBreakIcons afterLimitBreakIcons;
    [Token(Token = "0x400EF9D")]
    [FieldOffset(Offset = "0x70")]
    [SerializeField]
    private Text beforeSkillLevel;
    [Token(Token = "0x400EF9E")]
    [FieldOffset(Offset = "0x78")]
    [SerializeField]
    private Text afterSkillLevel;
    [Token(Token = "0x400EF9F")]
    [FieldOffset(Offset = "0x80")]
    [SerializeField]
    private GameObject thumbnail;
    [Token(Token = "0x400EFA0")]
    [FieldOffset(Offset = "0x88")]
    [SerializeField]
    private Text textNum;
    [Token(Token = "0x400EFA1")]
    [FieldOffset(Offset = "0x90")]
    [SerializeField]
    private Sprite blankSprit;
    [Token(Token = "0x400EFA2")]
    [FieldOffset(Offset = "0x98")]
    [SerializeField]
    private Sprite normalSprit;
    [Token(Token = "0x400EFA3")]
    [FieldOffset(Offset = "0xA0")]
    private int limitBreakNumMax;
    [Token(Token = "0x400EFA4")]
    [FieldOffset(Offset = "0xA4")]
    private int limitBreakNum;
    [Token(Token = "0x400EFA5")]
    [FieldOffset(Offset = "0xA8")]
    private MnemnographDetailSubScene detailSubScene;
    [Token(Token = "0x400EFA6")]
    [FieldOffset(Offset = "0xB0")]
    private ItemDetailPopupProvider itemDetailPopupProvider;
    [Token(Token = "0x400EFA7")]
    [FieldOffset(Offset = "0xB8")]
    private Color levelUpTextColor;

    [Token(Token = "0x1700478C")]
    private AssetCachedSpawner assetCachedSpawner
    {
      [Token(Token = "0x60159FA"), Address(RVA = "0x1D7E2A0", Offset = "0x1D7E2A0", VA = "0x1D7E2A0")] get
      {
        return (AssetCachedSpawner) null;
      }
    }

    [Token(Token = "0x60159FB")]
    [Address(RVA = "0x1D7E2BC", Offset = "0x1D7E2BC", VA = "0x1D7E2BC")]
    public void Initialize(MnemnographDetailSubScene detailSubScene)
    {
    }

    [Token(Token = "0x60159FC")]
    [Address(RVA = "0x1D7E2F4", Offset = "0x1D7E2F4", VA = "0x1D7E2F4", Slot = "4")]
    protected override void OnClickMinButton()
    {
    }

    [Token(Token = "0x60159FD")]
    [Address(RVA = "0x1D7E454", Offset = "0x1D7E454", VA = "0x1D7E454", Slot = "5")]
    protected override void OnClickMinusButton()
    {
    }

    [Token(Token = "0x60159FE")]
    [Address(RVA = "0x1D7E468", Offset = "0x1D7E468", VA = "0x1D7E468", Slot = "6")]
    protected override void OnClickPlusButton()
    {
    }

    [Token(Token = "0x60159FF")]
    [Address(RVA = "0x1D7E480", Offset = "0x1D7E480", VA = "0x1D7E480", Slot = "7")]
    protected override void OnClickMaxButton()
    {
    }

    [Token(Token = "0x6015A00")]
    [Address(RVA = "0x1D7E48C", Offset = "0x1D7E48C", VA = "0x1D7E48C", Slot = "8")]
    protected override void OnClickEnhanceButton()
    {
    }

    [Token(Token = "0x6015A01")]
    [Address(RVA = "0x1D7E810", Offset = "0x1D7E810", VA = "0x1D7E810", Slot = "9")]
    public override void Set(MindEquipment mindEquipment, Action onClickCloseButton)
    {
    }

    [Token(Token = "0x6015A02")]
    [Address(RVA = "0x1D7EE48", Offset = "0x1D7EE48", VA = "0x1D7EE48")]
    public void NeedMaterialOnClick()
    {
    }

    [Token(Token = "0x6015A03")]
    [Address(RVA = "0x1D7EEF8", Offset = "0x1D7EEF8", VA = "0x1D7EEF8")]
    private void UpdateItemParameter()
    {
    }

    [Token(Token = "0x6015A04")]
    [Address(RVA = "0x1D7EFC8", Offset = "0x1D7EFC8", VA = "0x1D7EFC8", Slot = "10")]
    protected override void UpdateInfo(MindEquipment mindEquipment)
    {
    }

    [Token(Token = "0x6015A05")]
    [Address(RVA = "0x1D7F14C", Offset = "0x1D7F14C", VA = "0x1D7F14C", Slot = "11")]
    protected override void InitializedInternal()
    {
    }

    [Token(Token = "0x6015A06")]
    [Address(RVA = "0x1D7F214", Offset = "0x1D7F214", VA = "0x1D7F214", Slot = "12")]
    protected override IEnumerator Connect() => (IEnumerator) null;

    [Token(Token = "0x6015A07")]
    [Address(RVA = "0x1D7E7A8", Offset = "0x1D7E7A8", VA = "0x1D7E7A8")]
    private IEnumerator ExecuteLimitBreak() => (IEnumerator) null;

    [Token(Token = "0x6015A08")]
    [Address(RVA = "0x1D7F2CC", Offset = "0x1D7F2CC", VA = "0x1D7F2CC")]
    private IEnumerator EffectLimitBreak() => (IEnumerator) null;

    [Token(Token = "0x6015A09")]
    [Address(RVA = "0x1D7F35C", Offset = "0x1D7F35C", VA = "0x1D7F35C")]
    private void UpdateSideBiew()
    {
    }

    [Token(Token = "0x6015A0A")]
    [Address(RVA = "0x1D7E2FC", Offset = "0x1D7E2FC", VA = "0x1D7E2FC")]
    private void SetLimitBreakAfter()
    {
    }

    [Token(Token = "0x6015A0B")]
    [Address(RVA = "0x1D7F4E8", Offset = "0x1D7F4E8", VA = "0x1D7F4E8")]
    private void SetSelectButtonState()
    {
    }

    [Token(Token = "0x6015A0C")]
    [Address(RVA = "0x1D7F44C", Offset = "0x1D7F44C", VA = "0x1D7F44C")]
    private void SetTextNumWithEnhanceButtonInteractable()
    {
    }

    [Token(Token = "0x6015A0D")]
    [Address(RVA = "0x1D7E6D0", Offset = "0x1D7E6D0", VA = "0x1D7E6D0")]
    private bool IsUnavailableLimitBreak() => new bool();

    [Token(Token = "0x6015A0E")]
    [Address(RVA = "0x1D7EE20", Offset = "0x1D7EE20", VA = "0x1D7EE20")]
    private int CalcMaxNumCanLimitBreak() => new int();

    [Token(Token = "0x6015A0F")]
    [Address(RVA = "0x1D7F5B8", Offset = "0x1D7F5B8", VA = "0x1D7F5B8")]
    public MnemnographLimitBreakSideMenu()
    {
    }
  }
}
