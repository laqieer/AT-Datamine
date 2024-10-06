// Decompiled with JetBrains decompiler
// Type: Battle.UI.Rewind.BattleRewindManager
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Battle.Data.Board;
using Battle.Process;
using Il2CppDummyDll;
using Network.API;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

#nullable disable
namespace Battle.UI.Rewind
{
  [Token(Token = "0x200244B")]
  public class BattleRewindManager : IDisposable
  {
    [Token(Token = "0x4009B9D")]
    [FieldOffset(Offset = "0x20")]
    private BattleRewindPanel battleRewindPanel;
    [Token(Token = "0x4009B9E")]
    [FieldOffset(Offset = "0x28")]
    private bool disposed;
    [Token(Token = "0x4009B9F")]
    [FieldOffset(Offset = "0x30")]
    private List<BoardData> backUpBoards;
    [Token(Token = "0x4009BA0")]
    [FieldOffset(Offset = "0x38")]
    private List<int> backUpBoardIndexes;
    [Token(Token = "0x4009BA1")]
    [FieldOffset(Offset = "0x40")]
    private int selectIndex;
    [Token(Token = "0x4009BA3")]
    [FieldOffset(Offset = "0x50")]
    private bool serverRequestSuccess;
    [Token(Token = "0x4009BA6")]
    [FieldOffset(Offset = "0x53")]
    private bool FreeMode;
    [Token(Token = "0x4009BA7")]
    [FieldOffset(Offset = "0x54")]
    private int allCoin;
    [Token(Token = "0x4009BA8")]
    [FieldOffset(Offset = "0x58")]
    private int paidCoin;
    [Token(Token = "0x4009BA9")]
    [FieldOffset(Offset = "0x5C")]
    private int freeCoin;
    [Token(Token = "0x4009BAA")]
    [FieldOffset(Offset = "0x60")]
    private int afterPaidCoin;
    [Token(Token = "0x4009BAB")]
    [FieldOffset(Offset = "0x64")]
    private int afterFreeCoin;
    [Token(Token = "0x4009BAC")]
    [FieldOffset(Offset = "0x68")]
    private int needCoin;
    [Token(Token = "0x4009BAD")]
    [FieldOffset(Offset = "0x6C")]
    private int freeRollbackLeftCount;

    [Token(Token = "0x17002FB6")]
    public BattleRewindManager.PanelType PrevPanelType
    {
      [Token(Token = "0x600DE6A"), Address(RVA = "0x1E320E8", Offset = "0x1E320E8", VA = "0x1E320E8")] get
      {
        return new BattleRewindManager.PanelType();
      }
      [Token(Token = "0x600DE6B"), Address(RVA = "0x1E320F0", Offset = "0x1E320F0", VA = "0x1E320F0")] private set
      {
      }
    }

    [Token(Token = "0x17002FB7")]
    public BattleRewindManager.PanelType NowPanelType
    {
      [Token(Token = "0x600DE6C"), Address(RVA = "0x1E320F8", Offset = "0x1E320F8", VA = "0x1E320F8")] get
      {
        return new BattleRewindManager.PanelType();
      }
      [Token(Token = "0x600DE6D"), Address(RVA = "0x1E32100", Offset = "0x1E32100", VA = "0x1E32100")] private set
      {
      }
    }

    [Token(Token = "0x17002FB8")]
    public BattleRewindManager.PanelType RootPanelType
    {
      [Token(Token = "0x600DE6E"), Address(RVA = "0x1E32108", Offset = "0x1E32108", VA = "0x1E32108")] get
      {
        return new BattleRewindManager.PanelType();
      }
      [Token(Token = "0x600DE6F"), Address(RVA = "0x1E32110", Offset = "0x1E32110", VA = "0x1E32110")] private set
      {
      }
    }

