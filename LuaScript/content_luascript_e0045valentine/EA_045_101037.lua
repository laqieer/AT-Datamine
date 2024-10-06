Include("content_luascript_system","LuaCommonPack")
Include("content_luascript_common","AreaCommonPack")
Include("content_luascript_common","DemoCommonPack")
Include("content_luascript_system","BattleAdvFunctions")

function Load()
  Load_common(false)

  setup2D_Rasia()
  load_image("EA_045_101037", "content_still_20101051_image", "201010510_StillImage")
  show_image("EA_045_101037", 0.0, 0.0, STILL_SWITCH_TIME, true, true) 
end

function Play()
  Play_start(true)

  change_face(Rasia,"Smile")
  open_speech_window("CHRNAME_RASIA", Rasia, nil)

  message("EA_045_1010370001")
  message("EA_045_1010370002")
  change_face(Rasia,"Shy")
  message("EA_045_1010370003")

  close_speech_window()

  Play_end(true)
end


function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
  setup2D_Rasia_preload()
  load_image_preload("EA_045_101037", "content_still_20101051_image", "201010510_StillImage")
end
