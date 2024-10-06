// Decompiled with JetBrains decompiler
// Type: Scenes.OutGame.Info.Style.UI.StyleDotUI
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace Scenes.OutGame.Info.Style.UI
{
  [Token(Token = "0x2003569")]
  [Serializable]
  public class StyleDotUI
  {
    [Token(Token = "0x400E840")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private Image silhouette;
    [Token(Token = "0x400E841")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private Transform root;
    [Token(Token = "0x400E842")]
    [FieldOffset(Offset = "0x20")]
    private GameObject activeDot;

    [Token(Token = "0x6014F72")]
    [Address(RVA = "0x4A9FB18", Offset = "0x4A9FB18", VA = "0x4A9FB18")]
    public void Set(GameObject dot)
    {
    }

    [Token(Token = "0x6014F73")]
    [Address(RVA = "0x4A9FBF8", Offset = "0x4A9FBF8", VA = "0x4A9FBF8")]
    public void Silhouette()
    {
    }

    [Token(Token = "0x6014F74")]
    [Address(RVA = "0x4A9FC24", Offset = "0x4A9FC24", VA = "0x4A9FC24")]
    public StyleDotUI()
    {
    }
  }
}
