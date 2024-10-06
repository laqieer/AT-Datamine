// Decompiled with JetBrains decompiler
// Type: FreeMap.UI.ColliderEvent.IFreeMapPlayerInstanceColliderEvent
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using FreeMap.Instance;
using Il2CppDummyDll;

#nullable disable
namespace FreeMap.UI.ColliderEvent
{
  [Token(Token = "0x20016CB")]
  public interface IFreeMapPlayerInstanceColliderEvent
  {
    [Token(Token = "0x60080DB")]
    void OnEnter(FreeMapPlayerInstance player, IFreeMapColliderEventObject colliderObject);
  }
}
