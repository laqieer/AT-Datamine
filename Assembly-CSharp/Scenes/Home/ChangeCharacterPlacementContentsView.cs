// Decompiled with JetBrains decompiler
// Type: Scenes.Home.ChangeCharacterPlacementContentsView
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using Scenes.Home.ChangeCharacter;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

#nullable disable
namespace Scenes.Home
{
  [Token(Token = "0x2002ACF")]
  public class ChangeCharacterPlacementContentsView : MonoBehaviour
  {
    [Token(Token = "0x400B62E")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private List<ChangeCharacterPlacementContainerView> _containerViewList;

    [Token(Token = "0x6010BBE")]
    [Address(RVA = "0x4BD9DE4", Offset = "0x4BD9DE4", VA = "0x4BD9DE4")]
    public IEnumerator InitializeAsync(ChangeCharacterSubScene.CharacterSettings saveData)
    {
      return (IEnumerator) null;
    }

    [Token(Token = "0x6010BBF")]
    [Address(RVA = "0x4BD9E80", Offset = "0x4BD9E80", VA = "0x4BD9E80")]
    public void SetOnClickCharacterChangeEvent(Action<int> action)
    {
    }

    [Token(Token = "0x6010BC0")]
    [Address(RVA = "0x4BD9FB8", Offset = "0x4BD9FB8", VA = "0x4BD9FB8")]
    public void SetOnClickStyleChangeEvent(Action<int> action)
    {
    }

    [Token(Token = "0x6010BC1")]
    [Address(RVA = "0x4BDA0F0", Offset = "0x4BDA0F0", VA = "0x4BDA0F0")]
    public ChangeCharacterPlacementContentsView()
    {
    }
  }
}
