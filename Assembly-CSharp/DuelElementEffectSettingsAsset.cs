// Decompiled with JetBrains decompiler
// Type: DuelElementEffectSettingsAsset
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections.Generic;
using UnityEngine;

#nullable disable
[Token(Token = "0x2000125")]
[CreateAssetMenu(menuName = "Duel/Duel Element Effect Settings Asset")]
public class DuelElementEffectSettingsAsset : ScriptableObject
{
  [Token(Token = "0x400062B")]
  [FieldOffset(Offset = "0x18")]
  public List<ElementEffectItem> elementEffectList;

  [Token(Token = "0x6000811")]
  [Address(RVA = "0x485D748", Offset = "0x485D748", VA = "0x485D748")]
  public GameObject GetElementEffectPrefab(ElementEffectItem.ElementType elementType)
  {
    return (GameObject) null;
  }

  [Token(Token = "0x6000812")]
  [Address(RVA = "0x485D948", Offset = "0x485D948", VA = "0x485D948")]
  public DuelElementEffectSettingsAsset()
  {
  }
}
