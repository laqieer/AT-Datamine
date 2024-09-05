// Decompiled with JetBrains decompiler
// Type: Battle.UI.AttentionTween
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Battle.Data.Board;
using GameCore.Tween;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace Battle.UI
{
  [Token(Token = "0x2002307")]
  [RequireComponent(typeof (UITweenGroup))]
  public sealed class AttentionTween : TweenWrapper
  {
    [Token(Token = "0x4009423")]
    [FieldOffset(Offset = "0x20")]
    [HideInInspector]
    [SerializeField]
    private string nameBattleStart;
    [Token(Token = "0x4009424")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    [HideInInspector]
    private string jingleBattleStart;
    [Token(Token = "0x4009425")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    [HideInInspector]
    private string nameAllyPhaseStart;
    [Token(Token = "0x4009426")]
    [FieldOffset(Offset = "0x38")]
    [HideInInspector]
    [SerializeField]
    private string jingleAllyPhaseStart;
    [Token(Token = "0x4009427")]
    [FieldOffset(Offset = "0x40")]
    [SerializeField]
    [HideInInspector]
    private Text allyPhaseText;
    [Token(Token = "0x4009428")]
    [FieldOffset(Offset = "0x48")]
    [HideInInspector]
    [SerializeField]
    private PhaseTurnText allyPhaseTurnText;
    [Token(Token = "0x4009429")]
    [FieldOffset(Offset = "0x50")]
    [HideInInspector]
    [SerializeField]
    private string nameEnemyPhaseStart;
    [Token(Token = "0x400942A")]
    [FieldOffset(Offset = "0x58")]
    [HideInInspector]
    [SerializeField]
    private string jingleEnemyPhaseStart;
    [Token(Token = "0x400942B")]
    [FieldOffset(Offset = "0x60")]
    [HideInInspector]
    [SerializeField]
    private Text enemyPhaseText;
    [Token(Token = "0x400942C")]
    [FieldOffset(Offset = "0x68")]
    [HideInInspector]
    [SerializeField]
    private PhaseTurnText enemyPhaseTurnText;
    [Token(Token = "0x400942D")]
    [FieldOffset(Offset = "0x70")]
    [SerializeField]
    [HideInInspector]
    private string nameLoseStart;
    [Token(Token = "0x400942E")]
    [FieldOffset(Offset = "0x78")]
    [SerializeField]
    [HideInInspector]
    private string jingleLoseStart;
    [Token(Token = "0x400942F")]
    [FieldOffset(Offset = "0x80")]
    [SerializeField]
    [HideInInspector]
    private string nameWinStart;
    [Token(Token = "0x4009430")]
    [FieldOffset(Offset = "0x88")]
    [SerializeField]
    [HideInInspector]
    private string jingleWinStart;
    [Token(Token = "0x4009431")]
    [FieldOffset(Offset = "0x90")]
    private string lastPlayedName;
    [Token(Token = "0x4009432")]
    [FieldOffset(Offset = "0x98")]
    private string lastJingleName;
    [Token(Token = "0x4009433")]
    [FieldOffset(Offset = "0xA0")]
    private bool keepActive;
    [Token(Token = "0x4009434")]
    [FieldOffset(Offset = "0xA8")]
    public BoardData board;

    [Token(Token = "0x600D60C")]
    [Address(RVA = "0x1D1A3B4", Offset = "0x1D1A3B4", VA = "0x1D1A3B4")]
    public void Play(AttentionTween.Mode mode)
    {
    }

    [Token(Token = "0x600D60D")]
    [Address(RVA = "0x1D1A670", Offset = "0x1D1A670", VA = "0x1D1A670", Slot = "6")]
    public override void Stop()
    {
    }

    [Token(Token = "0x600D60E")]
    [Address(RVA = "0x1D1A678", Offset = "0x1D1A678", VA = "0x1D1A678")]
    public void Stop(bool resetLastPlayed)
    {
    }

    [Token(Token = "0x600D60F")]
    [Address(RVA = "0x1D1A588", Offset = "0x1D1A588", VA = "0x1D1A588")]
    private void UpdateUIFor(AttentionTween.Mode mode)
    {
    }

    [Token(Token = "0x600D610")]
    [Address(RVA = "0x1D1A498", Offset = "0x1D1A498", VA = "0x1D1A498")]
    private void GetTweenNameWithMode(
      AttentionTween.Mode mode,
      out string tweenName,
      out string jingleName)
    {
    }

    [Token(Token = "0x600D611")]
    [Address(RVA = "0x1D1A578", Offset = "0x1D1A578", VA = "0x1D1A578")]
    private bool GetKeepActive(AttentionTween.Mode mode) => new bool();

    [Token(Token = "0x600D612")]
    [Address(RVA = "0x1D1A7D8", Offset = "0x1D1A7D8", VA = "0x1D1A7D8", Slot = "7")]
    protected override void LateUpdate()
    {
    }

    [Token(Token = "0x600D613")]
    [Address(RVA = "0x1D1A6BC", Offset = "0x1D1A6BC", VA = "0x1D1A6BC")]
    public void ResetLastPlayed()
    {
    }

    [Token(Token = "0x600D614")]
    [Address(RVA = "0x1D1A7EC", Offset = "0x1D1A7EC", VA = "0x1D1A7EC")]
    public AttentionTween()
    {
    }

    [Token(Token = "0x2002308")]
    public enum Mode
    {
      [Token(Token = "0x4009436")] BattleStart,
      [Token(Token = "0x4009437")] AllyPhase,
      [Token(Token = "0x4009438")] GuestPhase,
      [Token(Token = "0x4009439")] EnemyPhase,
      [Token(Token = "0x400943A")] AnotherForcePhase,
      [Token(Token = "0x400943B")] ArenaPhaseBegin,
      [Token(Token = "0x400943C")] Lose,
      [Token(Token = "0x400943D")] Win,
    }
  }
}
