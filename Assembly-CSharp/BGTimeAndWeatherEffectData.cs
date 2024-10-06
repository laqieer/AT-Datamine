// Decompiled with JetBrains decompiler
// Type: BGTimeAndWeatherEffectData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.MasterData;
using Il2CppDummyDll;
using System;

#nullable disable
[Token(Token = "0x20000EE")]
[Serializable]
public class BGTimeAndWeatherEffectData
{
  [Token(Token = "0x400044F")]
  [FieldOffset(Offset = "0x10")]
  public BattleTimeTypeEnum time;
  [Token(Token = "0x4000450")]
  [FieldOffset(Offset = "0x14")]
  public BattleWeatherTypeEnum weather;
  [Token(Token = "0x4000451")]
  [FieldOffset(Offset = "0x18")]
  public BGSceneEffectData effectData;

  [Token(Token = "0x60006CA")]
  [Address(RVA = "0x4187AF8", Offset = "0x4187AF8", VA = "0x4187AF8")]
  public BGTimeAndWeatherEffectData()
  {
  }
}
