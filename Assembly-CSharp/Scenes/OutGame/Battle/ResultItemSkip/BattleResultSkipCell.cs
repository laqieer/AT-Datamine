// Decompiled with JetBrains decompiler
// Type: Scenes.OutGame.Battle.ResultItemSkip.BattleResultSkipCell
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore;
using GameCore.Tween;
using Il2CppDummyDll;
using Scenes.OutGame.Battle.ResultItem;
using System;
using System.Collections.Generic;
using TMPro;
using UI.ItemDetail;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace Scenes.OutGame.Battle.ResultItemSkip
{
  [Token(Token = "0x20037CD")]
  public class BattleResultSkipCell : MonoBehaviour
  {
    [Token(Token = "0x400F3DD")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private UITweenGroup _tween;
    [Token(Token = "0x400F3DE")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private Text _title;
    [Token(Token = "0x400F3DF")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private BattleResultSkipCell.Bonus _bonus;
    [Token(Token = "0x400F3E0")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    private Text _zenyText;
    [Token(Token = "0x400F3E1")]
    [FieldOffset(Offset = "0x38")]
    [SerializeField]
    private BattleResultItemCell _cellBase;
    [Token(Token = "0x400F3E2")]
    [FieldOffset(Offset = "0x40")]
    private List<BattleResultItemCell> _cells;

    [Token(Token = "0x6015F62")]
    [Address(RVA = "0x232C218", Offset = "0x232C218", VA = "0x232C218")]
    private void Awake()
    {
    }

    [Token(Token = "0x6015F63")]
    [Address(RVA = "0x232C244", Offset = "0x232C244", VA = "0x232C244")]
    public void Initialize(
      AssetCachedSpawner spawner,
      SkipRewardModel model,
      ItemDetailPopupProvider itemDetailPopupProvider,
      int skipNo)
    {
    }

    [Token(Token = "0x6015F64")]
    [Address(RVA = "0x232C8DC", Offset = "0x232C8DC", VA = "0x232C8DC")]
    public void PlayIn()
    {
    }

    [Token(Token = "0x6015F65")]
    [Address(RVA = "0x232CA84", Offset = "0x232CA84", VA = "0x232CA84")]
    public BattleResultSkipCell()
    {
    }

    [Token(Token = "0x20037CE")]
    [Serializable]
    private class Bonus
    {
      [Token(Token = "0x400F3E3")]
      [FieldOffset(Offset = "0x10")]
      [SerializeField]
      private GameObject root;
      [Token(Token = "0x400F3E4")]
      [FieldOffset(Offset = "0x18")]
      [SerializeField]
      private TextMeshProUGUI valueText;

      [Token(Token = "0x6015F66")]
      [Address(RVA = "0x232C65C", Offset = "0x232C65C", VA = "0x232C65C")]
      public void SetBonus(int value)
      {
      }

      [Token(Token = "0x6015F67")]
      [Address(RVA = "0x232CA8C", Offset = "0x232CA8C", VA = "0x232CA8C")]
      public Bonus()
      {
      }
    }
  }
}
