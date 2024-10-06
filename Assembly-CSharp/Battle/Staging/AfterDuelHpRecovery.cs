// Decompiled with JetBrains decompiler
// Type: Battle.Staging.AfterDuelHpRecovery
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Battle.Data.Board;
using Battle.DuelScene;
using Il2CppDummyDll;
using System.Collections.Generic;

#nullable disable
namespace Battle.Staging
{
  [Token(Token = "0x200256C")]
  public sealed class AfterDuelHpRecovery : StagingDirector.ISequence, IStepUpdate
  {
    [Token(Token = "0x400A093")]
    [FieldOffset(Offset = "0x18")]
    private ActorDirector actorDirector;
    [Token(Token = "0x400A094")]
    [FieldOffset(Offset = "0x20")]
    private DuelData duelData;
    [Token(Token = "0x400A095")]
    [FieldOffset(Offset = "0x28")]
    private List<UnitParameterData> unitList;

    [Token(Token = "0x1700317D")]
    public bool IsCompleted
    {
      [Token(Token = "0x600E6BA"), Address(RVA = "0x48762D8", Offset = "0x48762D8", VA = "0x48762D8", Slot = "4")] get
      {
        return new bool();
      }
      [Token(Token = "0x600E6BB"), Address(RVA = "0x48762E0", Offset = "0x48762E0", VA = "0x48762E0")] private set
      {
      }
    }

    [Token(Token = "0x600E6BC")]
    [Address(RVA = "0x4873C08", Offset = "0x4873C08", VA = "0x4873C08")]
    public static AfterDuelHpRecovery Create(ActorDirector actorDirector, DuelData duelData)
    {
      return (AfterDuelHpRecovery) null;
    }

    [Token(Token = "0x600E6BD")]
    [Address(RVA = "0x48762EC", Offset = "0x48762EC", VA = "0x48762EC")]
    private AfterDuelHpRecovery(ActorDirector actorDirector, DuelData duelData)
    {
    }

    [Token(Token = "0x600E6BE")]
    [Address(RVA = "0x4876380", Offset = "0x4876380", VA = "0x4876380", Slot = "5")]
    public void Start()
    {
    }

    [Token(Token = "0x600E6BF")]
    [Address(RVA = "0x487677C", Offset = "0x487677C", VA = "0x487677C")]
    private void StartAnimation(UnitParameterData unit, int damage)
    {
    }

    [Token(Token = "0x600E6C0")]
    [Address(RVA = "0x487685C", Offset = "0x487685C", VA = "0x487685C", Slot = "8")]
    public void Step(float delta)
    {
    }

    [Token(Token = "0x600E6C1")]
    [Address(RVA = "0x4876A50", Offset = "0x4876A50", VA = "0x4876A50", Slot = "7")]
    public void Complete()
    {
    }

    [Token(Token = "0x600E6C2")]
    [Address(RVA = "0x4876A5C", Offset = "0x4876A5C", VA = "0x4876A5C", Slot = "6")]
    public void Abort()
    {
    }
  }
}
