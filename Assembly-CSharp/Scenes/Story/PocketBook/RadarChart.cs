// Decompiled with JetBrains decompiler
// Type: Scenes.Story.PocketBook.RadarChart
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.MasterData;
using Il2CppDummyDll;
using System;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace Scenes.Story.PocketBook
{
  [Token(Token = "0x2002DC5")]
  public class RadarChart : MonoBehaviour
  {
    [Token(Token = "0x400C4B9")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private RadarChart.OneData[] oneDatas;
    [Token(Token = "0x400C4BA")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private RadarChartMesh radarChartMesh;

    [Token(Token = "0x17003D25")]
    public Color LvMaxColor
    {
      [Token(Token = "0x6011E5B"), Address(RVA = "0x3FAA324", Offset = "0x3FAA324", VA = "0x3FAA324")] get
      {
        return new Color();
      }
    }

    [Token(Token = "0x6011E5C")]
    [Address(RVA = "0x3FAA358", Offset = "0x3FAA358", VA = "0x3FAA358")]
    public void Initialize()
    {
    }

    [Token(Token = "0x6011E5D")]
    [Address(RVA = "0x3FAA908", Offset = "0x3FAA908", VA = "0x3FAA908")]
    public void Initialize(int facilityId)
    {
    }

    [Token(Token = "0x6011E5E")]
    [Address(RVA = "0x3FAAF58", Offset = "0x3FAAF58", VA = "0x3FAAF58")]
    public float GetVolume(int level) => new float();

    [Token(Token = "0x6011E5F")]
    [Address(RVA = "0x3FAAF74", Offset = "0x3FAAF74", VA = "0x3FAAF74")]
    public RadarChart()
    {
    }

    [Token(Token = "0x2002DC6")]
    [Serializable]
    public class OneData
    {
      [Token(Token = "0x400C4BB")]
      [FieldOffset(Offset = "0x10")]
      [SerializeField]
      private Text paramName;
      [Token(Token = "0x400C4BC")]
      [FieldOffset(Offset = "0x18")]
      [SerializeField]
      private Text paramLevel;
      [Token(Token = "0x400C4BD")]
      [FieldOffset(Offset = "0x20")]
      [SerializeField]
      private Text nextExp;
      [Token(Token = "0x400C4BE")]
      [FieldOffset(Offset = "0x28")]
      [SerializeField]
      private GameObject paramUpIcon;
      [Token(Token = "0x400C4BF")]
      [FieldOffset(Offset = "0x30")]
      [SerializeField]
      private Text paramUpText;
      [Token(Token = "0x400C4C0")]
      [FieldOffset(Offset = "0x38")]
      [SerializeField]
      private RectTransform expGauge;
      [Token(Token = "0x400C4C1")]
      [FieldOffset(Offset = "0x40")]
      [SerializeField]
      private Color beforeFillColor;
      [Token(Token = "0x400C4C2")]
      [FieldOffset(Offset = "0x50")]
      [SerializeField]
      private Color lvMaxColor;

      [Token(Token = "0x17003D26")]
      public Color LvMaxColor
      {
        [Token(Token = "0x6011E60"), Address(RVA = "0x3FAAF7C", Offset = "0x3FAAF7C", VA = "0x3FAAF7C")] get
        {
          return new Color();
        }
      }

      [Token(Token = "0x6011E61")]
      [Address(RVA = "0x3FAA59C", Offset = "0x3FAA59C", VA = "0x3FAA59C")]
      public void Set(string paramName, int beforeValue, StoryHumanParameterLevelData levelData)
      {
      }

      [Token(Token = "0x6011E62")]
      [Address(RVA = "0x3FAAEEC", Offset = "0x3FAAEEC", VA = "0x3FAAEEC")]
      public void SetParamUp(bool isActive)
      {
      }

      [Token(Token = "0x6011E63")]
      [Address(RVA = "0x3FAAF88", Offset = "0x3FAAF88", VA = "0x3FAAF88")]
      public OneData()
      {
      }
    }
  }
}
