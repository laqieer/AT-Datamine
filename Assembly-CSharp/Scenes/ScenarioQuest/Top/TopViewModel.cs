// Decompiled with JetBrains decompiler
// Type: Scenes.ScenarioQuest.Top.TopViewModel
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.MasterData;
using Il2CppDummyDll;
using staq.SaveData;
using System;
using System.Collections;

#nullable disable
namespace Scenes.ScenarioQuest.Top
{
  [Token(Token = "0x2002967")]
  public class TopViewModel
  {
    [Token(Token = "0x400B05E")]
    [FieldOffset(Offset = "0x18")]
    public EventTopSaveData SaveData;
    [Token(Token = "0x400B05F")]
    [FieldOffset(Offset = "0x20")]
    public bool IsOpenFreeBattle;
    [Token(Token = "0x400B060")]
    [FieldOffset(Offset = "0x21")]
    public bool IsPlayOpenFreeBattleEffect;
    [Token(Token = "0x400B061")]
    [FieldOffset(Offset = "0x22")]
    public bool IsOpenSpecialBattle;
    [Token(Token = "0x400B062")]
    [FieldOffset(Offset = "0x23")]
    public bool IsPlayOpenSpecialBattleEffect;
    [Token(Token = "0x400B063")]
    [FieldOffset(Offset = "0x24")]
    public bool IsActiveSpecialBattle;
    [Token(Token = "0x400B064")]
    [FieldOffset(Offset = "0x25")]
    public bool IsOpenScoreAttack;
    [Token(Token = "0x400B065")]
    [FieldOffset(Offset = "0x26")]
    public bool IsPlayOpenScoreAttackEffect;
    [Token(Token = "0x400B066")]
    [FieldOffset(Offset = "0x27")]
    public bool IsActiveScoreAttack;

    [Token(Token = "0x170038F4")]
    public int ActiveScenarioEventId
    {
      [Token(Token = "0x6010465"), Address(RVA = "0x4756870", Offset = "0x4756870", VA = "0x4756870")] get
      {
        return new int();
      }
      [Token(Token = "0x6010466"), Address(RVA = "0x4756878", Offset = "0x4756878", VA = "0x4756878")] private set
      {
      }
    }

    [Token(Token = "0x6010467")]
    [Address(RVA = "0x47539CC", Offset = "0x47539CC", VA = "0x47539CC")]
    public void SetEventId(int id)
    {
    }

    [Token(Token = "0x6010468")]
    [Address(RVA = "0x47556D8", Offset = "0x47556D8", VA = "0x47556D8")]
    public void LoadSaveData()
    {
    }

    [Token(Token = "0x6010469")]
    [Address(RVA = "0x4756880", Offset = "0x4756880", VA = "0x4756880")]
    private void CheckIsOpenFreeBattle()
    {
    }

    [Token(Token = "0x601046A")]
    [Address(RVA = "0x4756B48", Offset = "0x4756B48", VA = "0x4756B48")]
    public void CheckIsSpecialBattle()
    {
    }

    [Token(Token = "0x601046B")]
    [Address(RVA = "0x4756CF0", Offset = "0x4756CF0", VA = "0x4756CF0")]
    private void CheckIsScoreAttack()
    {
    }

    [Token(Token = "0x601046C")]
    [Address(RVA = "0x4754458", Offset = "0x4754458", VA = "0x4754458")]
    public StoryScenarioQuestData GetEventData() => (StoryScenarioQuestData) null;

    [Token(Token = "0x1400014B")]
    public event Action<StoryScenarioQuestData> OnChange
    {
      [Token(Token = "0x601046D"), Address(RVA = "0x47564D4", Offset = "0x47564D4", VA = "0x47564D4")] add
      {
      }
      [Token(Token = "0x601046E"), Address(RVA = "0x4756E9C", Offset = "0x4756E9C", VA = "0x4756E9C")] remove
      {
      }
    }

    [Token(Token = "0x1400014C")]
    public event Func<bool> IsBusy
    {
      [Token(Token = "0x601046F"), Address(RVA = "0x47562C4", Offset = "0x47562C4", VA = "0x47562C4")] add
      {
      }
      [Token(Token = "0x6010470"), Address(RVA = "0x4756F4C", Offset = "0x4756F4C", VA = "0x4756F4C")] remove
      {
      }
    }

    [Token(Token = "0x1400014D")]
    public event Func<IEnumerator> OnChangeHide
    {
      [Token(Token = "0x6010471"), Address(RVA = "0x4756374", Offset = "0x4756374", VA = "0x4756374")] add
      {
      }
      [Token(Token = "0x6010472"), Address(RVA = "0x4756FFC", Offset = "0x4756FFC", VA = "0x4756FFC")] remove
      {
      }
    }

    [Token(Token = "0x1400014E")]
    public event Func<IEnumerator> OnChangeShow
    {
      [Token(Token = "0x6010473"), Address(RVA = "0x4756424", Offset = "0x4756424", VA = "0x4756424")] add
      {
      }
      [Token(Token = "0x6010474"), Address(RVA = "0x47570AC", Offset = "0x47570AC", VA = "0x47570AC")] remove
      {
      }
    }

    [Token(Token = "0x1400014F")]
    public event Action<bool, bool, bool, bool, bool, bool, bool, bool> OnTopButton
    {
      [Token(Token = "0x6010475"), Address(RVA = "0x4756584", Offset = "0x4756584", VA = "0x4756584")] add
      {
      }
      [Token(Token = "0x6010476"), Address(RVA = "0x475715C", Offset = "0x475715C", VA = "0x475715C")] remove
      {
      }
    }

    [Token(Token = "0x6010477")]
    [Address(RVA = "0x4755A24", Offset = "0x4755A24", VA = "0x4755A24")]
    public void Top()
    {
    }

    [Token(Token = "0x6010478")]
    [Address(RVA = "0x4755A20", Offset = "0x4755A20", VA = "0x4755A20")]
    public void Direct()
    {
    }

    [Token(Token = "0x6010479")]
    [Address(RVA = "0x475720C", Offset = "0x475720C", VA = "0x475720C")]
    private void Set()
    {
    }

    [Token(Token = "0x601047A")]
    [Address(RVA = "0x47539C4", Offset = "0x47539C4", VA = "0x47539C4")]
    public TopViewModel()
    {
    }
  }
}
