// Decompiled with JetBrains decompiler
// Type: Battle.UI.IFieldUnitListElement
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;

#nullable disable
namespace Battle.UI
{
  [Token(Token = "0x2002424")]
  public interface IFieldUnitListElement : IDisposable
  {
    [Token(Token = "0x17002F89")]
    FieldUnitListViewElement ViewElement { [Token(Token = "0x600DD71")] get; [Token(Token = "0x600DD72")] set; }

    [Token(Token = "0x600DD73")]
    float GetHeight();
  }
}
