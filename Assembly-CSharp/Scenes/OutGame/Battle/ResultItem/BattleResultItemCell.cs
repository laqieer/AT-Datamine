// Decompiled with JetBrains decompiler
// Type: Scenes.OutGame.Battle.ResultItem.BattleResultItemCell
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore;
using GameCore.UIControls;
using Il2CppDummyDll;
using TMPro;
using UI.ItemDetail;
using UnityEngine;

#nullable disable
namespace Scenes.OutGame.Battle.ResultItem
{
  [Token(Token = "0x20037E0")]
  public class BattleResultItemCell : MonoBehaviour
  {
    [Token(Token = "0x400F42C")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private GameObject Img_Treasure_Gold;
    [Token(Token = "0x400F42D")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private GameObject Img_Treasure_Silver;
    [Token(Token = "0x400F42E")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private GameObject Img_Treasure_Bronze;
    [Token(Token = "0x400F42F")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    private ItemIcon itemIcon;
    [Token(Token = "0x400F430")]
    [FieldOffset(Offset = "0x38")]
    [SerializeField]
    private TextMeshProUGUI itemNumText;

    [Token(Token = "0x6015FC8")]
    [Address(RVA = "0x232C6D8", Offset = "0x232C6D8", VA = "0x232C6D8")]
    public void Initialize(
      ResultData.ItemData dropItemData,
      ItemDetailPopupProvider itemDetailPopupProvider,
      AssetCachedSpawner assetCachedSpawner)
    {
    }

    [Token(Token = "0x6015FC9")]
    [Address(RVA = "0x232F17C", Offset = "0x232F17C", VA = "0x232F17C")]
    public BattleResultItemCell()
    {
    }
  }
}
