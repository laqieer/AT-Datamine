// Decompiled with JetBrains decompiler
// Type: FreeMap.State.FreeMapAreaAdvPlayer
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using FreeMap.Adv;
using Il2CppDummyDll;
using Story.Adv;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

#nullable disable
namespace FreeMap.State
{
  [Token(Token = "0x2001785")]
  public class FreeMapAreaAdvPlayer
  {
    [Token(Token = "0x4006829")]
    [FieldOffset(Offset = "0x28")]
    private AdvStageControl advStageControl;
    [Token(Token = "0x400682A")]
    [FieldOffset(Offset = "0x30")]
    private readonly FreeMapAreaAdvPlayer.Requirement requirement;
    [Token(Token = "0x400682B")]
    [FieldOffset(Offset = "0x38")]
    private bool isChangeArea;

    [Token(Token = "0x17001511")]
    public FreeMapAreaAdvPlayer.AdvReserve Reserve
    {
      [Token(Token = "0x6008548"), Address(RVA = "0x406B434", Offset = "0x406B434", VA = "0x406B434")] get
      {
        return (FreeMapAreaAdvPlayer.AdvReserve) null;
      }
    }

    [Token(Token = "0x14000114")]
    public event Action OnBeginEvent
    {
      [Token(Token = "0x6008549"), Address(RVA = "0x406B43C", Offset = "0x406B43C", VA = "0x406B43C")] add
      {
      }
      [Token(Token = "0x600854A"), Address(RVA = "0x406B4D8", Offset = "0x406B4D8", VA = "0x406B4D8")] remove
      {
      }
    }

    [Token(Token = "0x14000115")]
    public event Action OnEndEvent
    {
      [Token(Token = "0x600854B"), Address(RVA = "0x406B574", Offset = "0x406B574", VA = "0x406B574")] add
      {
      }
      [Token(Token = "0x600854C"), Address(RVA = "0x406B610", Offset = "0x406B610", VA = "0x406B610")] remove
      {
      }
    }

    [Token(Token = "0x600854D")]
    [Address(RVA = "0x406B6AC", Offset = "0x406B6AC", VA = "0x406B6AC")]
    public FreeMapAreaAdvPlayer(FreeMapAreaAdvPlayer.Requirement requirement)
    {
    }

    [Token(Token = "0x600854E")]
    [Address(RVA = "0x406B7D0", Offset = "0x406B7D0", VA = "0x406B7D0")]
    public IEnumerator Play() => (IEnumerator) null;

    [Token(Token = "0x600854F")]
    [Address(RVA = "0x406B860", Offset = "0x406B860", VA = "0x406B860")]
    private IEnumerator PlayInternal(FreeMapAreaAdvPlayer.PlayData playdata) => (IEnumerator) null;

    [Token(Token = "0x6008550")]
    [Address(RVA = "0x406B8FC", Offset = "0x406B8FC", VA = "0x406B8FC")]
    private void OnAreaChange()
    {
    }

    [Token(Token = "0x6008551")]
    [Address(RVA = "0x406BB1C", Offset = "0x406BB1C", VA = "0x406BB1C", Slot = "4")]
    protected virtual IEnumerator OnBegin() => (IEnumerator) null;

    [Token(Token = "0x6008552")]
    [Address(RVA = "0x406BBAC", Offset = "0x406BBAC", VA = "0x406BBAC", Slot = "5")]
    protected virtual IEnumerator OnEnd() => (IEnumerator) null;

    [Token(Token = "0x6008553")]
    [Address(RVA = "0x406BC3C", Offset = "0x406BC3C", VA = "0x406BC3C", Slot = "6")]
    protected virtual void HideUI()
    {
    }

    [Token(Token = "0x6008554")]
    [Address(RVA = "0x406BC7C", Offset = "0x406BC7C", VA = "0x406BC7C", Slot = "7")]
    protected virtual void ShowUI()
    {
    }

    [Token(Token = "0x6008555")]
    [Address(RVA = "0x406BC98", Offset = "0x406BC98", VA = "0x406BC98")]
    private void PlayerControlPermit(bool value)
    {
    }

    [Token(Token = "0x2001786")]
    public class Requirement
    {
      [Token(Token = "0x17001512")]
      public FreeMapCommonElement CommonElement
      {
        [Token(Token = "0x6008556"), Address(RVA = "0x406BD18", Offset = "0x406BD18", VA = "0x406BD18")] get
        {
          return (FreeMapCommonElement) null;
        }
      }

      [Token(Token = "0x17001513")]
      public IFreeMapAdvControl MapAdvControl
      {
        [Token(Token = "0x6008557"), Address(RVA = "0x406BA50", Offset = "0x406BA50", VA = "0x406BA50")] get
        {
          return (IFreeMapAdvControl) null;
        }
      }

