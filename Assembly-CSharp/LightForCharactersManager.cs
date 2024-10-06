// Decompiled with JetBrains decompiler
// Type: LightForCharactersManager
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.DesignPattern;
using Il2CppDummyDll;
using System;
using System.Collections.Generic;
using UnityEngine;

#nullable disable
[Token(Token = "0x20000B9")]
public class LightForCharactersManager : SingletonMonoBehaviour<LightForCharactersManager>
{
  [Token(Token = "0x40002FF")]
  [FieldOffset(Offset = "0x20")]
  [SerializeField]
  private LightForCharacters activeLight;
  [Token(Token = "0x4000300")]
  [FieldOffset(Offset = "0x28")]
  private List<ILightForCharactersReceiver> receivers;

  [Token(Token = "0x17000048")]
  public LightForCharacters ActiveLight
  {
    [Token(Token = "0x600059C"), Address(RVA = "0x44B4918", Offset = "0x44B4918", VA = "0x44B4918")] get
    {
      return (LightForCharacters) null;
    }
    [Token(Token = "0x600059D"), Address(RVA = "0x44B4920", Offset = "0x44B4920", VA = "0x44B4920")] set
    {
    }
  }

  [Token(Token = "0x140000DD")]
  private static event Action ReserveEvent
  {
    [Token(Token = "0x600059E"), Address(RVA = "0x44B4928", Offset = "0x44B4928", VA = "0x44B4928")] add
    {
    }
    [Token(Token = "0x600059F"), Address(RVA = "0x44B49E0", Offset = "0x44B49E0", VA = "0x44B49E0")] remove
    {
    }
  }

  [Token(Token = "0x60005A0")]
  [Address(RVA = "0x44B4A98", Offset = "0x44B4A98", VA = "0x44B4A98")]
  public static void AddReceiver(ILightForCharactersReceiver receiver)
  {
  }

  [Token(Token = "0x60005A1")]
  [Address(RVA = "0x44B4C10", Offset = "0x44B4C10", VA = "0x44B4C10")]
  private void AddReceiverInternal(ILightForCharactersReceiver receiver)
  {
  }

  [Token(Token = "0x60005A2")]
  [Address(RVA = "0x44B4D70", Offset = "0x44B4D70", VA = "0x44B4D70")]
  public static void RemoveReceiver(ILightForCharactersReceiver receiver)
  {
  }

  [Token(Token = "0x60005A3")]
  [Address(RVA = "0x44B4EE8", Offset = "0x44B4EE8", VA = "0x44B4EE8")]
  private void RemoveReceiverInternal(ILightForCharactersReceiver receiver)
  {
  }

  [Token(Token = "0x60005A4")]
  [Address(RVA = "0x44B4F40", Offset = "0x44B4F40", VA = "0x44B4F40")]
  public static void ChangeLight(LightForCharacters light)
  {
  }

  [Token(Token = "0x60005A5")]
  [Address(RVA = "0x44B50B8", Offset = "0x44B50B8", VA = "0x44B50B8")]
  private void ChangeLightInternal(LightForCharacters light)
  {
  }

  [Token(Token = "0x60005A6")]
  [Address(RVA = "0x44B52B4", Offset = "0x44B52B4", VA = "0x44B52B4", Slot = "5")]
  public override void Initialize()
  {
  }

  [Token(Token = "0x60005A7")]
  [Address(RVA = "0x44B5348", Offset = "0x44B5348", VA = "0x44B5348")]
  public LightForCharactersManager()
  {
  }
}