    [Token(Token = "0x17002FB9")]
    public BattleRewindPanel BattleRewindPanel
    {
      [Token(Token = "0x600DE70"), Address(RVA = "0x1E32118", Offset = "0x1E32118", VA = "0x1E32118")] get
      {
        return (BattleRewindPanel) null;
      }
    }

    [Token(Token = "0x17002FBA")]
    public IRewindPanelEventHandler EventHandler
    {
      [Token(Token = "0x600DE71"), Address(RVA = "0x1E32120", Offset = "0x1E32120", VA = "0x1E32120")] get
      {
        return (IRewindPanelEventHandler) null;
      }
      [Token(Token = "0x600DE72"), Address(RVA = "0x1E32128", Offset = "0x1E32128", VA = "0x1E32128")] private set
      {
      }
    }

    [Token(Token = "0x17002FBB")]
    public bool IsOpened
    {
      [Token(Token = "0x600DE73"), Address(RVA = "0x1E32130", Offset = "0x1E32130", VA = "0x1E32130")] get
      {
        return new bool();
      }
      [Token(Token = "0x600DE74"), Address(RVA = "0x1E32138", Offset = "0x1E32138", VA = "0x1E32138")] private set
      {
      }
    }

    [Token(Token = "0x17002FBC")]
    public bool IsExecuted
    {
      [Token(Token = "0x600DE75"), Address(RVA = "0x1E32144", Offset = "0x1E32144", VA = "0x1E32144")] get
      {
        return new bool();
      }
      [Token(Token = "0x600DE76"), Address(RVA = "0x1E3214C", Offset = "0x1E3214C", VA = "0x1E3214C")] private set
      {
      }
    }

    [Token(Token = "0x17002FBD")]
    public int AllCoin
    {
      [Token(Token = "0x600DE77"), Address(RVA = "0x1E32158", Offset = "0x1E32158", VA = "0x1E32158")] get
      {
        return new int();
      }
      [Token(Token = "0x600DE78"), Address(RVA = "0x1E32160", Offset = "0x1E32160", VA = "0x1E32160")] private set
      {
      }
    }

    [Token(Token = "0x17002FBE")]
    public int PaidCoin
    {
      [Token(Token = "0x600DE79"), Address(RVA = "0x1E321D8", Offset = "0x1E321D8", VA = "0x1E321D8")] get
      {
        return new int();
      }
      [Token(Token = "0x600DE7A"), Address(RVA = "0x1E321E0", Offset = "0x1E321E0", VA = "0x1E321E0")] private set
      {
      }
    }

    [Token(Token = "0x17002FBF")]
    public int FreeCoin
    {
      [Token(Token = "0x600DE7B"), Address(RVA = "0x1E32258", Offset = "0x1E32258", VA = "0x1E32258")] get
      {
        return new int();
      }
      [Token(Token = "0x600DE7C"), Address(RVA = "0x1E32260", Offset = "0x1E32260", VA = "0x1E32260")] private set
      {
      }
    }

    [Token(Token = "0x17002FC0")]
    public int AfterPaidCoin
    {
      [Token(Token = "0x600DE7D"), Address(RVA = "0x1E322D8", Offset = "0x1E322D8", VA = "0x1E322D8")] get
      {
        return new int();
      }
      [Token(Token = "0x600DE7E"), Address(RVA = "0x1E322E0", Offset = "0x1E322E0", VA = "0x1E322E0")] private set
      {
      }
    }

    [Token(Token = "0x17002FC1")]
    public int AfterFreeCoin
    {
      [Token(Token = "0x600DE7F"), Address(RVA = "0x1E32358", Offset = "0x1E32358", VA = "0x1E32358")] get
      {
        return new int();
      }
      [Token(Token = "0x600DE80"), Address(RVA = "0x1E32360", Offset = "0x1E32360", VA = "0x1E32360")] private set
      {
      }
    }

