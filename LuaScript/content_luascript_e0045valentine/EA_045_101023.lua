Include("content_luascript_system","LuaCommonPack")
Include("content_luascript_common","AreaCommonPack")
Include("content_luascript_common","DemoCommonPack")
Include("content_luascript_system","BattleAdvFunctions")

function Load()
  Load_common(false)

  setup2D_Clarice()
  load_image("EA_045_101023", "content_still_20101040_image", "201010400_StillImage")
  show_image("EA_045_101023", 0.0, 0.0, STILL_SWITCH_TIME, true, true) 
end

function Play()
  Play_start(true)

  change_face(Clarice,"Smile")
  open_speech_window("CHRNAME_CLARICE", Clarice, nil)

  message("EA_045_1010230001")
  change_face(Clarice,"Shy")
  message("EA_045_1010230002")
  message("EA_045_1010230003")

  close_speech_window()

  Play_end(true)
end


function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
  setup2D_Clarice_preload()
  load_image_preload("EA_045_101023", "content_still_20101040_image", "201010400_StillImage")
end