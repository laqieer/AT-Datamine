// Decompiled with JetBrains decompiler
// Type: Scenes.OutGame.Favorite.FavoriteButton
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace Scenes.OutGame.Favorite
{
  [Token(Token = "0x2003626")]
  public class FavoriteButton : MonoBehaviour
  {
    [Token(Token = "0x400EB6F")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private GameObject Img_Favorite_OFF;
    [Token(Token = "0x400EB70")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private GameObject Img_Favorite_ON;
    [Token(Token = "0x400EB71")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private CommonButton button;

    [Token(Token = "0x170046EB")]
    public Button.ButtonClickedEvent onClick
    {
      [Token(Token = "0x6015536"), Address(RVA = "0x4D9847C", Offset = "0x4D9847C", VA = "0x4D9847C")] get
      {
        return (Button.ButtonClickedEvent) null;
      }
      [Token(Token = "0x6015537"), Address(RVA = "0x4D98498", Offset = "0x4D98498", VA = "0x4D98498")] set
      {
      }
    }

    [Token(Token = "0x170046EC")]
    public bool IsFavorite
    {
      [Token(Token = "0x6015538"), Address(RVA = "0x4D984B4", Offset = "0x4D984B4", VA = "0x4D984B4")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x6015539")]
    [Address(RVA = "0x4D984D0", Offset = "0x4D984D0", VA = "0x4D984D0")]
    public CommonButton GetButton() => (CommonButton) null;

    [Token(Token = "0x601553A")]
    [Address(RVA = "0x4D984D8", Offset = "0x4D984D8", VA = "0x4D984D8")]
    public void SetActive(bool isActive)
    {
    }

    [Token(Token = "0x601553B")]
    [Address(RVA = "0x4D98500", Offset = "0x4D98500", VA = "0x4D98500")]
    public void SetFavorite(bool isFavorite)
    {
    }

    [Token(Token = "0x601553C")]
    [Address(RVA = "0x4D98548", Offset = "0x4D98548", VA = "0x4D98548")]
    public FavoriteButton()
    {
    }
  }
}
