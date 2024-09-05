// Decompiled with JetBrains decompiler
// Type: Battle.UI.DurableUI
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UI;
using UnityEngine;

#nullable disable
namespace Battle.UI
{
  [Token(Token = "0x2002382")]
  [Serializable]
  public class DurableUI
  {
    [Token(Token = "0x400972B")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private GameObject root;
    [Token(Token = "0x400972C")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private TextAccessor currentText;
    [Token(Token = "0x400972D")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private TextAccessor redText;
    [Token(Token = "0x400972E")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private TextAccessor maxText;

    [Token(Token = "0x600D8DF")]
    [Address(RVA = "0x1B99D10", Offset = "0x1B99D10", VA = "0x1B99D10")]
    public void SetActive(bool isActive)
    {
    }

    [Token(Token = "0x600D8E0")]
    [Address(RVA = "0x1B99D30", Offset = "0x1B99D30", VA = "0x1B99D30")]
    public void Set(int current, int max, Func<int, int, bool> condition = null)
    {
    }

    [Token(Token = "0x600D8E1")]
    [Address(RVA = "0x1B99EB0", Offset = "0x1B99EB0", VA = "0x1B99EB0")]
    public DurableUI()
    {
    }
  }
}
