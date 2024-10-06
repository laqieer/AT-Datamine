// Decompiled with JetBrains decompiler
// Type: Scenes.OutGame.QuestSelectMap.ILandmarkResourceProvider
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace Scenes.OutGame.QuestSelectMap
{
  [Token(Token = "0x20033C0")]
  public interface ILandmarkResourceProvider
  {
    [Token(Token = "0x6014585")]
    bool CanGetMapLandmarkResource();

    [Token(Token = "0x6014586")]
    MapLandmarkResource GetMapLandmarkResource();
  }
}
