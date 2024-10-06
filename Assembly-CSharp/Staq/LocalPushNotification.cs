// Decompiled with JetBrains decompiler
// Type: staq.LocalPushNotification
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections;

#nullable disable
namespace staq
{
  [Token(Token = "0x2003C46")]
  public static class LocalPushNotification
  {
    [Token(Token = "0x4010B80")]
    [FieldOffset(Offset = "0x0")]
    private static readonly string CHANEL_ID;

    [Token(Token = "0x6017B29")]
    [Address(RVA = "0x238C114", Offset = "0x238C114", VA = "0x238C114")]
    public static void Initialize()
    {
    }

    [Token(Token = "0x6017B2A")]
    [Address(RVA = "0x238C234", Offset = "0x238C234", VA = "0x238C234")]
    public static IEnumerator RequestNotificationPermission() => (IEnumerator) null;

    [Token(Token = "0x6017B2B")]
    [Address(RVA = "0x238C2BC", Offset = "0x238C2BC", VA = "0x238C2BC")]
    public static void CancelAll()
    {
    }

    [Token(Token = "0x6017B2C")]
    [Address(RVA = "0x238C314", Offset = "0x238C314", VA = "0x238C314")]
    public static void Cancel(int id)
    {
    }

    [Token(Token = "0x6017B2D")]
    [Address(RVA = "0x238C398", Offset = "0x238C398", VA = "0x238C398")]
    public static void Send(int id, string title, string body, int seconds)
    {
    }

    [Token(Token = "0x6017B2E")]
    [Address(RVA = "0x238C414", Offset = "0x238C414", VA = "0x238C414")]
    private static void SetAndroidNotification(int id, string title, string body, int seconds)
    {
    }

    [Token(Token = "0x6017B2F")]
    [Address(RVA = "0x238C590", Offset = "0x238C590", VA = "0x238C590")]
    static LocalPushNotification()
    {
    }
  }
}
