// Decompiled with JetBrains decompiler
// Type: UnitView.UI.Footer
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.Tween;
using Il2CppDummyDll;
using System;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace UnitView.UI
{
  [Token(Token = "0x20003FE")]
  [AddComponentMenu("Scripts/UnitView Footer")]
  [Serializable]
  public class Footer : MonoBehaviour
  {
    [Token(Token = "0x40016C4")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private Button back;
    [Token(Token = "0x40016C5")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private Button menu;
    [Token(Token = "0x40016C6")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private UITweenGroup tweenGroup;
    [Token(Token = "0x40016C7")]
    [FieldOffset(Offset = "0x30")]
    private Footer.IEventListener listener;

    [Token(Token = "0x60016DE")]
    [Address(RVA = "0x24894D0", Offset = "0x24894D0", VA = "0x24894D0")]
    public void Register(Footer.IEventListener listener)
    {
    }

    [Token(Token = "0x60016DF")]
    [Address(RVA = "0x24894D8", Offset = "0x24894D8", VA = "0x24894D8")]
    public void Initialize()
    {
    }

    [Token(Token = "0x60016E0")]
    [Address(RVA = "0x24895C8", Offset = "0x24895C8", VA = "0x24895C8")]
    public void In()
    {
    }

    [Token(Token = "0x60016E1")]
    [Address(RVA = "0x2489620", Offset = "0x2489620", VA = "0x2489620")]
    private void OnBack()
    {
    }

    [Token(Token = "0x60016E2")]
    [Address(RVA = "0x24896C8", Offset = "0x24896C8", VA = "0x24896C8")]
    private void OnMenu()
    {
    }

    [Token(Token = "0x60016E3")]
    [Address(RVA = "0x2489774", Offset = "0x2489774", VA = "0x2489774")]
    public Footer()
    {
    }

    [Token(Token = "0x20003FF")]
    public interface IEventListener
    {
      [Token(Token = "0x60016E4")]
      void OnBack();

      [Token(Token = "0x60016E5")]
      void OnMenu();
    }
  }
}
