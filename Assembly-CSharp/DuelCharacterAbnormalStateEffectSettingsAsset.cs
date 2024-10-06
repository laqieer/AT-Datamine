// Decompiled with JetBrains decompiler
// Type: DuelCharacterAbnormalStateEffectSettingsAsset
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections.Generic;
using UnityEngine;

#nullable disable
[Token(Token = "0x20000F5")]
[CreateAssetMenu(menuName = "Duel/Duel Character Abnormal State Settings Asset")]
public class DuelCharacterAbnormalStateEffectSettingsAsset : ScriptableObject
{
  [Token(Token = "0x4000476")]
  [FieldOffset(Offset = "0x18")]
  [Header("状態異常の設定")]
  public List<DuelAbnormalStateEffectData> abnormalStateEffectDataList;
  [Token(Token = "0x4000477")]
  [FieldOffset(Offset = "0x20")]
  [Header("回復Effect")]
  public DuelOtherEffectData healEffectData;
  [Token(Token = "0x4000478")]
  [FieldOffset(Offset = "0x28")]
  [Header("石化専用のTexture")]
  public Texture2D conditionTexture;
  [Token(Token = "0x4000479")]
  [FieldOffset(Offset = "0x30")]
  public Vector2 conditionTextureTiling;

  [Token(Token = "0x60006DB")]
  [Address(RVA = "0x4188510", Offset = "0x4188510", VA = "0x4188510")]
  public DuelCharacterAbnormalStateEffectSettingsAsset()
  {
  }
}