    [Token(Token = "0x17002FC2")]
    public bool IsEnablePaymentCoin
    {
      [Token(Token = "0x600DE81"), Address(RVA = "0x1E323D8", Offset = "0x1E323D8", VA = "0x1E323D8")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17002FC3")]
    public int NeedCoin
    {
      [Token(Token = "0x600DE82"), Address(RVA = "0x1E323F0", Offset = "0x1E323F0", VA = "0x1E323F0")] get
      {
        return new int();
      }
      [Token(Token = "0x600DE83"), Address(RVA = "0x1E323F8", Offset = "0x1E323F8", VA = "0x1E323F8")] private set
      {
      }
    }

    [Token(Token = "0x17002FC4")]
    public int FreeRollbackLeftCount
    {
      [Token(Token = "0x600DE84"), Address(RVA = "0x1E3248C", Offset = "0x1E3248C", VA = "0x1E3248C")] get
      {
        return new int();
      }
      [Token(Token = "0x600DE85"), Address(RVA = "0x1E32494", Offset = "0x1E32494", VA = "0x1E32494")] private set
      {
      }
    }

    [Token(Token = "0x17002FC5")]
    public bool IsFreeRweind
    {
      [Token(Token = "0x600DE86"), Address(RVA = "0x1E3257C", Offset = "0x1E3257C", VA = "0x1E3257C")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x600DE87")]
    [Address(RVA = "0x1E3259C", Offset = "0x1E3259C", VA = "0x1E3259C")]
    public BattleRewindManager(BattleRewindPanel controller)
    {
    }

    [Token(Token = "0x600DE88")]
    [Address(RVA = "0x1E3263C", Offset = "0x1E3263C", VA = "0x1E3263C", Slot = "4")]
    public void Dispose()
    {
    }

    [Token(Token = "0x600DE89")]
    [Address(RVA = "0x1E3268C", Offset = "0x1E3268C", VA = "0x1E3268C")]
    public IEnumerator Initialize(
      BattleCore core,
      bool freeMode,
      Dictionary<int, Sprite> unitThumbnailSprites)
    {
      return (IEnumerator) null;
    }

    [Token(Token = "0x600DE8A")]
    [Address(RVA = "0x1E3271C", Offset = "0x1E3271C", VA = "0x1E3271C")]
    public void ResetParameter()
    {
    }

    [Token(Token = "0x600DE8B")]
    [Address(RVA = "0x1E3272C", Offset = "0x1E3272C", VA = "0x1E3272C")]
    public void SetOpenedPanelStatus(BattleRewindManager.PanelType type)
    {
    }

    [Token(Token = "0x600DE8C")]
    [Address(RVA = "0x1E3273C", Offset = "0x1E3273C", VA = "0x1E3273C")]
    public void SetBackUpPanelStatus(BattleRewindManager.PanelType type)
    {
    }

    [Token(Token = "0x600DE8D")]
    [Address(RVA = "0x1E32748", Offset = "0x1E32748", VA = "0x1E32748")]
    public void Show(BattleRewindManager.PanelType panelType, BattleCore core)
    {
    }

    [Token(Token = "0x600DE8E")]
    [Address(RVA = "0x1E32918", Offset = "0x1E32918", VA = "0x1E32918")]
    public void SetEventHandler(IRewindPanelEventHandler handler)
    {
    }

    [Token(Token = "0x600DE8F")]
    [Address(RVA = "0x1E32660", Offset = "0x1E32660", VA = "0x1E32660")]
    public void ReleaseEventHandler()
    {
    }

    [Token(Token = "0x600DE90")]
    [Address(RVA = "0x1E32A0C", Offset = "0x1E32A0C", VA = "0x1E32A0C")]
    public void SetScrollNormalizedPositionY(float speed)
    {
    }

    [Token(Token = "0x600DE91")]
    [Address(RVA = "0x1E32A68", Offset = "0x1E32A68", VA = "0x1E32A68")]
    public float GetScrollNormalizedPositionY() => new float();

    [Token(Token = "0x600DE92")]
    [Address(RVA = "0x1E32A94", Offset = "0x1E32A94", VA = "0x1E32A94")]
    public void Update(
      BattleRewindManager.PanelType panelType,
      BattleCore core,
      List<UnitParameterData> dieUnits = null)
    {
    }

    [Token(Token = "0x600DE93")]
    [Address(RVA = "0x1E330A8", Offset = "0x1E330A8", VA = "0x1E330A8")]
    public IEnumerator RewindExecute() => (IEnumerator) null;

    [Token(Token = "0x600DE94")]
    [Address(RVA = "0x1E33110", Offset = "0x1E33110", VA = "0x1E33110")]
    public void RewindPanelSet()
    {
    }

    [Token(Token = "0x600DE95")]
    [Address(RVA = "0x1E33204", Offset = "0x1E33204", VA = "0x1E33204")]
    private void SetBoardTouchEvent(int index)
    {
    }

    [Token(Token = "0x600DE96")]
    [Address(RVA = "0x1E32F14", Offset = "0x1E32F14", VA = "0x1E32F14")]
    private void CalcPaymentCoin(int needCoin)
    {
    }

    [Token(Token = "0x600DE97")]
    [Address(RVA = "0x1E33084", Offset = "0x1E33084", VA = "0x1E33084")]
    private void UpdateEnableNormalRollbackButton(int logAmount)
    {
    }

    [Token(Token = "0x600DE98")]
    [Address(RVA = "0x1E332C8", Offset = "0x1E332C8", VA = "0x1E332C8")]
    public void OnSelectRollbackTo()
    {
    }

    [Token(Token = "0x600DE99")]
    [Address(RVA = "0x1E32FDC", Offset = "0x1E32FDC", VA = "0x1E32FDC")]
    private void CreateLog()
    {
    }

    [Token(Token = "0x600DE9A")]
    [Address(RVA = "0x1E33068", Offset = "0x1E33068", VA = "0x1E33068")]
    private void DeleteLog(int index)
    {
    }

    [Token(Token = "0x600DE9B")]
    [Address(RVA = "0x1E33374", Offset = "0x1E33374", VA = "0x1E33374")]
    public void SetBattleLogSimplifiedText(string log)
    {
    }

    [Token(Token = "0x600DE9C")]
    [Address(RVA = "0x1E33398", Offset = "0x1E33398", VA = "0x1E33398")]
    public void SetOpenBattleLogButtonEvent(UnityAction callback)
    {
    }

    [Token(Token = "0x600DE9D")]
    [Address(RVA = "0x1E333BC", Offset = "0x1E333BC", VA = "0x1E333BC")]
    public void ShowSimpleBattleLog()
    {
    }

    [Token(Token = "0x600DE9E")]
    [Address(RVA = "0x1E333E0", Offset = "0x1E333E0", VA = "0x1E333E0")]
    public void HideSimpleBattleLog()
    {
    }

    [Token(Token = "0x600DE9F")]
    [Address(RVA = "0x1E33404", Offset = "0x1E33404", VA = "0x1E33404")]
    private IEnumerator ServerRequest() => (IEnumerator) null;

    [Token(Token = "0x600DEA0")]
    [Address(RVA = "0x1E3346C", Offset = "0x1E3346C", VA = "0x1E3346C")]
    private IEnumerator ServerConnectWait(APIBattleRollback api) => (IEnumerator) null;

    [Token(Token = "0x600DEA1")]
    [Address(RVA = "0x1E334E0", Offset = "0x1E334E0", VA = "0x1E334E0")]
    private void ServerConnectFinished(APIBattleRollbackResponse response)
    {
    }

    [Token(Token = "0x200244C")]
    public enum PanelType
    {
      [Token(Token = "0x4009BAF")] None,
      [Token(Token = "0x4009BB0")] Normal,
      [Token(Token = "0x4009BB1")] RetreatUnit,
      [Token(Token = "0x4009BB2")] Lose,
      [Token(Token = "0x4009BB3")] Confirm,
    }
  }
}
