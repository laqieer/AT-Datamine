// Decompiled with JetBrains decompiler
// Type: Story.Adv.StoryMainAdvStage
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
  [Token(Token = "0x2000745")]
  public class StoryMainAdvStage : AdvStage, HaveStoryAlreadyRead, HaveStoryAlreadyReadAdvOption
  {
    [Token(Token = "0x60028AB")]
    [Address(RVA = "0x3678588", Offset = "0x3678588", VA = "0x3678588")]
    public StoryMainAdvStage(
      AdvDemoInfoData demoInfo,
      Func<string, GameObject> areaObjectModelRefGetMethod,
      Func<GameObject> getPlayerOjectModelRefMethod,
      Action onChangeArea)
    {
    }
  }
}
