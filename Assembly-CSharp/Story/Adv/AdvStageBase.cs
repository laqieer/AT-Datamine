// Decompiled with JetBrains decompiler
// Type: Story.Adv.AdvStageBase
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using ADV2;
using ADV2.LuaScript;
using GameCore.MasterData;
using Il2CppDummyDll;
using System.Collections.Generic;

#nullable disable
namespace Story.Adv
{
  [Token(Token = "0x2000749")]
  public abstract class AdvStageBase
  {
    [Token(Token = "0x4002187")]
    [FieldOffset(Offset = "0x10")]
    protected bool isBusy;
    [Token(Token = "0x4002188")]
    [FieldOffset(Offset = "0x14")]
    private int advId;
    [Token(Token = "0x4002189")]
    [FieldOffset(Offset = "0x18")]
    private List<int> selectedHistory;
    [Token(Token = "0x400218A")]
    [FieldOffset(Offset = "0x20")]
    private List<int> unlockedOptionIds;
    [Token(Token = "0x400218B")]
    [FieldOffset(Offset = "0x28")]
    private List<int> alreadyReadChoices;

    [Token(Token = "0x17000603")]
    public int AdvId
    {
      [Token(Token = "0x60028BA"), Address(RVA = "0x36789D4", Offset = "0x36789D4", VA = "0x36789D4")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17000604")]
    public IReadOnlyList<int> PlayerSelectedList
    {
      [Token(Token = "0x60028BB"), Address(RVA = "0x36789DC", Offset = "0x36789DC", VA = "0x36789DC")] get
      {
        return (IReadOnlyList<int>) null;
      }
    }

    [Token(Token = "0x17000605")]
    public IReadOnlyList<int> UnlockedOptions
    {
      [Token(Token = "0x60028BC"), Address(RVA = "0x36789E4", Offset = "0x36789E4", VA = "0x36789E4")] get
      {
        return (IReadOnlyList<int>) null;
      }
    }

    [Token(Token = "0x17000606")]
    public IReadOnlyList<int> AlreadyReadChoices
    {
      [Token(Token = "0x60028BD"), Address(RVA = "0x36789EC", Offset = "0x36789EC", VA = "0x36789EC")] get
      {
        return (IReadOnlyList<int>) null;
      }
    }

    [Token(Token = "0x17000607")]
    public Adv2LuaNetworkConnection Connection
    {
      [Token(Token = "0x60028BE"), Address(RVA = "0x36789F4", Offset = "0x36789F4", VA = "0x36789F4")] get
      {
        return (Adv2LuaNetworkConnection) null;
      }
      [Token(Token = "0x60028BF"), Address(RVA = "0x36789FC", Offset = "0x36789FC", VA = "0x36789FC")] set
      {
      }
    }

    [Token(Token = "0x60028C0")]
    [Address(RVA = "0x367864C", Offset = "0x367864C", VA = "0x367864C")]
    public AdvStageBase(AdvDemoInfoData demoInfo)
    {
    }

    [Token(Token = "0x60028C1")]
    [Address(RVA = "0x3678A2C", Offset = "0x3678A2C", VA = "0x3678A2C", Slot = "4")]
    public virtual void OnStart()
    {
    }

    [Token(Token = "0x60028C2")]
    [Address(RVA = "0x3678ADC", Offset = "0x3678ADC", VA = "0x3678ADC", Slot = "5")]
    public virtual void OnAbort()
    {
    }

    [Token(Token = "0x60028C3")]
    [Address(RVA = "0x3678AE0", Offset = "0x3678AE0", VA = "0x3678AE0")]
    public void Destroy()
    {
    }

    [Token(Token = "0x60028C4")]
    [Address(RVA = "0x3678AEC", Offset = "0x3678AEC", VA = "0x3678AEC", Slot = "6")]
    public virtual void OnDestroy()
    {
    }

    [Token(Token = "0x60028C5")]
    [Address(RVA = "0x3678BD8", Offset = "0x3678BD8", VA = "0x3678BD8")]
    public bool IsBusy() => new bool();

    [Token(Token = "0x60028C6")]
    [Address(RVA = "0x3678BE0", Offset = "0x3678BE0", VA = "0x3678BE0")]
    public void ForceBusyOff()
    {
    }

    [Token(Token = "0x60028C7")]
    [Address(RVA = "0x3678BE8", Offset = "0x3678BE8", VA = "0x3678BE8")]
    public void SendPlayerSelected(int id)
    {
    }

    [Token(Token = "0x60028C8")]
    [Address(RVA = "0x3678C90", Offset = "0x3678C90", VA = "0x3678C90")]
    public void SendPlayerSelectedOptionOneID(int optionOneId)
    {
    }

    [Token(Token = "0x60028C9")]
    [Address(RVA = "0x3678D38", Offset = "0x3678D38", VA = "0x3678D38")]
    public void AddUnlockedOptions(int unlockedOptionId)
    {
    }

    [Token(Token = "0x60028CA")]
    [Address(RVA = "0x3678DE0", Offset = "0x3678DE0", VA = "0x3678DE0")]
    public void AddAlreadyReadChoices(int choicesId)
    {
    }

    [Token(Token = "0x200074A")]
    public class ProccessSignal : Adv2Manager.OnProccessSignal
    {
      [Token(Token = "0x400218D")]
      [FieldOffset(Offset = "0x18")]
      private AdvStageBase parent;

      [Token(Token = "0x60028CB")]
      [Address(RVA = "0x3678A04", Offset = "0x3678A04", VA = "0x3678A04")]
      public ProccessSignal(AdvStageBase advStage)
      {
      }

      [Token(Token = "0x60028CC")]
      [Address(RVA = "0x3678E88", Offset = "0x3678E88", VA = "0x3678E88", Slot = "4")]
      public override void SetProccessing(bool value)
      {
      }
    }
  }
}
