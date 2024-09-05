// Decompiled with JetBrains decompiler
// Type: Battle.Process.AutoActionSelector
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Battle.Data.Board;
using Il2CppDummyDll;
using System;
using System.Threading;
using System.Threading.Tasks;

#nullable disable
namespace Battle.Process
{
  [Token(Token = "0x2002621")]
  public abstract class AutoActionSelector : UnitActionSelectorBase
  {
    [Token(Token = "0x600EBA9")]
    [Address(RVA = "0x4B9BAF4", Offset = "0x4B9BAF4", VA = "0x4B9BAF4")]
    public AutoActionSelector(BattleCore core)
    {
    }

    [Token(Token = "0x600EBAA")]
    [Address(RVA = "0x4B9FDF8", Offset = "0x4B9FDF8", VA = "0x4B9FDF8", Slot = "22")]
    public virtual void OnPlayerPhaseBegin()
    {
    }

    [Token(Token = "0x600EBAB")]
    protected abstract UnitParameterData GetNextActionUnit(CancellationToken token);

    [Token(Token = "0x600EBAC")]
    [Address(RVA = "0x4B9FDFC", Offset = "0x4B9FDFC", VA = "0x4B9FDFC", Slot = "24")]
    public virtual Task ThinkNextAction(
      UnitParameterData reservedUnit,
      bool forceEndAction,
      Action<bool> onSelected,
      CancellationToken token)
    {
      return (Task) null;
    }
  }
}
