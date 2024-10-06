// Decompiled with JetBrains decompiler
// Type: LipSyncController
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using ADV2.LuaScript;
using Home.LipSync;
using Il2CppDummyDll;
using UnityEngine;

#nullable disable
[Token(Token = "0x200022A")]
public class LipSyncController : MonoBehaviour
{
  [Token(Token = "0x4000CE7")]
  [FieldOffset(Offset = "0x18")]
  private FacialAnimation facialAnimation;
  [Token(Token = "0x4000CE8")]
  [FieldOffset(Offset = "0x20")]
  private LuaSequence.SoundSignal signal;
  [Token(Token = "0x4000CE9")]
  [FieldOffset(Offset = "0x28")]
  private float minVolume;
  [Token(Token = "0x4000CEA")]
  [FieldOffset(Offset = "0x2C")]
  private uint playingId;
  [Token(Token = "0x4000CEB")]
  [FieldOffset(Offset = "0x30")]
  private LipType lastOpenLipType;

  [Token(Token = "0x6000DB8")]
  [Address(RVA = "0x1C87AAC", Offset = "0x1C87AAC", VA = "0x1C87AAC")]
  public void Initialize(FacialAnimation facialAnimation)
  {
  }

  [Token(Token = "0x6000DB9")]
  [Address(RVA = "0x1C87AB4", Offset = "0x1C87AB4", VA = "0x1C87AB4")]
  public void Speak(LuaSequence.SoundSignal soundSignal, uint playingId)
  {
  }

  [Token(Token = "0x6000DBA")]
  [Address(RVA = "0x1C87B78", Offset = "0x1C87B78", VA = "0x1C87B78")]
  private void Update()
  {
  }

  [Token(Token = "0x6000DBB")]
  [Address(RVA = "0x1C87D34", Offset = "0x1C87D34", VA = "0x1C87D34")]
  public void Silence()
  {
  }

  [Token(Token = "0x6000DBC")]
  [Address(RVA = "0x1C87AC0", Offset = "0x1C87AC0", VA = "0x1C87AC0")]
  private void SetMinVolume()
  {
  }

  [Token(Token = "0x6000DBD")]
  [Address(RVA = "0x1C87C74", Offset = "0x1C87C74", VA = "0x1C87C74")]
  private bool IsVolumeMute() => new bool();

  [Token(Token = "0x6000DBE")]
  [Address(RVA = "0x1C87D50", Offset = "0x1C87D50", VA = "0x1C87D50")]
  public LipSyncController()
  {
  }
}
