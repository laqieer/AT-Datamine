// Decompiled with JetBrains decompiler
// Type: GlobalMenu.GameMenu
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.Tween;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace GlobalMenu
{
  [Token(Token = "0x2000B91")]
  public class GameMenu : MonoBehaviour
  {
    [Token(Token = "0x40034A4")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private UITweenGroup tweenGroup;
    [Token(Token = "0x40034A5")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private string tweenIn;
    [Token(Token = "0x40034A6")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private string tweenOut;
    [Token(Token = "0x40034A7")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    private Image[] badges;

    [Token(Token = "0x17000996")]
    public bool IsInAnimation
    {
      [Token(Token = "0x60041E3"), Address(RVA = "0x2A321D4", Offset = "0x2A321D4", VA = "0x2A321D4")] get
      {
        return new bool();
      }
      [Token(Token = "0x60041E4"), Address(RVA = "0x2A321DC", Offset = "0x2A321DC", VA = "0x2A321DC")] private set
      {
      }
    }

    [Token(Token = "0x17000997")]
    public bool IsShown
    {
      [Token(Token = "0x60041E5"), Address(RVA = "0x2A321E8", Offset = "0x2A321E8", VA = "0x2A321E8")] get
      {
        return new bool();
      }
      [Token(Token = "0x60041E6"), Address(RVA = "0x2A321F0", Offset = "0x2A321F0", VA = "0x2A321F0")] private set
      {
      }
    }

    [Token(Token = "0x60041E7")]
    [Address(RVA = "0x2A321FC", Offset = "0x2A321FC", VA = "0x2A321FC")]
    public void Initialize()
    {
    }

    [Token(Token = "0x60041E8")]
    [Address(RVA = "0x2A3253C", Offset = "0x2A3253C", VA = "0x2A3253C")]
    public void SetBadge(GameMenu.Badge badge, bool isActive)
    {
    }

    [Token(Token = "0x60041E9")]
    [Address(RVA = "0x2A32588", Offset = "0x2A32588", VA = "0x2A32588")]
    public void UpdateData()
    {
    }

    [Token(Token = "0x60041EA")]
    [Address(RVA = "0x2A328C8", Offset = "0x2A328C8", VA = "0x2A328C8")]
    public void PlayAnim(bool isIn)
    {
    }

    [Token(Token = "0x60041EB")]
    [Address(RVA = "0x2A32938", Offset = "0x2A32938", VA = "0x2A32938")]
    public void OnClickToPlayerData()
    {
    }

    [Token(Token = "0x60041EC")]
    [Address(RVA = "0x2A32A38", Offset = "0x2A32A38", VA = "0x2A32A38")]
    public void OnClickToItemList()
    {
    }

    [Token(Token = "0x60041ED")]
    [Address(RVA = "0x2A32AE4", Offset = "0x2A32AE4", VA = "0x2A32AE4")]
    public void OnClickToStoryChart()
    {
    }

    [Token(Token = "0x60041EE")]
    [Address(RVA = "0x2A32BE0", Offset = "0x2A32BE0", VA = "0x2A32BE0")]
    public void OnClickToOption()
    {
    }

    [Token(Token = "0x60041EF")]
    [Address(RVA = "0x2A32BE4", Offset = "0x2A32BE4", VA = "0x2A32BE4")]
    public void OnClickToPrivacyPolicy()
    {
    }

    [Token(Token = "0x60041F0")]
    [Address(RVA = "0x2A32BE8", Offset = "0x2A32BE8", VA = "0x2A32BE8")]
    public void OnClickToLoginBonus()
    {
    }

    [Token(Token = "0x60041F1")]
    [Address(RVA = "0x2A32BEC", Offset = "0x2A32BEC", VA = "0x2A32BEC")]
    public void OnClickToHelp()
    {
    }

    [Token(Token = "0x60041F2")]
    [Address(RVA = "0x2A32BF0", Offset = "0x2A32BF0", VA = "0x2A32BF0")]
    public void OnClickToContact()
    {
    }

    [Token(Token = "0x60041F3")]
    [Address(RVA = "0x2A32BF4", Offset = "0x2A32BF4", VA = "0x2A32BF4")]
    public void OnClickToCoin()
    {
    }

    [Token(Token = "0x60041F4")]
    [Address(RVA = "0x2A32BF8", Offset = "0x2A32BF8", VA = "0x2A32BF8")]
    public void OnClickToRecipe()
    {
    }

    [Token(Token = "0x60041F5")]
    [Address(RVA = "0x2A32BFC", Offset = "0x2A32BFC", VA = "0x2A32BFC")]
    public void OnClickToNotation()
    {
    }

    [Token(Token = "0x60041F6")]
    [Address(RVA = "0x2A32C00", Offset = "0x2A32C00", VA = "0x2A32C00")]
    public void OnClickToDataLink()
    {
    }

    [Token(Token = "0x60041F7")]
    [Address(RVA = "0x2A32C04", Offset = "0x2A32C04", VA = "0x2A32C04")]
    public void OnClickToOfficialSite()
    {
    }

    [Token(Token = "0x60041F8")]
    [Address(RVA = "0x2A32C08", Offset = "0x2A32C08", VA = "0x2A32C08")]
    public void OnClickToTile()
    {
    }

    [Token(Token = "0x60041F9")]
    [Address(RVA = "0x2A32C0C", Offset = "0x2A32C0C", VA = "0x2A32C0C")]
    public void OnClickBack()
    {
    }

    [Token(Token = "0x60041FA")]
    [Address(RVA = "0x2A32D04", Offset = "0x2A32D04", VA = "0x2A32D04")]
    public GameMenu()
    {
    }

    [Token(Token = "0x2000B92")]
    public enum Badge
    {
      [Token(Token = "0x40034AB")] PlayerData,
      [Token(Token = "0x40034AC")] Option,
      [Token(Token = "0x40034AD")] PrivacyPolicy,
      [Token(Token = "0x40034AE")] Coin,
      [Token(Token = "0x40034AF")] Recipe,
      [Token(Token = "0x40034B0")] Notation,
      [Token(Token = "0x40034B1")] Help,
    }
  }
}
