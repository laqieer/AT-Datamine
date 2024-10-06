// Decompiled with JetBrains decompiler
// Type: Scenes.OutGame.FirstClearRewardContent
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore;
using GameCore.MasterData;
using GameCore.UIControls;
using Il2CppDummyDll;
using UI.ItemDetail;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace Scenes.OutGame
{
  [Token(Token = "0x200321C")]
  internal class FirstClearRewardContent : MonoBehaviour
  {
    [Token(Token = "0x400D603")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private GameObject clearIcon;
    [Token(Token = "0x400D604")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private Text itemName;
    [Token(Token = "0x400D605")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private Text itemNum;
    [Token(Token = "0x400D606")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    private ItemIcon itemIcon;

    [Token(Token = "0x60138BB")]
    [Address(RVA = "0x49C4BC0", Offset = "0x49C4BC0", VA = "0x49C4BC0")]
    public void SetRewardData(
      AssetCachedSpawner assetCachedSpawner,
      BattleRewardDescriptionData reward,
      ItemDetailPopupProvider itemDetailPopupGenerator,
      bool cleared)
    {
    }

    [Token(Token = "0x60138BC")]
    [Address(RVA = "0x49C4DF4", Offset = "0x49C4DF4", VA = "0x49C4DF4")]
    public FirstClearRewardContent()
    {
    }
  }
}
