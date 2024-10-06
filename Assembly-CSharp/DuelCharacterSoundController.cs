// Decompiled with JetBrains decompiler
// Type: DuelCharacterSoundController
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.Sound;
using Il2CppDummyDll;
using UnityEngine;

#nullable disable
[Token(Token = "0x200010E")]
public class DuelCharacterSoundController : MonoBehaviour
{
  [Token(Token = "0x400058F")]
  [FieldOffset(Offset = "0x18")]
  public DuelCharacterController duelCharacterController;
  [Token(Token = "0x4000590")]
  [FieldOffset(Offset = "0x20")]
  private SoundManager soundManager;
  [Token(Token = "0x4000591")]
  [FieldOffset(Offset = "0x28")]
  public bool shouldPlaySound;

  [Token(Token = "0x6000762")]
  [Address(RVA = "0x4854CDC", Offset = "0x4854CDC", VA = "0x4854CDC")]
  private void Start()
  {
  }

  [Token(Token = "0x6000763")]
  [Address(RVA = "0x4854D50", Offset = "0x4854D50", VA = "0x4854D50")]
  public void PlaySE(string name)
  {
  }

  [Token(Token = "0x6000764")]
  [Address(RVA = "0x4854D70", Offset = "0x4854D70", VA = "0x4854D70")]
  public void PlayBGM(string name)
  {
  }

  [Token(Token = "0x6000765")]
  [Address(RVA = "0x4854D8C", Offset = "0x4854D8C", VA = "0x4854D8C")]
  public void PlayVoice(string name)
  {
  }

  [Token(Token = "0x6000766")]
  [Address(RVA = "0x4854DB0", Offset = "0x4854DB0", VA = "0x4854DB0")]
  public DuelCharacterSoundController()
  {
  }
}
