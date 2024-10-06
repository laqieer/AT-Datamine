// Decompiled with JetBrains decompiler
// Type: Battle.UI.EnemyForceEffector
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Battle.Data;
using Il2CppDummyDll;

#nullable disable
namespace Battle.UI
{
  [Token(Token = "0x2002303")]
  public class EnemyForceEffector : PlayerPhaseEffector
  {
    [Token(Token = "0x600D5FE")]
    [Address(RVA = "0x1D19DA4", Offset = "0x1D19DA4", VA = "0x1D19DA4")]
    public EnemyForceEffector(StoryBattleConfig config, IDirector director)
    {
    }

    [Token(Token = "0x600D5FF")]
    [Address(RVA = "0x1D19DEC", Offset = "0x1D19DEC", VA = "0x1D19DEC")]
    public EnemyForceEffector(IDirector director)
    {
    }

    [Token(Token = "0x600D600")]
    [Address(RVA = "0x1D19DF0", Offset = "0x1D19DF0", VA = "0x1D19DF0")]
    public EnemyForceEffector(ArenaBattleConfig config, IDirector director)
    {
    }

    [Token(Token = "0x600D601")]
    [Address(RVA = "0x1D19E2C", Offset = "0x1D19E2C", VA = "0x1D19E2C", Slot = "4")]
    public override void OnOwnPhaseBeginStep()
    {
    }

    [Token(Token = "0x600D602")]
    [Address(RVA = "0x1D19EF8", Offset = "0x1D19EF8", VA = "0x1D19EF8", Slot = "5")]
    public override string GetDyingEffectName() => (string) null;
  }
}
