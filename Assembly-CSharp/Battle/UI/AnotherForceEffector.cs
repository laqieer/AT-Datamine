// Decompiled with JetBrains decompiler
// Type: Battle.UI.AnotherForceEffector
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Battle.Data;
using Il2CppDummyDll;

#nullable disable
namespace Battle.UI
{
  [Token(Token = "0x2002305")]
  public class AnotherForceEffector : PlayerPhaseEffector
  {
    [Token(Token = "0x600D606")]
    [Address(RVA = "0x1D1A08C", Offset = "0x1D1A08C", VA = "0x1D1A08C")]
    public AnotherForceEffector(StoryBattleConfig config, IDirector director)
    {
    }

    [Token(Token = "0x600D607")]
    [Address(RVA = "0x1D1A0D4", Offset = "0x1D1A0D4", VA = "0x1D1A0D4", Slot = "4")]
    public override void OnOwnPhaseBeginStep()
    {
    }

    [Token(Token = "0x600D608")]
    [Address(RVA = "0x1D1A1A0", Offset = "0x1D1A1A0", VA = "0x1D1A1A0", Slot = "5")]
    public override string GetDyingEffectName() => (string) null;
  }
}