      [Token(Token = "0x6008558")]
      [Address(RVA = "0x406BA6C", Offset = "0x406BA6C", VA = "0x406BA6C")]
      public void MapUnLoadScene()
      {
      }

      [Token(Token = "0x6008559")]
      [Address(RVA = "0x406BE18", Offset = "0x406BE18", VA = "0x406BE18")]
      public IEnumerator MapLoadScene() => (IEnumerator) null;

      [Token(Token = "0x600855A")]
      [Address(RVA = "0x406BC54", Offset = "0x406BC54", VA = "0x406BC54")]
      public void HideUI()
      {
      }

      [Token(Token = "0x600855B")]
      [Address(RVA = "0x406BC94", Offset = "0x406BC94", VA = "0x406BC94")]
      public void ShowUI()
      {
      }

      [Token(Token = "0x17001514")]
      private FreeMapStateManager Entity
      {
        [Token(Token = "0x600855C"), Address(RVA = "0x406BEC8", Offset = "0x406BEC8", VA = "0x406BEC8")] get
        {
          return (FreeMapStateManager) null;
        }
      }

      [Token(Token = "0x600855D")]
      [Address(RVA = "0x406BED0", Offset = "0x406BED0", VA = "0x406BED0")]
      public Requirement(FreeMapStateManager entity)
      {
      }
    }

    [Token(Token = "0x2001788")]
    public class AdvReserve
    {
      [Token(Token = "0x17001517")]
      public Queue<FreeMapAreaAdvPlayer.PlayData> Queue
      {
        [Token(Token = "0x6008564"), Address(RVA = "0x406C040", Offset = "0x406C040", VA = "0x406C040")] get
        {
          return (Queue<FreeMapAreaAdvPlayer.PlayData>) null;
        }
      }

      [Token(Token = "0x17001518")]
      public bool Playable
      {
        [Token(Token = "0x6008565"), Address(RVA = "0x406C048", Offset = "0x406C048", VA = "0x406C048")] get
        {
          return new bool();
        }
      }

      [Token(Token = "0x6008566")]
      [Address(RVA = "0x406B754", Offset = "0x406B754", VA = "0x406B754")]
      public AdvReserve()
      {
      }
    }

    [Token(Token = "0x2001789")]
    public class PlayFreeStartData : FreeMapAreaAdvPlayer.PlayData
    {
      [Token(Token = "0x6008567")]
      [Address(RVA = "0x406C098", Offset = "0x406C098", VA = "0x406C098", Slot = "6")]
      public override AdvStage GetAdvStage(
        Func<string, GameObject> areaObjectModelRefGetMethod,
        Func<GameObject> getPlayerOjectModelRefMethod,
        Action onChangeArea)
      {
        return (AdvStage) null;
      }

      [Token(Token = "0x6008568")]
      [Address(RVA = "0x406C19C", Offset = "0x406C19C", VA = "0x406C19C")]
      public PlayFreeStartData()
      {
      }
    }

    [Token(Token = "0x200178A")]
    public abstract class PlayData
    {
      [Token(Token = "0x17001519")]
      public int AdvID
      {
        [Token(Token = "0x6008569"), Address(RVA = "0x406C1AC", Offset = "0x406C1AC", VA = "0x406C1AC")] get
        {
          return new int();
        }
        [Token(Token = "0x600856A"), Address(RVA = "0x406C1B4", Offset = "0x406C1B4", VA = "0x406C1B4")] private set
        {
        }
      }

      [Token(Token = "0x600856B")]
      [Address(RVA = "0x406C1BC", Offset = "0x406C1BC", VA = "0x406C1BC", Slot = "4")]
      public virtual IEnumerator OnBegin(AdvStage advStage) => (IEnumerator) null;

      [Token(Token = "0x600856C")]
      [Address(RVA = "0x406C244", Offset = "0x406C244", VA = "0x406C244", Slot = "5")]
      public virtual IEnumerator OnEnd(AdvStage advStage) => (IEnumerator) null;

      [Token(Token = "0x600856D")]
      [Address(RVA = "0x406C2CC", Offset = "0x406C2CC", VA = "0x406C2CC")]
      public void Initialize(int advID)
      {
      }

      [Token(Token = "0x600856E")]
      public abstract AdvStage GetAdvStage(
        Func<string, GameObject> areaObjectModelRefGetMethod,
        Func<GameObject> getPlayerOjectModelRefMethod,
        Action onChangeArea);

      [Token(Token = "0x600856F")]
      [Address(RVA = "0x406C1A4", Offset = "0x406C1A4", VA = "0x406C1A4")]
      protected PlayData()
      {
      }
    }
  }
}
