// Decompiled with JetBrains decompiler
// Type: ADV2.PsBattleAdv.MapDirector
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Battle;
using Battle.Data;
using Battle.RouteSearch;
using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace ADV2.PsBattleAdv
{
  [Token(Token = "0x2003E6C")]
  public sealed class MapDirector : 
    MapDirectorBase,
    ISubDirector<PsBattleAdvMainDirector>,
    IStepUpdate
  {
    [Token(Token = "0x17005184")]
    public bool EnableCursor
    {
      [Token(Token = "0x60191E1"), Address(RVA = "0x2CF3E04", Offset = "0x2CF3E04", VA = "0x2CF3E04")] get
      {
        return new bool();
      }
      [Token(Token = "0x60191E2"), Address(RVA = "0x2CF3E0C", Offset = "0x2CF3E0C", VA = "0x2CF3E0C")] set
      {
      }
    }

    [Token(Token = "0x17005185")]
    public bool Initialized
    {
      [Token(Token = "0x60191E3"), Address(RVA = "0x2CF3E18", Offset = "0x2CF3E18", VA = "0x2CF3E18", Slot = "12")] get
      {
        return new bool();
      }
      [Token(Token = "0x60191E4"), Address(RVA = "0x2CF3E20", Offset = "0x2CF3E20", VA = "0x2CF3E20")] private set
      {
      }
    }

    [Token(Token = "0x60191E5")]
    [Address(RVA = "0x2CF3E2C", Offset = "0x2CF3E2C", VA = "0x2CF3E2C", Slot = "13")]
    public void Initialize(PsBattleAdvMainDirector mainDirector)
    {
    }

    [Token(Token = "0x60191E6")]
    [Address(RVA = "0x2CF3E48", Offset = "0x2CF3E48", VA = "0x2CF3E48", Slot = "14")]
    public void Abort()
    {
    }

    [Token(Token = "0x60191E7")]
    [Address(RVA = "0x2CF3E4C", Offset = "0x2CF3E4C", VA = "0x2CF3E4C", Slot = "15")]
    public void Release()
    {
    }

    [Token(Token = "0x60191E8")]
    [Address(RVA = "0x2CF3E58", Offset = "0x2CF3E58", VA = "0x2CF3E58", Slot = "16")]
    public void Step(float delta)
    {
    }

    [Token(Token = "0x60191E9")]
    [Address(RVA = "0x2CF3E6C", Offset = "0x2CF3E6C", VA = "0x2CF3E6C", Slot = "5")]
    public override void CreateGrid(
      ISystemFlags sys,
      Transform gridRoot,
      MapEditorData mapEditorData)
    {
    }

    [Token(Token = "0x60191EA")]
    [Address(RVA = "0x2CF3F54", Offset = "0x2CF3F54", VA = "0x2CF3F54")]
    public void UnLoadGrid()
    {
    }

    [Token(Token = "0x60191EB")]
    [Address(RVA = "0x2CF409C", Offset = "0x2CF409C", VA = "0x2CF409C", Slot = "6")]
    public override void ShowCursorAt(int x, int y)
    {
    }

    [Token(Token = "0x60191EC")]
    [Address(RVA = "0x2CF40B0", Offset = "0x2CF40B0", VA = "0x2CF40B0", Slot = "7")]
    public override void ShowMovableAndAttackableAreaFromSearchResult(
      MovableAreaSearcher movable,
      int gridShapeSize,
      AttackableAreaSearcher attackable,
      bool isAttack)
    {
    }

    [Token(Token = "0x60191ED")]
    [Address(RVA = "0x2CF40B4", Offset = "0x2CF40B4", VA = "0x2CF40B4", Slot = "9")]
    public override void ShowMovableAreaFromResult(MovableAreaSearcher movable, int gridShapeSize)
    {
    }

    [Token(Token = "0x60191EE")]
    [Address(RVA = "0x2CF40B8", Offset = "0x2CF40B8", VA = "0x2CF40B8", Slot = "10")]
    public override void ShowAttackableAreaFromResult(
      AttackableAreaSearcher attackable,
      bool isAttack)
    {
    }

    [Token(Token = "0x60191EF")]
    [Address(RVA = "0x2CF40BC", Offset = "0x2CF40BC", VA = "0x2CF40BC", Slot = "11")]
    public override void ShowEffectiveAreaFromResult(AttackableAreaSearcher effective)
    {
    }

    [Token(Token = "0x60191F0")]
    [Address(RVA = "0x2CF40C0", Offset = "0x2CF40C0", VA = "0x2CF40C0")]
    public MapDirector()
    {
    }
  }
}
