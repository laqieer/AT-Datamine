// Decompiled with JetBrains decompiler
// Type: Scenes.OutGame.QuestSelectMap.ILandmarkResourceDictProvider
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections.Generic;

#nullable disable
namespace Scenes.OutGame.QuestSelectMap
{
  [Token(Token = "0x20033C1")]
  public interface ILandmarkResourceDictProvider
  {
    [Token(Token = "0x6014587")]
    List<int> GetLandmarkHandleIdList();

    [Token(Token = "0x6014588")]
    ILandmarkResourceProvider GetLandmarkSpriteProviter(int landHandleSpId);
  }
}
