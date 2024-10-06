// Decompiled with JetBrains decompiler
// Type: Story.Adv.StoryFreeStartAdvStage
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.MasterData;
using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace Story.Adv
{
  [Token(Token = "0x2000746")]
  public class StoryFreeStartAdvStage : AdvStage, HaveStoryAlreadyRead
  {
    [Token(Token = "0x60028AC")]
    [Address(RVA = "0x3678634", Offset = "0x3678634", VA = "0x3678634")]
    public StoryFreeStartAdvStage(
      AdvDemoInfoData demoInfo,
      Func<string, GameObject> areaObjectModelRefGetMethod,
      Func<GameObject> getPlayerOjectModelRefMethod,
      Action onChangeArea)
    {
    }
  }
}
