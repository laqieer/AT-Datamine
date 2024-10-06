Include("content_luascript_system","LuaCommonPack")
Include("content_luascript_common","AreaCommonPack")
Include("content_luascript_common","DemoCommonPack")
Include("content_luascript_system","BattleAdvFunctions")

function Load()
  Load_common(false)

  setup2D_Dinatan()
  load_image("EA_045_101012", "content_still_20101034_image", "201010340_StillImage")
  show_image("EA_045_101012", 0.0, 0.0, STILL_SWITCH_TIME, true, true) 
end

function Play()
  Play_start(true)

  change_face(Dinatan,"Shy")
  open_speech_window("CHRNAME_DINATAN", Dinatan, nil)

  message("EA_045_1010120001")
  message("EA_045_1010120002")
  change_face(Dinatan,"Smile")
  message("EA_045_1010120003")
  change_face(Dinatan,"Surprise")
  message("EA_045_1010120004")

  close_speech_window()

  Play_end(true)
end


function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
  setup2D_Dinatan_preload()
  load_image_preload("EA_045_101012", "content_still_20101034_image", "201010340_StillImage")
end
