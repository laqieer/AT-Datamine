// Decompiled with JetBrains decompiler
// Type: Scenes.OutGame.Info.Style.UI.StyleLpUI
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
  [Token(Token = "0x200356A")]
  [Serializable]
  public class StyleLpUI
  {
    [Token(Token = "0x400E843")]
    public const string LpSpriteAssetBundleName = "ui_page_abridged_texture_spriteatlas";
    [Token(Token = "0x400E844")]
    public const string LpSpriteOnAssetName = "Img_Abridged_Unit_LP_Dia_Active";
    [Token(Token = "0x400E845")]
    public const string LpSpriteOffAssetName = "Img_Abridged_Unit_LP_Dia_Base";
    [Token(Token = "0x400E846")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private GameObject root;
    [Token(Token = "0x400E847")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private Image[] images;

    [Token(Token = "0x6014F75")]
    [Address(RVA = "0x4A9FC2C", Offset = "0x4A9FC2C", VA = "0x4A9FC2C")]
    public void Set(Sprite sprite)
    {
    }

    [Token(Token = "0x6014F76")]
    [Address(RVA = "0x4A9FC94", Offset = "0x4A9FC94", VA = "0x4A9FC94")]
    public void Set(int index, Sprite sprite)
    {
    }

    [Token(Token = "0x6014F77")]
    [Address(RVA = "0x4A9FCD0", Offset = "0x4A9FCD0", VA = "0x4A9FCD0")]
    public void SetActive(bool isActive)
    {
    }

    [Token(Token = "0x6014F78")]
    [Address(RVA = "0x4A9FCF0", Offset = "0x4A9FCF0", VA = "0x4A9FCF0")]
    public StyleLpUI()
    {
    }
  }
}
