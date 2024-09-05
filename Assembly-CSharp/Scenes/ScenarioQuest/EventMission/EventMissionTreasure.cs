// Decompiled with JetBrains decompiler
// Type: Scenes.ScenarioQuest.EventMission.EventMissionTreasure
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.Tween;
using Il2CppDummyDll;
using System;
using System.Collections;
using TMPro;
using UI.Direction;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace Scenes.ScenarioQuest.EventMission
{
  [Token(Token = "0x200299A")]
  public class EventMissionTreasure : MonoBehaviour
  {
    [Token(Token = "0x400B132")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private TextMeshProUGUI rewardText;
    [Token(Token = "0x400B133")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private Button button;
    [Token(Token = "0x400B134")]
    [FieldOffset(Offset = "0x28")]
    [Header("Tween")]
    [SerializeField]
    private UITweenGroup tween;
    [Token(Token = "0x400B135")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    [Header("TimeLine")]
    private UITimelineController timeline;
    [Token(Token = "0x400B13C")]
    [FieldOffset(Offset = "0x4D")]
    private bool isPlayingEffectLoop;

    [Token(Token = "0x1700390E")]
    public int ProgressId
    {
      [Token(Token = "0x6010577"), Address(RVA = "0x4762AE0", Offset = "0x4762AE0", VA = "0x4762AE0")] get
      {
        return new int();
      }
      [Token(Token = "0x6010578"), Address(RVA = "0x4762AE8", Offset = "0x4762AE8", VA = "0x4762AE8")] private set
      {
      }
    }

    [Token(Token = "0x1700390F")]
    public int Number
    {
      [Token(Token = "0x6010579"), Address(RVA = "0x4762AF0", Offset = "0x4762AF0", VA = "0x4762AF0")] get
      {
        return new int();
      }
      [Token(Token = "0x601057A"), Address(RVA = "0x4762AF8", Offset = "0x4762AF8", VA = "0x4762AF8")] private set
      {
      }
    }

    [Token(Token = "0x17003910")]
    public int RewardPoint
    {
      [Token(Token = "0x601057B"), Address(RVA = "0x4762B00", Offset = "0x4762B00", VA = "0x4762B00")] get
      {
        return new int();
      }
      [Token(Token = "0x601057C"), Address(RVA = "0x4762B08", Offset = "0x4762B08", VA = "0x4762B08")] private set
      {
      }
    }

    [Token(Token = "0x17003911")]
    public TreasureType Type
    {
      [Token(Token = "0x601057D"), Address(RVA = "0x4762B10", Offset = "0x4762B10", VA = "0x4762B10")] get
      {
        return new TreasureType();
      }
      [Token(Token = "0x601057E"), Address(RVA = "0x4762B18", Offset = "0x4762B18", VA = "0x4762B18")] private set
      {
      }
    }

    [Token(Token = "0x17003912")]
    public float PosX
    {
      [Token(Token = "0x601057F"), Address(RVA = "0x4762B20", Offset = "0x4762B20", VA = "0x4762B20")] get
      {
        return new float();
      }
      [Token(Token = "0x6010580"), Address(RVA = "0x4762B28", Offset = "0x4762B28", VA = "0x4762B28")] set
      {
      }
    }

    [Token(Token = "0x17003913")]
    public bool IsLast
    {
      [Token(Token = "0x6010581"), Address(RVA = "0x4762B30", Offset = "0x4762B30", VA = "0x4762B30")] get
      {
        return new bool();
      }
      [Token(Token = "0x6010582"), Address(RVA = "0x4762B38", Offset = "0x4762B38", VA = "0x4762B38")] private set
      {
      }
    }

    [Token(Token = "0x6010583")]
    [Address(RVA = "0x4762938", Offset = "0x4762938", VA = "0x4762938")]
    public void Initialize(
      int progressId,
      int num,
      int rewardPoint,
      TreasureType treasureType,
      float posx,
      bool isLast,
      Action<bool, int> onclick)
    {
    }

    [Token(Token = "0x6010584")]
    [Address(RVA = "0x4762904", Offset = "0x4762904", VA = "0x4762904")]
    public void UpdateType(TreasureType treasureType, Action<bool, int> onclick)
    {
    }

    [Token(Token = "0x6010585")]
    [Address(RVA = "0x4762E64", Offset = "0x4762E64", VA = "0x4762E64")]
    private IEnumerator InitializeUITimeLineController(Action encAction) => (IEnumerator) null;

    [Token(Token = "0x6010586")]
    [Address(RVA = "0x4762B44", Offset = "0x4762B44", VA = "0x4762B44")]
    private void SettingTreasureButton(Action<bool, int> getProgressReward)
    {
    }

    [Token(Token = "0x6010587")]
    [Address(RVA = "0x4762ED8", Offset = "0x4762ED8", VA = "0x4762ED8")]
    private GameObject GetEffBack() => (GameObject) null;

    [Token(Token = "0x6010588")]
    [Address(RVA = "0x4762DB4", Offset = "0x4762DB4", VA = "0x4762DB4")]
    private void PlayTween()
    {
    }

    [Token(Token = "0x6010589")]
    [Address(RVA = "0x4762F94", Offset = "0x4762F94", VA = "0x4762F94")]
    public EventMissionTreasure()
    {
    }

    [Token(Token = "0x200299B")]
    private class TreasureTweenName
    {
      [Token(Token = "0x400B13D")]
      public const string OPEN_TWEEN_NAME = "Loop";
      [Token(Token = "0x400B13E")]
      public const string RECEIVED_TWEEN_NAME = "Check_Anim";
      [Token(Token = "0x400B13F")]
      public const string CLOSED_TWEEN_NAME = "CheckOn";
      [Token(Token = "0x400B140")]
      public const string NORMAL_TWEEN_NAME = "CheckOff";

      [Token(Token = "0x601058A")]
      [Address(RVA = "0x4880E84", Offset = "0x4880E84", VA = "0x4880E84")]
      public TreasureTweenName()
      {
      }
    }
  }
}
