// Decompiled with JetBrains decompiler
// Type: Scenes.OutGame.ScenarioQuest.ScoreAttack.ScoreAttackSubScene
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.Scene;
using Il2CppDummyDll;
using ScenarioQuest.ScoreAttack;
using System.Collections;
using UnityEngine;

#nullable disable
namespace Scenes.OutGame.ScenarioQuest.ScoreAttack
{
  [Token(Token = "0x20034FE")]
  public class ScoreAttackSubScene : SubScene
  {
    [Token(Token = "0x400E69C")]
    [FieldOffset(Offset = "0x58")]
    [Header("画面要素")]
    [SerializeField]
    private ScoreAttackView _view;
    [Token(Token = "0x400E69D")]
    [FieldOffset(Offset = "0x60")]
    private ScoreAttackSubScene.Parameter _sceneParam;
    [Token(Token = "0x400E69E")]
    [FieldOffset(Offset = "0x68")]
    private ScoreAttackModel _model;
    [Token(Token = "0x400E69F")]
    [FieldOffset(Offset = "0x70")]
    private bool _isRequestSuccess;

    [Token(Token = "0x6014C9C")]
    [Address(RVA = "0x1D77F24", Offset = "0x1D77F24", VA = "0x1D77F24")]
    public static void ChangeSubScene(int scoreAttackId)
    {
    }

    [Token(Token = "0x6014C9D")]
    [Address(RVA = "0x1D78008", Offset = "0x1D78008", VA = "0x1D78008")]
    public static void ChangeSceneReturnBattle(int questId)
    {
    }

    [Token(Token = "0x6014C9E")]
    [Address(RVA = "0x1D78268", Offset = "0x1D78268", VA = "0x1D78268")]
    public static void ChangeSceneFromResult(int scoreAttackId, int questId)
    {
    }

    [Token(Token = "0x6014C9F")]
    [Address(RVA = "0x1D78350", Offset = "0x1D78350", VA = "0x1D78350", Slot = "6")]
    public override void Initialize(ChangeSceneParameter param = null)
    {
    }

    [Token(Token = "0x6014CA0")]
    [Address(RVA = "0x1D78684", Offset = "0x1D78684", VA = "0x1D78684", Slot = "7")]
    public override IEnumerator InitializeAsync() => (IEnumerator) null;

    [Token(Token = "0x6014CA1")]
    [Address(RVA = "0x1D786EC", Offset = "0x1D786EC", VA = "0x1D786EC", Slot = "23")]
    public override void FinishInitialize(ChangeSceneParameter param)
    {
    }

    [Token(Token = "0x6014CA2")]
    [Address(RVA = "0x1D78714", Offset = "0x1D78714", VA = "0x1D78714", Slot = "24")]
    public override void OnBeforeBackScene()
    {
    }

    [Token(Token = "0x6014CA3")]
    [Address(RVA = "0x1D78718", Offset = "0x1D78718", VA = "0x1D78718", Slot = "25")]
    public override void OnBackScene()
    {
    }

    [Token(Token = "0x6014CA4")]
    [Address(RVA = "0x1D7871C", Offset = "0x1D7871C", VA = "0x1D7871C", Slot = "21")]
    public override IEnumerator EnableEffect() => (IEnumerator) null;

    [Token(Token = "0x6014CA5")]
    [Address(RVA = "0x1D78784", Offset = "0x1D78784", VA = "0x1D78784", Slot = "22")]
    public override IEnumerator DisableEffect() => (IEnumerator) null;

    [Token(Token = "0x6014CA6")]
    [Address(RVA = "0x1D787EC", Offset = "0x1D787EC", VA = "0x1D787EC", Slot = "26")]
    public override IEnumerator OnBackSceneAsync() => (IEnumerator) null;

    [Token(Token = "0x6014CA7")]
    [Address(RVA = "0x1D7859C", Offset = "0x1D7859C", VA = "0x1D7859C")]
    private void Bind()
    {
    }

    [Token(Token = "0x6014CA8")]
    [Address(RVA = "0x1D78854", Offset = "0x1D78854", VA = "0x1D78854")]
    private void OpenRule()
    {
    }

    [Token(Token = "0x6014CA9")]
    [Address(RVA = "0x1D78874", Offset = "0x1D78874", VA = "0x1D78874")]
    private IEnumerator IEOpenRule() => (IEnumerator) null;

    [Token(Token = "0x6014CAA")]
    [Address(RVA = "0x1D788DC", Offset = "0x1D788DC", VA = "0x1D788DC")]
    private void OpenHowTo()
    {
    }

    [Token(Token = "0x6014CAB")]
    [Address(RVA = "0x1D788FC", Offset = "0x1D788FC", VA = "0x1D788FC")]
    private IEnumerator IEOpenHowTo() => (IEnumerator) null;

    [Token(Token = "0x6014CAC")]
    [Address(RVA = "0x1D78964", Offset = "0x1D78964", VA = "0x1D78964")]
    private void Back()
    {
    }

    [Token(Token = "0x6014CAD")]
    [Address(RVA = "0x1D78A30", Offset = "0x1D78A30", VA = "0x1D78A30")]
    private void GotoSortie()
    {
    }

    [Token(Token = "0x6014CAE")]
    [Address(RVA = "0x1D78E44", Offset = "0x1D78E44", VA = "0x1D78E44")]
    private void FadeIn()
    {
    }

    [Token(Token = "0x6014CAF")]
    [Address(RVA = "0x1D78C84", Offset = "0x1D78C84", VA = "0x1D78C84")]
    private bool CheckDailyUpdate() => new bool();

    [Token(Token = "0x6014CB0")]
    [Address(RVA = "0x1D78EC4", Offset = "0x1D78EC4", VA = "0x1D78EC4")]
    public ScoreAttackSubScene()
    {
    }

    [Token(Token = "0x20034FF")]
    public class Parameter : ChangeSceneParameter
    {
      [Token(Token = "0x400E6A2")]
      [FieldOffset(Offset = "0x1C")]
      public bool NeedFadeIn;

      [Token(Token = "0x170044F0")]
      public int ScoreAttackId
      {
        [Token(Token = "0x6014CB3"), Address(RVA = "0x1B36480", Offset = "0x1B36480", VA = "0x1B36480")] get
        {
          return new int();
        }
        [Token(Token = "0x6014CB4"), Address(RVA = "0x1B36488", Offset = "0x1B36488", VA = "0x1B36488")] private set
        {
        }
      }

      [Token(Token = "0x170044F1")]
      public int QuestId
      {
        [Token(Token = "0x6014CB5"), Address(RVA = "0x1B36490", Offset = "0x1B36490", VA = "0x1B36490")] get
        {
          return new int();
        }
        [Token(Token = "0x6014CB6"), Address(RVA = "0x1B36498", Offset = "0x1B36498", VA = "0x1B36498")] private set
        {
        }
      }

      [Token(Token = "0x6014CB7")]
      [Address(RVA = "0x1B364A0", Offset = "0x1B364A0", VA = "0x1B364A0")]
      public Parameter(int scoreAttackId, int questId = 0, bool isFade = false, bool isCreatedBack = false)
      {
      }
    }
  }
}
