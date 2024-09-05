// Decompiled with JetBrains decompiler
// Type: UI.Utilities.SerializeUI.ContainerBase
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace UI.Utilities.SerializeUI
{
  [Token(Token = "0x20008A7")]
  [Serializable]
  public abstract class ContainerBase
  {
    [Token(Token = "0x40028A9")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    protected ContainerBase.ActiveType activeType;
    [Token(Token = "0x40028AA")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    protected GameObject rootObject;

    [Token(Token = "0x6003142")]
    [Address(RVA = "0x3C16264", Offset = "0x3C16264", VA = "0x3C16264", Slot = "4")]
    public virtual void SetActive(bool active)
    {
    }

    [Token(Token = "0x6003143")]
    [Address(RVA = "0x3C16318", Offset = "0x3C16318", VA = "0x3C16318", Slot = "5")]
    public virtual void Active()
    {
    }

    [Token(Token = "0x6003144")]
    [Address(RVA = "0x3C16328", Offset = "0x3C16328", VA = "0x3C16328", Slot = "6")]
    public virtual void Inactive()
    {
    }

    [Token(Token = "0x6003145")]
    [Address(RVA = "0x3C162B0", Offset = "0x3C162B0", VA = "0x3C162B0")]
    protected bool IsObjectExist(UnityEngine.Object obj) => new bool();

    [Token(Token = "0x6003146")]
    [Address(RVA = "0x3C16338", Offset = "0x3C16338", VA = "0x3C16338")]
    protected ContainerBase()
    {
    }

    [Token(Token = "0x20008A8")]
    public enum ActiveType
    {
      [Token(Token = "0x40028AC")] Component,
      [Token(Token = "0x40028AD")] GameObject,
    }
  }
}
