// Decompiled with JetBrains decompiler
// Type: FreeMap.Instance.FreeMapPlayerAutoMove
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using FreeMap.Instance.Element;
using Il2CppDummyDll;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

#nullable disable
namespace FreeMap.Instance
{
  [Token(Token = "0x20018BF")]
  public class FreeMapPlayerAutoMove : IPlayerInputProvider
  {
    [Token(Token = "0x4006B5A")]
    private const float StoppingDistanceMin = 0.1f;
    [Token(Token = "0x4006B5B")]
    private const float RotationLimit = 10f;
    [Token(Token = "0x4006B5C")]
    private const int DirQueueMax = 10;
    [Token(Token = "0x4006B5D")]
    [FieldOffset(Offset = "0x10")]
    protected float changeToWalkDistance;
    [Token(Token = "0x4006B5E")]
    [FieldOffset(Offset = "0x14")]
    protected float rotationSpeed;
    [Token(Token = "0x4006B5F")]
    [FieldOffset(Offset = "0x18")]
    protected float moveSpeedWalk;
    [Token(Token = "0x4006B60")]
    [FieldOffset(Offset = "0x1C")]
    protected float moveSpeedRun;
    [Token(Token = "0x4006B61")]
    [FieldOffset(Offset = "0x20")]
    protected float walkAnimationRate;
    [Token(Token = "0x4006B62")]
    [FieldOffset(Offset = "0x24")]
    protected float runAnimationRate;
    [Token(Token = "0x4006B65")]
    [FieldOffset(Offset = "0x38")]
    protected FreeMapPlayerAutoMove.State currentState;
    [Token(Token = "0x4006B69")]
    [FieldOffset(Offset = "0x58")]
    protected Vector3 lookPosition;

    [Token(Token = "0x1700168F")]
    protected Queue<Vector3> DirQueue
    {
      [Token(Token = "0x6008C87"), Address(RVA = "0x452D6A8", Offset = "0x452D6A8", VA = "0x452D6A8")] get
      {
        return (Queue<Vector3>) null;
      }
    }

    [Token(Token = "0x17001690")]
    public NavMeshAgent Agent
    {
      [Token(Token = "0x6008C88"), Address(RVA = "0x452D6B0", Offset = "0x452D6B0", VA = "0x452D6B0")] private set
      {
      }
      [Token(Token = "0x6008C89"), Address(RVA = "0x452D6B8", Offset = "0x452D6B8", VA = "0x452D6B8")] get
      {
        return (NavMeshAgent) null;
      }
    }

