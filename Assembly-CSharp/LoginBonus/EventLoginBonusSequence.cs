// Decompiled with JetBrains decompiler
// Type: LoginBonus.EventLoginBonusSequence
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore;
using GameCore.DLC;
using GameCore.MasterData;
using GameCore.Popup;
using GameCore.UIControls;
using Il2CppDummyDll;
using System;
using System.Collections;
using System.Collections.Generic;
using UI.ItemDetail;
using UI.MultipleItemDetail;

#nullable disable
namespace LoginBonus
{
  [Token(Token = "0x2000AC4")]
  public class EventLoginBonusSequence : ILoginBonusSequence, IDisposable
  {
    [Token(Token = "0x4003175")]
    private const string SPRITE_FORMAT = "Image/LoginBonus/{0}/{0}_LoginBonusBG.png";
    [Token(Token = "0x4003176")]
    [FieldOffset(Offset = "0x10")]
    private int loginBonusId;
    [Token(Token = "0x4003177")]
    [FieldOffset(Offset = "0x14")]
    private int spriteId;
    [Token(Token = "0x4003178")]
    [FieldOffset(Offset = "0x18")]
    private LoginBonusRewardHolder loginBonusRewardHolder;
    [Token(Token = "0x4003179")]
    [FieldOffset(Offset = "0x20")]
    private AsyncAssetLoader assetLoader;
    [Token(Token = "0x400317A")]
    [FieldOffset(Offset = "0x28")]
    private ItemDetailPopupProvider itemDetailPopupGenerator;
    [Token(Token = "0x400317B")]
    [FieldOffset(Offset = "0x30")]
    private MultipleItemDetailPopupGenerator multipleItemDetailPopupGenerator;
    [Token(Token = "0x400317C")]
    [FieldOffset(Offset = "0x38")]
    private EventLoginBonusResource resource;
    [Token(Token = "0x400317D")]
    [FieldOffset(Offset = "0x40")]
    private EventLoginBonusView eventLoginBonusView;
    [Token(Token = "0x4003182")]
    [FieldOffset(Offset = "0x50")]
    private PopupBase openedPopup;
    [Token(Token = "0x4003183")]
    [FieldOffset(Offset = "0x58")]
    private AssetCachedSpawner assetCachedSpawner;
    [Token(Token = "0x4003184")]
    [FieldOffset(Offset = "0x60")]
    private string voiceBankId;
    [Token(Token = "0x4003185")]
    [FieldOffset(Offset = "0x68")]
    private string voiceId;

    [Token(Token = "0x170008CC")]
    public bool IsPrepareStartCalled
    {
      [Token(Token = "0x6003D45"), Address(RVA = "0x2C0CCE0", Offset = "0x2C0CCE0", VA = "0x2C0CCE0", Slot = "7")] get
      {
        return new bool();
      }
      [Token(Token = "0x6003D46"), Address(RVA = "0x2C0CCE8", Offset = "0x2C0CCE8", VA = "0x2C0CCE8")] private set
      {
      }
    }

    [Token(Token = "0x170008CD")]
    public bool IsFinished
    {
      [Token(Token = "0x6003D47"), Address(RVA = "0x2C0CCF4", Offset = "0x2C0CCF4", VA = "0x2C0CCF4", Slot = "8")] get
      {
        return new bool();
      }
      [Token(Token = "0x6003D48"), Address(RVA = "0x2C0CCFC", Offset = "0x2C0CCFC", VA = "0x2C0CCFC")] private set
      {
      }
    }

    [Token(Token = "0x170008CE")]
    public bool IsReady
    {
      [Token(Token = "0x6003D49"), Address(RVA = "0x2C0CD08", Offset = "0x2C0CD08", VA = "0x2C0CD08", Slot = "9")] get
      {
        return new bool();
      }
      [Token(Token = "0x6003D4A"), Address(RVA = "0x2C0CD10", Offset = "0x2C0CD10", VA = "0x2C0CD10")] private set
      {
      }
    }

    [Token(Token = "0x170008CF")]
    public LoginBonusTypeEnum LoginBonusType
    {
      [Token(Token = "0x6003D4B"), Address(RVA = "0x2C0CD1C", Offset = "0x2C0CD1C", VA = "0x2C0CD1C", Slot = "10")] get
      {
        return new LoginBonusTypeEnum();
      }
      [Token(Token = "0x6003D4C"), Address(RVA = "0x2C0CD24", Offset = "0x2C0CD24", VA = "0x2C0CD24")] private set
      {
      }
    }

    [Token(Token = "0x6003D4D")]
    [Address(RVA = "0x2C0CD2C", Offset = "0x2C0CD2C", VA = "0x2C0CD2C")]
    public EventLoginBonusSequence(AssetCachedSpawner assetCachedSpawner = null)
    {
    }

    [Token(Token = "0x6003D4E")]
    [Address(RVA = "0x2C0CD98", Offset = "0x2C0CD98", VA = "0x2C0CD98", Slot = "11")]
    public void Dispose()
    {
    }

