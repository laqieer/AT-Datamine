// Decompiled with JetBrains decompiler
// Type: UI.Scroll.IInfiniteScrollSetup
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace UI.Scroll
{
  [Token(Token = "0x20008AE")]
  public interface IInfiniteScrollSetup
  {
    [Token(Token = "0x6003159")]
    void OnPostSetupItems();

    [Token(Token = "0x600315A")]
    void OnUpdateItem(int itemCount, GameObject obj);
  }
}
