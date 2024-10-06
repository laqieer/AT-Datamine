// Decompiled with JetBrains decompiler
// Type: DuelVCShakeController
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Cinemachine;
using Il2CppDummyDll;
using UnityEngine;

#nullable disable
[Token(Token = "0x2000188")]
[RequireComponent(typeof (CinemachineBrain))]
public class DuelVCShakeController : MonoBehaviour
{
  [Token(Token = "0x4000A1A")]
  [FieldOffset(Offset = "0x18")]
  private CinemachineBrain cinemachineBrain;
  [Token(Token = "0x4000A1B")]
  [FieldOffset(Offset = "0x20")]
  public Vector3 pivotOffset;
  [Token(Token = "0x4000A1C")]
  [FieldOffset(Offset = "0x2C")]
  public float amplitudeGain;
  [Token(Token = "0x4000A1D")]
  [FieldOffset(Offset = "0x30")]
  public float frequencyGain;

  [Token(Token = "0x6000AAE")]
  [Address(RVA = "0x4BBA13C", Offset = "0x4BBA13C", VA = "0x4BBA13C")]
  private void Start()
  {
  }

  [Token(Token = "0x6000AAF")]
  [Address(RVA = "0x4BBA18C", Offset = "0x4BBA18C", VA = "0x4BBA18C")]
  private void Update()
  {
  }

  [Token(Token = "0x6000AB0")]
  [Address(RVA = "0x4BBA1C0", Offset = "0x4BBA1C0", VA = "0x4BBA1C0")]
  private void UpdateVCShakeSettings()
  {
  }

  [Token(Token = "0x6000AB1")]
  [Address(RVA = "0x4BBA2D8", Offset = "0x4BBA2D8", VA = "0x4BBA2D8")]
  public void StopShakeEffect()
  {
  }

  [Token(Token = "0x6000AB2")]
  [Address(RVA = "0x4BBA334", Offset = "0x4BBA334", VA = "0x4BBA334")]
  public DuelVCShakeController()
  {
  }
}
