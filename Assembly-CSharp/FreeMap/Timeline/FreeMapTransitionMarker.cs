// Decompiled with JetBrains decompiler
// Type: FreeMap.Timeline.FreeMapTransitionMarker
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;
using UnityEngine.Playables;
using UnityEngine.Timeline;

#nullable disable
namespace FreeMap.Timeline
{
  [Token(Token = "0x2001781")]
  [Serializable]
  public class FreeMapTransitionMarker : Marker, INotification
  {
    [Token(Token = "0x1700150E")]
    public PropertyName id
    {
      [Token(Token = "0x600853A"), Address(RVA = "0x406B000", Offset = "0x406B000", VA = "0x406B000", Slot = "9")] get
      {
        return new PropertyName();
      }
    }

    [Token(Token = "0x600853B")]
    [Address(RVA = "0x406B054", Offset = "0x406B054", VA = "0x406B054")]
    public FreeMapTransitionMarker()
    {
    }
  }
}
