// Decompiled with JetBrains decompiler
// Type: Scenes.OutGame.Icon.TypeIcon
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace Scenes.OutGame.Icon
{
  [Token(Token = "0x20035F4")]
  public class TypeIcon : MonoBehaviour
  {
    [Token(Token = "0x400EAA3")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private GameObject None;
    [Token(Token = "0x400EAA4")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private GameObject BG_Class_Diamond;
    [Token(Token = "0x400EAA5")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private GameObject BG_Diamond;
    [Token(Token = "0x400EAA6")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    private GameObject BG_Hexagon;
    [Token(Token = "0x400EAA7")]
    [FieldOffset(Offset = "0x38")]
    [SerializeField]
    private CommonButton Icon_Type;
    [Token(Token = "0x400EAA8")]
    [FieldOffset(Offset = "0x40")]
    [SerializeField]
    private Image Img_Type;

    [Token(Token = "0x60153C6")]
    [Address(RVA = "0x4D8E050", Offset = "0x4D8E050", VA = "0x4D8E050")]
    public void Full()
    {
    }

    [Token(Token = "0x60153C7")]
    [Address(RVA = "0x4D8E0D8", Offset = "0x4D8E0D8", VA = "0x4D8E0D8")]
    public void Empty()
    {
    }

    [Token(Token = "0x60153C8")]
    [Address(RVA = "0x4D8E190", Offset = "0x4D8E190", VA = "0x4D8E190")]
    public void BgClassDiamond()
    {
    }

    [Token(Token = "0x60153C9")]
    [Address(RVA = "0x4D8E248", Offset = "0x4D8E248", VA = "0x4D8E248")]
    public void BgDiamond()
    {
    }

    [Token(Token = "0x60153CA")]
    [Address(RVA = "0x4D8E300", Offset = "0x4D8E300", VA = "0x4D8E300")]
    public void BgHexagon()
    {
    }

    [Token(Token = "0x60153CB")]
    [Address(RVA = "0x4D8E3B8", Offset = "0x4D8E3B8", VA = "0x4D8E3B8")]
    public void SetActiveIconImage(bool isActive)
    {
    }

    [Token(Token = "0x60153CC")]
    [Address(RVA = "0x4D8E3E8", Offset = "0x4D8E3E8", VA = "0x4D8E3E8")]
    public void SetSprite(Sprite sprite)
    {
    }

    [Token(Token = "0x60153CD")]
    [Address(RVA = "0x4D8E404", Offset = "0x4D8E404", VA = "0x4D8E404")]
    public CommonButton GetButton() => (CommonButton) null;

    [Token(Token = "0x60153CE")]
    [Address(RVA = "0x4D8E40C", Offset = "0x4D8E40C", VA = "0x4D8E40C")]
    public void SetButtonAction(Action action)
    {
    }

    [Token(Token = "0x60153CF")]
    [Address(RVA = "0x4D8E4FC", Offset = "0x4D8E4FC", VA = "0x4D8E4FC")]
    public TypeIcon()
    {
    }
  }
}
