// Decompiled with JetBrains decompiler
// Type: Scenes.Home.HomeScene
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.MasterData;
using GameCore.Scene;
using GameCore.Sound;
using Home;
using Il2CppDummyDll;
using Scenes.OutGame;
using Scenes.OutGame.QuestContentsList;
using Story.StoryArchive;
using System;
using UnityEngine;

#nullable disable
namespace Scenes.Home
{
  [Token(Token = "0x2002AD3")]
  public class HomeScene : GameCore.Scene.Scene, ILoginBonus3DEffectPlayer, IHome3DEffectPlayer
  {
    [Token(Token = "0x400B63C")]
    [FieldOffset(Offset = "0x58")]
    [SerializeField]
    private HomeManager homeManager;
    [Token(Token = "0x400B63D")]
    [FieldOffset(Offset = "0x60")]
    private SoundManager soundManager;

    [Token(Token = "0x6010BD4")]
    [Address(RVA = "0x4BDA5FC", Offset = "0x4BDA5FC", VA = "0x4BDA5FC")]
    public static void ChangeScene(HomeScene.Parameter param, bool isContinueSound = false)
    {
    }

    [Token(Token = "0x6010BD5")]
    [Address(RVA = "0x4BDA6D4", Offset = "0x4BDA6D4", VA = "0x4BDA6D4")]
    public static void TryBackToHome()
    {
    }

    [Token(Token = "0x6010BD6")]
    [Address(RVA = "0x4BDA940", Offset = "0x4BDA940", VA = "0x4BDA940", Slot = "6")]
    public override void Initialize(ChangeSceneParameter param = null)
    {
    }

    [Token(Token = "0x6010BD7")]
    [Address(RVA = "0x4BDAB08", Offset = "0x4BDAB08", VA = "0x4BDAB08", Slot = "9")]
    public override void Destroy()
    {
    }

    [Token(Token = "0x6010BD8")]
    [Address(RVA = "0x4BDAB94", Offset = "0x4BDAB94", VA = "0x4BDAB94", Slot = "24")]
    public void PlayHomeEnterEffect(Action onComplete)
    {
    }

    [Token(Token = "0x6010BD9")]
    [Address(RVA = "0x4BDAC3C", Offset = "0x4BDAC3C", VA = "0x4BDAC3C", Slot = "23")]
    public void PlayLoginBonusEffect(Action onComplete)
    {
    }

    [Token(Token = "0x6010BDA")]
    [Address(RVA = "0x4BDACE4", Offset = "0x4BDACE4", VA = "0x4BDACE4")]
    public HomeScene()
    {
    }

    [Token(Token = "0x2002AD4")]
    public sealed class Parameter : ChangeSceneParameter
    {
      [Token(Token = "0x400B63E")]
      [FieldOffset(Offset = "0x14")]
      public HomeScene.Parameter.FromBattleResultParam? FromBattleResult;
      [Token(Token = "0x400B63F")]
      [FieldOffset(Offset = "0x28")]
      public ScoreAttackBattleResultSubScene.Parameter ScoreAttackParam;
      [Token(Token = "0x400B640")]
      [FieldOffset(Offset = "0x30")]
      public StoryArchiveSubScene.Parameter StoryArchiveTransitionParameter;
      [Token(Token = "0x400B641")]
      [FieldOffset(Offset = "0x38")]
      public QuestContentsListSubScene.Parameter QuestContentsListParameter;

      [Token(Token = "0x6010BDB")]
      [Address(RVA = "0x4BDACEC", Offset = "0x4BDACEC", VA = "0x4BDACEC")]
      public Parameter()
      {
      }

      [Token(Token = "0x2002AD5")]
      public readonly struct FromBattleResultParam
      {
        [Token(Token = "0x400B642")]
        [FieldOffset(Offset = "0x0")]
        public readonly QuestTypeEnum questType;
        [Token(Token = "0x400B643")]
        [FieldOffset(Offset = "0x4")]
        public readonly int questId;
        [Token(Token = "0x400B644")]
        [FieldOffset(Offset = "0x8")]
        public readonly bool isChangeToQuestPrepare;

        [Token(Token = "0x6010BDC")]
        [Address(RVA = "0x4BDACF8", Offset = "0x4BDACF8", VA = "0x4BDACF8")]
        public FromBattleResultParam(
          QuestTypeEnum questType,
          int questId,
          bool isChangeToQuestPrepare)
        {
        }
      }
    }
  }
}
