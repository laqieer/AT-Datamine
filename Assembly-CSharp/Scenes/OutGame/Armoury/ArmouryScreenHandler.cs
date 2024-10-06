// Decompiled with JetBrains decompiler
// Type: Scenes.OutGame.Armoury.ArmouryScreenHandler
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore;
using Il2CppDummyDll;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

#nullable disable
namespace Scenes.OutGame.Armoury
{
  [Token(Token = "0x20037F0")]
  public class ArmouryScreenHandler
  {
    [Token(Token = "0x400F463")]
    [FieldOffset(Offset = "0x10")]
    private AssetCachedSpawner _spawner;
    [Token(Token = "0x400F464")]
    [FieldOffset(Offset = "0x18")]
    private Transform _parentTransform;
    [Token(Token = "0x400F465")]
    [FieldOffset(Offset = "0x20")]
    private ArmouryScreenType _nowScreen;
    [Token(Token = "0x400F466")]
    [FieldOffset(Offset = "0x24")]
    private ArmouryScreenType _nextScreen;
    [Token(Token = "0x400F467")]
    [FieldOffset(Offset = "0x28")]
    private Dictionary<ArmouryScreenType, ArmouryScreenBase> _screenDic;
    [Token(Token = "0x400F468")]
    [FieldOffset(Offset = "0x30")]
    private Action<bool> _homeButtonAnimationAction;
    [Token(Token = "0x400F469")]
    [FieldOffset(Offset = "0x38")]
    private Action<Action> _enableGrid;
    [Token(Token = "0x400F46A")]
    [FieldOffset(Offset = "0x40")]
    private Action<ArmouryScreenType, ArmouryChangeScreenParam> _changeScreenAction;
    [Token(Token = "0x400F46B")]
    [FieldOffset(Offset = "0x48")]
    private bool skilEnableEffect;

    [Token(Token = "0x6016027")]
    [Address(RVA = "0x20EAD9C", Offset = "0x20EAD9C", VA = "0x20EAD9C")]
    public void Initialize(
      AssetCachedSpawner spawner,
      Transform transform,
      Action<bool> homeButtonAction,
      Action<ArmouryScreenType, ArmouryChangeScreenParam> changeScreenAction,
      Action<Action> enableGrid)
    {
    }

    [Token(Token = "0x6016028")]
    [Address(RVA = "0x20EAE4C", Offset = "0x20EAE4C", VA = "0x20EAE4C")]
    public IEnumerator ChangeScreen(
      ArmouryScreenType next,
      ArmouryChangeScreenParam param = null,
      Action finishAction = null)
    {
      return (IEnumerator) null;
    }

    [Token(Token = "0x6016029")]
    [Address(RVA = "0x20EAF00", Offset = "0x20EAF00", VA = "0x20EAF00")]
    public IEnumerator CloseScreen() => (IEnumerator) null;

    [Token(Token = "0x601602A")]
    [Address(RVA = "0x20EAF88", Offset = "0x20EAF88", VA = "0x20EAF88")]
    public ArmouryScreenBase GetScreen() => (ArmouryScreenBase) null;

    [Token(Token = "0x601602B")]
    [Address(RVA = "0x20EAFDC", Offset = "0x20EAFDC", VA = "0x20EAFDC")]
    public void Destroy()
    {
    }

    [Token(Token = "0x601602C")]
    [Address(RVA = "0x20EB150", Offset = "0x20EB150", VA = "0x20EB150")]
    private IEnumerator LoadScreen(ArmouryScreenType type) => (IEnumerator) null;

    [Token(Token = "0x601602D")]
    [Address(RVA = "0x20EB1F0", Offset = "0x20EB1F0", VA = "0x20EB1F0")]
    private void RequestEnable(bool isActive)
    {
    }

    [Token(Token = "0x601602E")]
    [Address(RVA = "0x20EB274", Offset = "0x20EB274", VA = "0x20EB274")]
    public ArmouryScreenHandler()
    {
    }
  }
}
