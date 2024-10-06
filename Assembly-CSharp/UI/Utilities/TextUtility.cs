// Decompiled with JetBrains decompiler
// Type: UI.Utilities.TextUtility
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.MasterData;
using Il2CppDummyDll;
using Scenes.Guild.Data;
using System;

#nullable disable
namespace UI.Utilities
{
  [Token(Token = "0x200088E")]
  public class TextUtility
  {
    [Token(Token = "0x400284B")]
    [FieldOffset(Offset = "0x0")]
    private static TextUtility.ThresholdTimeText[] lastSingedInAtTexts;

    [Token(Token = "0x17000717")]
    private static TextUtility.ThresholdTimeText[] LastSingedInAtTexts
    {
      [Token(Token = "0x60030D5"), Address(RVA = "0x3C108B8", Offset = "0x3C108B8", VA = "0x3C108B8")] get
      {
        return (TextUtility.ThresholdTimeText[]) null;
      }
    }

    [Token(Token = "0x60030D6")]
    [Address(RVA = "0x3C10FA8", Offset = "0x3C10FA8", VA = "0x3C10FA8")]
    public static string GetLastSignedInAtText(DateTime lastSignedInAt) => (string) null;

    [Token(Token = "0x60030D7")]
    [Address(RVA = "0x3C1112C", Offset = "0x3C1112C", VA = "0x3C1112C")]
    public static (int, string) GetLastSignedInAtTextParts(DateTime lastSignedInAt) => ();

    [Token(Token = "0x60030D8")]
    [Address(RVA = "0x3C112E0", Offset = "0x3C112E0", VA = "0x3C112E0")]
    public static string GetLastSignedInAtBeforeText(DateTime lastSignedInAt) => (string) null;

    [Token(Token = "0x60030D9")]
    [Address(RVA = "0x3C115E0", Offset = "0x3C115E0", VA = "0x3C115E0")]
    public static string GetLastPostTimeText(DateTime postTime) => (string) null;

    [Token(Token = "0x60030DA")]
    [Address(RVA = "0x3C11998", Offset = "0x3C11998", VA = "0x3C11998")]
    public static string GetLastSignedInTextForRanking(DateTime postTime) => (string) null;

    [Token(Token = "0x60030DB")]
    [Address(RVA = "0x3C11B70", Offset = "0x3C11B70", VA = "0x3C11B70")]
    public static char OnValidateInput(string text, int index, char addedChar) => new char();

    [Token(Token = "0x60030DC")]
    [Address(RVA = "0x3C11B90", Offset = "0x3C11B90", VA = "0x3C11B90")]
    private static bool IsDisplayable(char addedChar) => new bool();

    [Token(Token = "0x60030DD")]
    [Address(RVA = "0x3C11C04", Offset = "0x3C11C04", VA = "0x3C11C04")]
    public static string GetScheduleText(DateTime begin, DateTime end) => (string) null;

    [Token(Token = "0x60030DE")]
    [Address(RVA = "0x3C11E14", Offset = "0x3C11E14", VA = "0x3C11E14")]
    public static string[] GetScheduleArray(DateTime begin, DateTime end) => (string[]) null;

    [Token(Token = "0x60030DF")]
    [Address(RVA = "0x3C11FA4", Offset = "0x3C11FA4", VA = "0x3C11FA4")]
    public static string ToNumericString(int value) => (string) null;

    [Token(Token = "0x60030E0")]
    [Address(RVA = "0x3C12024", Offset = "0x3C12024", VA = "0x3C12024")]
    public static string ToNumericString(uint value) => (string) null;

    [Token(Token = "0x60030E1")]
    [Address(RVA = "0x3C120A4", Offset = "0x3C120A4", VA = "0x3C120A4")]
    public static string ToNumericString(float value, int digit = 2) => (string) null;

    [Token(Token = "0x60030E2")]
    [Address(RVA = "0x3C1216C", Offset = "0x3C1216C", VA = "0x3C1216C")]
    public static string ToNumericString(long value) => (string) null;

    [Token(Token = "0x60030E3")]
    [Address(RVA = "0x3C121EC", Offset = "0x3C121EC", VA = "0x3C121EC")]
    public static string ToWithSignNumericString(int value) => (string) null;

    [Token(Token = "0x60030E4")]
    [Address(RVA = "0x3C1226C", Offset = "0x3C1226C", VA = "0x3C1226C")]
    public static string ToWithMinusNumericString(int value) => (string) null;

    [Token(Token = "0x60030E5")]
    [Address(RVA = "0x3C122EC", Offset = "0x3C122EC", VA = "0x3C122EC")]
    public static string GetGuildMemberCount(GuildDetailInfo guildDetailInfo) => (string) null;

    [Token(Token = "0x60030E6")]
    [Address(RVA = "0x3C12394", Offset = "0x3C12394", VA = "0x3C12394")]
    public static string GetGuildSubMasterCount(int subMasterCount, GuildDetailInfo guildDetailInfo)
    {
      return (string) null;
    }

