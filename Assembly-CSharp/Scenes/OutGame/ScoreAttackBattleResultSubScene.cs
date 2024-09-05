// Decompiled with JetBrains decompiler
// Type: Scenes.OutGame.ScoreAttackBattleResultSubScene
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Battle.Data.Board;
using Battle.ScoreAttack;
using GameCore.MasterData;
using GameCore.Scene;
using Il2CppDummyDll;
using Network.API;
using Network.Param;
using ScenarioQuest.ScoreAttack;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

#nullable disable
namespace Scenes.OutGame
{
  [Token(Token = "0x20031BB")]
  public class ScoreAttackBattleResultSubScene : SubScene
  {
    [Token(Token = "0x400D3D8")]
    [FieldOffset(Offset = "0x58")]
    private ScoreAttackBattleResultSubScene.Parameter sceneParameter;
    [Token(Token = "0x400D3D9")]
    [FieldOffset(Offset = "0x60")]
    [SerializeField]
    private ScoreAttackResultView view;
    [Token(Token = "0x400D3DA")]
    [FieldOffset(Offset = "0x68")]
    private Result _result;
    [Token(Token = "0x400D3DB")]
    [FieldOffset(Offset = "0x70")]
    private PlayerScoreAttackResultScoreType _scoreData;
    [Token(Token = "0x400D3DC")]
    [FieldOffset(Offset = "0x78")]
    private APIScoreAttackBattleEndResponse _response;
    [Token(Token = "0x400D3DD")]
    [FieldOffset(Offset = "0x80")]
    private ScoreType _type;
    [Token(Token = "0x400D3DE")]
    [FieldOffset(Offset = "0x84")]
    private bool _isRequestSuccess;

    [Token(Token = "0x601366B")]
    [Address(RVA = "0x4E05760", Offset = "0x4E05760", VA = "0x4E05760")]
    public static void ChangeScene(
      ScoreAttackBattleResultSubScene.Parameter parameter)
    {
    }

    [Token(Token = "0x601366C")]
    [Address(RVA = "0x4E0589C", Offset = "0x4E0589C", VA = "0x4E0589C")]
    public static void ChangeSubScene(
      ScoreAttackBattleResultSubScene.Parameter parameter)
    {
    }

    [Token(Token = "0x601366D")]
    [Address(RVA = "0x4E05940", Offset = "0x4E05940", VA = "0x4E05940")]
    public static void ChangeSubSceneFromProfile(
      ScoreAttackBattleResultSubScene.PlayerParameter parameter)
    {
    }

    [Token(Token = "0x601366E")]
    [Address(RVA = "0x4E059E4", Offset = "0x4E059E4", VA = "0x4E059E4", Slot = "6")]
    public override void Initialize(ChangeSceneParameter param = null)
    {
    }

    [Token(Token = "0x601366F")]
    [Address(RVA = "0x4E065E4", Offset = "0x4E065E4", VA = "0x4E065E4", Slot = "7")]
    public override IEnumerator InitializeAsync() => (IEnumerator) null;

    [Token(Token = "0x6013670")]
    [Address(RVA = "0x4E06674", Offset = "0x4E06674", VA = "0x4E06674", Slot = "21")]
    public override IEnumerator EnableEffect() => (IEnumerator) null;

    [Token(Token = "0x6013671")]
    [Address(RVA = "0x4E06704", Offset = "0x4E06704", VA = "0x4E06704", Slot = "22")]
    public override IEnumerator DisableEffect() => (IEnumerator) null;

    [Token(Token = "0x6013672")]
    [Address(RVA = "0x4E06794", Offset = "0x4E06794", VA = "0x4E06794")]
    private void FadeIn()
    {
    }

    [Token(Token = "0x6013673")]
    [Address(RVA = "0x4E06814", Offset = "0x4E06814", VA = "0x4E06814")]
    private void UpdateRuntime(APIScoreAttackBattleEndResponse response)
    {
    }

    [Token(Token = "0x6013674")]
    [Address(RVA = "0x4E05AEC", Offset = "0x4E05AEC", VA = "0x4E05AEC")]
    private Result CreateResult(
      ScoreAttackBattleResultSubScene.Parameter sceneParameter)
    {
      return (Result) null;
    }

    [Token(Token = "0x6013675")]
    [Address(RVA = "0x4E06430", Offset = "0x4E06430", VA = "0x4E06430")]
    private PlayerScoreAttackResultScoreType CreateScore(
      Result result,
      ScoreAttackBattleResultSubScene.Parameter sceneParameter)
    {
      return (PlayerScoreAttackResultScoreType) null;
    }

    [Token(Token = "0x6013676")]
    [Address(RVA = "0x4E06A50", Offset = "0x4E06A50", VA = "0x4E06A50")]
    public ScoreAttackBattleResultSubScene()
    {
    }

    [Token(Token = "0x20031BC")]
    public sealed class Parameter : ChangeSceneParameter
    {
      [Token(Token = "0x400D3DF")]
      [FieldOffset(Offset = "0x18")]
      public string battleUuid;
      [Token(Token = "0x400D3E0")]
      [FieldOffset(Offset = "0x20")]
      public int questid;
      [Token(Token = "0x400D3E1")]
      [FieldOffset(Offset = "0x28")]
      public List<int> achieved_mission_ids;
      [Token(Token = "0x400D3E2")]
      [FieldOffset(Offset = "0x30")]
      public QuestTypeEnum questType;
      [Token(Token = "0x400D3E3")]
      [FieldOffset(Offset = "0x34")]
      public int deckIdx;
      [Token(Token = "0x400D3E4")]
      [FieldOffset(Offset = "0x38")]
      public IReadOnlyList<IUnitPlacementData> enemyPlacements;
      [Token(Token = "0x400D3E5")]
      [FieldOffset(Offset = "0x40")]
      public AllocatePoint allocatePoint;
      [Token(Token = "0x400D3E6")]
      [FieldOffset(Offset = "0x48")]
      public BoardData board;
      [Token(Token = "0x400D3E7")]
      [FieldOffset(Offset = "0x50")]
      public bool isFade;

      [Token(Token = "0x601367B")]
      [Address(RVA = "0x4E06B24", Offset = "0x4E06B24", VA = "0x4E06B24")]
      public Parameter()
      {
      }
    }

    [Token(Token = "0x20031BD")]
    public sealed class PlayerParameter : ChangeSceneParameter
    {
      [Token(Token = "0x400D3E8")]
      [FieldOffset(Offset = "0x14")]
      public int thumbnailStyleId;
      [Token(Token = "0x400D3E9")]
      [FieldOffset(Offset = "0x18")]
      public PlayerScoreAttackResultScoreType scoreData;

      [Token(Token = "0x601367C")]
      [Address(RVA = "0x4E06BA4", Offset = "0x4E06BA4", VA = "0x4E06BA4")]
      public PlayerParameter()
      {
      }
    }
  }
}
