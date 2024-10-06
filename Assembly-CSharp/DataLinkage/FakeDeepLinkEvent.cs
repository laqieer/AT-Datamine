// Decompiled with JetBrains decompiler
// Type: DataLinkage.FakeDeepLinkEvent
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace DataLinkage
{
  [Token(Token = "0x2001F8E")]
  public class FakeDeepLinkEvent : MonoBehaviour
  {
    [Token(Token = "0x40086F2")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    [Header("Editorデバッグ用")]
    private string deepLink;
    [Token(Token = "0x40086F3")]
    [FieldOffset(Offset = "0x20")]
    public Action<string> DeepLinkActivated;

    [Token(Token = "0x600BB54")]
    [Address(RVA = "0x1E4CA64", Offset = "0x1E4CA64", VA = "0x1E4CA64")]
    public static FakeDeepLinkEvent Create(bool dontDestroyObject = false)
    {
      return (FakeDeepLinkEvent) null;
    }

    [Token(Token = "0x600BB55")]
    [Address(RVA = "0x1E4CC04", Offset = "0x1E4CC04", VA = "0x1E4CC04")]
    public FakeDeepLinkEvent()
    {
    }
  }
}
