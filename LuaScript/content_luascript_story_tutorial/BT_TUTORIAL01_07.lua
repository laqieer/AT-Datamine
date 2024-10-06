Include("content_luascript_system","LuaCommonPack")
Include("content_luascript_common","AreaCommonPack")
Include("content_luascript_common","DemoCommonPack")
Include("content_luascript_system", "BattleAdvFunctions")

function Load()
	demo_setup_nofade()

	setup2D_S_Lancelot()

end

-- エネミーフェイズ2
function Play()

	--ランスロットセリフ
	change_face(Lancelot, "Normal")
	open_speech_window("NPCNAME_0310",nil,Lancelot)--玲瓏な騎士(ランスロット）
	message("BT_20000_1001")--…
	close_speech_window()


	-- 残りのユニット待機
	unit_command_stay(2000001, false)


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
