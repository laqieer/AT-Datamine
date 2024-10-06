// Decompiled with JetBrains decompiler
// Type: Scenes.Expedition.Popup.ExpeditionBossBattleLoseResultPopup
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.Popup;
using Il2CppDummyDll;
using Scenes.Expedition.Boss.BattleResult;
using System;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace Scenes.Expedition.Popup
{
  [Token(Token = "0x2002C5F")]
  public class ExpeditionBossBattleLoseResultPopup : PopupBase
  {
    [Token(Token = "0x400BD09")]
    [FieldOffset(Offset = "0x88")]
    [SerializeField]
    private CommonButton bgButton;
    [Token(Token = "0x400BD0A")]
    [FieldOffset(Offset = "0x90")]
    [SerializeField]
    private CommonButton tapNextButton;
    [Token(Token = "0x400BD0B")]
    [FieldOffset(Offset = "0x98")]
    [SerializeField]
    private Text stageNameText;
    [Token(Token = "0x400BD0C")]
    [FieldOffset(Offset = "0xA0")]
    [SerializeField]
    private TextMeshProUGUI bossLevelText;
    [Token(Token = "0x400BD0D")]
    [FieldOffset(Offset = "0xA8")]
    [SerializeField]
    private TextMeshProUGUI turnText;
    [Token(Token = "0x400BD0E")]
    [FieldOffset(Offset = "0xB0")]
    [SerializeField]
    private BossResultEnemyUnitSlot[] enemyUnitSlots;
    [Token(Token = "0x400BD0F")]
    [FieldOffset(Offset = "0xB8")]
    private Action closeAction;

    [Token(Token = "0x601160B")]
    [Address(RVA = "0x4E1B410", Offset = "0x4E1B410", VA = "0x4E1B410")]
    public void Initialized(string stageName, int stageLevel, int turn, List<BossData> bossDatas)
    {
    }

    [Token(Token = "0x601160C")]
    [Address(RVA = "0x4E1B754", Offset = "0x4E1B754", VA = "0x4E1B754", Slot = "9")]
    public override void Close()
    {
    }

    [Token(Token = "0x601160D")]
    [Address(RVA = "0x4E1B780", Offset = "0x4E1B780", VA = "0x4E1B780")]
    public void Back()
    {
    }

    [Token(Token = "0x601160E")]
    [Address(RVA = "0x4E1B798", Offset = "0x4E1B798", VA = "0x4E1B798")]
    public void SetCloseAction(Action closeAction)
    {
    }

    [Token(Token = "0x601160F")]
    [Address(RVA = "0x4E1B7A0", Offset = "0x4E1B7A0", VA = "0x4E1B7A0")]
    public ExpeditionBossBattleLoseResultPopup()
    {
    }
  }
}
