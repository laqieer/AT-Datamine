// Decompiled with JetBrains decompiler
// Type: Gacha.GachaBonusThumbnailView
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.UIControls;
using Il2CppDummyDll;
using StaqData;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace Gacha
{
  [Token(Token = "0x20014F7")]
  internal class GachaBonusThumbnailView : MonoBehaviour
  {
    [Token(Token = "0x4006052")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private RectTransform thumbnailParent;
    [Token(Token = "0x4006053")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private Text textNum;
    [Token(Token = "0x4006054")]
    [FieldOffset(Offset = "0x28")]
    private ItemIcon itemIcon;
    [Token(Token = "0x4006055")]
    [FieldOffset(Offset = "0x30")]
    private IBunusThumbnailPresenter presenter;

    [Token(Token = "0x17001251")]
    public IBunusThumbnailPresenter Presenter
    {
      [Token(Token = "0x600767F"), Address(RVA = "0x44E9F0C", Offset = "0x44E9F0C", VA = "0x44E9F0C")] set
      {
      }
    }

    [Token(Token = "0x6007680")]
    [Address(RVA = "0x44E9FB4", Offset = "0x44E9FB4", VA = "0x44E9FB4")]
    public void Setup(
      ItemIcon thumbnailAsset,
      Sprite iconSprite,
      ItemUtility.Parameter param,
      string textNum)
    {
    }

    [Token(Token = "0x6007681")]
    [Address(RVA = "0x44EA0E8", Offset = "0x44EA0E8", VA = "0x44EA0E8")]
    public void SetText(string text)
    {
    }

    [Token(Token = "0x6007682")]
    [Address(RVA = "0x44EA10C", Offset = "0x44EA10C", VA = "0x44EA10C")]
    public GachaBonusThumbnailView()
    {
    }
  }
}
