// Decompiled with JetBrains decompiler
// Type: Gacha.DestroyEventHandler
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace Gacha
{
  [Token(Token = "0x20014EF")]
  internal class DestroyEventHandler : MonoBehaviour
  {
    [Token(Token = "0x400603F")]
    [FieldOffset(Offset = "0x18")]
    public Action Destroied;

    [Token(Token = "0x6007651")]
    [Address(RVA = "0x44E8C08", Offset = "0x44E8C08", VA = "0x44E8C08")]
    private void OnDestroy()
    {
    }

    [Token(Token = "0x6007652")]
    [Address(RVA = "0x44E8C24", Offset = "0x44E8C24", VA = "0x44E8C24")]
    public DestroyEventHandler()
    {
    }
  }
}