    [Token(Token = "0x17001691")]
    public bool IsAcitve
    {
      [Token(Token = "0x6008C8A"), Address(RVA = "0x452D6C0", Offset = "0x452D6C0", VA = "0x452D6C0")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17001692")]
    public bool IsComplete
    {
      [Token(Token = "0x6008C8B"), Address(RVA = "0x452D6D4", Offset = "0x452D6D4", VA = "0x452D6D4")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x1400011B")]
    public event MoveUpdateFunc OnMoveUpdate
    {
      [Token(Token = "0x6008C8C"), Address(RVA = "0x452D6E4", Offset = "0x452D6E4", VA = "0x452D6E4", Slot = "4")] add
      {
      }
      [Token(Token = "0x6008C8D"), Address(RVA = "0x452D780", Offset = "0x452D780", VA = "0x452D780", Slot = "5")] remove
      {
      }
    }

    [Token(Token = "0x1400011C")]
    public event SetMoveSpeedFunc SetMoveSpeed
    {
      [Token(Token = "0x6008C8E"), Address(RVA = "0x452D81C", Offset = "0x452D81C", VA = "0x452D81C", Slot = "6")] add
      {
      }
      [Token(Token = "0x6008C8F"), Address(RVA = "0x452D8B8", Offset = "0x452D8B8", VA = "0x452D8B8", Slot = "7")] remove
      {
      }
    }

    [Token(Token = "0x1400011D")]
    public event SetAnimationRateFunc SetAnimationRate
    {
      [Token(Token = "0x6008C90"), Address(RVA = "0x452D954", Offset = "0x452D954", VA = "0x452D954", Slot = "8")] add
      {
      }
      [Token(Token = "0x6008C91"), Address(RVA = "0x452D9F0", Offset = "0x452D9F0", VA = "0x452D9F0", Slot = "9")] remove
      {
      }
    }

    [Token(Token = "0x6008C92")]
    [Address(RVA = "0x452DA8C", Offset = "0x452DA8C", VA = "0x452DA8C")]
    public void Initialize(NavMeshAgent agent)
    {
    }

    [Token(Token = "0x6008C93")]
    [Address(RVA = "0x452DB3C", Offset = "0x452DB3C", VA = "0x452DB3C")]
    public void Update(float deltaTime, float currentSpeed)
    {
    }

    [Token(Token = "0x6008C94")]
    [Address(RVA = "0x452E2C0", Offset = "0x452E2C0", VA = "0x452E2C0")]
    public void LateUpdate(float deltaTime)
    {
    }

    [Token(Token = "0x6008C95")]
    [Address(RVA = "0x452DB5C", Offset = "0x452DB5C", VA = "0x452DB5C")]
    protected void UpdateMove(float deltaTime, float currentSpeed)
    {
    }

    [Token(Token = "0x6008C96")]
    [Address(RVA = "0x452DFA4", Offset = "0x452DFA4", VA = "0x452DFA4")]
    protected void UpdateAdjustment(float deltaTime)
    {
    }

    [Token(Token = "0x6008C97")]
    [Address(RVA = "0x452E36C", Offset = "0x452E36C", VA = "0x452E36C")]
    public void Start(Vector3 targetPosition, Vector3 lookPosition)
    {
    }

    [Token(Token = "0x6008C98")]
    [Address(RVA = "0x452E450", Offset = "0x452E450", VA = "0x452E450")]
    public GameObject Start(List<FreeMapMovePosition> positionList, Vector3 lookPosition)
    {
      return (GameObject) null;
    }

    [Token(Token = "0x6008C99")]
    [Address(RVA = "0x452E378", Offset = "0x452E378", VA = "0x452E378")]
    protected void StartInternal(Vector3 destination, Vector3 lookPosition, float stoppingDistance)
    {
    }

    [Token(Token = "0x6008C9A")]
    [Address(RVA = "0x452E978", Offset = "0x452E978", VA = "0x452E978")]
    public void Stop()
    {
    }

    [Token(Token = "0x6008C9B")]
    [Address(RVA = "0x452E2C4", Offset = "0x452E2C4", VA = "0x452E2C4")]
    protected void StopInternal()
    {
    }

    [Token(Token = "0x6008C9C")]
    [Address(RVA = "0x452E83C", Offset = "0x452E83C", VA = "0x452E83C")]
    protected float GetRouteDistance(Vector3[] corners) => new float();

    [Token(Token = "0x6008C9D")]
    [Address(RVA = "0x452E980", Offset = "0x452E980", VA = "0x452E980")]
    protected void ChangeState(FreeMapPlayerAutoMove.State next)
    {
    }

    [Token(Token = "0x6008C9E")]
    [Address(RVA = "0x452E988", Offset = "0x452E988", VA = "0x452E988")]
    public void DrawGizmos()
    {
    }

    [Token(Token = "0x6008C9F")]
    [Address(RVA = "0x452E9E8", Offset = "0x452E9E8", VA = "0x452E9E8")]
    public FreeMapPlayerAutoMove()
    {
    }

    [Token(Token = "0x20018C0")]
    protected enum State
    {
      [Token(Token = "0x4006B6B")] Idle,
      [Token(Token = "0x4006B6C")] Active,
      [Token(Token = "0x4006B6D")] Adjustment,
      [Token(Token = "0x4006B6E")] Complete,
    }
  }
}
