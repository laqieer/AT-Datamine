// Decompiled with JetBrains decompiler
// Type: Battle.UI.BattleConditionView
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace Battle.UI
{
  [Token(Token = "0x200237E")]
  [Serializable]
  public class BattleConditionView
  {
    [Token(Token = "0x4009722")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private Transform iconParent;
    [Token(Token = "0x4009723")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private GameObject nothingObj;
    [Token(Token = "0x4009724")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private CommonButton detail;
    [Token(Token = "0x4009725")]
    [FieldOffset(Offset = "0x28")]
    private Image[] iconImages;
    [Token(Token = "0x4009726")]
    [FieldOffset(Offset = "0x30")]
    private Action onClickDetail;

    [Token(Token = "0x600D8C6")]
    [Address(RVA = "0x1B993C8", Offset = "0x1B993C8", VA = "0x1B993C8")]
    public void Initalize()
    {
    }

    [Token(Token = "0x600D8C7")]
    [Address(RVA = "0x1B99488", Offset = "0x1B99488", VA = "0x1B99488")]
    public void UpdateView(StatusConditionModel[] models)
    {
    }

    [Token(Token = "0x600D8C8")]
    [Address(RVA = "0x1B99574", Offset = "0x1B99574", VA = "0x1B99574")]
    private void Set(Sprite[] sprites)
    {
    }

    [Token(Token = "0x600D8C9")]
    [Address(RVA = "0x1B99648", Offset = "0x1B99648", VA = "0x1B99648")]
    public void ResetIcon()
    {
    }

    [Token(Token = "0x600D8CA")]
    [Address(RVA = "0x1B996B8", Offset = "0x1B996B8", VA = "0x1B996B8")]
    private void SetActiveNothing(bool isActive)
    {
    }

    [Token(Token = "0x600D8CB")]
    [Address(RVA = "0x1B9970C", Offset = "0x1B9970C", VA = "0x1B9970C")]
    public void SetOnClickConditionDetail(Action onClick)
    {
    }

    [Token(Token = "0x600D8CC")]
    [Address(RVA = "0x1B99714", Offset = "0x1B99714", VA = "0x1B99714")]
    private void OnClickDetailAction()
    {
    }

    [Token(Token = "0x600D8CD")]
    [Address(RVA = "0x1B99730", Offset = "0x1B99730", VA = "0x1B99730")]
    public BattleConditionView()
    {
    }
  }
}
