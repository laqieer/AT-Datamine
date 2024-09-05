// Decompiled with JetBrains decompiler
// Type: Scenes.OutGame.Battle.ResultRetry.ShowHideCtrl
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.MasterData;
using Il2CppDummyDll;
using System;
using System.Collections.Generic;
using UnityEngine;

#nullable disable
namespace Scenes.OutGame.Battle.ResultRetry
{
  [Token(Token = "0x20037CA")]
  [Serializable]
  public class ShowHideCtrl
  {
    [Token(Token = "0x400F3D3")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private List<GameObject> _showObjects;
    [Token(Token = "0x400F3D4")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private List<GameObject> _apShowObjects;
    [Token(Token = "0x400F3D5")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private List<GameObject> _epShowObjects;
    [Token(Token = "0x400F3D6")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private List<GameObject> _hideObjects;

    [Token(Token = "0x6015F58")]
    [Address(RVA = "0x232B9F8", Offset = "0x232B9F8", VA = "0x232B9F8")]
    public void ShowHide(BattleComsumeCostTypeEnum costType, bool isShow)
    {
    }

    [Token(Token = "0x6015F59")]
    [Address(RVA = "0x232C090", Offset = "0x232C090", VA = "0x232C090")]
    public ShowHideCtrl()
    {
    }
  }
}
