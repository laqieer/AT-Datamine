// Decompiled with JetBrains decompiler
// Type: Scenes.Story.CalenderView
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.Tween;
using Il2CppDummyDll;
using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace Scenes.Story
{
  [Token(Token = "0x2002D79")]
  public class CalenderView : MonoBehaviour
  {
    [Token(Token = "0x400C32F")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    public GameObject containerCalender;
    [Token(Token = "0x400C330")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    public GameObject todayPos01;
    [Token(Token = "0x400C331")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    public GameObject todayPos02;
    [Token(Token = "0x400C332")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    public GameObject[] sDayPos;
    [Token(Token = "0x400C333")]
    [FieldOffset(Offset = "0x38")]
    [SerializeField]
    public GameObject[] vDayPos;
    [Token(Token = "0x400C334")]
    [FieldOffset(Offset = "0x40")]
    [SerializeField]
    public GameObject containerDays;
    [Token(Token = "0x400C335")]
    [FieldOffset(Offset = "0x48")]
    [SerializeField]
    public GameObject containerTimeLimit;
    [Token(Token = "0x400C336")]
    [FieldOffset(Offset = "0x50")]
    [SerializeField]
    public GameObject containerToday;
    [Token(Token = "0x400C337")]
    [FieldOffset(Offset = "0x58")]
    [SerializeField]
    public TextMeshProUGUI txtYearNum;
    [Token(Token = "0x400C338")]
    [FieldOffset(Offset = "0x60")]
    [SerializeField]
    public Image imageMonth;
    [Token(Token = "0x400C339")]
    [FieldOffset(Offset = "0x68")]
    [SerializeField]
    public TextMeshProUGUI txtMonth;
    [Token(Token = "0x400C33A")]
    [FieldOffset(Offset = "0x70")]
    [SerializeField]
    public TextMeshProUGUI txtTodaySub01;
    [Token(Token = "0x400C33B")]
    [FieldOffset(Offset = "0x78")]
    [SerializeField]
    public TextMeshProUGUI txtTodaySub02;
    [Token(Token = "0x400C33C")]
    [FieldOffset(Offset = "0x80")]
    private UIAnimationController animationController;
    [Token(Token = "0x400C33D")]
    [FieldOffset(Offset = "0x88")]
    private Action callback;
    [Token(Token = "0x400C33E")]
    [FieldOffset(Offset = "0x90")]
    private DateTime calenderToday;
    [Token(Token = "0x400C33F")]
    [FieldOffset(Offset = "0x98")]
    private DateTime timeLimitDt;
    [Token(Token = "0x400C340")]
    [FieldOffset(Offset = "0xA0")]
    private int addDay;
    [Token(Token = "0x400C341")]
    [FieldOffset(Offset = "0xA8")]
    private List<GameObject> cloneGameObj;
    [Token(Token = "0x400C342")]
    [FieldOffset(Offset = "0xB0")]
    private GameObject timeLimitObj;
    [Token(Token = "0x400C343")]
    [FieldOffset(Offset = "0xB8")]
    private GameObject timeLimitObjDay1;
    [Token(Token = "0x400C344")]
    [FieldOffset(Offset = "0xC0")]
    private GameObject timeLimitObjDay2;
    [Token(Token = "0x400C345")]
    [FieldOffset(Offset = "0xC8")]
    private string[] dayOfWeekShort;
    [Token(Token = "0x400C346")]
    [FieldOffset(Offset = "0xD0")]
    private string[] dayWeekBygone;
    [Token(Token = "0x400C347")]
    [FieldOffset(Offset = "0xD8")]
    private string[] dayDayBygone;
    [Token(Token = "0x400C348")]
    [FieldOffset(Offset = "0xE0")]
    private string[] dayWeekFuture;
    [Token(Token = "0x400C349")]
    [FieldOffset(Offset = "0xE8")]
    private string[] dayDayFuture;
    [Token(Token = "0x400C34A")]
    [FieldOffset(Offset = "0xF0")]
    private string[] todayWeek;
    [Token(Token = "0x400C34B")]
    [FieldOffset(Offset = "0xF8")]
    private string[] todayDay;
    [Token(Token = "0x400C34C")]
    [FieldOffset(Offset = "0x100")]
    private string dayEventBygone;
    [Token(Token = "0x400C34D")]
    [FieldOffset(Offset = "0x108")]
    private string dayEventFuture;
    [Token(Token = "0x400C34E")]
    [FieldOffset(Offset = "0x110")]
    private string todayEvent;
    [Token(Token = "0x400C34F")]
    [FieldOffset(Offset = "0x118")]
    private string[] dayOfMonth;

    [Token(Token = "0x6011C68")]
    [Address(RVA = "0x3F9A1B4", Offset = "0x3F9A1B4", VA = "0x3F9A1B4")]
    private void Awake()
    {
    }

    [Token(Token = "0x6011C69")]
    [Address(RVA = "0x3F9A2B4", Offset = "0x3F9A2B4", VA = "0x3F9A2B4")]
    private void Start()
    {
    }

    [Token(Token = "0x6011C6A")]
    [Address(RVA = "0x3F9A2B8", Offset = "0x3F9A2B8", VA = "0x3F9A2B8")]
    private void Update()
    {
    }

    [Token(Token = "0x6011C6B")]
    [Address(RVA = "0x3F9A2CC", Offset = "0x3F9A2CC", VA = "0x3F9A2CC")]
    private void OnDisable()
    {
    }

    [Token(Token = "0x6011C6C")]
    [Address(RVA = "0x3F9A468", Offset = "0x3F9A468", VA = "0x3F9A468")]
    public void StartCalender(string today, string limitDay, int addDay, Action callback = null)
    {
    }

    [Token(Token = "0x6011C6D")]
    [Address(RVA = "0x3F9A538", Offset = "0x3F9A538", VA = "0x3F9A538")]
    public void Setting(DateTime from, DateTime to, DateTime limit, Action callback = null)
    {
    }

    [Token(Token = "0x6011C6E")]
    [Address(RVA = "0x3F9A504", Offset = "0x3F9A504", VA = "0x3F9A504")]
    public void Play()
    {
    }

    [Token(Token = "0x6011C6F")]
    [Address(RVA = "0x3F9ADB0", Offset = "0x3F9ADB0", VA = "0x3F9ADB0")]
    private IEnumerator MainFlow() => (IEnumerator) null;

    [Token(Token = "0x6011C70")]
    [Address(RVA = "0x3F9AE40", Offset = "0x3F9AE40", VA = "0x3F9AE40")]
    private IEnumerator WaitAnim(string anim) => (IEnumerator) null;

    [Token(Token = "0x6011C71")]
    [Address(RVA = "0x3F9A5D4", Offset = "0x3F9A5D4", VA = "0x3F9A5D4")]
    private void SetCalenderClone()
    {
    }

    [Token(Token = "0x6011C72")]
    [Address(RVA = "0x3F9A808", Offset = "0x3F9A808", VA = "0x3F9A808")]
    private void SetCalenderDraw(DateTime todayDt)
    {
    }

    [Token(Token = "0x6011C73")]
    [Address(RVA = "0x3F9B134", Offset = "0x3F9B134", VA = "0x3F9B134")]
    private GameObject SetTodayDraw(GameObject parentObj, TextMeshProUGUI textObj, DateTime dt)
    {
      return (GameObject) null;
    }

    [Token(Token = "0x6011C74")]
    [Address(RVA = "0x3F9AEDC", Offset = "0x3F9AEDC", VA = "0x3F9AEDC")]
    private GameObject CloneGameObject(GameObject masterObj, GameObject parent)
    {
      return (GameObject) null;
    }

    [Token(Token = "0x6011C75")]
    [Address(RVA = "0x3F9B01C", Offset = "0x3F9B01C", VA = "0x3F9B01C")]
    private void SetComponentText(GameObject obj, string name, string message)
    {
    }

    [Token(Token = "0x6011C76")]
    [Address(RVA = "0x3F9A2D0", Offset = "0x3F9A2D0", VA = "0x3F9A2D0")]
    private void Removed()
    {
    }

    [Token(Token = "0x6011C77")]
    [Address(RVA = "0x3F9B3BC", Offset = "0x3F9B3BC", VA = "0x3F9B3BC")]
    public CalenderView()
    {
    }
  }
}
