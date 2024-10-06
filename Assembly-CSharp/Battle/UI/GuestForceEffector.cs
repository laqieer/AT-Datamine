// Decompiled with JetBrains decompiler
// Type: Battle.UI.GuestForceEffector
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Battle.Data;
using Il2CppDummyDll;

#nullable disable
namespace Battle.UI
{
  [Token(Token = "0x2002304")]
  public class GuestForceEffector : PlayerPhaseEffector
  {
    [Token(Token = "0x600D603")]
    [Address(RVA = "0x1D19F38", Offset = "0x1D19F38", VA = "0x1D19F38")]
    public GuestForceEffector(StoryBattleConfig config, IDirector director)
    {
    }

    [Token(Token = "0x600D604")]
    [Address(RVA = "0x1D19F80", Offset = "0x1D19F80", VA = "0x1D19F80", Slot = "4")]
    public override void OnOwnPhaseBeginStep()
    {
    }

    [Token(Token = "0x600D605")]
    [Address(RVA = "0x1D1A04C", Offset = "0x1D1A04C", VA = "0x1D1A04C", Slot = "5")]
    public override string GetDyingEffectName() => (string) null;
  }
}
