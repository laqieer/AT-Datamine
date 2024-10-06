Include("content_luascript_system","LuaCommonPack")
Include("content_luascript_common","AreaCommonPack")
Include("content_luascript_common","DemoCommonPack")
Include("content_luascript_system", "BattleAdvFunctions")

function Load()
	demo_setup_nofade()

	setup2D_S_Tyrfing(2)

end

function Play()

	--ティルフィングセリフ
	change_face(Tyrfing2, "Normal")
	open_speech_window("NPCNAME_0158",Tyrfing2,nil) --桃色の姫騎士（ティルフィング）
	message("BT_10000_1301")--マスター、ご無理をなさらず
	close_speech_window()


	-- ティルフィング
	unit_command_double(2, 5, 12, 5, 11)


	-- 残りのユニット待機
	unit_command_stay(3, false)
	unit_command_stay(4, false)
	unit_command_stay(5, false)
	unit_command_stay(6, false)
	unit_command_stay(7, false)


	Play_end(false)
end


function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	setup2D_S_Tyrfing_preload(2)
end
