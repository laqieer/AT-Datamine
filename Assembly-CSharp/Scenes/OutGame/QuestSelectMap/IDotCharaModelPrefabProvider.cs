// Decompiled with JetBrains decompiler
// Type: Scenes.OutGame.QuestSelectMap.IDotCharaModelPrefabProvider
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace Scenes.OutGame.QuestSelectMap
{
  [Token(Token = "0x20033BF")]
  public interface IDotCharaModelPrefabProvider
  {
    [Token(Token = "0x6014583")]
    bool CanGetDotModelPrefab();

    [Token(Token = "0x6014584")]
    GameObject GetDotModelPrefab();
  }
}
