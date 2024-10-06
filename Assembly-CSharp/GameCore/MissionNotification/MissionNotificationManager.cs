// Decompiled with JetBrains decompiler
// Type: GameCore.MissionNotification.MissionNotificationManager
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.DesignPattern;
using GameCore.MasterData;
using Il2CppDummyDll;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

#nullable disable
namespace GameCore.MissionNotification
{
  [Token(Token = "0x2000D31")]
  public class MissionNotificationManager : SingletonMonoBehaviour<MissionNotificationManager>
  {
    [Token(Token = "0x4003B0E")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private RectTransform notificationParent;
    [Token(Token = "0x4003B0F")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private CanvasGroup canvasGroup;
    [Token(Token = "0x4003B10")]
    [FieldOffset(Offset = "0x30")]
    [Tooltip("通知の最大同時表示数")]
    [Range(1f, 5f)]
    [SerializeField]
    private int maxShow;
    [Token(Token = "0x4003B11")]
    [FieldOffset(Offset = "0x34")]
    [Tooltip("同時表示での次の通知表示まで待つ時間")]
    [SerializeField]
    private float nextNotificationWaitTime;
    [Token(Token = "0x4003B12")]
    [FieldOffset(Offset = "0x38")]
    [SerializeField]
    [Tooltip("同時表示が最大数分揃った後、表示している時間")]
    private float displayTime;
    [Token(Token = "0x4003B13")]
    [FieldOffset(Offset = "0x40")]
    private List<MissionNotificationItem> notificationItems;
    [Token(Token = "0x4003B14")]
    [FieldOffset(Offset = "0x48")]
    private HashSet<MissionData> notificationMissionData;
    [Token(Token = "0x4003B15")]
    [FieldOffset(Offset = "0x50")]
    private bool isInitialized;
    [Token(Token = "0x4003B16")]
    [FieldOffset(Offset = "0x51")]
    private bool isPause;
    [Token(Token = "0x4003B17")]
    [FieldOffset(Offset = "0x52")]
    private bool isLockPause;
    [Token(Token = "0x4003B18")]
    [FieldOffset(Offset = "0x54")]
    private float currentDisplayWaitTime;
    [Token(Token = "0x4003B19")]
    [FieldOffset(Offset = "0x58")]
    private Coroutine showCoroutine;

    [Token(Token = "0x6004BE5")]
    [Address(RVA = "0x32E9830", Offset = "0x32E9830", VA = "0x32E9830")]
    public IEnumerator InitializeAsync() => (IEnumerator) null;

    [Token(Token = "0x6004BE6")]
    [Address(RVA = "0x32E98C0", Offset = "0x32E98C0", VA = "0x32E98C0")]
    public void Clear()
    {
    }

    [Token(Token = "0x6004BE7")]
    [Address(RVA = "0x32E9968", Offset = "0x32E9968", VA = "0x32E9968")]
    public void AddNotification(List<int> missionIds)
    {
    }

    [Token(Token = "0x6004BE8")]
    [Address(RVA = "0x32EA394", Offset = "0x32EA394", VA = "0x32EA394")]
    public IEnumerator SetPauseNotification(bool isPause) => (IEnumerator) null;

    [Token(Token = "0x6004BE9")]
    [Address(RVA = "0x32EA438", Offset = "0x32EA438", VA = "0x32EA438")]
    public void SetLockPause(bool isLockPause)
    {
    }

    [Token(Token = "0x6004BEA")]
    [Address(RVA = "0x32EA32C", Offset = "0x32EA32C", VA = "0x32EA32C")]
    private IEnumerator ShowNotification() => (IEnumerator) null;

    [Token(Token = "0x6004BEB")]
    [Address(RVA = "0x32EA46C", Offset = "0x32EA46C", VA = "0x32EA46C")]
    private IEnumerator WaitDisplayTime() => (IEnumerator) null;

    [Token(Token = "0x6004BEC")]
    [Address(RVA = "0x32EA4FC", Offset = "0x32EA4FC", VA = "0x32EA4FC")]
    private void OnClick()
    {
    }

    [Token(Token = "0x6004BED")]
    [Address(RVA = "0x32EA6E0", Offset = "0x32EA6E0", VA = "0x32EA6E0")]
    public MissionNotificationManager()
    {
    }
  }
}
