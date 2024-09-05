// Decompiled with JetBrains decompiler
// Type: FreeMap.State.PlayerObserver
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace FreeMap.State
{
  [Token(Token = "0x2001797")]
  public class PlayerObserver
  {
    [Token(Token = "0x14000116")]
    public event Action<Vector3, Quaternion> OnTransform
    {
      [Token(Token = "0x60085FD"), Address(RVA = "0x406E6EC", Offset = "0x406E6EC", VA = "0x406E6EC")] add
      {
      }
      [Token(Token = "0x60085FE"), Address(RVA = "0x406E79C", Offset = "0x406E79C", VA = "0x406E79C")] remove
      {
      }
    }

    [Token(Token = "0x60085FF")]
    [Address(RVA = "0x406D6A4", Offset = "0x406D6A4", VA = "0x406D6A4")]
    public void Observe(FreeMapStateManager entity)
    {
    }

    [Token(Token = "0x6008600")]
    [Address(RVA = "0x406D12C", Offset = "0x406D12C", VA = "0x406D12C")]
    public PlayerObserver()
    {
    }
  }
}
