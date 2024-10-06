// Decompiled with JetBrains decompiler
// Type: Battle.DuelScene.SimpleAttack
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Battle.Data.Board;
using Battle.Grid;
using GameCore.MasterData;
using Il2CppDummyDll;
using System;

#nullable disable
namespace Battle.DuelScene
{
  [Token(Token = "0x2002556")]
  public sealed class SimpleAttack : BaseSimpleDuelAction
  {
    [Token(Token = "0x600E664")]
    [Address(RVA = "0x48708E0", Offset = "0x48708E0", VA = "0x48708E0", Slot = "12")]
    public override void Initialize(
      DuelData data,
      ActionData targetActionData,
      IDirector mainDirector)
    {
    }

    [Token(Token = "0x600E665")]
    [Address(RVA = "0x48708EC", Offset = "0x48708EC", VA = "0x48708EC", Slot = "13")]
    public override void RequestStaging()
    {
    }

    [Token(Token = "0x600E666")]
    [Address(RVA = "0x4870EDC", Offset = "0x4870EDC", VA = "0x4870EDC")]
    private void Attack(GridObject from = null, Action completeAction = null)
    {
    }

    [Token(Token = "0x600E667")]
    [Address(RVA = "0x4871558", Offset = "0x4871558", VA = "0x4871558")]
    private new void ShowDamageToTarget()
    {
    }

    [Token(Token = "0x600E668")]
    [Address(RVA = "0x4870D30", Offset = "0x4870D30", VA = "0x4870D30")]
    private void ShowAttackSupport(Action<GridObject, Action> attackAction)
    {
    }

    [Token(Token = "0x600E669")]
    [Address(RVA = "0x4870E18", Offset = "0x4870E18", VA = "0x4870E18")]
    private void ShowGuardSupport(Action<GridObject, Action> attackAction)
    {
    }

    [Token(Token = "0x600E66A")]
    [Address(RVA = "0x4871F4C", Offset = "0x4871F4C", VA = "0x4871F4C")]
    private UnitParameterData GetSupportGuradUnit() => (UnitParameterData) null;

    [Token(Token = "0x600E66B")]
    [Address(RVA = "0x4871E60", Offset = "0x4871E60", VA = "0x4871E60")]
    private AttackTypeEnum GetAttackType() => new AttackTypeEnum();

    [Token(Token = "0x600E66C")]
    [Address(RVA = "0x4871EC4", Offset = "0x4871EC4", VA = "0x4871EC4")]
    private ElementTypeEnum GetElementType() => new ElementTypeEnum();

    [Token(Token = "0x600E66D")]
    [Address(RVA = "0x486EC00", Offset = "0x486EC00", VA = "0x486EC00")]
    public SimpleAttack()
    {
    }
  }
}
