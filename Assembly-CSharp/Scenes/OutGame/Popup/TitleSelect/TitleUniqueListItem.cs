// Decompiled with JetBrains decompiler
// Type: Scenes.OutGame.Popup.TitleSelect.TitleUniqueListItem
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Cysharp.Threading.Tasks;
using GameCore.MasterData;
using GameCore.Tween;
using Il2CppDummyDll;
using Scenes.OutGame.TitleEmblem;
using System;
using System.Threading;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace Scenes.OutGame.Popup.TitleSelect
{
  [Token(Token = "0x200347A")]
  public class TitleUniqueListItem : MonoBehaviour
  {
    [Token(Token = "0x400E43F")]
    private const string TWEEN_KEY_SET = "Set";
    [Token(Token = "0x400E440")]
    private const string TWEEN_KEY_ON = "On";
    [Token(Token = "0x400E441")]
    private const string TWEEN_KEY_OFF = "Off";
    [Token(Token = "0x400E442")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private UITweenGroup tweenGroup;
    [Token(Token = "0x400E443")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private Image textImage;
    [Token(Token = "0x400E444")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private TextMeshProUGUI titleText;
    [Token(Token = "0x400E445")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    private GameObject titleTextParent;
    [Token(Token = "0x400E446")]
    [FieldOffset(Offset = "0x38")]
    [SerializeField]
    private Image fullSetImage;
    [Token(Token = "0x400E447")]
    [FieldOffset(Offset = "0x40")]
    private Action onClickAction;

    [Token(Token = "0x1700445F")]
    public int TitleId
    {
      [Token(Token = "0x601495F"), Address(RVA = "0x1AAABD4", Offset = "0x1AAABD4", VA = "0x1AAABD4")] get
      {
        return new int();
      }
      [Token(Token = "0x6014960"), Address(RVA = "0x1AAABDC", Offset = "0x1AAABDC", VA = "0x1AAABDC")] private set
      {
      }
    }

    [Token(Token = "0x17004460")]
    public bool IsUnlockedTitle
    {
      [Token(Token = "0x6014961"), Address(RVA = "0x1AAABE4", Offset = "0x1AAABE4", VA = "0x1AAABE4")] get
      {
        return new bool();
      }
      [Token(Token = "0x6014962"), Address(RVA = "0x1AAABEC", Offset = "0x1AAABEC", VA = "0x1AAABEC")] private set
      {
      }
    }

    [Token(Token = "0x6014963")]
    [Address(RVA = "0x1AAA78C", Offset = "0x1AAA78C", VA = "0x1AAA78C")]
    public void Initialize(
      ITitleMasterData title,
      ITitleLoader titleLoader,
      bool unlocked,
      Action onClickAction,
      CancellationToken cancellationToken)
    {
    }

    [Token(Token = "0x6014964")]
    [Address(RVA = "0x1AAABF8", Offset = "0x1AAABF8", VA = "0x1AAABF8")]
    private UniTaskVoid InitializeAsync(
      ITitleMasterData title,
      ITitleLoader titleLoader,
      CancellationToken cancellationToken)
    {
      return new UniTaskVoid();
    }

    [Token(Token = "0x6014965")]
    [Address(RVA = "0x1AAAC90", Offset = "0x1AAAC90", VA = "0x1AAAC90")]
    private void DeactivateAll()
    {
    }

    [Token(Token = "0x6014966")]
    [Address(RVA = "0x1AAAD14", Offset = "0x1AAAD14", VA = "0x1AAAD14")]
    private UniTask LoadSpriteAsync(
      Image image,
      int titleId,
      ITitleLoader titleLoader,
      CancellationToken cancellationToken)
    {
      return new UniTask();
    }

    [Token(Token = "0x6014967")]
    [Address(RVA = "0x1AAAE74", Offset = "0x1AAAE74", VA = "0x1AAAE74")]
    public void OnItemClick()
    {
    }

    [Token(Token = "0x6014968")]
    [Address(RVA = "0x1AAA8D8", Offset = "0x1AAA8D8", VA = "0x1AAA8D8")]
    public void SetSelected(bool selected)
    {
    }

    [Token(Token = "0x6014969")]
    [Address(RVA = "0x1AAAE90", Offset = "0x1AAAE90", VA = "0x1AAAE90")]
    public TitleUniqueListItem()
    {
    }
  }
}
