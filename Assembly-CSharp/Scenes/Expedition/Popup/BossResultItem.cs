// Decompiled with JetBrains decompiler
// Type: Scenes.Expedition.Popup.BossResultItem
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.MasterData;
using GameCore.UIControls;
using Il2CppDummyDll;
using System;
using TMPro;
using UnityEngine;

#nullable disable
namespace Scenes.Expedition.Popup
{
  [Token(Token = "0x2002C53")]
  public class BossResultItem : MonoBehaviour
  {
    [Token(Token = "0x400BCD4")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private ItemIcon item;
    [Token(Token = "0x400BCD5")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private TextMeshProUGUI dropNumText;

    [Token(Token = "0x60115D0")]
    [Address(RVA = "0x4E1957C", Offset = "0x4E1957C", VA = "0x4E1957C")]
    public void SetData(
      ExpeditionBossBattleWinResultPopup.ViewItemData data,
      Action<RewardTypeEnum, int> OpenItemDetailPopup)
    {
    }

    [Token(Token = "0x60115D1")]
    [Address(RVA = "0x4E19744", Offset = "0x4E19744", VA = "0x4E19744")]
    public BossResultItem()
    {
    }
  }
}
