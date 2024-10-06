// Decompiled with JetBrains decompiler
// Type: DuelStratagemSceneController
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;

#nullable disable
[Token(Token = "0x2000172")]
public class DuelStratagemSceneController : MonoBehaviour
{
  [Token(Token = "0x4000948")]
  [FieldOffset(Offset = "0x18")]
  public PlayableDirector playableDirector;
  [Token(Token = "0x4000949")]
  [FieldOffset(Offset = "0x20")]
  private GameObject oldBackgroundRoot;
  [Token(Token = "0x400094A")]
  [FieldOffset(Offset = "0x28")]
  public List<GameObject> inactiveGameObjects;
  [Token(Token = "0x400094B")]
  [FieldOffset(Offset = "0x30")]
  public List<GameObject> activeGameObjects;

  [Token(Token = "0x6000A17")]
  [Address(RVA = "0x4BB2040", Offset = "0x4BB2040", VA = "0x4BB2040")]
  public void Initialize(GameObject oldBackgroundRoot)
  {
  }

  [Token(Token = "0x6000A18")]
  [Address(RVA = "0x4BB2048", Offset = "0x4BB2048", VA = "0x4BB2048")]
  public void ResetStatus()
  {
  }

  [Token(Token = "0x6000A19")]
  [Address(RVA = "0x4BB22B0", Offset = "0x4BB22B0", VA = "0x4BB22B0")]
  public DuelStratagemSceneController()
  {
  }
}
