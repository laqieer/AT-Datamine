// Decompiled with JetBrains decompiler
// Type: DuelBGSceneSettingsAsset
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections.Generic;
using UnityEngine;

#nullable disable
[Token(Token = "0x20000F3")]
[CreateAssetMenu(menuName = "Duel/Duel BG Scene Settings Asset")]
public class DuelBGSceneSettingsAsset : ScriptableObject
{
  [Token(Token = "0x4000474")]
  [FieldOffset(Offset = "0x18")]
  public List<DuelBGSceneDungeonEffectSettingsData> dungeonEffectSettingsDataList;

  [Token(Token = "0x60006D9")]
  [Address(RVA = "0x418848C", Offset = "0x418848C", VA = "0x418848C")]
  public DuelBGSceneSettingsAsset()
  {
  }
}
