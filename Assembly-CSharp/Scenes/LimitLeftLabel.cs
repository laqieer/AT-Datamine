// Decompiled with JetBrains decompiler
// Type: Scenes.LimitLeftLabel
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace Scenes
{
  [Token(Token = "0x2002889")]
  public class LimitLeftLabel : MonoBehaviour
  {
    [Token(Token = "0x400ACEB")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private Text timeLeft;

    [Token(Token = "0x600FF5D")]
    [Address(RVA = "0x40F9750", Offset = "0x40F9750", VA = "0x40F9750")]
    public void SetTimeLeft(string _endAt)
    {
    }

    [Token(Token = "0x600FF5E")]
    [Address(RVA = "0x40F9A10", Offset = "0x40F9A10", VA = "0x40F9A10")]
    public LimitLeftLabel()
    {
    }
  }
}
