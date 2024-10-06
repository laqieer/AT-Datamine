// Decompiled with JetBrains decompiler
// Type: FreeMap.UI.ButtonEvent.FreeMapIconEventAdvStage
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using ADV2.LuaScript;
using FreeMap.Adv;
using FreeMap.Loader;
using GameCore.MasterData;
using Il2CppDummyDll;
using Story.Adv;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

#nullable disable
namespace FreeMap.UI.ButtonEvent
{
  [Token(Token = "0x20016FA")]
  public class FreeMapIconEventAdvStage
  {
    [Token(Token = "0x400669A")]
    [FieldOffset(Offset = "0x10")]
    protected AdvStage advStage;
    [Token(Token = "0x400669B")]
    [FieldOffset(Offset = "0x18")]
    protected int advId;
    [Token(Token = "0x400669C")]
    [FieldOffset(Offset = "0x20")]
    protected IFreeMapAdvControl advControlMethod;
    [Token(Token = "0x400669D")]
    [FieldOffset(Offset = "0x28")]
    protected IFreeMapTemporarySceneLoader sceneHandler;
    [Token(Token = "0x400669E")]
    [FieldOffset(Offset = "0x30")]
    private IReadOnlyList<int> selected;
    [Token(Token = "0x400669F")]
    [FieldOffset(Offset = "0x38")]
    private IReadOnlyDictionary<int, int> localFalgs;
    [Token(Token = "0x40066A1")]
    [FieldOffset(Offset = "0x48")]
    private IReadOnlyList<int> unlockedoption;
    [Token(Token = "0x40066A2")]
    [FieldOffset(Offset = "0x50")]
    private IReadOnlyList<int> alreadyReadChoices;
    [Token(Token = "0x40066A3")]
    [FieldOffset(Offset = "0x58")]
    private Adv2LuaNetworkConnection.APICallOnAdv apicallOnAdv;
    [Token(Token = "0x40066A4")]
    [FieldOffset(Offset = "0x60")]
    private bool isLoaded;
    [Token(Token = "0x40066A5")]
    [FieldOffset(Offset = "0x61")]
    private bool isChangeArea;
    [Token(Token = "0x40066A6")]
    [FieldOffset(Offset = "0x62")]
    private bool isAreaEnd;

    [Token(Token = "0x17001449")]
    public Adv2LuaNetworkConnection Connection
    {
      [Token(Token = "0x6008208"), Address(RVA = "0x41FDEF0", Offset = "0x41FDEF0", VA = "0x41FDEF0")] get
      {
        return (Adv2LuaNetworkConnection) null;
      }
    }

    [Token(Token = "0x1700144A")]
    public bool Canceled
    {
      [Token(Token = "0x6008209"), Address(RVA = "0x41FDF0C", Offset = "0x41FDF0C", VA = "0x41FDF0C")] get
      {
        return new bool();
      }
      [Token(Token = "0x600820A"), Address(RVA = "0x41FDF14", Offset = "0x41FDF14", VA = "0x41FDF14")] private set
      {
      }
    }

    [Token(Token = "0x600820B")]
    [Address(RVA = "0x41F6F2C", Offset = "0x41F6F2C", VA = "0x41F6F2C")]
    public FreeMapIconEventAdvStage(
      int advId,
      IFreeMapAdvControl advControlMethod,
      IFreeMapTemporarySceneLoader sceneHandler,
      bool isAreaEnd = false)
    {
    }

    [Token(Token = "0x600820C")]
    [Address(RVA = "0x41F75C0", Offset = "0x41F75C0", VA = "0x41F75C0")]
    public void Destroy()
    {
    }

    [Token(Token = "0x600820D")]
    [Address(RVA = "0x41FDF20", Offset = "0x41FDF20", VA = "0x41FDF20", Slot = "4")]
    protected virtual void OnDestroy()
    {
    }

