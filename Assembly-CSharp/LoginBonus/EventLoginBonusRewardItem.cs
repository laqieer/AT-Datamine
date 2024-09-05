// Decompiled with JetBrains decompiler
// Type: LoginBonus.EventLoginBonusRewardItem
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore;
using GameCore.Tween;
using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace LoginBonus
{
  [Token(Token = "0x2000AC1")]
  public class EventLoginBonusRewardItem : MonoBehaviour
  {
    [Token(Token = "0x4003160")]
    [FieldOffset(Offset = "0x18")]
    private EventLoginBonusResource resource;
    [Token(Token = "0x4003161")]
    [FieldOffset(Offset = "0x20")]
    private UITweenGroup tweenGroup;
    [Token(Token = "0x4003162")]
    [FieldOffset(Offset = "0x28")]
    private GameObject dayImgXX;
    [Token(Token = "0x4003163")]
    [FieldOffset(Offset = "0x30")]
    private GameObject dayImgX;
    [Token(Token = "0x4003164")]
    [FieldOffset(Offset = "0x38")]
    private GameObject imgBase;
    [Token(Token = "0x4003165")]
    [FieldOffset(Offset = "0x40")]
    private RectTransform thumb;
    [Token(Token = "0x4003166")]
    [FieldOffset(Offset = "0x48")]
    private GameObject imgStamp;
    [Token(Token = "0x4003167")]
    [FieldOffset(Offset = "0x50")]
    private GameObject stampEffect;
    [Token(Token = "0x4003168")]
    [FieldOffset(Offset = "0x58")]
    private AssetCachedSpawner assetCachedSpawner;

    [Token(Token = "0x140000EC")]
    private event Action<ILoginBonusRewardUIParam> OnRewardItemClicked
    {
      [Token(Token = "0x6003D36"), Address(RVA = "0x2C0C260", Offset = "0x2C0C260", VA = "0x2C0C260")] add
      {
      }
      [Token(Token = "0x6003D37"), Address(RVA = "0x2C0C310", Offset = "0x2C0C310", VA = "0x2C0C310")] remove
      {
      }
    }

    [Token(Token = "0x170008CB")]
    public ILoginBonusRewardUIParam loginBonusRewardUIParam
    {
      [Token(Token = "0x6003D38"), Address(RVA = "0x2C0C3C0", Offset = "0x2C0C3C0", VA = "0x2C0C3C0")] get
      {
        return (ILoginBonusRewardUIParam) null;
      }
      [Token(Token = "0x6003D39"), Address(RVA = "0x2C0C3C8", Offset = "0x2C0C3C8", VA = "0x2C0C3C8")] private set
      {
      }
    }

    [Token(Token = "0x6003D3A")]
    [Address(RVA = "0x2C0C3D0", Offset = "0x2C0C3D0", VA = "0x2C0C3D0")]
    public void Initialize(
      AssetCachedSpawner assetCachedSpawner,
      int day,
      bool isReceivedReward,
      ILoginBonusRewardUIParam param,
      EventLoginBonusResource resource,
      Action<ILoginBonusRewardUIParam> onRewardItemClicked)
    {
    }

    [Token(Token = "0x6003D3B")]
    [Address(RVA = "0x2C0C794", Offset = "0x2C0C794", VA = "0x2C0C794")]
    private void InitializeIcon(ILoginBonusRewardUIParam param)
    {
    }

    [Token(Token = "0x6003D3C")]
    [Address(RVA = "0x2C0CBE8", Offset = "0x2C0CBE8", VA = "0x2C0CBE8")]
    public void PlayStampAnim()
    {
    }

    [Token(Token = "0x6003D3D")]
    [Address(RVA = "0x2C0CC08", Offset = "0x2C0CC08", VA = "0x2C0CC08")]
    public void PlayNextAnim()
    {
    }

    [Token(Token = "0x6003D3E")]
    [Address(RVA = "0x2C0C638", Offset = "0x2C0C638", VA = "0x2C0C638")]
    private void SetDay(int day)
    {
    }

    [Token(Token = "0x6003D3F")]
    [Address(RVA = "0x2C0C774", Offset = "0x2C0C774", VA = "0x2C0C774")]
    private void SetReceivedStamp(bool isReceivedReward)
    {
    }

    [Token(Token = "0x6003D40")]
    [Address(RVA = "0x2C0CC60", Offset = "0x2C0CC60", VA = "0x2C0CC60")]
    public EventLoginBonusRewardItem()
    {
    }
  }
}
