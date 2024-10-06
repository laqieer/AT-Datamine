// Decompiled with JetBrains decompiler
// Type: Scenes.OutGame.QuestSelectMap.IGroundPrefabProvider
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace Scenes.OutGame.QuestSelectMap
{
  [Token(Token = "0x20033BE")]
  public interface IGroundPrefabProvider
  {
    [Token(Token = "0x6014581")]
    bool CanGetPrefabResource();

    [Token(Token = "0x6014582")]
    GameObject GetPrefabResource();
  }
}
