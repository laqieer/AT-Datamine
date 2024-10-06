// Decompiled with JetBrains decompiler
// Type: Scenes.OutGame.EventQuest.RouteButtonList
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.MasterData;
using Il2CppDummyDll;
using System;
using System.Collections.Generic;
using UnityEngine;

#nullable disable
namespace Scenes.OutGame.EventQuest
{
  [Token(Token = "0x200366D")]
  public class RouteButtonList : MonoBehaviour
  {
    [Token(Token = "0x400ECD5")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private RectTransform buttonParent;
    [Token(Token = "0x400ECD6")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private CommonButton baseButton;
    [Token(Token = "0x400ECD7")]
    [FieldOffset(Offset = "0x28")]
    private List<CommonButton> buttonList;

    [Token(Token = "0x60156CC")]
    [Address(RVA = "0x18DDC3C", Offset = "0x18DDC3C", VA = "0x18DDC3C")]
    public void CreateRouteButton(int chapter, Action<StoryRouteData> action)
    {
    }

    [Token(Token = "0x60156CD")]
    [Address(RVA = "0x18E0410", Offset = "0x18E0410", VA = "0x18E0410")]
    private void ResetObject()
    {
    }

    [Token(Token = "0x60156CE")]
    [Address(RVA = "0x18E05E8", Offset = "0x18E05E8", VA = "0x18E05E8")]
    private void OnDestroy()
    {
    }

    [Token(Token = "0x60156CF")]
    [Address(RVA = "0x18E05EC", Offset = "0x18E05EC", VA = "0x18E05EC")]
    public RouteButtonList()
    {
    }
  }
}
