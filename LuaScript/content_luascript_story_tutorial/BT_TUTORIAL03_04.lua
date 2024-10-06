Include("content_luascript_system","LuaCommonPack")
Include("content_luascript_common","AreaCommonPack")
Include("content_luascript_common","DemoCommonPack")
Include("content_luascript_system", "BattleAdvFunctions")

function Load()
	demo_setup_nofade()
	
	setup2D_S_Dinatan()
	setup2D_S_Maladisant(2)

end

function Play()

	--ディナタン＆マルディサントセリフ
	change_face(Maladisant2, "Smile")
	open_speech_window("NPCNAME_0362",Maladisant2,nil)--黒盾の麗人（ビアンパンサント）
	message("BT_10000_0701")--いいね、いいね、高ぶってきた！
	close_speech_window()


	change_face(Dinatan, "Anger")
	open_speech_window("NPCNAME_0309",Dinatan,nil)--リボンの癒し手（ディナタン）
	message("BT_10000_0702")--もうっ…！ひとりで前に出過ぎないで！
	close_speech_window()


	-- ディナタン&マルディサント移動＆攻撃
	unit_command_move_only(5, 5, 15, false)
	unit_command_skill(7, 6, 15, 6, 14, 0, false)


	-- ティルフィング待機
	unit_command_stay(2, false)


	Play_end(false)
end


function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	setup2D_S_Dinatan_preload()
	setup2D_S_Maladisant_preload(2)
end
