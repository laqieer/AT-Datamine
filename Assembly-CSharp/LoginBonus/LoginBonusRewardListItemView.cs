// Decompiled with JetBrains decompiler
// Type: LoginBonus.LoginBonusRewardListItemView
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore;
using GameCore.Tween;
using Il2CppDummyDll;
using System;
using UnityEngine;
using UnityEngine.Playables;
using UnityEngine.UI;

#nullable disable
namespace LoginBonus
{
  [Token(Token = "0x2000B04")]
  public class LoginBonusRewardListItemView : MonoBehaviour
  {
    [Token(Token = "0x400325D")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private RectTransform thumbParent;
    [Token(Token = "0x400325E")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private Text textNumber;
    [Token(Token = "0x400325F")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private UITweenGroup tweenGroup;
    [Token(Token = "0x4003260")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    private PlayableDirector timelineNextReward;
    [Token(Token = "0x4003261")]
    [FieldOffset(Offset = "0x38")]
    [SerializeField]
    private PlayableDirector timelineGetReward;

    [Token(Token = "0x1700091E")]
    public int RewardNumber
    {
      [Token(Token = "0x6003EBD"), Address(RVA = "0x2C16B38", Offset = "0x2C16B38", VA = "0x2C16B38")] get
      {
        return new int();
      }
      [Token(Token = "0x6003EBE"), Address(RVA = "0x2C16B40", Offset = "0x2C16B40", VA = "0x2C16B40")] private set
      {
      }
    }

    [Token(Token = "0x140000ED")]
    private event Action<ILoginBonusRewardUIParam> OnRewardItemClicked
    {
      [Token(Token = "0x6003EBF"), Address(RVA = "0x2C16B48", Offset = "0x2C16B48", VA = "0x2C16B48")] add
      {
      }
      [Token(Token = "0x6003EC0"), Address(RVA = "0x2C16BF8", Offset = "0x2C16BF8", VA = "0x2C16BF8")] remove
      {
      }
    }

    [Token(Token = "0x1700091F")]
    public ILoginBonusRewardUIParam loginBonusRewardUIParam
    {
      [Token(Token = "0x6003EC1"), Address(RVA = "0x2C16CA8", Offset = "0x2C16CA8", VA = "0x2C16CA8")] get
      {
        return (ILoginBonusRewardUIParam) null;
      }
      [Token(Token = "0x6003EC2"), Address(RVA = "0x2C16CB0", Offset = "0x2C16CB0", VA = "0x2C16CB0")] private set
      {
      }
    }

    [Token(Token = "0x6003EC3")]
    [Address(RVA = "0x2C16CB8", Offset = "0x2C16CB8", VA = "0x2C16CB8")]
    public void Setup(
      AssetCachedSpawner assetCachedSpawner,
      ILoginBonusRewardUIParam loginBonusRewardUIParam,
      Action<ILoginBonusRewardUIParam> onRewardItemClicked)
    {
    }

    [Token(Token = "0x6003EC4")]
    [Address(RVA = "0x2C17124", Offset = "0x2C17124", VA = "0x2C17124")]
    private void SetNumber(int rewardNumber)
    {
    }

    [Token(Token = "0x6003EC5")]
    [Address(RVA = "0x2C17170", Offset = "0x2C17170", VA = "0x2C17170")]
    public IAnimationStateHandle PlayCheckIconOffAnimation(Action onAnimationComplete)
    {
      return (IAnimationStateHandle) null;
    }

    [Token(Token = "0x6003EC6")]
    [Address(RVA = "0x2C15B38", Offset = "0x2C15B38", VA = "0x2C15B38")]
    public IAnimationStateHandle PlayCheckIconOnAnimation(Action onAnimationComplete)
    {
      return (IAnimationStateHandle) null;
    }

    [Token(Token = "0x6003EC7")]
    [Address(RVA = "0x2C15B30", Offset = "0x2C15B30", VA = "0x2C15B30")]
    public IAnimationStateHandle PlayGetAnimation(Action onAnimationComplete)
    {
      return (IAnimationStateHandle) null;
    }

    [Token(Token = "0x6003EC8")]
    [Address(RVA = "0x2C15B90", Offset = "0x2C15B90", VA = "0x2C15B90")]
    public IAnimationStateHandle PlayNextAnimation(Action onAnimationComplete)
    {
      return (IAnimationStateHandle) null;
    }

    [Token(Token = "0x6003EC9")]
    [Address(RVA = "0x2C171C8", Offset = "0x2C171C8", VA = "0x2C171C8")]
    public void OnClickItemIcon()
    {
    }

    [Token(Token = "0x6003ECA")]
    [Address(RVA = "0x2C171E8", Offset = "0x2C171E8", VA = "0x2C171E8")]
    public LoginBonusRewardListItemView()
    {
    }
  }
}
