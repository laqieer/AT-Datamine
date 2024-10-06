// Decompiled with JetBrains decompiler
// Type: Scenes.OutGame.EquipmentDetail.OptionEffectLotteryItemController
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore;
using Il2CppDummyDll;
using StaqData;
using System.Collections.Generic;
using UnityEngine;

#nullable disable
namespace Scenes.OutGame.EquipmentDetail
{
  [Token(Token = "0x2003689")]
  public class OptionEffectLotteryItemController : MonoBehaviour
  {
    [Token(Token = "0x400ED45")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private OptionEffectLotteryItem lotteryItem;
    [Token(Token = "0x400ED46")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private AssetCachedSpawner assetCachedSpawner;
    [Token(Token = "0x400ED47")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private GameObject nothingObj;
    [Token(Token = "0x400ED48")]
    [FieldOffset(Offset = "0x30")]
    private List<OptionEffectLotteryItem> lotteryItems;
    [Token(Token = "0x400ED49")]
    [FieldOffset(Offset = "0x38")]
    private Transform itemRootTrans;
    [Token(Token = "0x400ED4A")]
    [FieldOffset(Offset = "0x40")]
    private bool isInitialized;

    [Token(Token = "0x601574E")]
    [Address(RVA = "0x18E5C94", Offset = "0x18E5C94", VA = "0x18E5C94")]
    private void Initialize()
    {
    }

    [Token(Token = "0x601574F")]
    [Address(RVA = "0x18E5D68", Offset = "0x18E5D68", VA = "0x18E5D68")]
    public void Initialize(Weapon weapon)
    {
    }

    [Token(Token = "0x6015750")]
    [Address(RVA = "0x18E657C", Offset = "0x18E657C", VA = "0x18E657C")]
    public void Initialize(Accessory accessory)
    {
    }

    [Token(Token = "0x6015751")]
    [Address(RVA = "0x18E6D90", Offset = "0x18E6D90", VA = "0x18E6D90")]
    public OptionEffectLotteryItemController()
    {
    }
  }
}
