// Decompiled with JetBrains decompiler
// Type: Tween.Tweeners.TweenRadarChart
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.Tween;
using Il2CppDummyDll;
using Scenes.Story;
using System;
using System.Collections.Generic;
using UnityEngine;

#nullable disable
namespace Tween.Tweeners
{
  [Token(Token = "0x2000516")]
  [RequireComponent(typeof (RadarChartMesh))]
  [AddComponentMenu("Tween/Tweeners/Tween RadarChart")]
  public class TweenRadarChart : UITweener
  {
    [Token(Token = "0x4001B1E")]
    [FieldOffset(Offset = "0x68")]
    [SerializeField]
    public List<TweenRadarChart.VerticesParam> Vertices;

    [Token(Token = "0x6001D68")]
    [Address(RVA = "0x29F9B88", Offset = "0x29F9B88", VA = "0x29F9B88")]
    public void SetVerticesParam(int index, float fromValue, float toValue)
    {
    }

    [Token(Token = "0x6001D69")]
    [Address(RVA = "0x29F9C4C", Offset = "0x29F9C4C", VA = "0x29F9C4C", Slot = "8")]
    protected override void OnUpdate(float factor, bool isFinished)
    {
    }

    [Token(Token = "0x6001D6A")]
    [Address(RVA = "0x29F9E28", Offset = "0x29F9E28", VA = "0x29F9E28")]
    public TweenRadarChart()
    {
    }

    [Token(Token = "0x2000517")]
    [Serializable]
    public class VerticesParam
    {
      [Token(Token = "0x4001B1F")]
      [FieldOffset(Offset = "0x10")]
      [Range(0.0f, 1f)]
      [SerializeField]
      private float from;
      [Token(Token = "0x4001B20")]
      [FieldOffset(Offset = "0x14")]
      [Range(0.0f, 1f)]
      [SerializeField]
      private float to;

      [Token(Token = "0x170003CE")]
      public float From
      {
        [Token(Token = "0x6001D6B"), Address(RVA = "0x29F9EA4", Offset = "0x29F9EA4", VA = "0x29F9EA4")] get
        {
          return new float();
        }
        [Token(Token = "0x6001D6C"), Address(RVA = "0x29F9EAC", Offset = "0x29F9EAC", VA = "0x29F9EAC")] set
        {
        }
      }

      [Token(Token = "0x170003CF")]
      public float To
      {
        [Token(Token = "0x6001D6D"), Address(RVA = "0x29F9EB4", Offset = "0x29F9EB4", VA = "0x29F9EB4")] get
        {
          return new float();
        }
        [Token(Token = "0x6001D6E"), Address(RVA = "0x29F9EBC", Offset = "0x29F9EBC", VA = "0x29F9EBC")] set
        {
        }
      }

      [Token(Token = "0x6001D6F")]
      [Address(RVA = "0x29F9E18", Offset = "0x29F9E18", VA = "0x29F9E18")]
      public VerticesParam()
      {
      }
    }
  }
}
