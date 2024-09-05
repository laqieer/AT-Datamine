// Decompiled with JetBrains decompiler
// Type: Battle.Expedition.SimpleDuelActionReciever
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Battle.Data.Board;
using Battle.DuelScene;
using Battle.Expedition.Data;
using Battle.Staging;
using Il2CppDummyDll;

#nullable disable
namespace Battle.Expedition
{
  [Token(Token = "0x20025D6")]
  public class SimpleDuelActionReciever : Battle.SimpleDuelActionReciever
  {
    [Token(Token = "0x400A2BA")]
    [FieldOffset(Offset = "0x20")]
    private BoardData board;
    [Token(Token = "0x400A2BB")]
    [FieldOffset(Offset = "0x28")]
    private ExpeditionBattleData battleData;

    [Token(Token = "0x600E9C0")]
    [Address(RVA = "0x4C4ABC8", Offset = "0x4C4ABC8", VA = "0x4C4ABC8")]
    public void Initialize(
      MainDirector mainDirector,
      BoardData board,
      ExpeditionBattleData battleData)
    {
    }

    [Token(Token = "0x600E9C1")]
    [Address(RVA = "0x4C4BAE4", Offset = "0x4C4BAE4", VA = "0x4C4BAE4", Slot = "8")]
    public override StagingDirector.ISequence OnDamage(
      DuelData duelData,
      ActionTargetResultData result,
      UnitParameterData actionOwner)
    {
      return (StagingDirector.ISequence) null;
    }

    [Token(Token = "0x600E9C2")]
    [Address(RVA = "0x4C4ABC0", Offset = "0x4C4ABC0", VA = "0x4C4ABC0")]
    public SimpleDuelActionReciever()
    {
    }
  }
}
