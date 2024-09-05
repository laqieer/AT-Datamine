// Decompiled with JetBrains decompiler
// Type: Home.Event.HomeEventHomeButton
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.MasterData;
using GameCore.RawData;
using Il2CppDummyDll;
using System;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace Home.Event
{
  [Token(Token = "0x2000B68")]
  public class HomeEventHomeButton : MonoBehaviour
  {
    [Token(Token = "0x4003404")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private CommonButton button;
    [Token(Token = "0x4003405")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private RawImage icon;
    [Token(Token = "0x4003406")]
    [FieldOffset(Offset = "0x28")]
    private RawTextureManager rawTextureManager;

    [Token(Token = "0x60040DE")]
    [Address(RVA = "0x2A2A374", Offset = "0x2A2A374", VA = "0x2A2A374")]
    public void Initialize(HomeEventData master, Action onClickAction)
    {
    }

    [Token(Token = "0x60040DF")]
    [Address(RVA = "0x2A2A4EC", Offset = "0x2A2A4EC", VA = "0x2A2A4EC")]
    private string GetRawDataURL(int id) => (string) null;

    [Token(Token = "0x60040E0")]
    [Address(RVA = "0x2A2A57C", Offset = "0x2A2A57C", VA = "0x2A2A57C")]
    public HomeEventHomeButton()
    {
    }
  }
}
