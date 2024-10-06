// Decompiled with JetBrains decompiler
// Type: Scenes.Story.Common.WeatherIcon
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.MasterData;
using GameCore.Tween;
using Il2CppDummyDll;
using System.Collections.Generic;
using UnityEngine;

#nullable disable
namespace Scenes.Story.Common
{
  [Token(Token = "0x2002EEB")]
  public class WeatherIcon : MonoBehaviour
  {
    [Token(Token = "0x400C907")]
    [FieldOffset(Offset = "0x18")]
    private Dictionary<int, string> storyWeatherAnimMap;
    [Token(Token = "0x400C908")]
    [FieldOffset(Offset = "0x20")]
    private Dictionary<int, string> battleWeatherAnimMap;
    [Token(Token = "0x400C909")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private UITweenGroup tweenGroup;
    [Token(Token = "0x400C90A")]
    [FieldOffset(Offset = "0x30")]
    private string reservedTweenGroupID;

    [Token(Token = "0x601253A")]
    [Address(RVA = "0x22F6EC8", Offset = "0x22F6EC8", VA = "0x22F6EC8")]
    private void OnEnable()
    {
    }

    [Token(Token = "0x601253B")]
    [Address(RVA = "0x22F6F44", Offset = "0x22F6F44", VA = "0x22F6F44")]
    public void PlayWeatherIcon(StoryWeatherTypeEnum weatherType)
    {
    }

    [Token(Token = "0x601253C")]
    [Address(RVA = "0x22F6FFC", Offset = "0x22F6FFC", VA = "0x22F6FFC")]
    public void PlayWeatherIcon(BattleWeatherTypeEnum weatherType)
    {
    }

    [Token(Token = "0x601253D")]
    [Address(RVA = "0x22F70AC", Offset = "0x22F70AC", VA = "0x22F70AC")]
    public WeatherIcon()
    {
    }
  }
}
