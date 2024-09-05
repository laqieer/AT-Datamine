// Decompiled with JetBrains decompiler
// Type: DuelMarker.TakeScreenShotMarker
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Playables;
using UnityEngine.Timeline;

#nullable disable
namespace DuelMarker
{
  [Token(Token = "0x20021EC")]
  public class TakeScreenShotMarker : Marker, INotification
  {
    [Token(Token = "0x17002D16")]
    public PropertyName id
    {
      [Token(Token = "0x600CEC4"), Address(RVA = "0x4B65C18", Offset = "0x4B65C18", VA = "0x4B65C18", Slot = "9")] get
      {
        return new PropertyName();
      }
    }

    [Token(Token = "0x600CEC5")]
    [Address(RVA = "0x4B65C20", Offset = "0x4B65C20", VA = "0x4B65C20")]
    public TakeScreenShotMarker()
    {
    }
  }
}
