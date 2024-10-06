// Decompiled with JetBrains decompiler
// Type: Scenes.Arena.ArenaBattleHistoryDetailPopup
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.Popup;
using Il2CppDummyDll;
using Network.Param;
using System.Collections;
using UnityEngine;

#nullable disable
namespace Scenes.Arena
{
  [Token(Token = "0x200311A")]
  public class ArenaBattleHistoryDetailPopup : PopupBase
  {
    [Token(Token = "0x400D10A")]
    [FieldOffset(Offset = "0x88")]
    [SerializeField]
    private GameObject detailRoot;
    [Token(Token = "0x400D10B")]
    [FieldOffset(Offset = "0x90")]
    [SerializeField]
    private GameObject damageRoot;
    [Token(Token = "0x400D10C")]
    [FieldOffset(Offset = "0x98")]
    [SerializeField]
    private ArenaBattleHistoryDetailItem playerDetail;
    [Token(Token = "0x400D10D")]
    [FieldOffset(Offset = "0xA0")]
    [SerializeField]
    private ArenaBattleHistoryDetailItem enemyDetail;
    [Token(Token = "0x400D10E")]
    [FieldOffset(Offset = "0xA8")]
    [SerializeField]
    private ArenaBattleHistoryDetailDamageReportItem playerDamage;
    [Token(Token = "0x400D10F")]
    [FieldOffset(Offset = "0xB0")]
    [SerializeField]
    private ArenaBattleHistoryDetailDamageReportItem enemyDamage;
    [Token(Token = "0x400D110")]
    [FieldOffset(Offset = "0xB8")]
    [SerializeField]
    private CommonToggle detailToggle;
    [Token(Token = "0x400D111")]
    [FieldOffset(Offset = "0xC0")]
    [SerializeField]
    private CommonToggle damageToggle;
    [Token(Token = "0x400D112")]
    [FieldOffset(Offset = "0xC8")]
    [SerializeField]
    private GameObject tabRoot;
    [Token(Token = "0x400D113")]
    [FieldOffset(Offset = "0xD0")]
    [SerializeField]
    private GameObject damageReportPlayerOffence;
    [Token(Token = "0x400D114")]
    [FieldOffset(Offset = "0xD8")]
    [SerializeField]
    private GameObject damageReportPlayerDefense;
    [Token(Token = "0x400D115")]
    [FieldOffset(Offset = "0xE0")]
    [SerializeField]
    private GameObject damageReportEnemyOffence;
    [Token(Token = "0x400D116")]
    [FieldOffset(Offset = "0xE8")]
    [SerializeField]
    private GameObject damageReportEnemyDefense;
    [Token(Token = "0x400D117")]
    [FieldOffset(Offset = "0xF0")]
    [SerializeField]
    private GameObject damageReportPlayerWin;
    [Token(Token = "0x400D118")]
    [FieldOffset(Offset = "0xF8")]
    [SerializeField]
    private GameObject damageReportPlayerLose;
    [Token(Token = "0x400D119")]
    [FieldOffset(Offset = "0x100")]
    [SerializeField]
    private GameObject damageReportEnemyWin;
    [Token(Token = "0x400D11A")]
    [FieldOffset(Offset = "0x108")]
    [SerializeField]
    private GameObject damageReportEnemyLose;
    [Token(Token = "0x400D11B")]
    [FieldOffset(Offset = "0x110")]
    private ArenaBattleHistoryType history;

    [Token(Token = "0x60132BE")]
    [Address(RVA = "0x45E2DA0", Offset = "0x45E2DA0", VA = "0x45E2DA0")]
    public IEnumerator InitializeWithOpen(
      ArenaLoader loader,
      ArenaBattleHistoryType history,
      ArenaBattleHistoryDetailPopup.TransitionFrom type = ArenaBattleHistoryDetailPopup.TransitionFrom.Top)
    {
      return (IEnumerator) null;
    }

    [Token(Token = "0x60132BF")]
    [Address(RVA = "0x45E2E54", Offset = "0x45E2E54", VA = "0x45E2E54")]
    private (string, string)[] GetSprites() => ((string, string)[]) null;

    [Token(Token = "0x60132C0")]
    [Address(RVA = "0x45E329C", Offset = "0x45E329C", VA = "0x45E329C")]
    private void SetupDetail()
    {
    }

    [Token(Token = "0x60132C1")]
    [Address(RVA = "0x45E335C", Offset = "0x45E335C", VA = "0x45E335C")]
    private void SetupDamage()
    {
    }

    [Token(Token = "0x60132C2")]
    [Address(RVA = "0x45E3F30", Offset = "0x45E3F30", VA = "0x45E3F30")]
    private void OnClickDetail()
    {
    }

    [Token(Token = "0x60132C3")]
    [Address(RVA = "0x45E3F84", Offset = "0x45E3F84", VA = "0x45E3F84")]
    private void OnClickDamageReport()
    {
    }

    [Token(Token = "0x60132C4")]
    [Address(RVA = "0x45E3FD8", Offset = "0x45E3FD8", VA = "0x45E3FD8")]
    public ArenaBattleHistoryDetailPopup()
    {
    }

    [Token(Token = "0x200311B")]
    public enum TransitionFrom
    {
      [Token(Token = "0x400D11D")] Top,
      [Token(Token = "0x400D11E")] Battle,
    }
  }
}
