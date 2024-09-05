// Decompiled with JetBrains decompiler
// Type: GameCore.Scene.TransitionEffectBase
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections;
using UnityEngine;

#nullable disable
namespace GameCore.Scene
{
  [Token(Token = "0x2000CA5")]
  public class TransitionEffectBase : MonoBehaviour
  {
    [Token(Token = "0x6004904")]
    [Address(RVA = "0x31344EC", Offset = "0x31344EC", VA = "0x31344EC", Slot = "4")]
    public virtual IEnumerator Initialize() => (IEnumerator) null;

    [Token(Token = "0x6004905")]
    [Address(RVA = "0x3134574", Offset = "0x3134574", VA = "0x3134574", Slot = "5")]
    public virtual IEnumerator Execute() => (IEnumerator) null;

    [Token(Token = "0x6004906")]
    [Address(RVA = "0x31345FC", Offset = "0x31345FC", VA = "0x31345FC")]
    public TransitionEffectBase()
    {
    }
  }
}
