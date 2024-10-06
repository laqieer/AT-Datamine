// Decompiled with JetBrains decompiler
// Type: Battle.UI.AllyForceEffector
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Battle.Data;
using Il2CppDummyDll;

#nullable disable
namespace Battle.UI
{
  [Token(Token = "0x2002302")]
  public class AllyForceEffector : PlayerPhaseEffector
  {
    [Token(Token = "0x600D5F9")]
    [Address(RVA = "0x1D19C00", Offset = "0x1D19C00", VA = "0x1D19C00")]
    public AllyForceEffector(StoryBattleConfig config, IDirector director)
    {
    }

    [Token(Token = "0x600D5FA")]
    [Address(RVA = "0x1D19C58", Offset = "0x1D19C58", VA = "0x1D19C58")]
    public AllyForceEffector(IDirector director)
    {
    }

    [Token(Token = "0x600D5FB")]
    [Address(RVA = "0x1D19C5C", Offset = "0x1D19C5C", VA = "0x1D19C5C")]
    public AllyForceEffector(ArenaBattleConfig config, IDirector director)
    {
    }

    [Token(Token = "0x600D5FC")]
    [Address(RVA = "0x1D19C98", Offset = "0x1D19C98", VA = "0x1D19C98", Slot = "4")]
    public override void OnOwnPhaseBeginStep()
    {
    }

    [Token(Token = "0x600D5FD")]
    [Address(RVA = "0x1D19D64", Offset = "0x1D19D64", VA = "0x1D19D64", Slot = "5")]
    public override string GetDyingEffectName() => (string) null;
  }
}
