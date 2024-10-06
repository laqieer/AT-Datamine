// Decompiled with JetBrains decompiler
// Type: Scenes.OutGame.Battle.ResultItemSkip.ResultItemSkipFlow
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore;
using Il2CppDummyDll;
using System.Collections;
using UI.ItemDetail;
using UnityEngine;

#nullable disable
namespace Scenes.OutGame.Battle.ResultItemSkip
{
  [Token(Token = "0x20037D6")]
  public class ResultItemSkipFlow : IBattleResultFlow
  {
    [Token(Token = "0x400F408")]
    [FieldOffset(Offset = "0x10")]
    private AssetCachedSpawner _assetCachedSpawner;
    [Token(Token = "0x400F409")]
    [FieldOffset(Offset = "0x18")]
    private ItemDetailPopupProvider _itemDetailProvider;
    [Token(Token = "0x400F40A")]
    [FieldOffset(Offset = "0x20")]
    private Transform _parent;
    [Token(Token = "0x400F40B")]
    [FieldOffset(Offset = "0x28")]
    private ResultItemSkipModel _model;

    [Token(Token = "0x6015F92")]
    [Address(RVA = "0x232DDE8", Offset = "0x232DDE8", VA = "0x232DDE8")]
    public ResultItemSkipFlow(
      BattleResultSubScene subScene,
      BattleResultSubScene.Parameter parameter,
      ResultData resultData,
      bool[] missionClear)
    {
    }

    [Token(Token = "0x6015F93")]
    [Address(RVA = "0x232E024", Offset = "0x232E024", VA = "0x232E024", Slot = "4")]
    public IEnumerator PlayAndWait() => (IEnumerator) null;
  }
}
