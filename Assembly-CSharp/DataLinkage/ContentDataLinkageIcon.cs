// Decompiled with JetBrains decompiler
// Type: DataLinkage.ContentDataLinkageIcon
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace DataLinkage
{
  [Token(Token = "0x2001F69")]
  public class ContentDataLinkageIcon : MonoBehaviour
  {
    [Token(Token = "0x4008686")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    [Header("Apple のアイコン")]
    private Image iconApple;
    [Token(Token = "0x4008687")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    [Header("FaceBook のアイコン")]
    private Image iconFacebook;
    [Token(Token = "0x4008688")]
    [FieldOffset(Offset = "0x28")]
    [Header("Google のアイコン")]
    [SerializeField]
    private Image iconGoogle;
    [Token(Token = "0x4008689")]
    [FieldOffset(Offset = "0x30")]
    private List<Image> icons;

    [Token(Token = "0x600BA74")]
    [Address(RVA = "0x1E45CDC", Offset = "0x1E45CDC", VA = "0x1E45CDC")]
    private void Awake()
    {
    }

    [Token(Token = "0x600BA75")]
    [Address(RVA = "0x1E45E78", Offset = "0x1E45E78", VA = "0x1E45E78")]
    public void EnableAppleIcon()
    {
    }

    [Token(Token = "0x600BA76")]
    [Address(RVA = "0x1E4609C", Offset = "0x1E4609C", VA = "0x1E4609C")]
    public void EnableFacebookIcon()
    {
    }

    [Token(Token = "0x600BA77")]
    [Address(RVA = "0x1E460A4", Offset = "0x1E460A4", VA = "0x1E460A4")]
    public void EnableGoogleIcon()
    {
    }

    [Token(Token = "0x600BA78")]
    [Address(RVA = "0x1E45E80", Offset = "0x1E45E80", VA = "0x1E45E80")]
    private void EnableIcon(Image enableIcon)
    {
    }

    [Token(Token = "0x600BA79")]
    [Address(RVA = "0x1E460AC", Offset = "0x1E460AC", VA = "0x1E460AC")]
    public ContentDataLinkageIcon()
    {
    }
  }
}
