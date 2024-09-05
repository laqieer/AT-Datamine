// Decompiled with JetBrains decompiler
// Type: Gacha.SelectGachaPopup
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Gacha.SelectGacha;
using GameCore;
using GameCore.Input;
using GameCore.MasterData;
using GameCore.Popup;
using Il2CppDummyDll;
using StaqData;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace Gacha
{
  [Token(Token = "0x200154D")]
  public class SelectGachaPopup : PopupBase
  {
    [Token(Token = "0x40061DE")]
    public const string AssetBundleName = "ui_page_gacha_prefab";
    [Token(Token = "0x40061DF")]
    public const string AssetName = "Container_Popup_GachaSelectValue";
    [Token(Token = "0x40061E0")]
    [FieldOffset(Offset = "0x88")]
    [SerializeField]
    private Transform content;
    [Token(Token = "0x40061E1")]
    [FieldOffset(Offset = "0x90")]
    [SerializeField]
    private CommonButton closeButton;
    [Token(Token = "0x40061E2")]
    [FieldOffset(Offset = "0x98")]
    [SerializeField]
    private Toggle toggleStyle;
    [Token(Token = "0x40061E3")]
    [FieldOffset(Offset = "0xA0")]
    [SerializeField]
    private Toggle toggleMnemnograph;
    [Token(Token = "0x40061E4")]
    [FieldOffset(Offset = "0xA8")]
    [SerializeField]
    private MnemnographSelectView mnemnographSelectView;
    [Token(Token = "0x40061E5")]
    [FieldOffset(Offset = "0xB0")]
    [SerializeField]
    private StyleSelectView styleSelectView;
    [Token(Token = "0x40061E6")]
    [FieldOffset(Offset = "0xB8")]
    [SerializeField]
    private BackKeyHandlerComponent backKeyHandlerComponent;
    [Token(Token = "0x40061E7")]
    [FieldOffset(Offset = "0xC0")]
    private AssetCachedSpawner spawner;
    [Token(Token = "0x40061E8")]
    [FieldOffset(Offset = "0xC8")]
    private SelectGachaTargetDetailInfo selectedTargetDetailInfo;
    [Token(Token = "0x40061E9")]
    [FieldOffset(Offset = "0xD0")]
    private Dictionary<RewardTypeEnum, List<SelectGachaTargetDetailInfo>> targetDetailInfoDic;
    [Token(Token = "0x40061EA")]
    [FieldOffset(Offset = "0xD8")]
    private Action<SelectGachaTargetDetailInfo> selectionChangeCallback;

    [Token(Token = "0x60078A7")]
    [Address(RVA = "0x44FCC18", Offset = "0x44FCC18", VA = "0x44FCC18")]
    public static IEnumerator Create(
      AssetCachedSpawner spawner,
      Transform parent,
      Action<SelectGachaPopup> onCreate)
    {
      return (IEnumerator) null;
    }

    [Token(Token = "0x60078A8")]
    [Address(RVA = "0x44FCCBC", Offset = "0x44FCCBC", VA = "0x44FCCBC")]
    private void Awake()
    {
    }

    [Token(Token = "0x60078A9")]
    [Address(RVA = "0x44FCE78", Offset = "0x44FCE78", VA = "0x44FCE78")]
    private void SetEnableStyleSelectView(bool enable)
    {
    }

    [Token(Token = "0x60078AA")]
    [Address(RVA = "0x44FCEA8", Offset = "0x44FCEA8", VA = "0x44FCEA8")]
    private void SetEnableMnemnographSelectView(bool enable)
    {
    }

    [Token(Token = "0x60078AB")]
    [Address(RVA = "0x44FCED8", Offset = "0x44FCED8", VA = "0x44FCED8")]
    public void Initialize(
      AssetCachedSpawner spawner,
      GachaDetailInfo gachaDetailInfo,
      Action<SelectGachaTargetDetailInfo> onSelectionChanged)
    {
    }

    [Token(Token = "0x60078AC")]
    [Address(RVA = "0x44FCF78", Offset = "0x44FCF78", VA = "0x44FCF78")]
    private void InitializeData(GachaDetailInfo gachaDetailInfo)
    {
    }

    [Token(Token = "0x60078AD")]
    [Address(RVA = "0x44FD464", Offset = "0x44FD464", VA = "0x44FD464")]
    private void InitializeStyleSelectView()
    {
    }

    [Token(Token = "0x60078AE")]
    [Address(RVA = "0x44FD56C", Offset = "0x44FD56C", VA = "0x44FD56C")]
    private void InitializeMnemnographSelectView()
    {
    }

    [Token(Token = "0x60078AF")]
    [Address(RVA = "0x44FD684", Offset = "0x44FD684", VA = "0x44FD684")]
    public SelectGachaPopup()
    {
    }
  }
}
