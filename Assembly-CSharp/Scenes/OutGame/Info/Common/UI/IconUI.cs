// Decompiled with JetBrains decompiler
// Type: Scenes.OutGame.Info.Common.UI.IconUI
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using Scenes.OutGame.Icon;
using System;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace Scenes.OutGame.Info.Common.UI
{
  [Token(Token = "0x20035F3")]
  [Serializable]
  public class IconUI
  {
    [Token(Token = "0x400EAA0")]
    [FieldOffset(Offset = "0x10")]
    [Tooltip("複製、アクティブの切り替え対象。空ならicon自身が複製される。")]
    [SerializeField]
    private GameObject root;
    [Token(Token = "0x400EAA1")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private TypeIcon typeIcon;
    [Token(Token = "0x400EAA2")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private Image icon;

    [Token(Token = "0x170046B6")]
    public GameObject Root
    {
      [Token(Token = "0x60153BE"), Address(RVA = "0x4D8D8C8", Offset = "0x4D8D8C8", VA = "0x4D8D8C8")] get
      {
        return (GameObject) null;
      }
    }

    [Token(Token = "0x170046B7")]
    public Transform Parent
    {
      [Token(Token = "0x60153BF"), Address(RVA = "0x4D8D950", Offset = "0x4D8D950", VA = "0x4D8D950")] get
      {
        return (Transform) null;
      }
    }

    [Token(Token = "0x170046B8")]
    public TypeIcon TypeIcon
    {
      [Token(Token = "0x60153C0"), Address(RVA = "0x4D8D978", Offset = "0x4D8D978", VA = "0x4D8D978")] get
      {
        return (TypeIcon) null;
      }
    }

    [Token(Token = "0x60153C1")]
    [Address(RVA = "0x4D8D980", Offset = "0x4D8D980", VA = "0x4D8D980")]
    public void Set(Sprite sprite)
    {
    }

    [Token(Token = "0x60153C2")]
    [Address(RVA = "0x4D8DA90", Offset = "0x4D8DA90", VA = "0x4D8DA90")]
    public void SetActive(bool active)
    {
    }

    [Token(Token = "0x60153C3")]
    [Address(RVA = "0x4D8DBA0", Offset = "0x4D8DBA0", VA = "0x4D8DBA0")]
    public IconUI Duplicate() => (IconUI) null;

    [Token(Token = "0x60153C4")]
    [Address(RVA = "0x4D8DE98", Offset = "0x4D8DE98", VA = "0x4D8DE98")]
    private string GetPath(Component component) => (string) null;

    [Token(Token = "0x60153C5")]
    [Address(RVA = "0x4D8DE90", Offset = "0x4D8DE90", VA = "0x4D8DE90")]
    public IconUI()
    {
    }
  }
}
