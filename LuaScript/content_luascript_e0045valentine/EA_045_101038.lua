Include("content_luascript_system","LuaCommonPack")
Include("content_luascript_common","AreaCommonPack")
Include("content_luascript_common","DemoCommonPack")
Include("content_luascript_system","BattleAdvFunctions")

function Load()
  Load_common(false)

  setup2D_Lola()
  load_image("EA_045_101038", "content_still_20101052_image", "201010520_StillImage")
  show_image("EA_045_101038", 0.0, 0.0, STILL_SWITCH_TIME, true, true) 
end

function Play()
  Play_start(true)

  change_face(Lola,"Shy")
  open_speech_window("CHRNAME_LOLA", Lola, nil)

  message("EA_045_1010380001")
  message("EA_045_1010380002")
  change_face(Lola,"Sad")
  message("EA_045_1010380003")

  close_speech_window()

  Play_end(true)
end


function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
  setup2D_Lola_preload()
  load_image_preload("EA_045_101038", "content_still_20101052_image", "201010520_StillImage")
end
