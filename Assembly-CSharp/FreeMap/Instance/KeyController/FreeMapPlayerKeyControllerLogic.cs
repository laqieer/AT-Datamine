// Decompiled with JetBrains decompiler
// Type: FreeMap.Instance.KeyController.FreeMapPlayerKeyControllerLogic
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace FreeMap.Instance.KeyController
{
  [Token(Token = "0x2001909")]
  public class FreeMapPlayerKeyControllerLogic : IPlayerInputProvider
  {
    [Token(Token = "0x4006C35")]
    [FieldOffset(Offset = "0x18")]
    private FreeMapPlayerKeyController component;
    [Token(Token = "0x4006C36")]
    [FieldOffset(Offset = "0x20")]
    private ITrackedCamera trackedCamera;
    [Token(Token = "0x4006C37")]
    [FieldOffset(Offset = "0x28")]
    private Transform targetPlayer;
    [Token(Token = "0x4006C38")]
    [FieldOffset(Offset = "0x30")]
    private Vector3 forwardDirection;
    [Token(Token = "0x4006C39")]
    [FieldOffset(Offset = "0x3C")]
    private Vector3 rightDirection;

    [Token(Token = "0x170016CE")]
    public bool IsValid
    {
      [Token(Token = "0x6008E51"), Address(RVA = "0x4B009C0", Offset = "0x4B009C0", VA = "0x4B009C0")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x170016CF")]
    private bool IsNotExistPlayer
    {
      [Token(Token = "0x6008E52"), Address(RVA = "0x4B00A20", Offset = "0x4B00A20", VA = "0x4B00A20")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x170016D0")]
    private bool IsNotExistCamera
    {
      [Token(Token = "0x6008E53"), Address(RVA = "0x4B00A80", Offset = "0x4B00A80", VA = "0x4B00A80")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x170016D1")]
    public bool IsEnabled
    {
      [Token(Token = "0x6008E54"), Address(RVA = "0x4B00A90", Offset = "0x4B00A90", VA = "0x4B00A90")] get
      {
        return new bool();
      }
      [Token(Token = "0x6008E55"), Address(RVA = "0x4B00A98", Offset = "0x4B00A98", VA = "0x4B00A98")] private set
      {
      }
    }

    [Token(Token = "0x170016D2")]
    public bool IsControlling
    {
      [Token(Token = "0x6008E56"), Address(RVA = "0x4B00AA4", Offset = "0x4B00AA4", VA = "0x4B00AA4")] set
      {
      }
      [Token(Token = "0x6008E57"), Address(RVA = "0x4B00AB0", Offset = "0x4B00AB0", VA = "0x4B00AB0")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x14000129")]
    public event MoveUpdateFunc OnMoveUpdate
    {
      [Token(Token = "0x6008E58"), Address(RVA = "0x4B00AB8", Offset = "0x4B00AB8", VA = "0x4B00AB8", Slot = "4")] add
      {
      }
      [Token(Token = "0x6008E59"), Address(RVA = "0x4B00B54", Offset = "0x4B00B54", VA = "0x4B00B54", Slot = "5")] remove
      {
      }
    }

    [Token(Token = "0x1400012A")]
    public event SetMoveSpeedFunc SetMoveSpeed
    {
      [Token(Token = "0x6008E5A"), Address(RVA = "0x4B00BF0", Offset = "0x4B00BF0", VA = "0x4B00BF0", Slot = "6")] add
      {
      }
      [Token(Token = "0x6008E5B"), Address(RVA = "0x4B00C8C", Offset = "0x4B00C8C", VA = "0x4B00C8C", Slot = "7")] remove
      {
      }
    }

    [Token(Token = "0x1400012B")]
    public event SetAnimationRateFunc SetAnimationRate
    {
      [Token(Token = "0x6008E5C"), Address(RVA = "0x4B00D28", Offset = "0x4B00D28", VA = "0x4B00D28", Slot = "8")] add
      {
      }
      [Token(Token = "0x6008E5D"), Address(RVA = "0x4B00DC4", Offset = "0x4B00DC4", VA = "0x4B00DC4", Slot = "9")] remove
      {
      }
    }

    [Token(Token = "0x6008E5E")]
    [Address(RVA = "0x4B00E60", Offset = "0x4B00E60", VA = "0x4B00E60")]
    public FreeMapPlayerKeyControllerLogic()
    {
    }

    [Token(Token = "0x6008E5F")]
    [Address(RVA = "0x4B00E68", Offset = "0x4B00E68", VA = "0x4B00E68")]
    public void Setup(
      FreeMapPlayerKeyController component,
      ITrackedCamera trackedCamera,
      Transform targetPlayer)
    {
    }

    [Token(Token = "0x6008E60")]
    [Address(RVA = "0x4B00FC0", Offset = "0x4B00FC0", VA = "0x4B00FC0")]
    public void SetPlayer(ITrackedCamera trackedCamera, Transform targetPlayer)
    {
    }

    [Token(Token = "0x6008E61")]
    [Address(RVA = "0x4B00FC8", Offset = "0x4B00FC8", VA = "0x4B00FC8")]
    public void SetEnabled(bool enabled)
    {
    }

    [Token(Token = "0x6008E62")]
    [Address(RVA = "0x4B010E4", Offset = "0x4B010E4", VA = "0x4B010E4")]
    private void OnStartControl()
    {
    }

    [Token(Token = "0x6008E63")]
    [Address(RVA = "0x4B01074", Offset = "0x4B01074", VA = "0x4B01074")]
    private void OnEndControl()
    {
    }

    [Token(Token = "0x6008E64")]
    [Address(RVA = "0x4B01270", Offset = "0x4B01270", VA = "0x4B01270")]
    private void OnUpdateControl(Vector2 inputDirection)
    {
    }

    [Token(Token = "0x6008E65")]
    [Address(RVA = "0x4B01400", Offset = "0x4B01400", VA = "0x4B01400")]
    protected Vector3 GetDirMove(in Vector2 inputDirection) => new Vector3();

    [Token(Token = "0x6008E66")]
    [Address(RVA = "0x4B011B0", Offset = "0x4B011B0", VA = "0x4B011B0")]
    private void UpdateDirMove(Transform transform)
    {
    }

    [Token(Token = "0x6008E67")]
    [Address(RVA = "0x4B018A8", Offset = "0x4B018A8", VA = "0x4B018A8")]
    public void Release()
    {
    }

    [Token(Token = "0x6008E68")]
    [Address(RVA = "0x4B018B8", Offset = "0x4B018B8", VA = "0x4B018B8")]
    public void Destroy()
    {
    }
  }
}
