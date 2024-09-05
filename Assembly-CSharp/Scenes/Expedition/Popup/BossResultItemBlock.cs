// Decompiled with JetBrains decompiler
// Type: Scenes.Expedition.Popup.BossResultItemBlock
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.MasterData;
using Il2CppDummyDll;
using System;
using System.Collections.Generic;
using UnityEngine;

#nullable disable
namespace Scenes.Expedition.Popup
{
  [Token(Token = "0x2002C55")]
  public class BossResultItemBlock : MonoBehaviour
  {
    [Token(Token = "0x400BCD8")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private BossResultItem[] items;

    [Token(Token = "0x60115D4")]
    [Address(RVA = "0x4E1977C", Offset = "0x4E1977C", VA = "0x4E1977C")]
    public void SetData(
      List<ExpeditionBossBattleWinResultPopup.ViewItemData> datas,
      Action<RewardTypeEnum, int> OpenItemDetailPopup)
    {
    }

    [Token(Token = "0x60115D5")]
    [Address(RVA = "0x4E19894", Offset = "0x4E19894", VA = "0x4E19894")]
    public BossResultItemBlock()
    {
    }
  }
}
