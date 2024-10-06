// Decompiled with JetBrains decompiler
// Type: Scenes.OutGame.Battle.ResultItemSkip.ResultItemSkipPresenter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore;
using GameCore.Input;
using Il2CppDummyDll;
using Scenes.OutGame.Utility;
using System.Collections;
using UI.ItemDetail;
using UnityEngine;

#nullable disable
namespace Scenes.OutGame.Battle.ResultItemSkip
{
  [Token(Token = "0x20037DC")]
  public class ResultItemSkipPresenter : MonoBehaviour
  {
    [Token(Token = "0x400F41A")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private ResultItemSkipView _view;
    [Token(Token = "0x400F41B")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private BattleResultSkipList _skipList;
    [Token(Token = "0x400F41C")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private InOutFaderBase _inOut;
    [Token(Token = "0x400F41D")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    private BackKeyHandlerComponent backKeyHandlerComponent;
    [Token(Token = "0x400F41E")]
    [FieldOffset(Offset = "0x38")]
    private AssetCachedSpawner _assetCachedSpawner;
    [Token(Token = "0x400F41F")]
    [FieldOffset(Offset = "0x40")]
    private ResultItemSkipModel _model;
    [Token(Token = "0x400F420")]
    [FieldOffset(Offset = "0x48")]
    private bool _isSkip;
    [Token(Token = "0x400F421")]
    [FieldOffset(Offset = "0x49")]
    private bool _canNext;

    [Token(Token = "0x6015FAD")]
    [Address(RVA = "0x232EB0C", Offset = "0x232EB0C", VA = "0x232EB0C")]
    private void Update()
    {
    }

    [Token(Token = "0x6015FAE")]
    [Address(RVA = "0x232E330", Offset = "0x232E330", VA = "0x232E330")]
    public void Initialize(ItemDetailPopupProvider itemDetailProvider, ResultItemSkipModel model)
    {
    }

    [Token(Token = "0x6015FAF")]
    [Address(RVA = "0x232E510", Offset = "0x232E510", VA = "0x232E510")]
    public IEnumerator ExecPlay() => (IEnumerator) null;

    [Token(Token = "0x6015FB0")]
    [Address(RVA = "0x232EC5C", Offset = "0x232EC5C", VA = "0x232EC5C")]
    private bool Skip() => new bool();

    [Token(Token = "0x6015FB1")]
    [Address(RVA = "0x232ECCC", Offset = "0x232ECCC", VA = "0x232ECCC")]
    public ResultItemSkipPresenter()
    {
    }
  }
}
