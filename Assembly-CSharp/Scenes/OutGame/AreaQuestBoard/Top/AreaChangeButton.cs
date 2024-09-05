// Decompiled with JetBrains decompiler
// Type: Scenes.OutGame.AreaQuestBoard.Top.AreaChangeButton
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Cysharp.Threading.Tasks;
using Il2CppDummyDll;
using System;
using UnityEngine;
using UnityEngine.Playables;

#nullable disable
namespace Scenes.OutGame.AreaQuestBoard.Top
{
  [Token(Token = "0x20038CE")]
  internal class AreaChangeButton : MonoBehaviour
  {
    [Token(Token = "0x400F86E")]
    [FieldOffset(Offset = "0x18")]
    [Header("タイムライン")]
    [SerializeField]
    private PlayableDirector lockPlayableDirector;
    [Token(Token = "0x400F86F")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private PlayableDirector onButtonPlayableDirector;
    [Token(Token = "0x400F870")]
    [FieldOffset(Offset = "0x28")]
    [Header("LockボタンのInアニメーションを遅延させる時間 (秒)")]
    [SerializeField]
    private float lockPlayDelaySeconds;
    [Token(Token = "0x400F871")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    [Header("ボタン")]
    private CommonButton button;
    [Token(Token = "0x400F872")]
    [FieldOffset(Offset = "0x38")]
    [SerializeField]
    [Header("OFF")]
    private GameObject off;
    [Token(Token = "0x400F873")]
    [FieldOffset(Offset = "0x40")]
    [SerializeField]
    private GameObject lockObj;
    [Token(Token = "0x400F874")]
    [FieldOffset(Offset = "0x48")]
    [SerializeField]
    [Header("ON")]
    private GameObject on;
    [Token(Token = "0x400F875")]
    [FieldOffset(Offset = "0x50")]
    private bool existRequestPlayDirection;
    [Token(Token = "0x400F876")]
    [FieldOffset(Offset = "0x51")]
    private bool isUnlock;
    [Token(Token = "0x400F877")]
    [FieldOffset(Offset = "0x58")]
    private Action onFinishUnlockDirection;

    [Token(Token = "0x1700497C")]
    public bool IsActive
    {
      [Token(Token = "0x6016540"), Address(RVA = "0x2079B18", Offset = "0x2079B18", VA = "0x2079B18")] get
      {
        return new bool();
      }
      [Token(Token = "0x6016541"), Address(RVA = "0x2079B20", Offset = "0x2079B20", VA = "0x2079B20")] private set
      {
      }
    }

    [Token(Token = "0x1700497D")]
    public int AreaId
    {
      [Token(Token = "0x6016542"), Address(RVA = "0x2079B2C", Offset = "0x2079B2C", VA = "0x2079B2C")] get
      {
        return new int();
      }
      [Token(Token = "0x6016543"), Address(RVA = "0x2079B34", Offset = "0x2079B34", VA = "0x2079B34")] private set
      {
      }
    }

    [Token(Token = "0x6016544")]
    [Address(RVA = "0x2074BE0", Offset = "0x2074BE0", VA = "0x2074BE0")]
    public void SetUnlock(int currentAreaId, bool isUnlock, bool requestPlayUnlockAnim = false)
    {
    }

    [Token(Token = "0x6016545")]
    [Address(RVA = "0x2079C68", Offset = "0x2079C68", VA = "0x2079C68")]
    public void SetAction(int areaId, Action onClick)
    {
    }

    [Token(Token = "0x6016546")]
    [Address(RVA = "0x2079B78", Offset = "0x2079B78", VA = "0x2079B78")]
    public void EnableOnButton()
    {
    }

    [Token(Token = "0x6016547")]
    [Address(RVA = "0x2079D10", Offset = "0x2079D10", VA = "0x2079D10")]
    public void Disable()
    {
    }

    [Token(Token = "0x6016548")]
    [Address(RVA = "0x2079B3C", Offset = "0x2079B3C", VA = "0x2079B3C")]
    private void EnableLock()
    {
    }

    [Token(Token = "0x6016549")]
    [Address(RVA = "0x2079BE8", Offset = "0x2079BE8", VA = "0x2079BE8")]
    private void EnableOffButton()
    {
    }

    [Token(Token = "0x601654A")]
    [Address(RVA = "0x2079D28", Offset = "0x2079D28", VA = "0x2079D28")]
    public void PlayUnlockDirection(int currentAreaId, Action onFinishUnlockDirection = null)
    {
    }

    [Token(Token = "0x601654B")]
    [Address(RVA = "0x2079D90", Offset = "0x2079D90", VA = "0x2079D90")]
    private UniTaskVoid PlayLockAnim() => new UniTaskVoid();

    [Token(Token = "0x601654C")]
    [Address(RVA = "0x2079E08", Offset = "0x2079E08", VA = "0x2079E08")]
    private void OnFinishUnlock(PlayableDirector director = null)
    {
    }

    [Token(Token = "0x601654D")]
    [Address(RVA = "0x2079ED8", Offset = "0x2079ED8", VA = "0x2079ED8")]
    public AreaChangeButton()
    {
    }
  }
}
