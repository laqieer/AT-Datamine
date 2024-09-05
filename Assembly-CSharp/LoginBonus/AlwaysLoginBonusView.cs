// Decompiled with JetBrains decompiler
// Type: LoginBonus.AlwaysLoginBonusView
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore;
using GameCore.Tween;
using GameCore.UIControls;
using Il2CppDummyDll;
using System;
using System.Collections;
using UI;
using UI.Direction;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace LoginBonus
{
  [Token(Token = "0x2000AF7")]
  public class AlwaysLoginBonusView : MonoBehaviour
  {
    [Token(Token = "0x4003230")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private TextAccessor textTotalLoginCount;
    [Token(Token = "0x4003231")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private LoginBonusRewardListView rewardList;
    [Token(Token = "0x4003232")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private UITweenGroup tweenGroup;
    [Token(Token = "0x4003233")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    private UITimelineController timelineController;
    [Token(Token = "0x4003234")]
    [FieldOffset(Offset = "0x38")]
    [SerializeField]
    private Button buttonSkip;
    [Token(Token = "0x4003235")]
    [FieldOffset(Offset = "0x40")]
    [SerializeField]
    private Button buttonNext;
    [Token(Token = "0x4003236")]
    [FieldOffset(Offset = "0x48")]
    private AssetCachedSpawner assetCachedSpawner;
    [Token(Token = "0x4003237")]
    [FieldOffset(Offset = "0x50")]
    private LoginBonusRewardListItemView todayRewardListItem;
    [Token(Token = "0x4003238")]
    [FieldOffset(Offset = "0x58")]
    private LoginBonusRewardListItemView tommorowRewardListItem;
    [Token(Token = "0x4003239")]
    [FieldOffset(Offset = "0x60")]
    private ItemRewardPopupManage todayRewardEffectPopup;
    [Token(Token = "0x400323A")]
    [FieldOffset(Offset = "0x68")]
    private ItemRewardPopupManage tommorowRewardEffectPopup;

    [Token(Token = "0x6003E70")]
    [Address(RVA = "0x2C08B4C", Offset = "0x2C08B4C", VA = "0x2C08B4C")]
    public IEnumerator Setup(
      AssetCachedSpawner assetCachedSpawner,
      int totalLoginCount,
      LoginBonusRewardHolder loginBonusRewardHolder,
      Action<ILoginBonusRewardUIParam> onRewardItemClicked)
    {
      return (IEnumerator) null;
    }

    [Token(Token = "0x6003E71")]
    [Address(RVA = "0x2C1560C", Offset = "0x2C1560C", VA = "0x2C1560C")]
    private void SetTotalLoginCount(int totalLoginCount)
    {
    }

    [Token(Token = "0x6003E72")]
    [Address(RVA = "0x2C156F0", Offset = "0x2C156F0", VA = "0x2C156F0")]
    private void SetupRewardList(
      LoginBonusRewardHolder loginBonusRewardHolder,
      Action<ILoginBonusRewardUIParam> onRewardItemClicked)
    {
    }

    [Token(Token = "0x6003E73")]
    [Address(RVA = "0x2C159A8", Offset = "0x2C159A8", VA = "0x2C159A8")]
    private IEnumerator SetupTodayRewardEffect(LoginBonusRewardHolder loginBonusRewardHolder)
    {
      return (IEnumerator) null;
    }

    [Token(Token = "0x6003E74")]
    [Address(RVA = "0x2C15A44", Offset = "0x2C15A44", VA = "0x2C15A44")]
    private IEnumerator SetupTommorowRewardEffect(LoginBonusRewardHolder loginBonusRewardHolder)
    {
      return (IEnumerator) null;
    }

    [Token(Token = "0x6003E75")]
    [Address(RVA = "0x2C08BDC", Offset = "0x2C08BDC", VA = "0x2C08BDC")]
    public IEnumerator PlayInAnimation() => (IEnumerator) null;

    [Token(Token = "0x6003E76")]
    [Address(RVA = "0x2C08F50", Offset = "0x2C08F50", VA = "0x2C08F50")]
    public IEnumerator PlayOutAnimation() => (IEnumerator) null;

    [Token(Token = "0x6003E77")]
    [Address(RVA = "0x2C08C44", Offset = "0x2C08C44", VA = "0x2C08C44")]
    public IAnimationStateHandle PlayStampInAnimation(Action onAnimationComplete)
    {
      return (IAnimationStateHandle) null;
    }

    [Token(Token = "0x6003E78")]
    [Address(RVA = "0x2C08CC8", Offset = "0x2C08CC8", VA = "0x2C08CC8")]
    public IAnimationStateHandle PlayStampOutAnimation(Action onAnimationComplete)
    {
      return (IAnimationStateHandle) null;
    }

    [Token(Token = "0x6003E79")]
    [Address(RVA = "0x2C08D9C", Offset = "0x2C08D9C", VA = "0x2C08D9C")]
    public IAnimationStateHandle PlayNextAnimation(Action onAnimationComplete)
    {
      return (IAnimationStateHandle) null;
    }

    [Token(Token = "0x6003E7A")]
    [Address(RVA = "0x2C08D34", Offset = "0x2C08D34", VA = "0x2C08D34")]
    public IEnumerator PlayStampOffAnimationAll() => (IEnumerator) null;

    [Token(Token = "0x6003E7B")]
    [Address(RVA = "0x2C08C60", Offset = "0x2C08C60", VA = "0x2C08C60")]
    public IEnumerator PlayTodayRewardEffect() => (IEnumerator) null;

    [Token(Token = "0x6003E7C")]
    [Address(RVA = "0x2C08DB8", Offset = "0x2C08DB8", VA = "0x2C08DB8")]
    public IEnumerator PlayTommorowRewardEffect() => (IEnumerator) null;

    [Token(Token = "0x6003E7D")]
    [Address(RVA = "0x2C15C10", Offset = "0x2C15C10", VA = "0x2C15C10")]
    public void EnableSkipButton(Action onClick)
    {
    }

    [Token(Token = "0x6003E7E")]
    [Address(RVA = "0x2C15D48", Offset = "0x2C15D48", VA = "0x2C15D48")]
    public void DisableSkipButton()
    {
    }

    [Token(Token = "0x6003E7F")]
    [Address(RVA = "0x2C08E20", Offset = "0x2C08E20", VA = "0x2C08E20")]
    public void EnableNextButton(Action onClick)
    {
    }

    [Token(Token = "0x6003E80")]
    [Address(RVA = "0x2C082DC", Offset = "0x2C082DC", VA = "0x2C082DC")]
    public void DisableNextButton()
    {
    }

    [Token(Token = "0x6003E81")]
    [Address(RVA = "0x2C15DD8", Offset = "0x2C15DD8", VA = "0x2C15DD8")]
    private void OnDestroy()
    {
    }

    [Token(Token = "0x6003E82")]
    [Address(RVA = "0x2C15E10", Offset = "0x2C15E10", VA = "0x2C15E10")]
    public AlwaysLoginBonusView()
    {
    }
  }
}
