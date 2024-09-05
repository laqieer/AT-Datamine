// Decompiled with JetBrains decompiler
// Type: FreeMap.Instance.FreeMapPlayerMoveController
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using Story;
using UnityEngine;
using UnityEngine.AI;

#nullable disable
namespace FreeMap.Instance
{
  [Token(Token = "0x20018C3")]
  public class FreeMapPlayerMoveController
  {
    [Token(Token = "0x4006B7F")]
    [FieldOffset(Offset = "0x24")]
    protected float rotationSpeed;
    [Token(Token = "0x4006B80")]
    [FieldOffset(Offset = "0x28")]
    protected float rotationLimit;
    [Token(Token = "0x4006B81")]
    [FieldOffset(Offset = "0x2C")]
    protected float moveSpeedWalk;
    [Token(Token = "0x4006B82")]
    [FieldOffset(Offset = "0x30")]
    protected float moveSpeedRun;
    [Token(Token = "0x4006B83")]
    [FieldOffset(Offset = "0x34")]
    protected float moveSpeedTimeline;
    [Token(Token = "0x4006B84")]
    [FieldOffset(Offset = "0x38")]
    protected float moveSpeedRate;
    [Token(Token = "0x4006B85")]
    [FieldOffset(Offset = "0x3C")]
    protected Vector3 moveDirection;
    [Token(Token = "0x4006B86")]
    [FieldOffset(Offset = "0x48")]
    protected float currentSpeed;
    [Token(Token = "0x4006B87")]
    [FieldOffset(Offset = "0x4C")]
    protected float changeStateDuration;
    [Token(Token = "0x4006B88")]
    [FieldOffset(Offset = "0x50")]
    protected float changeStateValue;
    [Token(Token = "0x4006B89")]
    [FieldOffset(Offset = "0x54")]
    protected float changeStateCounter;

    [Token(Token = "0x1700169D")]
    public NavMeshAgent Agent
    {
      [Token(Token = "0x6008CCD"), Address(RVA = "0x4530160", Offset = "0x4530160", VA = "0x4530160")] private set
      {
      }
      [Token(Token = "0x6008CCE"), Address(RVA = "0x4530168", Offset = "0x4530168", VA = "0x4530168")] get
      {
        return (NavMeshAgent) null;
      }
    }

    [Token(Token = "0x1700169E")]
    public Transform TargetTransform
    {
      [Token(Token = "0x6008CCF"), Address(RVA = "0x4530170", Offset = "0x4530170", VA = "0x4530170")] private set
      {
      }
      [Token(Token = "0x6008CD0"), Address(RVA = "0x4530178", Offset = "0x4530178", VA = "0x4530178")] get
      {
        return (Transform) null;
      }
    }

    [Token(Token = "0x1700169F")]
    public bool IsMoving
    {
      [Token(Token = "0x6008CD1"), Address(RVA = "0x452EB60", Offset = "0x452EB60", VA = "0x452EB60")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x170016A0")]
    public StoryCharacterMoveBehaviour.MoveSpeedType CurrentMoveState
    {
      [Token(Token = "0x6008CD2"), Address(RVA = "0x4530180", Offset = "0x4530180", VA = "0x4530180")] private set
      {
      }
      [Token(Token = "0x6008CD3"), Address(RVA = "0x4530188", Offset = "0x4530188", VA = "0x4530188")] get
      {
        return new StoryCharacterMoveBehaviour.MoveSpeedType();
      }
    }

    [Token(Token = "0x170016A1")]
    public float CurrentSpeed
    {
      [Token(Token = "0x6008CD4"), Address(RVA = "0x4530190", Offset = "0x4530190", VA = "0x4530190")] get
      {
        return new float();
      }
    }

    [Token(Token = "0x6008CD5")]
    [Address(RVA = "0x452ED08", Offset = "0x452ED08", VA = "0x452ED08")]
    public void Initialize(NavMeshAgent agent, Transform transform)
    {
    }

    [Token(Token = "0x6008CD6")]
    [Address(RVA = "0x452EF2C", Offset = "0x452EF2C", VA = "0x452EF2C")]
    public void Update(float deltaTime)
    {
    }

    [Token(Token = "0x6008CD7")]
    [Address(RVA = "0x452EF84", Offset = "0x452EF84", VA = "0x452EF84")]
    public void LateUpdate(float deltaTime)
    {
    }

    [Token(Token = "0x6008CD8")]
    [Address(RVA = "0x452F0FC", Offset = "0x452F0FC", VA = "0x452F0FC")]
    public void ChangeState(StoryCharacterMoveBehaviour.MoveSpeedType moveType, float duration)
    {
    }

    [Token(Token = "0x6008CD9")]
    [Address(RVA = "0x45306D0", Offset = "0x45306D0", VA = "0x45306D0")]
    private float StateToSpeed(StoryCharacterMoveBehaviour.MoveSpeedType moveType) => new float();

    [Token(Token = "0x6008CDA")]
    [Address(RVA = "0x4530198", Offset = "0x4530198", VA = "0x4530198")]
    private void CalcSpeed(float deltaTime)
    {
    }

    [Token(Token = "0x6008CDB")]
    [Address(RVA = "0x4530220", Offset = "0x4530220", VA = "0x4530220")]
    private void UpdateTransform(float deltaTime)
    {
    }

    [Token(Token = "0x6008CDC")]
    [Address(RVA = "0x452F308", Offset = "0x452F308", VA = "0x452F308")]
    public void SetMoveDirection(Vector3 dir)
    {
    }

    [Token(Token = "0x6008CDD")]
    [Address(RVA = "0x452F550", Offset = "0x452F550", VA = "0x452F550")]
    public void Warp(Vector3 position, Quaternion rotation)
    {
    }

    [Token(Token = "0x6008CDE")]
    [Address(RVA = "0x4530704", Offset = "0x4530704", VA = "0x4530704")]
    public void SetMoveSpeedRate(float rate)
    {
    }

    [Token(Token = "0x6008CDF")]
    [Address(RVA = "0x453070C", Offset = "0x453070C", VA = "0x453070C")]
    public void SetMoveSpeed(float walkSpeed, float runSpeed)
    {
    }

    [Token(Token = "0x6008CE0")]
    [Address(RVA = "0x452F3EC", Offset = "0x452F3EC", VA = "0x452F3EC")]
    public void Stop()
    {
    }

    [Token(Token = "0x6008CE1")]
    [Address(RVA = "0x452FFCC", Offset = "0x452FFCC", VA = "0x452FFCC")]
    public FreeMapPlayerMoveController()
    {
    }
  }
}
