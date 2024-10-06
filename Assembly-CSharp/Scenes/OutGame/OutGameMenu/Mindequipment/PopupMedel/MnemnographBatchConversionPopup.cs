// Decompiled with JetBrains decompiler
// Type: Scenes.OutGame.OutGameMenu.Mindequipment.PopupMedel.MnemnographBatchConversionPopup
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore;
using GameCore.Popup;
using Il2CppDummyDll;
using Network.Param;
using Scenes.OutGame.OutGameMenu.Mindequipment.ConversionCompleted;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace Scenes.OutGame.OutGameMenu.Mindequipment.PopupMedel
{
  [Token(Token = "0x2003BFD")]
  public class MnemnographBatchConversionPopup : PopupBase
  {
    [Token(Token = "0x40109C1")]
    [FieldOffset(Offset = "0x88")]
    [SerializeField]
    private RectTransform content;
    [Token(Token = "0x40109C2")]
    [FieldOffset(Offset = "0x90")]
    [SerializeField]
    private int constraintCount;
    [Token(Token = "0x40109C3")]
    [FieldOffset(Offset = "0x98")]
    [SerializeField]
    private MnemnographThumbAccessor cloneObj;
    [Token(Token = "0x40109C4")]
    [FieldOffset(Offset = "0xA0")]
    [SerializeField]
    private Text medalName;
    [Token(Token = "0x40109C5")]
    [FieldOffset(Offset = "0xA8")]
    [SerializeField]
    private Text medalAmount;
    [Token(Token = "0x40109C6")]
    [FieldOffset(Offset = "0xB0")]
    [SerializeField]
    private CommonButton cancel;
    [Token(Token = "0x40109C7")]
    [FieldOffset(Offset = "0xB8")]
    [SerializeField]
    private CommonButton conversion;
    [Token(Token = "0x40109C8")]
    [FieldOffset(Offset = "0xC0")]
    private AssetCachedSpawner assetCachedSpawner;
    [Token(Token = "0x40109C9")]
    [FieldOffset(Offset = "0xC8")]
    private List<PlayerGearMindEquipmentMedalExchangeType> conversionList;
    [Token(Token = "0x40109CA")]
    [FieldOffset(Offset = "0xD0")]
    private Action<ConversionContext> successConversionAction;
    [Token(Token = "0x40109CB")]
    [FieldOffset(Offset = "0xD8")]
    private Action cancelAction;
    [Token(Token = "0x40109CC")]
    [FieldOffset(Offset = "0xE0")]
    private int conversionAmount;
    [Token(Token = "0x40109CD")]
    private const int MedalId = 201150001;

    [Token(Token = "0x601793F")]
    [Address(RVA = "0x237C608", Offset = "0x237C608", VA = "0x237C608")]
    public IEnumerator Initialize(
      AssetCachedSpawner assetCachedSpawner,
      Action<ConversionContext> successConversionAction,
      Action cancelAction)
    {
      return (IEnumerator) null;
    }

    [Token(Token = "0x6017940")]
    [Address(RVA = "0x237C6B8", Offset = "0x237C6B8", VA = "0x237C6B8")]
    private void OnClickCancel()
    {
    }

    [Token(Token = "0x6017941")]
    [Address(RVA = "0x237C768", Offset = "0x237C768", VA = "0x237C768")]
    private IEnumerator OnClickConversion() => (IEnumerator) null;

    [Token(Token = "0x6017942")]
    [Address(RVA = "0x237C7F8", Offset = "0x237C7F8", VA = "0x237C7F8")]
    private void OnSuccessConvertion(ConversionContext result)
    {
    }

    [Token(Token = "0x6017943")]
    [Address(RVA = "0x237C8C0", Offset = "0x237C8C0", VA = "0x237C8C0")]
    public MnemnographBatchConversionPopup()
    {
    }
  }
}
