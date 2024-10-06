Include("content_luascript_system","LuaCommonPack")
Include("content_luascript_common","AreaCommonPack")
Include("content_luascript_common","DemoCommonPack")
Include("content_luascript_system", "BattleAdvFunctions")

function Load()
	demo_setup_nofade()
	
	setup2D_S_Noir(3)

end

function Play()

	--ノワールセリフ
	change_face(Noir3, "Normal")
	open_speech_window("CHRNAME_NOIR",Noir3,nil) --ノワール
	message("BT_20000_0301")--しまった、ディナタンと離れすぎた…！
	close_speech_window()


	-- ディナタンの隣に移動指示
	manual_command_move(1, 8, 12)


	Play_end(false)
end


function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	setup2D_S_Noir_preload(3)
end
