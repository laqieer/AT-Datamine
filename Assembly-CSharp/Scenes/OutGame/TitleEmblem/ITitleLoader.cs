// Decompiled with JetBrains decompiler
// Type: Scenes.OutGame.TitleEmblem.ITitleLoader
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Cysharp.Threading.Tasks;
using GameCore.MasterData;
using Il2CppDummyDll;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

#nullable disable
namespace Scenes.OutGame.TitleEmblem
{
  [Token(Token = "0x2003358")]
  public interface ITitleLoader
  {
    [Token(Token = "0x60142DE")]
    bool IsUnlocked(int titleId);

    [Token(Token = "0x60142DF")]
    UniTask<Sprite> LoadSpriteAsync(int titleId, CancellationToken cancellationToken);

    [Token(Token = "0x60142E0")]
    ITitleMasterData GetTitleMaster(int titleId);

    [Token(Token = "0x60142E1")]
    IEnumerable<ITitleMasterData> GetAllMasters();
  }
}
