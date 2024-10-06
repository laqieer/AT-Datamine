// Decompiled with JetBrains decompiler
// Type: TimelineTestController
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Cinemachine;
using Il2CppDummyDll;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;

#nullable disable
[Token(Token = "0x2000319")]
public class TimelineTestController : MonoBehaviour
{
  [Token(Token = "0x400128A")]
  [FieldOffset(Offset = "0x18")]
  public PlayableDirector mainDirector;
  [Token(Token = "0x400128B")]
  [FieldOffset(Offset = "0x20")]
  public CinemachineBrain brain;
  [Token(Token = "0x400128C")]
  [FieldOffset(Offset = "0x28")]
  public List<CinemachineVirtualCamera> virtualCameras;

  [Token(Token = "0x60012A4")]
  [Address(RVA = "0x285C198", Offset = "0x285C198", VA = "0x285C198")]
  private void Start()
  {
  }

  [Token(Token = "0x60012A5")]
  [Address(RVA = "0x285C19C", Offset = "0x285C19C", VA = "0x285C19C")]
  private void Update()
  {
  }

  [Token(Token = "0x60012A6")]
  [Address(RVA = "0x285C1A0", Offset = "0x285C1A0", VA = "0x285C1A0")]
  public void OnClickPlay()
  {
  }

  [Token(Token = "0x60012A7")]
  [Address(RVA = "0x285C2C4", Offset = "0x285C2C4", VA = "0x285C2C4")]
  public TimelineTestController()
  {
  }
}
