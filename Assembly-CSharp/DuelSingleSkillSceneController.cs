// Decompiled with JetBrains decompiler
// Type: DuelSingleSkillSceneController
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;

#nullable disable
[Token(Token = "0x2000167")]
public class DuelSingleSkillSceneController : MonoBehaviour
{
  [Token(Token = "0x4000907")]
  [FieldOffset(Offset = "0x18")]
  public PlayableDirector playableDirector;
  [Token(Token = "0x4000908")]
  [FieldOffset(Offset = "0x20")]
  private GameObject oldBackgroundRoot;
  [Token(Token = "0x4000909")]
  [FieldOffset(Offset = "0x28")]
  public List<GameObject> inactiveGameObjects;
  [Token(Token = "0x400090A")]
  [FieldOffset(Offset = "0x30")]
  public List<GameObject> activeGameObjects;

  [Token(Token = "0x60009D6")]
  [Address(RVA = "0x47752EC", Offset = "0x47752EC", VA = "0x47752EC")]
  public void Initialize(GameObject oldBackgroundRoot)
  {
  }

  [Token(Token = "0x60009D7")]
  [Address(RVA = "0x4775370", Offset = "0x4775370", VA = "0x4775370")]
  public void ResetStatus()
  {
  }

  [Token(Token = "0x60009D8")]
  [Address(RVA = "0x4776014", Offset = "0x4776014", VA = "0x4776014")]
  public DuelSingleSkillSceneController()
  {
  }
}
