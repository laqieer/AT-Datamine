// Decompiled with JetBrains decompiler
// Type: Gacha.GachaMainModel
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Gacha.API;
using Il2CppDummyDll;
using StaqData;
using System;
using System.Collections.Generic;
using UnityEngine;

#nullable disable
namespace Gacha
{
  [Token(Token = "0x2001536")]
  internal class GachaMainModel
  {
    [Token(Token = "0x4006182")]
    [FieldOffset(Offset = "0x10")]
    private GachaInfoHolder gachaInfoHolder;
    [Token(Token = "0x4006183")]
    [FieldOffset(Offset = "0x18")]
    private string selectedGachaName;
    [Token(Token = "0x4006184")]
    [FieldOffset(Offset = "0x20")]
    public Action<GachaListInfo> GachaListChanged;
    [Token(Token = "0x4006185")]
    [FieldOffset(Offset = "0x28")]
    public Action<GachaInfoHolder, string> GachaDetailChanged;
    [Token(Token = "0x4006186")]
    [FieldOffset(Offset = "0x30")]
    public Action GachaPaymentRequestStart;
    [Token(Token = "0x4006187")]
    [FieldOffset(Offset = "0x38")]
    public Action<GachaInfo, GachaDetailInfo, GachaResultInfo> GachaPaymentCompleted;
    [Token(Token = "0x4006188")]
    [FieldOffset(Offset = "0x40")]
    public Action<GachaDetailInfo> GachaPaymentNotEnough;
    [Token(Token = "0x4006189")]
    [FieldOffset(Offset = "0x48")]
    public Action GachaPaymentAdvertisementCancel;
    [Token(Token = "0x400618A")]
    [FieldOffset(Offset = "0x50")]
    private GachaAPIProxy gachaAPIProxy;
    [Token(Token = "0x400618B")]
    [FieldOffset(Offset = "0x58")]
    public bool IsSkipGachaPlayback;

    [Token(Token = "0x17001280")]
    public GachaSettingModel GachaSettingModel
    {
      [Token(Token = "0x6007838"), Address(RVA = "0x44F7CA4", Offset = "0x44F7CA4", VA = "0x44F7CA4")] get
      {
        return (GachaSettingModel) null;
      }
      [Token(Token = "0x6007839"), Address(RVA = "0x44F7CAC", Offset = "0x44F7CAC", VA = "0x44F7CAC")] private set
      {
      }
    }

    [Token(Token = "0x600783A")]
    [Address(RVA = "0x44F7CB4", Offset = "0x44F7CB4", VA = "0x44F7CB4")]
    public GachaMainModel(MonoBehaviour coroutineRunner)
    {
    }

    [Token(Token = "0x600783B")]
    [Address(RVA = "0x44F7E1C", Offset = "0x44F7E1C", VA = "0x44F7E1C")]
    public void RequestGachaList(Action onFinished, Action onError)
    {
    }

    [Token(Token = "0x600783C")]
    [Address(RVA = "0x44F7EF4", Offset = "0x44F7EF4", VA = "0x44F7EF4")]
    public void RequestGachaDetail(
      IGachaModuleInfo gachaModuleInfo,
      Action onFinished,
      Action onError)
    {
    }

    [Token(Token = "0x600783D")]
    [Address(RVA = "0x44F813C", Offset = "0x44F813C", VA = "0x44F813C")]
    public void RequestGachaPay(string gachaName, int gachaDetailId, int executeCount)
    {
    }

    [Token(Token = "0x600783E")]
    [Address(RVA = "0x44F82DC", Offset = "0x44F82DC", VA = "0x44F82DC")]
    private void _RequestGachaPay(GachaDetailInfo detail, int executeCount)
    {
    }

    [Token(Token = "0x600783F")]
    [Address(RVA = "0x44F81A0", Offset = "0x44F81A0", VA = "0x44F81A0")]
    private void _RequestGachaPayAdvertisement(GachaDetailInfo detail, int executeCount)
    {
    }

    [Token(Token = "0x6007840")]
    [Address(RVA = "0x44F859C", Offset = "0x44F859C", VA = "0x44F859C")]
    public void RequestGachaProvideInfo(
      string gachaName,
      int gachaGroupId,
      Action<string, string> onSuccess)
    {
    }

    [Token(Token = "0x6007841")]
    [Address(RVA = "0x44F8768", Offset = "0x44F8768", VA = "0x44F8768")]
    public void RequestSelectGachaSetTarget(string gachaName, int targetId, int targetOptionId)
    {
    }

    [Token(Token = "0x6007842")]
    [Address(RVA = "0x44F8978", Offset = "0x44F8978", VA = "0x44F8978")]
    private bool IsTargetGachaOpen(string gachaName) => new bool();

    [Token(Token = "0x6007843")]
    [Address(RVA = "0x44F8A94", Offset = "0x44F8A94", VA = "0x44F8A94")]
    public void SelectGacha(
      string gachaName,
      Action<GachaInfoHolder, string> onSelect,
      Action onError,
      Action onTimeouted)
    {
    }

    [Token(Token = "0x6007844")]
    [Address(RVA = "0x44F8C6C", Offset = "0x44F8C6C", VA = "0x44F8C6C")]
    public void SelectValidFirstGacha(
      Action<GachaInfoHolder, string> onSelect,
      Action onError,
      int? gachaNumber = null,
      int avoidGachaNumberOnNotFound = 0)
    {
    }

    [Token(Token = "0x6007845")]
    [Address(RVA = "0x44F90A0", Offset = "0x44F90A0", VA = "0x44F90A0")]
    public GachaDetailInfo GetCurrentGachaDetailInfo() => (GachaDetailInfo) null;

    [Token(Token = "0x6007846")]
    [Address(RVA = "0x44F9100", Offset = "0x44F9100", VA = "0x44F9100")]
    public GachaDetailGroupInfo GetGachaDetailGroupInfo(string gachaName)
    {
      return (GachaDetailGroupInfo) null;
    }

    [Token(Token = "0x6007847")]
    [Address(RVA = "0x44F9118", Offset = "0x44F9118", VA = "0x44F9118")]
    public List<GachaPickupInfo> GetPickupInfo(string gachaName, int groupId)
    {
      return (List<GachaPickupInfo>) null;
    }

    [Token(Token = "0x6007848")]
    [Address(RVA = "0x44F9144", Offset = "0x44F9144", VA = "0x44F9144")]
    private void NotifyGachaListChanged()
    {
    }

    [Token(Token = "0x6007849")]
    [Address(RVA = "0x44F8C48", Offset = "0x44F8C48", VA = "0x44F8C48")]
    private void NotifyGachaDetailChanged(string gachaName)
    {
    }

    [Token(Token = "0x600784A")]
    [Address(RVA = "0x44F917C", Offset = "0x44F917C", VA = "0x44F917C")]
    public List<StoryGachaNotificationData> GetReleasedStoryGachaNotificationDatas()
    {
      return (List<StoryGachaNotificationData>) null;
    }
  }
}
