Include("content_luascript_system","LuaCommonPack")
Include("content_luascript_common","AreaCommonPack")
Include("content_luascript_common","DemoCommonPack")
Include("content_luascript_system","BattleAdvFunctions")

function Load()
  Load_common(false)

  setup2D_Liliana()
  load_image("EA_045_101035", "content_still_20101049_image", "201010490_StillImage")
  show_image("EA_045_101035", 0.0, 0.0, STILL_SWITCH_TIME, true, true) 
end

function Play()
  Play_start(true)

  change_face(Liliana,"Shy")
  open_speech_window("CHRNAME_LILIANA", Liliana, nil)

  message("EA_045_1010350001")
  message("EA_045_1010350002")

  close_speech_window()

  Play_end(true)
end


function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
  setup2D_Liliana_preload()
  load_image_preload("EA_045_101035", "content_still_20101049_image", "201010490_StillImage")
end
