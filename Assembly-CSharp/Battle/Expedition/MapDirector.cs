// Decompiled with JetBrains decompiler
// Type: Battle.Expedition.MapDirector
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Battle.Data;
using Battle.Expedition.Data;
using Battle.RouteSearch;
using Il2CppDummyDll;
using System.Collections.Generic;
using UnityEngine;

#nullable disable
namespace Battle.Expedition
{
  [Token(Token = "0x20025D4")]
  public sealed class MapDirector : MapDirectorBase, ISubDirector<MainDirector>, IStepUpdate
  {
    [Token(Token = "0x170031EA")]
    public bool EnableCursor
    {
      [Token(Token = "0x600E99F"), Address(RVA = "0x4C4B3CC", Offset = "0x4C4B3CC", VA = "0x4C4B3CC")] get
      {
        return new bool();
      }
      [Token(Token = "0x600E9A0"), Address(RVA = "0x4C4B3D4", Offset = "0x4C4B3D4", VA = "0x4C4B3D4")] set
      {
      }
    }

    [Token(Token = "0x170031EB")]
    public bool Initialized
    {
      [Token(Token = "0x600E9A1"), Address(RVA = "0x4C4B3E0", Offset = "0x4C4B3E0", VA = "0x4C4B3E0", Slot = "12")] get
      {
        return new bool();
      }
      [Token(Token = "0x600E9A2"), Address(RVA = "0x4C4B3E8", Offset = "0x4C4B3E8", VA = "0x4C4B3E8")] private set
      {
      }
    }

    [Token(Token = "0x600E9A3")]
    [Address(RVA = "0x4C4A9A4", Offset = "0x4C4A9A4", VA = "0x4C4A9A4", Slot = "13")]
    public void Initialize(MainDirector mainDirector)
    {
    }

    [Token(Token = "0x600E9A4")]
    [Address(RVA = "0x4C4B3F4", Offset = "0x4C4B3F4", VA = "0x4C4B3F4", Slot = "14")]
    public void Abort()
    {
    }

    [Token(Token = "0x600E9A5")]
    [Address(RVA = "0x4C4AC74", Offset = "0x4C4AC74", VA = "0x4C4AC74", Slot = "15")]
    public void Release()
    {
    }

    [Token(Token = "0x600E9A6")]
    [Address(RVA = "0x4C4AE18", Offset = "0x4C4AE18", VA = "0x4C4AE18", Slot = "16")]
    public void Step(float delta)
    {
    }

    [Token(Token = "0x600E9A7")]
    [Address(RVA = "0x4C4B3F8", Offset = "0x4C4B3F8", VA = "0x4C4B3F8", Slot = "5")]
    public override void CreateGrid(
      ISystemFlags sys,
      Transform gridRoot,
      MapEditorData mapEditorData)
    {
    }

    [Token(Token = "0x600E9A8")]
    [Address(RVA = "0x4C4B43C", Offset = "0x4C4B43C", VA = "0x4C4B43C")]
    public void UnLoadGrid()
    {
    }

    [Token(Token = "0x600E9A9")]
    [Address(RVA = "0x4C4B584", Offset = "0x4C4B584", VA = "0x4C4B584", Slot = "6")]
    public override void ShowCursorAt(int x, int y)
    {
    }

    [Token(Token = "0x600E9AA")]
    [Address(RVA = "0x4C4B598", Offset = "0x4C4B598", VA = "0x4C4B598", Slot = "7")]
    public override void ShowMovableAndAttackableAreaFromSearchResult(
      MovableAreaSearcher movable,
      int gridShapeSize,
      AttackableAreaSearcher attackable,
      bool isAttack)
    {
    }

    [Token(Token = "0x600E9AB")]
    [Address(RVA = "0x4C4B59C", Offset = "0x4C4B59C", VA = "0x4C4B59C", Slot = "9")]
    public override void ShowMovableAreaFromResult(MovableAreaSearcher movable, int gridShapeSize)
    {
    }

    [Token(Token = "0x600E9AC")]
    [Address(RVA = "0x4C4B5A0", Offset = "0x4C4B5A0", VA = "0x4C4B5A0", Slot = "10")]
    public override void ShowAttackableAreaFromResult(
      AttackableAreaSearcher attackable,
      bool isAttack)
    {
    }

    [Token(Token = "0x600E9AD")]
    [Address(RVA = "0x4C4B5A4", Offset = "0x4C4B5A4", VA = "0x4C4B5A4", Slot = "11")]
    public override void ShowEffectiveAreaFromResult(AttackableAreaSearcher effective)
    {
    }

    [Token(Token = "0x600E9AE")]
    [Address(RVA = "0x4C4B5A8", Offset = "0x4C4B5A8", VA = "0x4C4B5A8")]
    public void ShowInitializePlacementArea(List<ExpeditionBattleData.PlaceAllyData> placeData)
    {
    }

    [Token(Token = "0x600E9AF")]
    [Address(RVA = "0x4C4B72C", Offset = "0x4C4B72C", VA = "0x4C4B72C")]
    public void HideInitialPlacementArea(List<ExpeditionBattleData.PlaceAllyData> placeData)
    {
    }

    [Token(Token = "0x600E9B0")]
    [Address(RVA = "0x4C4B204", Offset = "0x4C4B204", VA = "0x4C4B204")]
    public void HideInitializeAllPlacementArea()
    {
    }

    [Token(Token = "0x600E9B1")]
    [Address(RVA = "0x4C4B8AC", Offset = "0x4C4B8AC", VA = "0x4C4B8AC")]
    public MapDirector()
    {
    }
  }
}
