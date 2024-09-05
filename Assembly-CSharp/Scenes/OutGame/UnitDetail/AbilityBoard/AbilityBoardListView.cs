// Decompiled with JetBrains decompiler
// Type: Scenes.OutGame.UnitDetail.AbilityBoard.AbilityBoardListView
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.MasterData;
using GameCore.Tween;
using Il2CppDummyDll;
using Network.Param;
using System;
using System.Collections.Generic;
using UnityEngine;

#nullable disable
namespace Scenes.OutGame.UnitDetail.AbilityBoard
{
  [Token(Token = "0x200332D")]
  public class AbilityBoardListView : MonoBehaviour
  {
    [Token(Token = "0x400DD61")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private UITweenGroup tweenGroup;
    [Token(Token = "0x400DD62")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private AbilityBoardListIcon[] icons;
    [Token(Token = "0x400DD63")]
    [FieldOffset(Offset = "0x28")]
    public Action<int, bool> OnBoardButtonAction;
    [Token(Token = "0x400DD64")]
    [FieldOffset(Offset = "0x30")]
    private bool animeWait;
    [Token(Token = "0x400DD65")]
    [FieldOffset(Offset = "0x38")]
    private List<string> waitAnimeNames;
    [Token(Token = "0x400DD66")]
    [FieldOffset(Offset = "0x40")]
    private bool viewControlAllowed;
    [Token(Token = "0x400DD67")]
    [FieldOffset(Offset = "0x48")]
    private IReadOnlyList<AbilityBoardBoardListSettingData> boardListSettingDatas;
    [Token(Token = "0x400DD68")]
    [FieldOffset(Offset = "0x50")]
    private Dictionary<int, string> listAnimeDatas;

    [Token(Token = "0x60141C7")]
    [Address(RVA = "0x20C8194", Offset = "0x20C8194", VA = "0x20C8194")]
    public void AllowViewControl()
    {
    }

    [Token(Token = "0x60141C8")]
    [Address(RVA = "0x20C81A0", Offset = "0x20C81A0", VA = "0x20C81A0")]
    public void NotAllowViewControl()
    {
    }

    [Token(Token = "0x60141C9")]
    [Address(RVA = "0x20C81A8", Offset = "0x20C81A8", VA = "0x20C81A8")]
    public void SetData(int boardListId, List<PlayerUnitAbilityBoardType> unlockNodeData)
    {
    }

    [Token(Token = "0x60141CA")]
    [Address(RVA = "0x20C8E5C", Offset = "0x20C8E5C", VA = "0x20C8E5C")]
    public void SelectBoard(int boardId)
    {
    }

    [Token(Token = "0x60141CB")]
    [Address(RVA = "0x20C85F0", Offset = "0x20C85F0", VA = "0x20C85F0")]
    private void SetIcon()
    {
    }

    [Token(Token = "0x60141CC")]
    [Address(RVA = "0x20C91AC", Offset = "0x20C91AC", VA = "0x20C91AC")]
    private void SetIconState(AbilityBoardListView.IconIndex index)
    {
    }

    [Token(Token = "0x60141CD")]
    [Address(RVA = "0x20C8670", Offset = "0x20C8670", VA = "0x20C8670")]
    private void InitializeBoardButton()
    {
    }

    [Token(Token = "0x60141CE")]
    [Address(RVA = "0x20C8880", Offset = "0x20C8880", VA = "0x20C8880")]
    private void SetListLine(int boardListId, List<PlayerUnitAbilityBoardType> unlockNodeData)
    {
    }

    [Token(Token = "0x60141CF")]
    [Address(RVA = "0x20C92B0", Offset = "0x20C92B0", VA = "0x20C92B0")]
    private void Update()
    {
    }

    [Token(Token = "0x60141D0")]
    [Address(RVA = "0x20C937C", Offset = "0x20C937C", VA = "0x20C937C")]
    public AbilityBoardListView()
    {
    }

    [Token(Token = "0x200332E")]
    private enum IconIndex
    {
      [Token(Token = "0x400DD6A")] STATUS_0,
      [Token(Token = "0x400DD6B")] CUSTOM_1,
      [Token(Token = "0x400DD6C")] CLASS_1,
      [Token(Token = "0x400DD6D")] STATUS_1,
      [Token(Token = "0x400DD6E")] CUSTOM_2,
      [Token(Token = "0x400DD6F")] CLASS_2,
      [Token(Token = "0x400DD70")] STATUS_2,
      [Token(Token = "0x400DD71")] CUSTOM_3,
      [Token(Token = "0x400DD72")] CLASS_3,
      [Token(Token = "0x400DD73")] STATUS_3,
    }
  }
}
