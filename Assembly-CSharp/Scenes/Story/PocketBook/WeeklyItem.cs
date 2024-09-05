// Decompiled with JetBrains decompiler
// Type: Scenes.Story.PocketBook.WeeklyItem
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace Scenes.Story.PocketBook
{
  [Token(Token = "0x2002DCA")]
  public class WeeklyItem : MonoBehaviour
  {
    [Token(Token = "0x400C4D4")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private Text sundayNoonIcon;
    [Token(Token = "0x400C4D5")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private Text sundayNightIcon;
    [Token(Token = "0x400C4D6")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private Text mondayNoonIcon;
    [Token(Token = "0x400C4D7")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    private Text mondayNightIcon;
    [Token(Token = "0x400C4D8")]
    [FieldOffset(Offset = "0x38")]
    [SerializeField]
    private Text tuesdayNoonIcon;
    [Token(Token = "0x400C4D9")]
    [FieldOffset(Offset = "0x40")]
    [SerializeField]
    private Text tuesdayNightIcon;
    [Token(Token = "0x400C4DA")]
    [FieldOffset(Offset = "0x48")]
    [SerializeField]
    private Text wednesdayNoonIcon;
    [Token(Token = "0x400C4DB")]
    [FieldOffset(Offset = "0x50")]
    [SerializeField]
    private Text wednesdayNightIcon;
    [Token(Token = "0x400C4DC")]
    [FieldOffset(Offset = "0x58")]
    [SerializeField]
    private Text thursdayNoonIcon;
    [Token(Token = "0x400C4DD")]
    [FieldOffset(Offset = "0x60")]
    [SerializeField]
    private Text thursdayNightIcon;
    [Token(Token = "0x400C4DE")]
    [FieldOffset(Offset = "0x68")]
    [SerializeField]
    private Text fridayNoonIcon;
    [Token(Token = "0x400C4DF")]
    [FieldOffset(Offset = "0x70")]
    [SerializeField]
    private Text fridayNightIcon;
    [Token(Token = "0x400C4E0")]
    [FieldOffset(Offset = "0x78")]
    [SerializeField]
    private Text saturdayNoonIcon;
    [Token(Token = "0x400C4E1")]
    [FieldOffset(Offset = "0x80")]
    [SerializeField]
    private Text saturdayNightIcon;

    [Token(Token = "0x6011E73")]
    [Address(RVA = "0x3FABA44", Offset = "0x3FABA44", VA = "0x3FABA44")]
    public void Initialize(int commuWeeklyId)
    {
    }

    [Token(Token = "0x6011E74")]
    [Address(RVA = "0x3FABB9C", Offset = "0x3FABB9C", VA = "0x3FABB9C")]
    private void SetDayCondition(Text iconText, int dayCondition)
    {
    }

    [Token(Token = "0x6011E75")]
    [Address(RVA = "0x3FABCF0", Offset = "0x3FABCF0", VA = "0x3FABCF0")]
    public WeeklyItem()
    {
    }
  }
}
