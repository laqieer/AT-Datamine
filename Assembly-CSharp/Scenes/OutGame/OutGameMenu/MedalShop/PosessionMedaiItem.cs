// Decompiled with JetBrains decompiler
// Type: Scenes.OutGame.OutGameMenu.MedalShop.PosessionMedaiItem
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore;
using GameCore.MasterData;
using GameCore.Tween;
using Il2CppDummyDll;
using UI;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

#nullable disable
namespace Scenes.OutGame.OutGameMenu.MedalShop
{
  [Token(Token = "0x2003B2F")]
  public class PosessionMedaiItem : MonoBehaviour
  {
    [Token(Token = "0x4010542")]
    [FieldOffset(Offset = "0x18")]
    private string PLAY_TO_IN;
    [Token(Token = "0x4010543")]
    [FieldOffset(Offset = "0x20")]
    private string PLAY_TO_OUT;
    [Token(Token = "0x4010544")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private TextAccessor posessionNum;
    [Token(Token = "0x4010545")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    private Image medalIcon;
    [Token(Token = "0x4010546")]
    [FieldOffset(Offset = "0x38")]
    [SerializeField]
    private UITweenGroup tweenGroup;
    [Token(Token = "0x4010547")]
    [FieldOffset(Offset = "0x40")]
    [SerializeField]
    private RectTransform rectTransform;
    [Token(Token = "0x4010548")]
    [FieldOffset(Offset = "0x48")]
    private int medalId;

    [Token(Token = "0x17004BF5")]
    public RectTransform RectTransform
    {
      [Token(Token = "0x601749B"), Address(RVA = "0x271D098", Offset = "0x271D098", VA = "0x271D098")] get
      {
        return (RectTransform) null;
      }
    }

    [Token(Token = "0x601749C")]
    [Address(RVA = "0x271D0A0", Offset = "0x271D0A0", VA = "0x271D0A0")]
    public void Initialize(MedalShopLoader loader, AssetCachedSpawner spawner, MedalData medalData)
    {
    }

    [Token(Token = "0x601749D")]
    [Address(RVA = "0x271D1B8", Offset = "0x271D1B8", VA = "0x271D1B8")]
    public void UpdateMedal()
    {
    }

    [Token(Token = "0x601749E")]
    [Address(RVA = "0x271D290", Offset = "0x271D290", VA = "0x271D290")]
    public void PlayToIn()
    {
    }

    [Token(Token = "0x601749F")]
    [Address(RVA = "0x271D2B8", Offset = "0x271D2B8", VA = "0x271D2B8")]
    public void PlayToOut(UnityAction finishAction)
    {
    }

    [Token(Token = "0x60174A0")]
    [Address(RVA = "0x271D314", Offset = "0x271D314", VA = "0x271D314")]
    public PosessionMedaiItem()
    {
    }
  }
}
