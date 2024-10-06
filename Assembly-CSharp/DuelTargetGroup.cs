// Decompiled with JetBrains decompiler
// Type: DuelTargetGroup
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Cinemachine;
using Il2CppDummyDll;
using UnityEngine;

#nullable disable
[Token(Token = "0x2000173")]
[ExecuteInEditMode]
public class DuelTargetGroup : MonoBehaviour
{
  [Token(Token = "0x400094C")]
  [FieldOffset(Offset = "0x18")]
  [SerializeField]
  private CinemachineVirtualCamera virtualCamera;
  [Token(Token = "0x400094D")]
  [FieldOffset(Offset = "0x20")]
  [SerializeField]
  private CinemachineTargetGroup targetGroup;
  [Token(Token = "0x400094E")]
  [FieldOffset(Offset = "0x28")]
  [SerializeField]
  private CinemachineBrain cinemachineBrain;
  [Token(Token = "0x400094F")]
  [FieldOffset(Offset = "0x30")]
  [Range(0.0f, 1f)]
  public float depth;

  [Token(Token = "0x6000A1A")]
  [Address(RVA = "0x4BB22B8", Offset = "0x4BB22B8", VA = "0x4BB22B8")]
  private void Start()
  {
  }

  [Token(Token = "0x6000A1B")]
  [Address(RVA = "0x4BB22BC", Offset = "0x4BB22BC", VA = "0x4BB22BC")]
  private void Update()
  {
  }

  [Token(Token = "0x6000A1C")]
  [Address(RVA = "0x4BB26B4", Offset = "0x4BB26B4", VA = "0x4BB26B4")]
  public void Initialize(
    CinemachineVirtualCamera virtualCamera,
    CinemachineTargetGroup targetGroup,
    CinemachineBrain cinemachineBrain)
  {
  }

  [Token(Token = "0x6000A1D")]
  [Address(RVA = "0x4BB22C0", Offset = "0x4BB22C0", VA = "0x4BB22C0")]
  private void UpdatePosition()
  {
  }

  [Token(Token = "0x6000A1E")]
  [Address(RVA = "0x4BB26C0", Offset = "0x4BB26C0", VA = "0x4BB26C0")]
  public DuelTargetGroup()
  {
  }
}
