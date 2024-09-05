// Decompiled with JetBrains decompiler
// Type: Scenes.OutGame.BoxItemDetailPopup
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore;
using GameCore.MasterData;
using Il2CppDummyDll;
using StaqData;
using System.Collections.Generic;
using UI.ItemDetail;
using UnityEngine;

#nullable disable
namespace Scenes.OutGame
{
  [Token(Token = "0x20031DD")]
  [RequireComponent(typeof (ItemDetailPopup))]
  public class BoxItemDetailPopup : MonoBehaviour
  {
    [Token(Token = "0x400D4AB")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private GameObject contentItemBoxListParts;
    [Token(Token = "0x400D4AC")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private GameObject txtExplanation;
    [Token(Token = "0x400D4AD")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private GameObject txtExplanationLottery;
    [Token(Token = "0x400D4AE")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    private GameObject txtExplanationChoice;
    [Token(Token = "0x400D4AF")]
    [FieldOffset(Offset = "0x38")]
    private AssetCachedSpawner assetCachedSpawner;
    [Token(Token = "0x400D4B0")]
    [FieldOffset(Offset = "0x40")]
    private bool enabledItemDetailPopup;
    [Token(Token = "0x400D4B1")]
    [FieldOffset(Offset = "0x48")]
    private ItemDetailPopupProvider itemDetailPopup;
    [Token(Token = "0x400D4B2")]
    [FieldOffset(Offset = "0x50")]
    private List<BoxItemRewardListSheet> boxItemRewardListSheets;

    [Token(Token = "0x6013772")]
    [Address(RVA = "0x4E0E970", Offset = "0x4E0E970", VA = "0x4E0E970")]
    private void Update()
    {
    }

    [Token(Token = "0x6013773")]
    [Address(RVA = "0x4E0EAD8", Offset = "0x4E0EAD8", VA = "0x4E0EAD8")]
    public void Initialize(ItemUtility.Parameter item, AssetCachedSpawner cachedSpawner)
    {
    }

    [Token(Token = "0x6013774")]
    [Address(RVA = "0x4E0F51C", Offset = "0x4E0F51C", VA = "0x4E0F51C")]
    private void InitializeTxtExplanation(BoxItemOpenTypeEnum boxItemOpenType)
    {
    }

    [Token(Token = "0x6013775")]
    [Address(RVA = "0x4E0F688", Offset = "0x4E0F688", VA = "0x4E0F688")]
    public BoxItemDetailPopup()
    {
    }
  }
}
