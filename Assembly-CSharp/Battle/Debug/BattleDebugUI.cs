// Decompiled with JetBrains decompiler
// Type: Battle.Debug.BattleDebugUI
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Battle.Data.Board;
using Il2CppDummyDll;
using System;
using System.Collections.Generic;
using UnityEngine;

#nullable disable
namespace Battle.Debug
{
  [Token(Token = "0x20025C8")]
  public class BattleDebugUI : MonoBehaviour
  {
    [Token(Token = "0x400A28A")]
    [FieldOffset(Offset = "0x18")]
    public bool isView;
    [Token(Token = "0x400A28B")]
    [FieldOffset(Offset = "0x20")]
    private List<IBattleDebugContent> contents;
    [Token(Token = "0x400A28C")]
    [FieldOffset(Offset = "0x0")]
    private static BattleDebugUI instance;
    [Token(Token = "0x400A28D")]
    [FieldOffset(Offset = "0x28")]
    public bool CommandPause;
    [Token(Token = "0x400A28E")]
    [FieldOffset(Offset = "0x2C")]
    private Rect viewArea;
    [Token(Token = "0x400A28F")]
    [FieldOffset(Offset = "0x40")]
    private UnitParameterData debugUnit;
    [Token(Token = "0x400A290")]
    [FieldOffset(Offset = "0x48")]
    private GridData gridData;
    [Token(Token = "0x400A291")]
    [FieldOffset(Offset = "0x50")]
    private Action UpdateBoard;

    [Token(Token = "0x170031C9")]
    public static BattleDebugUI Instance
    {
      [Token(Token = "0x600E937"), Address(RVA = "0x4C47AC8", Offset = "0x4C47AC8", VA = "0x4C47AC8")] get
      {
        return (BattleDebugUI) null;
      }
    }

    [Token(Token = "0x600E938")]
    [Address(RVA = "0x4C47BF8", Offset = "0x4C47BF8", VA = "0x4C47BF8")]
    public void AddDebugContent(IBattleDebugContent content)
    {
    }

    [Token(Token = "0x600E939")]
    [Address(RVA = "0x4C47CA0", Offset = "0x4C47CA0", VA = "0x4C47CA0")]
    public void ClearDebugContent()
    {
    }

    [Token(Token = "0x600E93A")]
    [Address(RVA = "0x4C47D10", Offset = "0x4C47D10", VA = "0x4C47D10")]
    public void DestroyInstance()
    {
    }

    [Token(Token = "0x600E93B")]
    [Address(RVA = "0x4C47DDC", Offset = "0x4C47DDC", VA = "0x4C47DDC")]
    private void OnGUI()
    {
    }

    [Token(Token = "0x600E93C")]
    [Address(RVA = "0x4C48DF8", Offset = "0x4C48DF8", VA = "0x4C48DF8")]
    public void SetDebugObj(UnitParameterData unit, Action updateBoardFunc)
    {
    }

    [Token(Token = "0x600E93D")]
    [Address(RVA = "0x4C48E04", Offset = "0x4C48E04", VA = "0x4C48E04")]
    public void SetDebugObj(GridData grid, Action updateBoardFunc)
    {
    }

    [Token(Token = "0x600E93E")]
    [Address(RVA = "0x4C48DEC", Offset = "0x4C48DEC", VA = "0x4C48DEC")]
    public void ReleaseDebugObj()
    {
    }

    [Token(Token = "0x600E93F")]
    [Address(RVA = "0x4C48E10", Offset = "0x4C48E10", VA = "0x4C48E10")]
    public bool IsHoldingAny() => new bool();

    [Token(Token = "0x600E940")]
    [Address(RVA = "0x4C48E30", Offset = "0x4C48E30", VA = "0x4C48E30")]
    public BattleDebugUI()
    {
    }
  }
}
