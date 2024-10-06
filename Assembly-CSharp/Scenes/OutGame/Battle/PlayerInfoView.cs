// Decompiled with JetBrains decompiler
// Type: Scenes.OutGame.Battle.PlayerInfoView
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.Tween;
using Il2CppDummyDll;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

#nullable disable
namespace Scenes.OutGame.Battle
{
  [Token(Token = "0x2003750")]
  public sealed class PlayerInfoView : ResultViewBase
  {
    [Token(Token = "0x400F197")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private string showName;
    [Token(Token = "0x400F198")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    private string hideName;
    [Token(Token = "0x400F199")]
    [FieldOffset(Offset = "0x38")]
    [SerializeField]
    private string tapOnName;
    [Token(Token = "0x400F19A")]
    [FieldOffset(Offset = "0x40")]
    [SerializeField]
    private UITweenGroup tweenGroup;
    [Token(Token = "0x400F19B")]
    [FieldOffset(Offset = "0x48")]
    [SerializeField]
    private float showResultWaitTime;
    [Token(Token = "0x400F19C")]
    [FieldOffset(Offset = "0x50")]
    [SerializeField]
    private DropItemCell itemCell;
    [Token(Token = "0x400F19D")]
    [FieldOffset(Offset = "0x58")]
    [SerializeField]
    private Transform itemCellParent;
    [Token(Token = "0x400F1A0")]
    [FieldOffset(Offset = "0x70")]
    private List<DropItemCell> dropItemCells;

    [Token(Token = "0x1400021C")]
    public event UnityAction OnClickAction
    {
      [Token(Token = "0x6015C7E"), Address(RVA = "0x1B2AC88", Offset = "0x1B2AC88", VA = "0x1B2AC88")] add
      {
      }
      [Token(Token = "0x6015C7F"), Address(RVA = "0x1B2AD24", Offset = "0x1B2AD24", VA = "0x1B2AD24")] remove
      {
      }
    }

    [Token(Token = "0x1400021D")]
    public event UnityAction OnRetryAction
    {
      [Token(Token = "0x6015C80"), Address(RVA = "0x1B2ADC0", Offset = "0x1B2ADC0", VA = "0x1B2ADC0")] add
      {
      }
      [Token(Token = "0x6015C81"), Address(RVA = "0x1B2AE5C", Offset = "0x1B2AE5C", VA = "0x1B2AE5C")] remove
      {
      }
    }

    [Token(Token = "0x170047FF")]
    public BattleResultSubScene.Parameter Parameter
    {
      [Token(Token = "0x6015C82"), Address(RVA = "0x1B2AEF8", Offset = "0x1B2AEF8", VA = "0x1B2AEF8")] get
      {
        return (BattleResultSubScene.Parameter) null;
      }
      [Token(Token = "0x6015C83"), Address(RVA = "0x1B2AF00", Offset = "0x1B2AF00", VA = "0x1B2AF00")] set
      {
      }
    }

    [Token(Token = "0x6015C84")]
    [Address(RVA = "0x1B2AF08", Offset = "0x1B2AF08", VA = "0x1B2AF08")]
    public void Initialize(BattleResultSubScene subScene, ResultData.ItemData[] dropItemList)
    {
    }

    [Token(Token = "0x6015C85")]
    [Address(RVA = "0x1B2B08C", Offset = "0x1B2B08C", VA = "0x1B2B08C", Slot = "6")]
    public override void Play()
    {
    }

    [Token(Token = "0x6015C86")]
    [Address(RVA = "0x1B2B0EC", Offset = "0x1B2B0EC", VA = "0x1B2B0EC")]
    public void OnClickButton()
    {
    }

    [Token(Token = "0x6015C87")]
    [Address(RVA = "0x1B2B11C", Offset = "0x1B2B11C", VA = "0x1B2B11C")]
    public void OnClickRetryButton()
    {
    }

    [Token(Token = "0x6015C88")]
    [Address(RVA = "0x1B2B14C", Offset = "0x1B2B14C", VA = "0x1B2B14C", Slot = "8")]
    protected override IEnumerator ExecutePlayFlow() => (IEnumerator) null;

    [Token(Token = "0x6015C89")]
    [Address(RVA = "0x1B2B1DC", Offset = "0x1B2B1DC", VA = "0x1B2B1DC")]
    public PlayerInfoView()
    {
    }
  }
}