    [Token(Token = "0x60030E7")]
    [Address(RVA = "0x3C1243C", Offset = "0x3C1243C", VA = "0x3C1243C")]
    public static string GetGuildRoleTypeText(GuildRoleTypeEnum roleType) => (string) null;

    [Token(Token = "0x60030E8")]
    [Address(RVA = "0x3C12508", Offset = "0x3C12508", VA = "0x3C12508")]
    public static string GetDataDownloadPopupText(long downloadSize) => (string) null;

    [Token(Token = "0x60030E9")]
    [Address(RVA = "0x3C12704", Offset = "0x3C12704", VA = "0x3C12704")]
    public static string GetDataBackgroundDownloadPopupText() => (string) null;

    [Token(Token = "0x60030EA")]
    [Address(RVA = "0x3C127B8", Offset = "0x3C127B8", VA = "0x3C127B8")]
    public static string GetStorageShortagePopupText(long downloadSize) => (string) null;

    [Token(Token = "0x60030EB")]
    [Address(RVA = "0x3C128B4", Offset = "0x3C128B4", VA = "0x3C128B4")]
    public static string GetStorageShortagePopupRetryText(long downloadSize) => (string) null;

    [Token(Token = "0x60030EC")]
    [Address(RVA = "0x3C129B0", Offset = "0x3C129B0", VA = "0x3C129B0")]
    public static string GetSelectMainDownloadModePopupText(
      long normalDownloadSize,
      long lightDownloadSize)
    {
      return (string) null;
    }

    [Token(Token = "0x60030ED")]
    [Address(RVA = "0x3C12C10", Offset = "0x3C12C10", VA = "0x3C12C10")]
    public TextUtility()
    {
    }

    [Token(Token = "0x200088F")]
    public class ThresholdTimeText
    {
      [Token(Token = "0x400284C")]
      private const int MinutesPerHour = 60;
      [Token(Token = "0x400284D")]
      private const int HourPerDay = 24;

      [Token(Token = "0x17000718")]
      public double minutes
      {
        [Token(Token = "0x60030EE"), Address(RVA = "0x3C12C18", Offset = "0x3C12C18", VA = "0x3C12C18")] get
        {
          return new double();
        }
        [Token(Token = "0x60030EF"), Address(RVA = "0x3C12C20", Offset = "0x3C12C20", VA = "0x3C12C20")] private set
        {
        }
      }

      [Token(Token = "0x17000719")]
      public string text
      {
        [Token(Token = "0x60030F0"), Address(RVA = "0x3C12C28", Offset = "0x3C12C28", VA = "0x3C12C28")] get
        {
          return (string) null;
        }
        [Token(Token = "0x60030F1"), Address(RVA = "0x3C12C30", Offset = "0x3C12C30", VA = "0x3C12C30")] private set
        {
        }
      }

      [Token(Token = "0x1700071A")]
      public string format
      {
        [Token(Token = "0x60030F2"), Address(RVA = "0x3C12C38", Offset = "0x3C12C38", VA = "0x3C12C38")] get
        {
          return (string) null;
        }
        [Token(Token = "0x60030F3"), Address(RVA = "0x3C12C40", Offset = "0x3C12C40", VA = "0x3C12C40")] private set
        {
        }
      }

      [Token(Token = "0x1700071B")]
      public int time
      {
        [Token(Token = "0x60030F4"), Address(RVA = "0x3C12C48", Offset = "0x3C12C48", VA = "0x3C12C48")] get
        {
          return new int();
        }
        [Token(Token = "0x60030F5"), Address(RVA = "0x3C12C50", Offset = "0x3C12C50", VA = "0x3C12C50")] private set
        {
        }
      }

      [Token(Token = "0x60030F6")]
      [Address(RVA = "0x3C10EF4", Offset = "0x3C10EF4", VA = "0x3C10EF4")]
      public static TextUtility.ThresholdTimeText CreateFromMinutes(int minutes, string format)
      {
        return (TextUtility.ThresholdTimeText) null;
      }

      [Token(Token = "0x60030F7")]
      [Address(RVA = "0x3C10E38", Offset = "0x3C10E38", VA = "0x3C10E38")]
      public static TextUtility.ThresholdTimeText CreateFromHours(int hours, string format)
      {
        return (TextUtility.ThresholdTimeText) null;
      }

      [Token(Token = "0x60030F8")]
      [Address(RVA = "0x3C10D7C", Offset = "0x3C10D7C", VA = "0x3C10D7C")]
      public static TextUtility.ThresholdTimeText CreateFromDays(int days, string format)
      {
        return (TextUtility.ThresholdTimeText) null;
      }

      [Token(Token = "0x60030F9")]
      [Address(RVA = "0x3C12C58", Offset = "0x3C12C58", VA = "0x3C12C58")]
      public ThresholdTimeText()
      {
      }
    }
  }
}
