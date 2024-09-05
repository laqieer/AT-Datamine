// Decompiled with JetBrains decompiler
// Type: Scenes.OutGame.CharacterList.ContentCharacterView
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.Tween;
using Il2CppDummyDll;
using System;
using UI.Common;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

#nullable disable
namespace Scenes.OutGame.CharacterList
{
  [Token(Token = "0x2003723")]
  public class ContentCharacterView : MonoBehaviour
  {
    [Token(Token = "0x400F0C6")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private Image _emblemImage;
    [Token(Token = "0x400F0C7")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private Image _characterImage;
    [Token(Token = "0x400F0C8")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private ContainerLp _lpIcon;
    [Token(Token = "0x400F0C9")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    private ContainerLost _lostObj;
    [Token(Token = "0x400F0CA")]
    [FieldOffset(Offset = "0x38")]
    [SerializeField]
    private ContainerSoul _soulObj;
    [Token(Token = "0x400F0CB")]
    [FieldOffset(Offset = "0x40")]
    [SerializeField]
    private CommonButton _characterButton;
    [Token(Token = "0x400F0CC")]
    [FieldOffset(Offset = "0x48")]
    [SerializeField]
    private CoverNormalView _coverNormal;
    [Token(Token = "0x400F0CD")]
    [FieldOffset(Offset = "0x50")]
    [SerializeField]
    private CoverLostView _coverLost;
    [Token(Token = "0x400F0CE")]
    [FieldOffset(Offset = "0x58")]
    [SerializeField]
    private CoverHealView _coverHeal;
    [Token(Token = "0x400F0CF")]
    [FieldOffset(Offset = "0x60")]
    [SerializeField]
    private GameObject _cursor;
    [Token(Token = "0x400F0D0")]
    [FieldOffset(Offset = "0x68")]
    [SerializeField]
    private UITweenGroup _tweenGroup;
    [Token(Token = "0x400F0D1")]
    [FieldOffset(Offset = "0x70")]
    private UnityAction _onPressHealButton;
    [Token(Token = "0x400F0D2")]
    [FieldOffset(Offset = "0x78")]
    private UnityAction _onReleaseHealButton;

    [Token(Token = "0x6015B8A")]
    [Address(RVA = "0x1D8BCF4", Offset = "0x1D8BCF4", VA = "0x1D8BCF4")]
    public void SetConentState(ContentState state)
    {
    }

    [Token(Token = "0x6015B8B")]
    [Address(RVA = "0x1D8B330", Offset = "0x1D8B330", VA = "0x1D8B330")]
    public void SetEmblemImage(Sprite sprite)
    {
    }

    [Token(Token = "0x6015B8C")]
    [Address(RVA = "0x1D8B3F4", Offset = "0x1D8B3F4", VA = "0x1D8B3F4")]
    public void SetCharacterImage(Sprite sprite)
    {
    }

    [Token(Token = "0x6015B8D")]
    [Address(RVA = "0x1D8BF24", Offset = "0x1D8BF24", VA = "0x1D8BF24")]
    public void SetLp(int lp, int heal = 0)
    {
    }

    [Token(Token = "0x6015B8E")]
    [Address(RVA = "0x1D8B4C4", Offset = "0x1D8B4C4", VA = "0x1D8B4C4")]
    public void SetOnClickCharacterEvent(UnityAction callback)
    {
    }

    [Token(Token = "0x6015B8F")]
    [Address(RVA = "0x1D8B514", Offset = "0x1D8B514", VA = "0x1D8B514")]
    public void SetOnClickLostComebackButtonEvent(UnityAction callback)
    {
    }

    [Token(Token = "0x6015B90")]
    [Address(RVA = "0x1D8C034", Offset = "0x1D8C034", VA = "0x1D8C034")]
    public void SetLostRecoveryCost(int cost, bool isEnough = true)
    {
    }

    [Token(Token = "0x6015B91")]
    [Address(RVA = "0x1D8C01C", Offset = "0x1D8C01C", VA = "0x1D8C01C")]
    public void SetLostRecoveryTime(in TimeSpan timeSpan)
    {
    }

    [Token(Token = "0x6015B92")]
    [Address(RVA = "0x1D8C050", Offset = "0x1D8C050", VA = "0x1D8C050")]
    public void SetHealCost(int cost, int diff, bool isEnough = true)
    {
    }

    [Token(Token = "0x6015B93")]
    [Address(RVA = "0x1D8B310", Offset = "0x1D8B310", VA = "0x1D8B310")]
    public void SetCursor(bool on)
    {
    }

    [Token(Token = "0x6015B94")]
    [Address(RVA = "0x1D8C06C", Offset = "0x1D8C06C", VA = "0x1D8C06C")]
    public void PlayHealOn()
    {
    }

    [Token(Token = "0x6015B95")]
    [Address(RVA = "0x1D8C0C4", Offset = "0x1D8C0C4", VA = "0x1D8C0C4")]
    public void PlayHealOff()
    {
    }

    [Token(Token = "0x6015B96")]
    [Address(RVA = "0x1D8BB40", Offset = "0x1D8BB40", VA = "0x1D8BB40")]
    public void OperationPossible(bool flg)
    {
    }

    [Token(Token = "0x6015B97")]
    [Address(RVA = "0x1D8C11C", Offset = "0x1D8C11C", VA = "0x1D8C11C")]
    public ContentCharacterView()
    {
    }
  }
}
