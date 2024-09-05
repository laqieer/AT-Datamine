// Decompiled with JetBrains decompiler
// Type: UIGyroController
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections.Generic;
using UnityEngine;

#nullable disable
[Token(Token = "0x20002CC")]
public class UIGyroController : MonoBehaviour
{
  [Token(Token = "0x400104C")]
  [FieldOffset(Offset = "0x18")]
  public bool isControllerStarted;
  [Token(Token = "0x400104D")]
  [FieldOffset(Offset = "0x1C")]
  public float leftMax;
  [Token(Token = "0x400104E")]
  [FieldOffset(Offset = "0x20")]
  public float rightMax;
  [Token(Token = "0x400104F")]
  [FieldOffset(Offset = "0x24")]
  public float bottomMax;
  [Token(Token = "0x4001050")]
  [FieldOffset(Offset = "0x28")]
  public float topMax;
  [Token(Token = "0x4001051")]
  [FieldOffset(Offset = "0x30")]
  public List<UIGyroController.GyroControlledTransform> gyroControlledTransforms;
  [Token(Token = "0x4001052")]
  [FieldOffset(Offset = "0x38")]
  private bool isGyroAvailable;
  [Token(Token = "0x4001053")]
  [FieldOffset(Offset = "0x3C")]
  private float currentRotationRateX;
  [Token(Token = "0x4001054")]
  [FieldOffset(Offset = "0x40")]
  private float currentRotationRateY;
  [Token(Token = "0x4001055")]
  [FieldOffset(Offset = "0x44")]
  private float? tX;
  [Token(Token = "0x4001056")]
  [FieldOffset(Offset = "0x4C")]
  private float? tY;
  [Token(Token = "0x4001057")]
  [FieldOffset(Offset = "0x58")]
  private UIGyroController.GyroControlledTransform currTarget;

  [Token(Token = "0x600117C")]
  [Address(RVA = "0x1BF2EE4", Offset = "0x1BF2EE4", VA = "0x1BF2EE4")]
  private void Start()
  {
  }

  [Token(Token = "0x600117D")]
  [Address(RVA = "0x1BF2F28", Offset = "0x1BF2F28", VA = "0x1BF2F28")]
  private void Update()
  {
  }

  [Token(Token = "0x600117E")]
  [Address(RVA = "0x1BF3234", Offset = "0x1BF3234", VA = "0x1BF3234")]
  private void OnDestroy()
  {
  }

  [Token(Token = "0x600117F")]
  [Address(RVA = "0x1BF3244", Offset = "0x1BF3244", VA = "0x1BF3244")]
  public void StartController()
  {
  }

  [Token(Token = "0x6001180")]
  [Address(RVA = "0x1BF3254", Offset = "0x1BF3254", VA = "0x1BF3254")]
  private void InitializeControlledTargets()
  {
  }

  [Token(Token = "0x6001181")]
  [Address(RVA = "0x1BF323C", Offset = "0x1BF323C", VA = "0x1BF323C")]
  public void StopController()
  {
  }

  [Token(Token = "0x6001182")]
  [Address(RVA = "0x1BF33B8", Offset = "0x1BF33B8", VA = "0x1BF33B8")]
  private void ResetControlledTargets()
  {
  }

  [Token(Token = "0x6001183")]
  [Address(RVA = "0x1BF351C", Offset = "0x1BF351C", VA = "0x1BF351C")]
  public UIGyroController()
  {
  }

  [Token(Token = "0x20002CD")]
  [Serializable]
  public class GyroControlledTransform
  {
    [Token(Token = "0x4001058")]
    [FieldOffset(Offset = "0x10")]
    public float xMin;
    [Token(Token = "0x4001059")]
    [FieldOffset(Offset = "0x14")]
    public float xMax;
    [Token(Token = "0x400105A")]
    [FieldOffset(Offset = "0x18")]
    public float yMin;
    [Token(Token = "0x400105B")]
    [FieldOffset(Offset = "0x1C")]
    public float yMax;
    [Token(Token = "0x400105C")]
    [FieldOffset(Offset = "0x20")]
    public Transform targetTransform;
    [Token(Token = "0x400105D")]
    [FieldOffset(Offset = "0x28")]
    public Vector3 originalLocalPosition;

    [Token(Token = "0x6001184")]
    [Address(RVA = "0x1BF3598", Offset = "0x1BF3598", VA = "0x1BF3598")]
    public GyroControlledTransform()
    {
    }
  }
}
