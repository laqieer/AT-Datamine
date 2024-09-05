// Decompiled with JetBrains decompiler
// Type: Home.Bannner.HomeBannerListItemView
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace Home.Bannner
{
  [Token(Token = "0x2000B83")]
  public class HomeBannerListItemView : MonoBehaviour
  {
    [Token(Token = "0x400346D")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private Button buttonBanner;
    [Token(Token = "0x400346E")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private RawImage imageBanner;

    [Token(Token = "0x140000F0")]
    private event Action OnClickBanner
    {
      [Token(Token = "0x6004184"), Address(RVA = "0x2A30358", Offset = "0x2A30358", VA = "0x2A30358")] add
      {
      }
      [Token(Token = "0x6004185"), Address(RVA = "0x2A303F4", Offset = "0x2A303F4", VA = "0x2A303F4")] remove
      {
      }
    }

    [Token(Token = "0x6004186")]
    [Address(RVA = "0x2A30490", Offset = "0x2A30490", VA = "0x2A30490")]
    private void Awake()
    {
    }

    [Token(Token = "0x6004187")]
    [Address(RVA = "0x2A30524", Offset = "0x2A30524", VA = "0x2A30524")]
    public void SetCallBack(Action onClick)
    {
    }

    [Token(Token = "0x6004188")]
    [Address(RVA = "0x2A302C8", Offset = "0x2A302C8", VA = "0x2A302C8")]
    public void SetBannerTexture(Texture texture)
    {
    }

    [Token(Token = "0x6004189")]
    [Address(RVA = "0x2A30160", Offset = "0x2A30160", VA = "0x2A30160")]
    public void SetDisable()
    {
    }

    [Token(Token = "0x600418A")]
    [Address(RVA = "0x2A3052C", Offset = "0x2A3052C", VA = "0x2A3052C")]
    private void SetActiveFast(GameObject go, bool isActive)
    {
    }

    [Token(Token = "0x600418B")]
    [Address(RVA = "0x2A3057C", Offset = "0x2A3057C", VA = "0x2A3057C")]
    public HomeBannerListItemView()
    {
    }
  }
}
