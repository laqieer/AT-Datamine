// Decompiled with JetBrains decompiler
// Type: Scenes.OutGame.BattleAPIUtil
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.Popup;
using Il2CppDummyDll;
using StaqData;
using System;
using System.Collections;
using TeamOrganization;

#nullable disable
namespace Scenes.OutGame
{
  [Token(Token = "0x2003207")]
  public static class BattleAPIUtil
  {
    [Token(Token = "0x400D5CA")]
    [FieldOffset(Offset = "0x0")]
    private static bool isOpenApPopup;
    [Token(Token = "0x400D5CB")]
    [FieldOffset(Offset = "0x8")]
    private static PopupHandle popupHandle;

    [Token(Token = "0x6013881")]
    [Address(RVA = "0x49C0430", Offset = "0x49C0430", VA = "0x49C0430")]
    public static bool OnStartCostCheck(
      QuestInfo questInfo,
      Action onApCheckConfirm = null,
      int playCount = 1,
      bool openApPopup = true)
    {
      return new bool();
    }

    [Token(Token = "0x6013882")]
    [Address(RVA = "0x49C09F8", Offset = "0x49C09F8", VA = "0x49C09F8")]
    public static IEnumerator RequestStart(QuestInfo questInfo, OrganizationTeam team)
    {
      return (IEnumerator) null;
    }
  }
}
