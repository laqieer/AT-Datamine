// Decompiled with JetBrains decompiler
// Type: Scenes.Arena.ArenaPartyFormationSubScene
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.Scene;
using Il2CppDummyDll;
using Scenes.OutGame;
using System;
using System.Collections;
using UnityEngine;

#nullable disable
namespace Scenes.Arena
{
  [Token(Token = "0x2003135")]
  public class ArenaPartyFormationSubScene : PartyFormationSubScene
  {
    [Token(Token = "0x400D182")]
    [FieldOffset(Offset = "0xA8")]
    [SerializeField]
    private GameObject defenseTitle;
    [Token(Token = "0x400D183")]
    [FieldOffset(Offset = "0xB0")]
    [SerializeField]
    private GameObject attackTitle;

    [Token(Token = "0x6013333")]
    [Address(RVA = "0x45E6E4C", Offset = "0x45E6E4C", VA = "0x45E6E4C", Slot = "6")]
    public override void Initialize(ChangeSceneParameter param = null)
    {
    }

    [Token(Token = "0x6013334")]
    [Address(RVA = "0x45E700C", Offset = "0x45E700C", VA = "0x45E700C", Slot = "7")]
    public override IEnumerator InitializeAsync() => (IEnumerator) null;

    [Token(Token = "0x6013335")]
    [Address(RVA = "0x45E709C", Offset = "0x45E709C", VA = "0x45E709C", Slot = "33")]
    protected override IEnumerator LoadDeckAssetData() => (IEnumerator) null;

    [Token(Token = "0x6013336")]
    [Address(RVA = "0x45E712C", Offset = "0x45E712C", VA = "0x45E712C", Slot = "34")]
    public override void ChangeTemplate(int templateId)
    {
    }

    [Token(Token = "0x6013337")]
    [Address(RVA = "0x45E715C", Offset = "0x45E715C", VA = "0x45E715C")]
    private void OpenPartyUnsavedWarningPopup(Action onCanceled, Action onDecided)
    {
    }

    [Token(Token = "0x6013338")]
    [Address(RVA = "0x45E745C", Offset = "0x45E745C", VA = "0x45E745C")]
    private void OnClickBackToHome()
    {
    }

    [Token(Token = "0x6013339")]
    [Address(RVA = "0x45E7558", Offset = "0x45E7558", VA = "0x45E7558")]
    public ArenaPartyFormationSubScene()
    {
    }
  }
}
