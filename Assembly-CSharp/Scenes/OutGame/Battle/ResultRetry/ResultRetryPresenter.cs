// Decompiled with JetBrains decompiler
// Type: Scenes.OutGame.Battle.ResultRetry.ResultRetryPresenter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore;
using GameCore.MasterData;
using Il2CppDummyDll;
using Scenes.OutGame.APRecovery;
using Scenes.OutGame.LimitedEventQuest;
using System;
using UnityEngine;

#nullable disable
namespace Scenes.OutGame.Battle.ResultRetry
{
  [Token(Token = "0x20037C3")]
  public class ResultRetryPresenter : MonoBehaviour
  {
    [Token(Token = "0x400F3BA")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private ResultRetryView _view;
    [Token(Token = "0x400F3BB")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private ApRecoveryHeader _apHeader;
    [Token(Token = "0x400F3BC")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private StaminaItemPopUpButton _epHeader;
    [Token(Token = "0x400F3BD")]
    [FieldOffset(Offset = "0x30")]
    private ResultRetryModel _model;

    [Token(Token = "0x6015F2C")]
    [Address(RVA = "0x232B0A0", Offset = "0x232B0A0", VA = "0x232B0A0")]
    public bool Initialize(AssetCachedSpawner spawner, int questId, QuestTypeEnum questType)
    {
      return new bool();
    }

    [Token(Token = "0x6015F2D")]
    [Address(RVA = "0x232B4C8", Offset = "0x232B4C8", VA = "0x232B4C8")]
    public void SetClickCallback(Action<Action> callback)
    {
    }

    [Token(Token = "0x6015F2E")]
    [Address(RVA = "0x232B1BC", Offset = "0x232B1BC", VA = "0x232B1BC")]
    private void SetupHeader(AssetCachedSpawner spawner)
    {
    }

    [Token(Token = "0x6015F2F")]
    [Address(RVA = "0x232B240", Offset = "0x232B240", VA = "0x232B240")]
    private void SetupConsumeCost(AssetCachedSpawner spawner)
    {
    }

    [Token(Token = "0x6015F30")]
    [Address(RVA = "0x232B30C", Offset = "0x232B30C", VA = "0x232B30C")]
    private void SetupButtons()
    {
    }

    [Token(Token = "0x6015F31")]
    [Address(RVA = "0x232B910", Offset = "0x232B910", VA = "0x232B910")]
    private void OnRetryQuest()
    {
    }

    [Token(Token = "0x6015F32")]
    [Address(RVA = "0x232B9AC", Offset = "0x232B9AC", VA = "0x232B9AC")]
    public ResultRetryPresenter()
    {
    }
  }
}
