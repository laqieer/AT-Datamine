﻿// Decompiled with JetBrains decompiler
// Type: Gacha.IRewardListItemPresenter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore;
using Il2CppDummyDll;

#nullable disable
namespace Gacha
{
  [Token(Token = "0x2001561")]
  public interface IRewardListItemPresenter
  {
    [Token(Token = "0x6007914")]
    void AssignView(GachaResultRewardListItemView view);

    [Token(Token = "0x6007915")]
    void Preload(AssetCachedSpawner spawner);
  }
}
