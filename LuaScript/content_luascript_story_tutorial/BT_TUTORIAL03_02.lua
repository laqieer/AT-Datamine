Include("content_luascript_system","LuaCommonPack")
Include("content_luascript_common","AreaCommonPack")
Include("content_luascript_common","DemoCommonPack")
Include("content_luascript_system", "BattleAdvFunctions")

function Load()
	demo_setup_nofade()

	setup2D_S_Guinevere()
	setup2D_S_Gwenhwymawr(2)

end

function Play()

	--ギネヴィア＆ギネマウアセリフ
	change_face(Guinevere, "Normal")
	open_speech_window("NPCNAME_0308",Guinevere,nil) --勝ち気な二つ結び（ギネヴィア）
	message("BT_10000_0301")--よーし、連携していきましょ！
	close_speech_window()


	change_face(Gwenhwymawr2, "Normal")
	open_speech_window("NPCNAME_0361",Gwenhwymawr2,nil) --白花の槍兵（ロンゴミアント）
	message("BT_10000_0302")--準備はできております
	close_speech_window()


	-- ギネヴィア&ギネマウア移動＆攻撃
	-- unit_command_double(4, 3, 21, 4, 21)
	unit_command_move_only(4, 3, 21, false)
	unit_command_skill(6, 4, 21, 4, 22, 0, false)


	Play_end(false)
end


function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	setup2D_S_Guinevere_preload()
	setup2D_S_Gwenhwymawr_preload(2)
end
