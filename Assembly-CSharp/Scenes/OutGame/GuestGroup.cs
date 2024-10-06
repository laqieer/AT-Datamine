// Decompiled with JetBrains decompiler
// Type: Scenes.OutGame.GuestGroup
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using StaqData;
using UnityEngine;

#nullable disable
namespace Scenes.OutGame
{
  [Token(Token = "0x200321F")]
  internal class GuestGroup : MonoBehaviour
  {
    [Token(Token = "0x400D60C")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private GameObject line;
    [Token(Token = "0x400D60D")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private RestrictContent restrictContent;

    [Token(Token = "0x60138C1")]
    [Address(RVA = "0x49C5284", Offset = "0x49C5284", VA = "0x49C5284")]
    public bool SetGuestInfo(QuestInfo questInfo) => new bool();

    [Token(Token = "0x60138C2")]
    [Address(RVA = "0x49C59F0", Offset = "0x49C59F0", VA = "0x49C59F0")]
    public GuestGroup()
    {
    }
  }
}
