// Decompiled with JetBrains decompiler
// Type: Scenes.OutGame.OutGameMenu.ShortagePopup
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore;
using GameCore.MasterData;
using GameCore.Popup;
using Il2CppDummyDll;
using System;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace Scenes.OutGame.OutGameMenu
{
  [Token(Token = "0x2003A47")]
  public class ShortagePopup : PopupBase
  {
    [Token(Token = "0x400FF43")]
    public const string AssetBundleName = "ui_common_prefabs";
    [Token(Token = "0x400FF44")]
    public const string AssetName = "Com_Popup_Shortage";
    [Token(Token = "0x400FF45")]
    [FieldOffset(Offset = "0x88")]
    [SerializeField]
    private ShortageContents dia;
    [Token(Token = "0x400FF46")]
    [FieldOffset(Offset = "0x90")]
    [SerializeField]
    private ShortageContents diaPaid;
    [Token(Token = "0x400FF47")]
    [FieldOffset(Offset = "0x98")]
    [SerializeField]
    private ShortageContents item;
    [Token(Token = "0x400FF48")]
    [FieldOffset(Offset = "0xA0")]
    [SerializeField]
    private ShortageContents zeny;
    [Token(Token = "0x400FF49")]
    [FieldOffset(Offset = "0xA8")]
    [SerializeField]
    private GameObject decisionButtonParent;
    [Token(Token = "0x400FF4A")]
    [FieldOffset(Offset = "0xB0")]
    [SerializeField]
    private Button buttonDecision;
    [Token(Token = "0x400FF4B")]
    [FieldOffset(Offset = "0xB8")]
    [SerializeField]
    private Button buttonCancel;
    [Token(Token = "0x400FF4C")]
    [FieldOffset(Offset = "0xC0")]
    public Action OnClickDecision;
    [Token(Token = "0x400FF4D")]
    [FieldOffset(Offset = "0xC8")]
    public Action OnClickCancel;

    [Token(Token = "0x6016E64")]
    [Address(RVA = "0x2C60750", Offset = "0x2C60750", VA = "0x2C60750")]
    public static void Preload(AssetCachedSpawner spawner)
    {
    }

    [Token(Token = "0x6016E65")]
    [Address(RVA = "0x2C607D0", Offset = "0x2C607D0", VA = "0x2C607D0")]
    public static AssetSpawnOperation<GameObject> Create(
      AssetCachedSpawner spawner,
      Action<ShortagePopup> onCreate,
      bool isStartRequest = false)
    {
      return (AssetSpawnOperation<GameObject>) null;
    }

    [Token(Token = "0x6016E66")]
    [Address(RVA = "0x2C60900", Offset = "0x2C60900", VA = "0x2C60900")]
    public static AssetSpawnOperation<GameObject> RequestForConsumeCoin(
      AssetCachedSpawner spawner,
      Action<BuyConfirmStonePopup> callback = null,
      bool isStartRequest = false)
    {
      return (AssetSpawnOperation<GameObject>) null;
    }

    [Token(Token = "0x6016E67")]
    [Address(RVA = "0x2C609D4", Offset = "0x2C609D4", VA = "0x2C609D4")]
    private void Awake()
    {
    }

    [Token(Token = "0x6016E68")]
    [Address(RVA = "0x2C4F350", Offset = "0x2C4F350", VA = "0x2C4F350")]
    public void SetInsufficientInfo(PaymentTypeEnum paymentType, int paymentId, int paymentAmount)
    {
    }

    [Token(Token = "0x6016E69")]
    [Address(RVA = "0x2C60AD4", Offset = "0x2C60AD4", VA = "0x2C60AD4")]
    public ShortagePopup()
    {
    }
  }
}
