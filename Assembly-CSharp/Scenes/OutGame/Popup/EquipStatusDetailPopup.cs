// Decompiled with JetBrains decompiler
// Type: Scenes.OutGame.Popup.EquipStatusDetailPopup
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.DLC;
using GameCore.MasterData;
using GameCore.Popup;
using Il2CppDummyDll;
using StaqData;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace Scenes.OutGame.Popup
{
  [Token(Token = "0x200344C")]
  public class EquipStatusDetailPopup : PopupBase
  {
    [Token(Token = "0x400E3B2")]
    [FieldOffset(Offset = "0x88")]
    [SerializeField]
    private Image rarerityImage;
    [Token(Token = "0x400E3B3")]
    [FieldOffset(Offset = "0x90")]
    [SerializeField]
    private Text nameText;
    [Token(Token = "0x400E3B4")]
    [FieldOffset(Offset = "0x0")]
    [SerializeField]
    private static UniqueID uniqueId;
    [Token(Token = "0x400E3B5")]
    private const string EquipmentDetailAssetBundleName = "2dassets_ui_equipdetail";
    [Token(Token = "0x400E3B6")]
    private const string UnitDetailAssetBundleName = "ui_page_unitdetail";
    [Token(Token = "0x400E3B7")]
    private const string PopupPrefabName = "Popup_EquipStatus_Detail";
    [Token(Token = "0x400E3B8")]
    [FieldOffset(Offset = "0x8")]
    private static readonly Dictionary<RarityTypeEnum, string> RarityAssetNames;
    [Token(Token = "0x400E3B9")]
    [FieldOffset(Offset = "0x10")]
    private static AssetBundleManager assetMan;
    [Token(Token = "0x400E3BA")]
    [FieldOffset(Offset = "0x98")]
    [SerializeField]
    private CommonButton closeBtn;
    [Token(Token = "0x400E3BB")]
    [FieldOffset(Offset = "0xA0")]
    [SerializeField]
    private List<EquipStatusDetail_WepStatusWinBase> statusWin;

    [Token(Token = "0x60148BC")]
    [Address(RVA = "0x1A9FBEC", Offset = "0x1A9FBEC", VA = "0x1A9FBEC")]
    public void Initialize(UniqueID id)
    {
    }

    [Token(Token = "0x60148BD")]
    [Address(RVA = "0x1AA0070", Offset = "0x1AA0070", VA = "0x1AA0070")]
    public EquipStatusDetailPopup()
    {
    }

    [Token(Token = "0x60148BE")]
    [Address(RVA = "0x1AA0078", Offset = "0x1AA0078", VA = "0x1AA0078")]
    static EquipStatusDetailPopup()
    {
    }
  }
}
