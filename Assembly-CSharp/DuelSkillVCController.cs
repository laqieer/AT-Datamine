// Decompiled with JetBrains decompiler
// Type: DuelSkillVCController
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Cinemachine;
using Il2CppDummyDll;
using UnityEngine;

#nullable disable
[Token(Token = "0x2000168")]
public class DuelSkillVCController : MonoBehaviour
{
  [Token(Token = "0x400090B")]
  [FieldOffset(Offset = "0x18")]
  public GameObject actorAimTarget;
  [Token(Token = "0x400090C")]
  [FieldOffset(Offset = "0x20")]
  public GameObject targetAimTarget;
  [Token(Token = "0x400090D")]
  [FieldOffset(Offset = "0x28")]
  public GameObject centerAimTarget;
  [Token(Token = "0x400090E")]
  [FieldOffset(Offset = "0x30")]
  public GameObject skillVCMotionRoot;
  [Token(Token = "0x400090F")]
  [FieldOffset(Offset = "0x38")]
  public CinemachineVirtualCamera skillVC;

  [Token(Token = "0x60009D9")]
  [Address(RVA = "0x477120C", Offset = "0x477120C", VA = "0x477120C")]
  public void SetActorAimTargetScaleY(float scaleY)
  {
  }

  [Token(Token = "0x60009DA")]
  [Address(RVA = "0x47752F4", Offset = "0x47752F4", VA = "0x47752F4")]
  public void SetTargetAimTargetScaleY(float scaleY)
  {
  }

  [Token(Token = "0x60009DB")]
  [Address(RVA = "0x4771030", Offset = "0x4771030", VA = "0x4771030")]
  public void SetToDetaultStatus()
  {
  }

  [Token(Token = "0x60009DC")]
  [Address(RVA = "0x477601C", Offset = "0x477601C", VA = "0x477601C")]
  public DuelSkillVCController()
  {
  }
}
