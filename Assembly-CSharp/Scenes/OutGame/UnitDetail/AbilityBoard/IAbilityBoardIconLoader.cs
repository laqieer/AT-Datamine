// Decompiled with JetBrains decompiler
// Type: Scenes.OutGame.UnitDetail.AbilityBoard.IAbilityBoardIconLoader
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.UIControls;
using Il2CppDummyDll;
using StaqData;
using System.Collections;
using UnityEngine;

#nullable disable
namespace Scenes.OutGame.UnitDetail.AbilityBoard
{
  [Token(Token = "0x20032F1")]
  public interface IAbilityBoardIconLoader
  {
    [Token(Token = "0x6014046")]
    IEnumerator SetItemIcon(ItemIcon icon, ItemUtility.Parameter parameter, bool rarityBase = true);

    [Token(Token = "0x6014047")]
    IEnumerator SetItemIcon(ItemIcon icon, int id);

    [Token(Token = "0x6014048")]
    Sprite GetNodeIcon(int iconId);
  }
}