    [Token(Token = "0x600820E")]
    [Address(RVA = "0x41FDF24", Offset = "0x41FDF24", VA = "0x41FDF24", Slot = "5")]
    protected virtual AdvStage CreateAdvStage(
      AdvDemoInfoData demoInfo,
      Func<string, GameObject> areaObjectModelRefGetMethod,
      Func<GameObject> getPlayerOjectModelRefMethod,
      Action onChangeArea)
    {
      return (AdvStage) null;
    }

    [Token(Token = "0x600820F")]
    [Address(RVA = "0x41F6F78", Offset = "0x41F6F78", VA = "0x41F6F78")]
    public IEnumerator LoadIconEvent() => (IEnumerator) null;

    [Token(Token = "0x6008210")]
    [Address(RVA = "0x41FDFD8", Offset = "0x41FDFD8", VA = "0x41FDFD8")]
    public bool IsLoadedIconEvent() => new bool();

    [Token(Token = "0x6008211")]
    [Address(RVA = "0x41FDFE0", Offset = "0x41FDFE0", VA = "0x41FDFE0")]
    private void OnAreaChange()
    {
    }

    [Token(Token = "0x6008212")]
    [Address(RVA = "0x41F7558", Offset = "0x41F7558", VA = "0x41F7558")]
    public IEnumerator PlayIconEvent() => (IEnumerator) null;

    [Token(Token = "0x6008213")]
    [Address(RVA = "0x41FE1AC", Offset = "0x41FE1AC", VA = "0x41FE1AC")]
    public void ExtractSelect()
    {
    }

    [Token(Token = "0x6008214")]
    [Address(RVA = "0x41FE1D8", Offset = "0x41FE1D8", VA = "0x41FE1D8")]
    public void Register(Adv2LuaNetworkConnection.APICallOnAdv apicallOnAdv)
    {
    }

    [Token(Token = "0x6008215")]
    [Address(RVA = "0x41FE1E0", Offset = "0x41FE1E0", VA = "0x41FE1E0", Slot = "6")]
    protected virtual IEnumerator OnCreatedAdvStage() => (IEnumerator) null;

    [Token(Token = "0x6008216")]
    [Address(RVA = "0x41FE270", Offset = "0x41FE270", VA = "0x41FE270", Slot = "7")]
    public virtual IEnumerator SequenceAfterAdv() => (IEnumerator) null;

    [Token(Token = "0x6008217")]
    [Address(RVA = "0x41FE2F8", Offset = "0x41FE2F8", VA = "0x41FE2F8", Slot = "8")]
    protected virtual IEnumerator FadeOutBeforeAdv() => (IEnumerator) null;

    [Token(Token = "0x6008218")]
    [Address(RVA = "0x41FE380", Offset = "0x41FE380", VA = "0x41FE380", Slot = "9")]
    protected virtual IEnumerator FadeOutAfterAdv() => (IEnumerator) null;

    [Token(Token = "0x6008219")]
    [Address(RVA = "0x41FAEC0", Offset = "0x41FAEC0", VA = "0x41FAEC0")]
    public IReadOnlyList<int> GetPlayerSelectedIndex() => (IReadOnlyList<int>) null;

    [Token(Token = "0x600821A")]
    [Address(RVA = "0x41FE408", Offset = "0x41FE408", VA = "0x41FE408")]
    public IReadOnlyDictionary<int, int> GetPlayerSelectedFlag()
    {
      return (IReadOnlyDictionary<int, int>) null;
    }

    [Token(Token = "0x600821B")]
    [Address(RVA = "0x41FAF3C", Offset = "0x41FAF3C", VA = "0x41FAF3C")]
    public IReadOnlyList<int> GetUnlockedOption() => (IReadOnlyList<int>) null;

    [Token(Token = "0x600821C")]
    [Address(RVA = "0x41FAFB8", Offset = "0x41FAFB8", VA = "0x41FAFB8")]
    public IReadOnlyList<int> GetAlreadyReadChoices() => (IReadOnlyList<int>) null;
  }
}
