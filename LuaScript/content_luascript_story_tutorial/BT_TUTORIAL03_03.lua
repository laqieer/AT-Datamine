Include("content_luascript_system","LuaCommonPack")
Include("content_luascript_common","AreaCommonPack")
Include("content_luascript_common","DemoCommonPack")
Include("content_luascript_system", "BattleAdvFunctions")

function Load()
	demo_setup_nofade()

	setup2D_S_Lancelot()

end

function Play()

	--ランスロットセリフ
	change_face(Lancelot, "Normal")
	open_speech_window("NPCNAME_0310",Lancelot,nil)--玲瓏な騎士(ランスロット）
	message("BT_10000_0501")--ゆっくり相手をしていられる状況ではない
	close_speech_window()


	-- ランスロット攻撃
	unit_command_skill(3, 2, 8, 1, 8, 1, false)


	Play_end(false)
end


function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	setup2D_S_Lancelot_preload()
end
