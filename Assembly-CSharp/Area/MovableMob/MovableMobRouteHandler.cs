// Decompiled with JetBrains decompiler
// Type: Area.MovableMob.MovableMobRouteHandler
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Area.MovableMob.Data;
using Area.MovableMob.Instance;
using Il2CppDummyDll;
using System.Collections.Generic;
using UnityEngine;

#nullable disable
namespace Area.MovableMob
{
  [Token(Token = "0x200282D")]
  public class MovableMobRouteHandler
  {
    [Token(Token = "0x400AB5E")]
    [FieldOffset(Offset = "0x10")]
    private MovablePartialRouteParameter lineParameter;
    [Token(Token = "0x400AB60")]
    [FieldOffset(Offset = "0x20")]
    private List<MovableMobInstanceDataBase> originalMobTable;
    [Token(Token = "0x400AB61")]
    [FieldOffset(Offset = "0x28")]
    private List<MovableMobInstanceDataBase> currentUnselectedMobTable;
    [Token(Token = "0x400AB62")]
    [FieldOffset(Offset = "0x30")]
    private List<IMovableMobAnchor> anchorList;
    [Token(Token = "0x400AB63")]
    [FieldOffset(Offset = "0x38")]
    private float currentPopTime;
    [Token(Token = "0x400AB64")]
    [FieldOffset(Offset = "0x3C")]
    private float nextPopTime;
    [Token(Token = "0x400AB65")]
    [FieldOffset(Offset = "0x40")]
    private List<MovableMobInstanceBase> activeInstanceList;
    [Token(Token = "0x400AB66")]
    [FieldOffset(Offset = "0x48")]
    private List<MovableMobInstanceBase> deactiveInstanceList;

