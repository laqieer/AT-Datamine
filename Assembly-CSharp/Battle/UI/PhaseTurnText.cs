// Decompiled with JetBrains decompiler
// Type: Battle.UI.PhaseTurnText
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace Battle.UI
{
  [Token(Token = "0x200232C")]
  [RequireComponent(typeof (Text))]
  public sealed class PhaseTurnText : MonoBehaviour
  {
    [Token(Token = "0x4009538")]
    [FieldOffset(Offset = "0x18")]
    private Func<string> Format;
    [Token(Token = "0x4009539")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    [HideInInspector]
    private Text targetText;

    [Token(Token = "0x17002E5E")]
    public int TurnNumber
    {
      [Token(Token = "0x600D703"), Address(RVA = "0x1D1A72C", Offset = "0x1D1A72C", VA = "0x1D1A72C")] set
      {
      }
    }

    [Token(Token = "0x600D704")]
    [Address(RVA = "0x1D24CC4", Offset = "0x1D24CC4", VA = "0x1D24CC4")]
    public PhaseTurnText()
    {
    }
  }
}
