// Decompiled with JetBrains decompiler
// Type: Scenes.OutGame.QuestSelectMap.MapDotCharaModelFadeAccesser
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace Scenes.OutGame.QuestSelectMap
{
  [Token(Token = "0x20033C6")]
  public class MapDotCharaModelFadeAccesser : MonoBehaviour
  {
    [Token(Token = "0x400E0E9")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private float fadeValue;

    [Token(Token = "0x1400020A")]
    private event Action<float> onUpdate
    {
      [Token(Token = "0x601458F"), Address(RVA = "0x206FE5C", Offset = "0x206FE5C", VA = "0x206FE5C")] add
      {
      }
      [Token(Token = "0x6014590"), Address(RVA = "0x206FF0C", Offset = "0x206FF0C", VA = "0x206FF0C")] remove
      {
      }
    }

    [Token(Token = "0x6014591")]
    [Address(RVA = "0x206FFBC", Offset = "0x206FFBC", VA = "0x206FFBC")]
    public void LateUpdate()
    {
    }

    [Token(Token = "0x6014592")]
    [Address(RVA = "0x206FFDC", Offset = "0x206FFDC", VA = "0x206FFDC")]
    public float GetFadeValue() => new float();

    [Token(Token = "0x6014593")]
    [Address(RVA = "0x206F7A8", Offset = "0x206F7A8", VA = "0x206F7A8")]
    public void Register(Action<float> func)
    {
    }

    [Token(Token = "0x6014594")]
    [Address(RVA = "0x206F7AC", Offset = "0x206F7AC", VA = "0x206F7AC")]
    public void UnRegister(Action<float> func)
    {
    }

    [Token(Token = "0x6014595")]
    [Address(RVA = "0x206FFE4", Offset = "0x206FFE4", VA = "0x206FFE4")]
    public MapDotCharaModelFadeAccesser()
    {
    }
  }
}
