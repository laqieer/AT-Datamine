// Decompiled with JetBrains decompiler
// Type: Player.PlayerRankupStage
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

#nullable disable
namespace Player
{
  [Token(Token = "0x20009CD")]
  public class PlayerRankupStage : MonoBehaviour
  {
    [Token(Token = "0x4002D50")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private PlayerRankupStageControlAttach Container;
    [Token(Token = "0x4002D51")]
    [FieldOffset(Offset = "0x20")]
    private Action outEndCallback;

    [Token(Token = "0x60037D8")]
    [Address(RVA = "0x3104880", Offset = "0x3104880", VA = "0x3104880")]
    public void Setup(PlayerRankupStageControlAttach ui)
    {
    }

    [Token(Token = "0x60037D9")]
    [Address(RVA = "0x3104888", Offset = "0x3104888", VA = "0x3104888")]
    public List<string> SetContentsDataAndGetNeedResourceData(
      DisplayPlayerRankupStageInfo displayInfo)
    {
      return (List<string>) null;
    }

    [Token(Token = "0x60037DA")]
    [Address(RVA = "0x31049B8", Offset = "0x31049B8", VA = "0x31049B8")]
    public IEnumerator SystemInitializeProcess() => (IEnumerator) null;

    [Token(Token = "0x60037DB")]
    [Address(RVA = "0x3104A40", Offset = "0x3104A40", VA = "0x3104A40")]
    public void ContentsInitializeProcess()
    {
    }

    [Token(Token = "0x60037DC")]
    [Address(RVA = "0x3104A44", Offset = "0x3104A44", VA = "0x3104A44")]
    public void AddEndedCallback(Action callback)
    {
    }

    [Token(Token = "0x60037DD")]
    [Address(RVA = "0x3104AC4", Offset = "0x3104AC4", VA = "0x3104AC4")]
    public void RemoveEndedCallback(Action callback)
    {
    }

    [Token(Token = "0x60037DE")]
    [Address(RVA = "0x3104B44", Offset = "0x3104B44", VA = "0x3104B44")]
    public void PlayIn()
    {
    }

    [Token(Token = "0x60037DF")]
    [Address(RVA = "0x3104DCC", Offset = "0x3104DCC", VA = "0x3104DCC")]
    private void OnPlayOutEnd()
    {
    }

    [Token(Token = "0x60037E0")]
    [Address(RVA = "0x3104DE8", Offset = "0x3104DE8", VA = "0x3104DE8")]
    public PlayerRankupStage()
    {
    }
  }
}
