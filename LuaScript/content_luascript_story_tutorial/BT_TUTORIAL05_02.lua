Include("content_luascript_system","LuaCommonPack")
Include("content_luascript_common","AreaCommonPack")
Include("content_luascript_common","DemoCommonPack")
Include("content_luascript_system", "BattleAdvFunctions")

function Load()
	demo_setup_nofade()

	setup2D_S_Dinatan(3)

end


function Play()
	Play_start(false)


	--ディナタンセリフ
	change_face(Dinatan3, "Surprise")
	open_speech_window("CHRNAME_DINATAN",Dinatan3,nil) --ディナタン
	message("BT_TUTORIAL05_020001") --兄さん、無理しないで！
	close_speech_window()


	--ディナタン移動
	unit_command_skill(2, 8, 13, 9, 13, 0, false)

	Play_end(false)
end


function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	setup2D_S_Dinatan_preload(3)
end
