// Decompiled with JetBrains decompiler
// Type: Scenes.Story.Facility.Book.IRentalEvent
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;

#nullable disable
namespace Scenes.Story.Facility.Book
{
  [Token(Token = "0x2002EDC")]
  public interface IRentalEvent
  {
    [Token(Token = "0x17003E18")]
    Action OnPositive { [Token(Token = "0x60124E4")] set; }

    [Token(Token = "0x17003E19")]
    Action OnNegative { [Token(Token = "0x60124E5")] set; }
  }
}
