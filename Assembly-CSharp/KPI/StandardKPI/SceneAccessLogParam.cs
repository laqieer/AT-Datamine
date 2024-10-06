// Decompiled with JetBrains decompiler
// Type: KPI.StandardKPI.SceneAccessLogParam
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace KPI.StandardKPI
{
  [Token(Token = "0x2000A6C")]
  [Serializable]
  public class SceneAccessLogParam : StandardKPILogParam<SceneAccessLogParam.Body>
  {
    [Token(Token = "0x17000872")]
    public override string LogFormatType
    {
      [Token(Token = "0x6003B3E"), Address(RVA = "0x331C5F8", Offset = "0x331C5F8", VA = "0x331C5F8", Slot = "5")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x6003B3F")]
    [Address(RVA = "0x331C638", Offset = "0x331C638", VA = "0x331C638")]
    public static SceneAccessLogParam CreateFromScene(
      string sceneName,
      string subSceneAssetBundleName,
      string subSceneName,
      GameCore.Scene.Scene fromScene,
      Vector2 pos)
    {
      return (SceneAccessLogParam) null;
    }

    [Token(Token = "0x6003B40")]
    [Address(RVA = "0x331C7AC", Offset = "0x331C7AC", VA = "0x331C7AC")]
    public SceneAccessLogParam()
    {
    }

    [Token(Token = "0x2000A6D")]
    [Serializable]
    public class Body : IStandardKPILogBodyParam
    {
      [Token(Token = "0x4003052")]
      [FieldOffset(Offset = "0x10")]
      public string scene_category_id;
      [Token(Token = "0x4003053")]
      [FieldOffset(Offset = "0x18")]
      public string scene_id;
      [Token(Token = "0x4003054")]
      [FieldOffset(Offset = "0x20")]
      public string scene_name;
      [Token(Token = "0x4003055")]
      [FieldOffset(Offset = "0x28")]
      public string from_scene_category_id;
      [Token(Token = "0x4003056")]
      [FieldOffset(Offset = "0x30")]
      public string from_scene_id;
      [Token(Token = "0x4003057")]
      [FieldOffset(Offset = "0x38")]
      public string tap_x;
      [Token(Token = "0x4003058")]
      [FieldOffset(Offset = "0x40")]
      public string tap_y;

      [Token(Token = "0x6003B41")]
      [Address(RVA = "0x331C7F4", Offset = "0x331C7F4", VA = "0x331C7F4")]
      public Body()
      {
      }
    }
  }
}
