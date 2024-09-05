// Decompiled with JetBrains decompiler
// Type: FreeMap.UI.Entity.FreeMapEntityUIUtility
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

#nullable disable
namespace FreeMap.UI.Entity
{
  [Token(Token = "0x2001697")]
  public static class FreeMapEntityUIUtility
  {
    [Token(Token = "0x6007F76")]
    [Address(RVA = "0x21B6BD4", Offset = "0x21B6BD4", VA = "0x21B6BD4")]
    public static void AddButtonEvent(
      GameObject buttonPrefab,
      string buttonObjectName,
      UnityAction action)
    {
    }

    [Token(Token = "0x6007F77")]
    [Address(RVA = "0x21B69AC", Offset = "0x21B69AC", VA = "0x21B69AC")]
    public static void ChangeButtonEvent(
      GameObject buttonPrefab,
      string buttonObjectName,
      UnityAction action)
    {
    }

    [Token(Token = "0x6007F78")]
    [Address(RVA = "0x21B6D40", Offset = "0x21B6D40", VA = "0x21B6D40")]
    public static void InvokeButtonEvent(GameObject buttonPrefab, string buttonObjectName)
    {
    }

    [Token(Token = "0x6007F79")]
    [Address(RVA = "0x21B6C70", Offset = "0x21B6C70", VA = "0x21B6C70")]
    public static Button GetButtonComponent(GameObject buttonPrefab, string buttonObjectName)
    {
      return (Button) null;
    }
  }
}
