// Decompiled with JetBrains decompiler
// Type: BGMementosEffectData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.MasterData;
using Il2CppDummyDll;
using System;

#nullable disable
[Token(Token = "0x20000EF")]
[Serializable]
public class BGMementosEffectData
{
  [Token(Token = "0x4000452")]
  [FieldOffset(Offset = "0x10")]
  public BattleBgColorIdEnum bgColorId;
  [Token(Token = "0x4000453")]
  [FieldOffset(Offset = "0x18")]
  public BGSceneEffectData effectData;

  [Token(Token = "0x60006CB")]
  [Address(RVA = "0x4187B08", Offset = "0x4187B08", VA = "0x4187B08")]
  public BGMementosEffectData()
  {
  }
}