    [Token(Token = "0x6003D4F")]
    [Address(RVA = "0x2C0CDBC", Offset = "0x2C0CDBC", VA = "0x2C0CDBC")]
    public void Setup(
      int loginBonusId,
      int currentRewardNumber,
      int spriteId,
      LoginBonusTypeEnum typeEnum,
      string voiceBankId,
      string voiceId)
    {
    }

    [Token(Token = "0x6003D50")]
    [Address(RVA = "0x2C0CF08", Offset = "0x2C0CF08", VA = "0x2C0CF08", Slot = "4")]
    public void PrepareStart()
    {
    }

    [Token(Token = "0x6003D51")]
    [Address(RVA = "0x2C0D04C", Offset = "0x2C0D04C", VA = "0x2C0D04C")]
    private IEnumerator PrepareStartAsync() => (IEnumerator) null;

    [Token(Token = "0x6003D52")]
    [Address(RVA = "0x2C0D0DC", Offset = "0x2C0D0DC", VA = "0x2C0D0DC", Slot = "5")]
    public void Start()
    {
    }

    [Token(Token = "0x6003D53")]
    [Address(RVA = "0x2C0D2DC", Offset = "0x2C0D2DC", VA = "0x2C0D2DC")]
    private IEnumerator WaitForReadyAsync(Func<IEnumerator> onReady) => (IEnumerator) null;

    [Token(Token = "0x6003D54")]
    [Address(RVA = "0x2C0D350", Offset = "0x2C0D350", VA = "0x2C0D350")]
    private IEnumerator StartImple() => (IEnumerator) null;

    [Token(Token = "0x6003D55")]
    [Address(RVA = "0x2C0D408", Offset = "0x2C0D408", VA = "0x2C0D408")]
    private IEnumerator Wait(float seconds, Func<bool> onCancel) => (IEnumerator) null;

    [Token(Token = "0x6003D56")]
    [Address(RVA = "0x2C0D4A8", Offset = "0x2C0D4A8", VA = "0x2C0D4A8")]
    private IEnumerator InitializeEventLoginBonusViewAsync(
      EventLoginBonusView view,
      LoginBonusRewardHolder loginBonusRewardHolder)
    {
      return (IEnumerator) null;
    }

    [Token(Token = "0x6003D57")]
    [Address(RVA = "0x2C0D54C", Offset = "0x2C0D54C", VA = "0x2C0D54C")]
    private IEnumerator InitializeLoginBonusRewardPopupAsync(
      ItemRewardPopupManage popup,
      ILoginBonusRewardUIParam param)
    {
      return (IEnumerator) null;
    }

    [Token(Token = "0x6003D58")]
    [Address(RVA = "0x2C0D5F0", Offset = "0x2C0D5F0", VA = "0x2C0D5F0")]
    private IEnumerator InitializeLoginBonusNextPopupAsync(
      ItemRewardPopupManage popup,
      ILoginBonusRewardUIParam param)
    {
      return (IEnumerator) null;
    }

    [Token(Token = "0x6003D59")]
    [Address(RVA = "0x2C0D694", Offset = "0x2C0D694", VA = "0x2C0D694")]
    private List<DisplayItemRewardInfoData> CreateDisplayItemRewardInfoData(
      ILoginBonusRewardUIParam param)
    {
      return (List<DisplayItemRewardInfoData>) null;
    }

    [Token(Token = "0x6003D5A")]
    [Address(RVA = "0x2C0DB0C", Offset = "0x2C0DB0C", VA = "0x2C0DB0C")]
    private IEnumerator InitializePopupAsync(
      ItemRewardPopupManage itemRewardPopupManage,
      string ABAssetName,
      string contentText,
      List<DisplayItemRewardInfoData> infos,
      Action onFinished)
    {
      return (IEnumerator) null;
    }

    [Token(Token = "0x6003D5B")]
    [Address(RVA = "0x2C0DBC4", Offset = "0x2C0DBC4", VA = "0x2C0DBC4", Slot = "6")]
    public void Release()
    {
    }

    [Token(Token = "0x6003D5C")]
    [Address(RVA = "0x2C0DD5C", Offset = "0x2C0DD5C", VA = "0x2C0DD5C")]
    private void OnClickRewardItem(ILoginBonusRewardUIParam param)
    {
    }

    [Token(Token = "0x6003D5D")]
    [Address(RVA = "0x2C0E248", Offset = "0x2C0E248", VA = "0x2C0E248")]
    private void OpenSingleItemDetailPopup(ILoginBonusRewardUIParam param)
    {
    }

    [Token(Token = "0x6003D5E")]
    [Address(RVA = "0x2C0DEBC", Offset = "0x2C0DEBC", VA = "0x2C0DEBC")]
    private void OpenMultipleItemDetailPopup(IEnumerable<MultipleItemDetailParamater> param)
    {
    }

    [Token(Token = "0x6003D5F")]
    [Address(RVA = "0x2C0E0D8", Offset = "0x2C0E0D8", VA = "0x2C0E0D8")]
    private void OpenOtherDetailPopup(ILoginBonusRewardUIParam param)
    {
    }
  }
}
