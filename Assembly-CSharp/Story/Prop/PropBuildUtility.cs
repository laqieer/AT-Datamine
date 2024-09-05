// Decompiled with JetBrains decompiler
// Type: Story.Prop.PropBuildUtility
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace Story.Prop
{
  [Token(Token = "0x200066D")]
  public static class PropBuildUtility
  {
    [Token(Token = "0x4001F10")]
    public const string OpenedUmbrellaGroupName = "umb_opened";
    [Token(Token = "0x4001F11")]
    public const string ClosedUmbrellaGroupName = "umb_closed";

    [Token(Token = "0x60024D7")]
    [Address(RVA = "0x2F34874", Offset = "0x2F34874", VA = "0x2F34874")]
    public static string ToAssetBundleName(int propID) => (string) null;

    [Token(Token = "0x60024D8")]
    [Address(RVA = "0x2F3487C", Offset = "0x2F3487C", VA = "0x2F3487C")]
    public static string ToAssetName(int propID) => (string) null;

    [Token(Token = "0x60024D9")]
    [Address(RVA = "0x2F34884", Offset = "0x2F34884", VA = "0x2F34884")]
    public static bool AttachToModel(
      GameObject prop,
      GameObject target,
      PropSettingData settingData)
    {
      return new bool();
    }

    [Token(Token = "0x60024DA")]
    [Address(RVA = "0x2F34C70", Offset = "0x2F34C70", VA = "0x2F34C70")]
    public static void IKSetting(
      GameObject prop,
      PropSettingData settingData,
      Action<Transform> IKSetupFunc)
    {
    }

    [Token(Token = "0x60024DB")]
    [Address(RVA = "0x2F34EA0", Offset = "0x2F34EA0", VA = "0x2F34EA0")]
    public static void SubscribeEvent(GameObject prop, IPropEventSubject eventSubject)
    {
    }

    [Token(Token = "0x60024DC")]
    [Address(RVA = "0x2F34FB4", Offset = "0x2F34FB4", VA = "0x2F34FB4")]
    public static void SendOpenedUmbrella(GameObject prop)
    {
    }
  }
}
