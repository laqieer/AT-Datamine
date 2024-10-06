Include("content_luascript_system","LuaCommonPack")
Include("content_luascript_common","AreaCommonPack")
Include("content_luascript_common","DemoCommonPack")
Include("content_luascript_system","BattleAdvFunctions")

function Load()
  Load_common(false)

  setup2D_Isolde()
  load_image("EA_045_101019", "content_still_20101038_image", "201010380_StillImage")
  show_image("EA_045_101019", 0.0, 0.0, STILL_SWITCH_TIME, true, true) 
end

function Play()
  Play_start(true)

  change_face(Isolde,"Shy")
  open_speech_window("CHRNAME_ISOLDE", Isolde, nil)

  message("EA_045_1010190001")
  change_face(Isolde,"Surprise")
  message("EA_045_1010190002")
  change_face(Isolde,"Anger")
  message("EA_045_1010190003")

  close_speech_window()

  Play_end(true)
end


function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
  setup2D_Isolde_preload()
  load_image_preload("EA_045_101019", "content_still_20101038_image", "201010380_StillImage")
end
