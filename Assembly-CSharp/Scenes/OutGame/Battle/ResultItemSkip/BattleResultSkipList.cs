// Decompiled with JetBrains decompiler
// Type: Scenes.OutGame.Battle.ResultItemSkip.BattleResultSkipList
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore;
using Il2CppDummyDll;
using System;
using System.Collections;
using System.Collections.Generic;
using UI.ItemDetail;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace Scenes.OutGame.Battle.ResultItemSkip
{
  [Token(Token = "0x20037CF")]
  public class BattleResultSkipList : MonoBehaviour
  {
    [Token(Token = "0x400F3E5")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private BattleResultSkipCell _cellBase;
    [Token(Token = "0x400F3E6")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private GameObject _separator;
    [Token(Token = "0x400F3E7")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private CanvasGroup _canvas;
    [Token(Token = "0x400F3E8")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    private ScrollRect _scrollRect;
    [Token(Token = "0x400F3E9")]
    [FieldOffset(Offset = "0x38")]
    private List<BattleResultSkipCell> _cells;

    [Token(Token = "0x6015F68")]
    [Address(RVA = "0x232CA94", Offset = "0x232CA94", VA = "0x232CA94")]
    private void Awake()
    {
    }

    [Token(Token = "0x6015F69")]
    [Address(RVA = "0x232CAD8", Offset = "0x232CAD8", VA = "0x232CAD8")]
    public void Initialize(
      AssetCachedSpawner spawner,
      ResultItemSkipModel model,
      ItemDetailPopupProvider itemDetailPopupProvider)
    {
    }

    [Token(Token = "0x6015F6A")]
    [Address(RVA = "0x232D24C", Offset = "0x232D24C", VA = "0x232D24C")]
    public IEnumerator PlayIn(Func<bool> skip) => (IEnumerator) null;

    [Token(Token = "0x6015F6B")]
    [Address(RVA = "0x232CC3C", Offset = "0x232CC3C", VA = "0x232CC3C")]
    private BattleResultSkipCell CreateCell() => (BattleResultSkipCell) null;

    [Token(Token = "0x6015F6C")]
    [Address(RVA = "0x232CD78", Offset = "0x232CD78", VA = "0x232CD78")]
    private GameObject CreateSeparator() => (GameObject) null;

    [Token(Token = "0x6015F6D")]
    [Address(RVA = "0x232D2E8", Offset = "0x232D2E8", VA = "0x232D2E8")]
    public BattleResultSkipList()
    {
    }
  }
}
