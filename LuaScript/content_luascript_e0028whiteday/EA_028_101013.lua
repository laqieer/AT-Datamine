Include("content_luascript_system","LuaCommonPack")
Include("content_luascript_common","AreaCommonPack")
Include("content_luascript_common","DemoCommonPack")
Include("content_luascript_system","BattleAdvFunctions")

function Load()
  Load_common(false)

  setup2D_Gawain()
  load_image("EA_028_101013", "content_still_20101056_image", "201010560_StillImage")
  show_image("EA_028_101013", 0.0, 0.0, STILL_SWITCH_TIME, true, true) 
end

function Play()
  Play_start(true)

  change_face(Gawain,"Normal")
  open_speech_window("CHRNAME_GAWAIN", Gawain, nil)

  message("EA_028_1010130001")
  change_face(Gawain,"Smile")
  message("EA_028_1010130002")

  close_speech_window()

  Play_end(true)
end


function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
  setup2D_Gawain_preload()
  load_image_preload("EA_028_101013", "content_still_20101056_image", "201010560_StillImage")
end