    [Token(Token = "0x17003791")]
    public string Name
    {
      [Token(Token = "0x600FCD7"), Address(RVA = "0x44263F8", Offset = "0x44263F8", VA = "0x44263F8")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x17003792")]
    public MovableGeneralParameter GeneralParameter
    {
      [Token(Token = "0x600FCD8"), Address(RVA = "0x4428D90", Offset = "0x4428D90", VA = "0x4428D90")] get
      {
        return (MovableGeneralParameter) null;
      }
      [Token(Token = "0x600FCD9"), Address(RVA = "0x4428D98", Offset = "0x4428D98", VA = "0x4428D98")] private set
      {
      }
    }

    [Token(Token = "0x17003793")]
    public IMovableMobAnchor StartAnchor
    {
      [Token(Token = "0x600FCDA"), Address(RVA = "0x4428DA0", Offset = "0x4428DA0", VA = "0x4428DA0")] get
      {
        return (IMovableMobAnchor) null;
      }
    }

    [Token(Token = "0x17003794")]
    public IMovableMobAnchor EndAnchor
    {
      [Token(Token = "0x600FCDB"), Address(RVA = "0x4428E10", Offset = "0x4428E10", VA = "0x4428E10")] get
      {
        return (IMovableMobAnchor) null;
      }
    }

    [Token(Token = "0x17003795")]
    public float MoveSpeed
    {
      [Token(Token = "0x600FCDC"), Address(RVA = "0x4428E80", Offset = "0x4428E80", VA = "0x4428E80")] get
      {
        return new float();
      }
    }

    [Token(Token = "0x17003796")]
    public MovablePartialRouteParameter.MobOffsetParameter MobOffset
    {
      [Token(Token = "0x600FCDD"), Address(RVA = "0x4428E98", Offset = "0x4428E98", VA = "0x4428E98")] get
      {
        return (MovablePartialRouteParameter.MobOffsetParameter) null;
      }
    }

    [Token(Token = "0x17003797")]
    public Transform InstanceParent
    {
      [Token(Token = "0x600FCDE"), Address(RVA = "0x4428EB0", Offset = "0x4428EB0", VA = "0x4428EB0")] get
      {
        return (Transform) null;
      }
      [Token(Token = "0x600FCDF"), Address(RVA = "0x4428EB8", Offset = "0x4428EB8", VA = "0x4428EB8")] private set
      {
      }
    }

    [Token(Token = "0x600FCE0")]
    [Address(RVA = "0x4428830", Offset = "0x4428830", VA = "0x4428830")]
    public MovableMobRouteHandler(
      List<MovableMobInstanceDataBase> instanceData,
      MovablePartialRouteParameter lineData,
      MovableRouteData routeData,
      MovableGeneralParameter movableParameter,
      Transform parent,
      Transform player = null)
    {
    }

    [Token(Token = "0x600FCE1")]
    [Address(RVA = "0x4426454", Offset = "0x4426454", VA = "0x4426454")]
    public void SetLineParameter(
      float moveSpeed,
      float popMobTime,
      float popMinTime,
      float popMaxTime,
      int maxPopCount,
      MovablePartialRouteParameter.MobOffsetParameter mobOffsetParam)
    {
    }

    [Token(Token = "0x600FCE2")]
    [Address(RVA = "0x4426580", Offset = "0x4426580", VA = "0x4426580")]
    public void SetMoveSpeed(float moveSpeed)
    {
    }

    [Token(Token = "0x600FCE3")]
    [Address(RVA = "0x44266B4", Offset = "0x44266B4", VA = "0x44266B4")]
    public void SetPopTimes(float popMobTime, float popMinTime, float popMaxTime)
    {
    }

    [Token(Token = "0x600FCE4")]
    [Address(RVA = "0x44267D0", Offset = "0x44267D0", VA = "0x44267D0")]
    public void SetMaxPopCount(int maxPopCount)
    {
    }

    [Token(Token = "0x600FCE5")]
    [Address(RVA = "0x44268F0", Offset = "0x44268F0", VA = "0x44268F0")]
    public void SetMobOffset(
      MovablePartialRouteParameter.MobOffsetParameter parameter)
    {
    }

    [Token(Token = "0x600FCE6")]
    [Address(RVA = "0x4426AAC", Offset = "0x4426AAC", VA = "0x4426AAC")]
    public void LineUpdate(Transform playerTransform)
    {
    }

    [Token(Token = "0x600FCE7")]
    [Address(RVA = "0x44294F8", Offset = "0x44294F8", VA = "0x44294F8")]
    private void PopUpdate(Transform playerTransform)
    {
    }

    [Token(Token = "0x600FCE8")]
    [Address(RVA = "0x4426E50", Offset = "0x4426E50", VA = "0x4426E50")]
    public void ViewUpdate(Camera camera, Transform playerTransform)
    {
    }

    [Token(Token = "0x600FCE9")]
    [Address(RVA = "0x4428F94", Offset = "0x4428F94", VA = "0x4428F94")]
    private void RandomPlaceLineMobs(Transform playerTransform)
    {
    }

    [Token(Token = "0x600FCEA")]
    [Address(RVA = "0x44298A0", Offset = "0x44298A0", VA = "0x44298A0")]
    private float CalcRouteDistance() => new float();

    [Token(Token = "0x600FCEB")]
    [Address(RVA = "0x4429AB0", Offset = "0x4429AB0", VA = "0x4429AB0")]
    private IMovableMobAnchor GetAnchorFromDistance(float distance, out float distanceRate)
    {
      return (IMovableMobAnchor) null;
    }

    [Token(Token = "0x600FCEC")]
    [Address(RVA = "0x4427240", Offset = "0x4427240", VA = "0x4427240")]
    public void Release()
    {
    }

    [Token(Token = "0x600FCED")]
    [Address(RVA = "0x442959C", Offset = "0x442959C", VA = "0x442959C")]
    private MovableMobInstanceBase RegisterInstance(Transform playerTransform)
    {
      return (MovableMobInstanceBase) null;
    }

    [Token(Token = "0x600FCEE")]
    [Address(RVA = "0x4429054", Offset = "0x4429054", VA = "0x4429054")]
    private void SetNextPopTime()
    {
    }

    [Token(Token = "0x600FCEF")]
    [Address(RVA = "0x4429F00", Offset = "0x4429F00", VA = "0x4429F00")]
    private bool TryGetDeactiveInstance(
      MovableMobInstanceDataBase param,
      out MovableMobInstanceBase deactiveInstance)
    {
      return new bool();
    }

    [Token(Token = "0x600FCF0")]
    [Address(RVA = "0x4428EC0", Offset = "0x4428EC0", VA = "0x4428EC0")]
    private void ResetUnselectedPopTable()
    {
    }

    [Token(Token = "0x600FCF1")]
    [Address(RVA = "0x4429A7C", Offset = "0x4429A7C", VA = "0x4429A7C")]
    public float GetNextPopTime() => new float();
  }
}
