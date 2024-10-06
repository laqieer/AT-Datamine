// Decompiled with JetBrains decompiler
// Type: BGSceneEffectSettingsAsset
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections.Generic;
using UnityEngine;

#nullable disable
[Token(Token = "0x20000EC")]
[CreateAssetMenu(menuName = "Duel/BG Scene Effect Settings Asset")]
public class BGSceneEffectSettingsAsset : ScriptableObject
{
  [Token(Token = "0x400043D")]
  [FieldOffset(Offset = "0x18")]
  public List<BGMementosEffectData> mementosEffectDataList;
  [Token(Token = "0x400043E")]
  [FieldOffset(Offset = "0x20")]
  public List<BGTimeAndWeatherEffectData> timeAndWeatherEffectDataList;

  [Token(Token = "0x60006C8")]
  [Address(RVA = "0x41879F8", Offset = "0x41879F8", VA = "0x41879F8")]
  public BGSceneEffectSettingsAsset()
  {
  }
}
