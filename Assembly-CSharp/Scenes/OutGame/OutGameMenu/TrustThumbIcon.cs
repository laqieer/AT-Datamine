// Decompiled with JetBrains decompiler
// Type: Scenes.OutGame.OutGameMenu.TrustThumbIcon
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace Scenes.OutGame.OutGameMenu
{
  [Token(Token = "0x2003ACB")]
  public class TrustThumbIcon : MonoBehaviour
  {
    [Token(Token = "0x40102C9")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private Image img_base;
    [Token(Token = "0x40102CA")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private Image img_TrustThumb;
    [Token(Token = "0x40102CB")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private GameObject img_Loading;
    [Token(Token = "0x40102CC")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    private Image rarityImage;
    [Token(Token = "0x40102CD")]
    [FieldOffset(Offset = "0x38")]
    [SerializeField]
    private GameObject img_Favorite;
    [Token(Token = "0x40102CE")]
    [FieldOffset(Offset = "0x40")]
    [SerializeField]
    private GameObject Img_Gray_Acquired;
    [Token(Token = "0x40102CF")]
    [FieldOffset(Offset = "0x48")]
    [SerializeField]
    private GameObject Layout_Rarity;
    [Token(Token = "0x40102D0")]
    [FieldOffset(Offset = "0x50")]
    [SerializeField]
    private GameObject Img_equip;
    [Token(Token = "0x40102D1")]
    [FieldOffset(Offset = "0x58")]
    [SerializeField]
    private GameObject Img_Ic_NewBadge;
    [Token(Token = "0x40102D2")]
    [FieldOffset(Offset = "0x60")]
    [SerializeField]
    private GameObject Img_Ic_OrdinalNum_Badge;
    [Token(Token = "0x40102D3")]
    [FieldOffset(Offset = "0x68")]
    [SerializeField]
    private GameObject Img_Icon_Element;
    [Token(Token = "0x40102D4")]
    [FieldOffset(Offset = "0x70")]
    [SerializeField]
    private GameObject Img_lost;
    [Token(Token = "0x40102D5")]
    [FieldOffset(Offset = "0x78")]
    [SerializeField]
    private GameObject Txt_Item_Num;

    [Token(Token = "0x6017214")]
    [Address(RVA = "0x30095D8", Offset = "0x30095D8", VA = "0x30095D8")]
    private void Awake()
    {
    }

    [Token(Token = "0x6017215")]
    [Address(RVA = "0x3009688", Offset = "0x3009688", VA = "0x3009688")]
    public void SetBaseImage(Sprite sprite)
    {
    }

    [Token(Token = "0x6017216")]
    [Address(RVA = "0x30096A4", Offset = "0x30096A4", VA = "0x30096A4")]
    public void SetTrustThumbImage(Sprite sprite)
    {
    }

    [Token(Token = "0x6017217")]
    [Address(RVA = "0x30096D8", Offset = "0x30096D8", VA = "0x30096D8")]
    public void SetLoading(bool flg)
    {
    }

    [Token(Token = "0x6017218")]
    [Address(RVA = "0x30096F8", Offset = "0x30096F8", VA = "0x30096F8")]
    public void SetRarity(Sprite raritySprite)
    {
    }

    [Token(Token = "0x6017219")]
    [Address(RVA = "0x3009714", Offset = "0x3009714", VA = "0x3009714")]
    public void SetFavoriteImage(bool flg)
    {
    }

    [Token(Token = "0x601721A")]
    [Address(RVA = "0x3009734", Offset = "0x3009734", VA = "0x3009734")]
    public TrustThumbIcon()
    {
    }
  }
}
