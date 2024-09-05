// Decompiled with JetBrains decompiler
// Type: Scenes.Expedition.Main.ExpeditionTimeManager
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections.Generic;
using UnityEngine;

#nullable disable
namespace Scenes.Expedition.Main
{
  [Token(Token = "0x2002CC8")]
  public class ExpeditionTimeManager : MonoBehaviour
  {
    [Token(Token = "0x400BF6D")]
    [FieldOffset(Offset = "0x18")]
    public int boxStorage;
    [Token(Token = "0x400BF6E")]
    [FieldOffset(Offset = "0x1C")]
    public int boxMaxStorage;
    [Token(Token = "0x400BF70")]
    [FieldOffset(Offset = "0x28")]
    private List<ExpeditionTimeManager.BoxTimeData> boxTimeDatas;
    [Token(Token = "0x400BF71")]
    [FieldOffset(Offset = "0x30")]
    private bool isBoxUpdate;
    [Token(Token = "0x400BF72")]
    [FieldOffset(Offset = "0x38")]
    private Action boxUpdateAction;
    [Token(Token = "0x400BF73")]
    [FieldOffset(Offset = "0x40")]
    private Dictionary<string, int> styleStoredExperienceDic;
    [Token(Token = "0x400BF74")]
    [FieldOffset(Offset = "0x48")]
    private List<ExpeditionTimeManager.StyleExpTimeData> styleExpTimeDatas;
    [Token(Token = "0x400BF75")]
    [FieldOffset(Offset = "0x50")]
    private bool isStyleExpUpdate;
    [Token(Token = "0x400BF76")]
    [FieldOffset(Offset = "0x58")]
    private Action styleExpUpdateAction;

    [Token(Token = "0x17003C47")]
    public int BoxMaxStorageRestTime
    {
      [Token(Token = "0x6011862"), Address(RVA = "0x49486AC", Offset = "0x49486AC", VA = "0x49486AC")] get
      {
        return new int();
      }
      [Token(Token = "0x6011863"), Address(RVA = "0x49486B4", Offset = "0x49486B4", VA = "0x49486B4")] private set
      {
      }
    }

    [Token(Token = "0x17003C48")]
    public IReadOnlyDictionary<string, int> StyleStoredExperienceDic
    {
      [Token(Token = "0x6011864"), Address(RVA = "0x49486BC", Offset = "0x49486BC", VA = "0x49486BC")] get
      {
        return (IReadOnlyDictionary<string, int>) null;
      }
    }

    [Token(Token = "0x6011865")]
    [Address(RVA = "0x49467A8", Offset = "0x49467A8", VA = "0x49467A8")]
    public void Initialize()
    {
    }

    [Token(Token = "0x6011866")]
    [Address(RVA = "0x49443CC", Offset = "0x49443CC", VA = "0x49443CC")]
    public void UpdateBoxData()
    {
    }

    [Token(Token = "0x6011867")]
    [Address(RVA = "0x49489BC", Offset = "0x49489BC", VA = "0x49489BC")]
    public void SetBoxUpdateAction(Action boxUpdateAction)
    {
    }

    [Token(Token = "0x6011868")]
    [Address(RVA = "0x49489C4", Offset = "0x49489C4", VA = "0x49489C4")]
    private void UpdateBoxTimer()
    {
    }

    [Token(Token = "0x6011869")]
    [Address(RVA = "0x49486D4", Offset = "0x49486D4", VA = "0x49486D4")]
    private void CalcBoxMaxStorageRestTime()
    {
    }

    [Token(Token = "0x601186A")]
    [Address(RVA = "0x49438E8", Offset = "0x49438E8", VA = "0x49438E8")]
    public void UpdateStyleExpData()
    {
    }

    [Token(Token = "0x601186B")]
    [Address(RVA = "0x4948B60", Offset = "0x4948B60", VA = "0x4948B60")]
    public void SetStyleExpUpdateAction(Action styleExpUpdateAction)
    {
    }

    [Token(Token = "0x601186C")]
    [Address(RVA = "0x4948B68", Offset = "0x4948B68", VA = "0x4948B68")]
    private void UpdateStyleExpTimer()
    {
    }

    [Token(Token = "0x601186D")]
    [Address(RVA = "0x4948F6C", Offset = "0x4948F6C", VA = "0x4948F6C")]
    private void Update()
    {
    }

    [Token(Token = "0x601186E")]
    [Address(RVA = "0x4948F84", Offset = "0x4948F84", VA = "0x4948F84")]
    public ExpeditionTimeManager()
    {
    }

    [Token(Token = "0x2002CC9")]
    private class BoxTimeData
    {
      [Token(Token = "0x400BF77")]
      [FieldOffset(Offset = "0x10")]
      public float boxTimer;
      [Token(Token = "0x400BF78")]
      [FieldOffset(Offset = "0x14")]
      public float boxProductionTime;

      [Token(Token = "0x601186F")]
      [Address(RVA = "0x49486CC", Offset = "0x49486CC", VA = "0x49486CC")]
      public BoxTimeData()
      {
      }
    }

    [Token(Token = "0x2002CCA")]
    private class StyleExpTimeData
    {
      [Token(Token = "0x400BF79")]
      [FieldOffset(Offset = "0x10")]
      public float styleExpTimer;
      [Token(Token = "0x400BF7A")]
      [FieldOffset(Offset = "0x14")]
      public float styleExpProductionTime;
      [Token(Token = "0x400BF7B")]
      [FieldOffset(Offset = "0x18")]
      public int styleExpProductionValue;
      [Token(Token = "0x400BF7C")]
      [FieldOffset(Offset = "0x20")]
      public List<string> setStyleIdList;

      [Token(Token = "0x6011870")]
      [Address(RVA = "0x4948B58", Offset = "0x4948B58", VA = "0x4948B58")]
      public StyleExpTimeData()
      {
      }
    }
  }
}
