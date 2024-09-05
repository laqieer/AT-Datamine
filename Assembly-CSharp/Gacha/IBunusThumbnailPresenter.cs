// Decompiled with JetBrains decompiler
// Type: Gacha.IBunusThumbnailPresenter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore;
using Il2CppDummyDll;

#nullable disable
namespace Gacha
{
  [Token(Token = "0x2001560")]
  internal interface IBunusThumbnailPresenter
  {
    [Token(Token = "0x6007912")]
    void AssignView(GachaBonusThumbnailView view);

    [Token(Token = "0x6007913")]
    void Preload(AssetCachedSpawner spawner);
  }
}
