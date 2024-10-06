Include("content_luascript_system","LuaCommonPack")
Include("content_luascript_common","DemoCommonPack")
Include("content_luascript_system","BattleAdvFunctions")


function Load()
	Load_common(false)

	setup2D_S_Lovein(3)
	setup2D_S_Elaine(7)
	setup2D_S_Elaine(5)

	load_sound("BGM_Battle_Running")

end

function Play()
	Play_start(false)

	change_face(Elaine7,"Normal")
	open_speech_window("CHRNAME_NAMELES",Elaine7,nil)
bgm_play("Stop_BGM_Bus_MidFade")
	message("EA_072_0330007")
	close_speech_window()

	change_face(Lovein3,"Normal")
	open_speech_window("CHRNAME_NAMELES",Lovein3,nil)
	message("EA_072_0330009")
	close_speech_window()

	open_cutin(1,1)
	on_cutin(1,Elaine5,"Anger")
	open_speech_window("CHRNAME_ELAINE",nil,nil)
bgm_play("BGM_Battle_Running")
PlayPartVoiceDirect("エレイン","0035")
	message("EA_072_0330011")
	close_speech_window()
	close_cutin()

	Play_end(false)
end


function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	setup2D_S_Lovein_preload(3)
	setup2D_S_Elaine_preload(7)
	setup2D_S_Elaine_preload(5)
	preload_sound("BGM_Battle_Running")
end
