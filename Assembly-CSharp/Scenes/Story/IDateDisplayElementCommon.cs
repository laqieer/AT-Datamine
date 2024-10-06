// Decompiled with JetBrains decompiler
// Type: Scenes.Story.IDateDisplayElementCommon
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace Scenes.Story
{
  [Token(Token = "0x2002D6D")]
  public interface IDateDisplayElementCommon
  {
    [Token(Token = "0x17003C9F")]
    GameObject Root { [Token(Token = "0x6011BFC")] get; }

    [Token(Token = "0x17003CA0")]
    GameObject[] DayOfWeekEnTextImages { [Token(Token = "0x6011BFD")] get; }

    [Token(Token = "0x17003CA1")]
    Text DayOfWeekZH { [Token(Token = "0x6011BFE")] get; }
  }
}
