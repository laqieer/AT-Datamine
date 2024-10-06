// Decompiled with JetBrains decompiler
// Type: Battle.UI.FieldDamageDirection
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.Tween;
using Il2CppDummyDll;
using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.Playables;
using UnityEngine.UI;

#nullable disable
namespace Battle.UI
{
  [Token(Token = "0x20022F5")]
  public class FieldDamageDirection : MonoBehaviour
  {
    [Token(Token = "0x40093DF")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private RectTransform rectTransform;
    [Token(Token = "0x40093E0")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private PlayableDirector playableDirector;
    [Token(Token = "0x40093E1")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private UITweenGroup elementTweenGroup;
    [Token(Token = "0x40093E2")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    private UITweenGroup supportEffect;
    [Token(Token = "0x40093E3")]
    [FieldOffset(Offset = "0x38")]
    [SerializeField]
    private List<GameObject> categoryObjects;
    [Token(Token = "0x40093E4")]
    [FieldOffset(Offset = "0x40")]
    [SerializeField]
    private List<Image> damageDigitImages;
    [Token(Token = "0x40093E5")]
    [FieldOffset(Offset = "0x48")]
    [SerializeField]
    private List<Sprite> damageNumbers;
    [Token(Token = "0x40093E6")]
    [FieldOffset(Offset = "0x50")]
    [SerializeField]
    private List<Image> criticalDigitImages;
    [Token(Token = "0x40093E7")]
    [FieldOffset(Offset = "0x58")]
    [SerializeField]
    private List<Sprite> criticalNumbers;
    [Token(Token = "0x40093E8")]
    [FieldOffset(Offset = "0x60")]
    [SerializeField]
    private List<Image> healDigitImages;
    [Token(Token = "0x40093E9")]
    [FieldOffset(Offset = "0x68")]
    [SerializeField]
    private List<Sprite> healNumbers;
    [Token(Token = "0x40093EA")]
    [FieldOffset(Offset = "0x70")]
    private bool playing;
    [Token(Token = "0x40093EB")]
    [FieldOffset(Offset = "0x78")]
    private UnityAction timelineCallback;
    [Token(Token = "0x40093EC")]
    [FieldOffset(Offset = "0x80")]
    private UnityAction tweenCallback;
    [Token(Token = "0x40093ED")]
    [FieldOffset(Offset = "0x88")]
    private Action<PlayableDirector> backUpStoppedCallback;

    [Token(Token = "0x17002E33")]
    public bool IsPlaying
    {
      [Token(Token = "0x600D5BC"), Address(RVA = "0x1D1795C", Offset = "0x1D1795C", VA = "0x1D1795C")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x600D5BD")]
    [Address(RVA = "0x1D17964", Offset = "0x1D17964", VA = "0x1D17964")]
    public void Initialize()
    {
    }

    [Token(Token = "0x600D5BE")]
    [Address(RVA = "0x1D17A04", Offset = "0x1D17A04", VA = "0x1D17A04")]
    public void Play(FieldDamageDirection.Category category, Vector2 position, int damageValue)
    {
    }

    [Token(Token = "0x600D5BF")]
    [Address(RVA = "0x1D17ECC", Offset = "0x1D17ECC", VA = "0x1D17ECC")]
    public void PlaySupportEffectTween(Vector3 pos, string tweenName)
    {
    }

    [Token(Token = "0x600D5C0")]
    [Address(RVA = "0x1D17BDC", Offset = "0x1D17BDC", VA = "0x1D17BDC")]
    private void SetDigitNumber(List<Image> digits, List<Sprite> numbers, int damageValue)
    {
    }

    [Token(Token = "0x600D5C1")]
    [Address(RVA = "0x1D17FE0", Offset = "0x1D17FE0", VA = "0x1D17FE0")]
    public void Stop()
    {
    }

    [Token(Token = "0x600D5C2")]
    [Address(RVA = "0x1D17B64", Offset = "0x1D17B64", VA = "0x1D17B64")]
    public void Hide()
    {
    }

    [Token(Token = "0x600D5C3")]
    [Address(RVA = "0x1D17FFC", Offset = "0x1D17FFC", VA = "0x1D17FFC")]
    public FieldDamageDirection()
    {
    }

    [Token(Token = "0x20022F6")]
    public enum Category
    {
      [Token(Token = "0x40093EF")] Damage,
      [Token(Token = "0x40093F0")] Critical,
      [Token(Token = "0x40093F1")] Heal,
      [Token(Token = "0x40093F2")] Miss,
      [Token(Token = "0x40093F3")] ElementChain,
    }

    [Token(Token = "0x20022F7")]
    private enum Digit
    {
      [Token(Token = "0x40093F5")] OnePlace,
      [Token(Token = "0x40093F6")] TensPlace,
      [Token(Token = "0x40093F7")] OneHundredsPlace,
      [Token(Token = "0x40093F8")] OneThousandsPlace,
    }
  }
}
