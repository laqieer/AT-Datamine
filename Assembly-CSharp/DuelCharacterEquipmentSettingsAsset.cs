// Decompiled with JetBrains decompiler
// Type: DuelCharacterEquipmentSettingsAsset
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections.Generic;
using UnityEngine;

#nullable disable
[Token(Token = "0x2000105")]
[CreateAssetMenu(menuName = "Duel/Duel Character Equipment Settings Asset")]
public class DuelCharacterEquipmentSettingsAsset : ScriptableObject
{
  [Token(Token = "0x400052F")]
  [FieldOffset(Offset = "0x18")]
  public List<EquipmentSettingsData> equipmentSettingsDataList;

  [Token(Token = "0x600074F")]
  [Address(RVA = "0x485259C", Offset = "0x485259C", VA = "0x485259C")]
  public DuelCharacterEquipmentSettingsAsset()
  {
  }
}
