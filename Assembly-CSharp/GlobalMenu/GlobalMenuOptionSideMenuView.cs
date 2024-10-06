// Decompiled with JetBrains decompiler
// Type: GlobalMenu.GlobalMenuOptionSideMenuView
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.Tween;
using Il2CppDummyDll;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace GlobalMenu
{
  [Token(Token = "0x2000BA4")]
  public class GlobalMenuOptionSideMenuView : MonoBehaviour
  {
    [Token(Token = "0x4003510")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private UITweenGroup tweenGroup;
    [Token(Token = "0x4003511")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private Button[] buttons;
    [Token(Token = "0x4003512")]
    [FieldOffset(Offset = "0x28")]
    private int selectId;
    [Token(Token = "0x4003513")]
    [FieldOffset(Offset = "0x30")]
    private GlobalMenuOptionView globalMenuOptionView;
    [Token(Token = "0x4003514")]
    [FieldOffset(Offset = "0x38")]
    private Dictionary<int, string> ButtonInAnimeNames;
    [Token(Token = "0x4003515")]
    [FieldOffset(Offset = "0x40")]
    private Dictionary<int, string> ButtonOutAnimeNames;

    [Token(Token = "0x600426E")]
    [Address(RVA = "0x2A3644C", Offset = "0x2A3644C", VA = "0x2A3644C")]
    public void Initialize(GlobalMenuOptionView globalMenuOptionView)
    {
    }

    [Token(Token = "0x600426F")]
    [Address(RVA = "0x2A367F0", Offset = "0x2A367F0", VA = "0x2A367F0")]
    public void InitSelect()
    {
    }

    [Token(Token = "0x6004270")]
    [Address(RVA = "0x2A36CAC", Offset = "0x2A36CAC", VA = "0x2A36CAC")]
    private void OnButonAction(int index, bool isInit = false)
    {
    }

    [Token(Token = "0x6004271")]
    [Address(RVA = "0x2A36EC8", Offset = "0x2A36EC8", VA = "0x2A36EC8")]
    public GlobalMenuOptionSideMenuView()
    {
    }
  }
}
