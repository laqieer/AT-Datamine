// Decompiled with JetBrains decompiler
// Type: DuelMarker.ResumeTimelineMarker
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
  [Token(Token = "0x20021E5")]
  public class ResumeTimelineMarker : Marker, INotification
  {
    [Token(Token = "0x17002D11")]
    public PropertyName id
    {
      [Token(Token = "0x600CEB5"), Address(RVA = "0x4B65A84", Offset = "0x4B65A84", VA = "0x4B65A84", Slot = "9")] get
      {
        return new PropertyName();
      }
    }

    [Token(Token = "0x600CEB6")]
    [Address(RVA = "0x4B65A8C", Offset = "0x4B65A8C", VA = "0x4B65A8C")]
    public ResumeTimelineMarker()
    {
    }
  }
}
