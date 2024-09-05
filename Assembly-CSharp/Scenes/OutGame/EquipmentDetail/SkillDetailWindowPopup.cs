// Decompiled with JetBrains decompiler
// Type: Scenes.OutGame.EquipmentDetail.SkillDetailWindowPopup
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.Input;
using GameCore.MasterData;
using GameCore.Popup;
using Il2CppDummyDll;
using Scenes.OutGame.Info.Common.UI;
using StaqData;
using System;
using UnityEngine;

#nullable disable
namespace Scenes.OutGame.EquipmentDetail
{
  [Token(Token = "0x2003696")]
  public class SkillDetailWindowPopup : PopupBase
  {
    [Token(Token = "0x400ED6E")]
    private const string AssetBundleName = "ui_page_equipdetail";
    [Token(Token = "0x400ED6F")]
    private const string AssetName = "Container_SkillDetailWindow_popup";
    [Token(Token = "0x400ED70")]
    [FieldOffset(Offset = "0x88")]
    [SerializeField]
    private SkillDetailWindowPresenter _presenter;
    [Token(Token = "0x400ED71")]
    [FieldOffset(Offset = "0x90")]
    [SerializeField]
    private BackKeyHandlerComponent backKeyHandlerComponent;

    [Token(Token = "0x601578D")]
    [Address(RVA = "0x18E8390", Offset = "0x18E8390", VA = "0x18E8390")]
    public static void RequestDetail(
      EquipmentSkill skill,
      IAssetProvider assetProvider,
      Transform parent = null)
    {
    }

    [Token(Token = "0x601578E")]
    [Address(RVA = "0x18E8638", Offset = "0x18E8638", VA = "0x18E8638")]
    public static void RequestDetail(
      int skillID,
      int level,
      RarityTypeEnum rare,
      IAssetProvider assetProvider,
      Style style = null,
      Transform parent = null)
    {
    }

    [Token(Token = "0x601578F")]
    [Address(RVA = "0x18E8728", Offset = "0x18E8728", VA = "0x18E8728")]
    public static void RequestDetail(
      Style style,
      int skillID,
      IAssetProvider assetProvider,
      Transform parent = null)
    {
    }

    [Token(Token = "0x6015790")]
    [Address(RVA = "0x18E8808", Offset = "0x18E8808", VA = "0x18E8808")]
    public static void RequestLvChangeInfo(
      EquipmentSkill skill,
      IAssetProvider assetProvider,
      Transform parent = null)
    {
    }

    [Token(Token = "0x6015791")]
    [Address(RVA = "0x18E845C", Offset = "0x18E845C", VA = "0x18E845C")]
    private static void RequestCommon(
      Action<SkillDetailWindowPopup> initializer,
      IAssetProvider assetProvider,
      Transform parent)
    {
    }

    [Token(Token = "0x6015792")]
    [Address(RVA = "0x18E88DC", Offset = "0x18E88DC", VA = "0x18E88DC")]
    private void Awake()
    {
    }

    [Token(Token = "0x6015793")]
    [Address(RVA = "0x18E89D0", Offset = "0x18E89D0", VA = "0x18E89D0", Slot = "8")]
    public override void Open()
    {
    }

    [Token(Token = "0x6015794")]
    [Address(RVA = "0x18E8A50", Offset = "0x18E8A50", VA = "0x18E8A50", Slot = "9")]
    public override void Close()
    {
    }

    [Token(Token = "0x6015795")]
    [Address(RVA = "0x18E8AEC", Offset = "0x18E8AEC", VA = "0x18E8AEC")]
    public void OnPressedBackKey()
    {
    }

    [Token(Token = "0x6015796")]
    [Address(RVA = "0x18E8AF8", Offset = "0x18E8AF8", VA = "0x18E8AF8")]
    private void InitilizeAsDetail(EquipmentSkill skill, IAssetProvider assetProvider)
    {
    }

    [Token(Token = "0x6015797")]
    [Address(RVA = "0x18E8C50", Offset = "0x18E8C50", VA = "0x18E8C50")]
    private void InitilizeAsDetail(
      int skillID,
      int level,
      RarityTypeEnum rare,
      IAssetProvider assetProvider,
      Style style)
    {
    }

    [Token(Token = "0x6015798")]
    [Address(RVA = "0x18E8DE8", Offset = "0x18E8DE8", VA = "0x18E8DE8")]
    private void InitilizeAsDetail(Style style, int skillID, IAssetProvider assetProvider)
    {
    }

    [Token(Token = "0x6015799")]
    [Address(RVA = "0x18E8F50", Offset = "0x18E8F50", VA = "0x18E8F50")]
    private void InitilizeAsLvChangeInfo(EquipmentSkill skill, IAssetProvider assetProvider)
    {
    }

    [Token(Token = "0x601579A")]
    [Address(RVA = "0x18E914C", Offset = "0x18E914C", VA = "0x18E914C")]
    public SkillDetailWindowPopup()
    {
    }
  }
}
