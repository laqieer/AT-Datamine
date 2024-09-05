// Decompiled with JetBrains decompiler
// Type: FreeMap.UI.ColliderEvent.IFreeMapColliderEventObject
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using FreeMap.Instance;
using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace FreeMap.UI.ColliderEvent
{
  [Token(Token = "0x20016CA")]
  public interface IFreeMapColliderEventObject
  {
    [Token(Token = "0x17001400")]
    GameObject Self { [Token(Token = "0x60080D8")] get; }

    [Token(Token = "0x17001401")]
    GameObject Target { [Token(Token = "0x60080D9")] get; }

    [Token(Token = "0x60080DA")]
    bool OnEnter(FreeMapInstance instance);
  }
}
