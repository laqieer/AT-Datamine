// Decompiled with JetBrains decompiler
// Type: Battle.Expedition.Command.DuelCommand
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Battle.Data;
using Battle.Data.Board;
using Battle.DuelScene;
using Battle.Process;
using Battle.RouteSearch;
using Il2CppDummyDll;
using System;
using System.Collections.Generic;

#nullable disable
namespace Battle.Expedition.Command
{
  [Token(Token = "0x20025DC")]
  public sealed class DuelCommand : Battle.Command.DuelCommand
  {
    [Token(Token = "0x400A2DB")]
    [FieldOffset(Offset = "0x0")]
    public static bool Debug;
    [Token(Token = "0x400A2DC")]
    private const float CameraMoveDuration = 0.2f;
    [Token(Token = "0x400A2DE")]
    [FieldOffset(Offset = "0x1FC")]
    private float startCameraDist;
    [Token(Token = "0x400A2DF")]
    [FieldOffset(Offset = "0x200")]
    private List<UnitParameterData> unForcusUnits;
    [Token(Token = "0x400A2E0")]
    [FieldOffset(Offset = "0x208")]
    private bool isCompleting;

    [Token(Token = "0x170031F4")]
    private bool IsBossBattle
    {
      [Token(Token = "0x600E9F6"), Address(RVA = "0x4C4D9F8", Offset = "0x4C4D9F8", VA = "0x4C4D9F8")] get
      {
        return new bool();
      }
      [Token(Token = "0x600E9F7"), Address(RVA = "0x4C4DA00", Offset = "0x4C4DA00", VA = "0x4C4DA00")] set
      {
      }
    }

    [Token(Token = "0x600E9F8")]
    [Address(RVA = "0x4C4DA0C", Offset = "0x4C4DA0C", VA = "0x4C4DA0C")]
    public DuelCommand(
      BattleCore core,
      UnitParameterData owner,
      GridData ownerGrid,
      TargetPair mainTarget,
      Dictionary<int, List<TargetPair>> targetsByEffect,
      AttackableAreaSearcher effectable,
      SkillParameterData skillParam)
    {
    }

    [Token(Token = "0x600E9F9")]
    [Address(RVA = "0x4C4DC48", Offset = "0x4C4DC48", VA = "0x4C4DC48", Slot = "12")]
    protected override void Consume()
    {
    }

    [Token(Token = "0x600E9FA")]
    [Address(RVA = "0x4C4DC74", Offset = "0x4C4DC74", VA = "0x4C4DC74", Slot = "6")]
    protected override void ExecuteInternal()
    {
    }

    [Token(Token = "0x600E9FB")]
    [Address(RVA = "0x4C4EAB0", Offset = "0x4C4EAB0", VA = "0x4C4EAB0", Slot = "7")]
    public override void Complete(bool complete)
    {
    }

    [Token(Token = "0x600E9FC")]
    [Address(RVA = "0x4C4DE74", Offset = "0x4C4DE74", VA = "0x4C4DE74")]
    private void FocusCamera(DuelData duelData)
    {
    }

    [Token(Token = "0x600E9FD")]
    [Address(RVA = "0x4C4EBC0", Offset = "0x4C4EBC0", VA = "0x4C4EBC0")]
    private void ResetCameraFocus(Action onCompleted)
    {
    }

    [Token(Token = "0x600E9FE")]
    [Address(RVA = "0x4C4F184", Offset = "0x4C4F184", VA = "0x4C4F184")]
    static DuelCommand()
    {
    }
  }
}
